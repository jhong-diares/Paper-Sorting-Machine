import sys
import threading
import platform
import RPi.GPIO as GPIO
import time
import mysql.connector
from datetime import datetime
import serial
from mysql.connector import Error
from datetime import date

ser = serial.Serial('/dev/ttyACM0', 9600, timeout=1)
ser.flush()
today = date.today()
datetoday_display = today.strftime("%B %d, %Y")
now = datetime.now()
current_time = now.strftime("%I:%M:%S")
current_date = now.strftime("%A,%B %d %Y")
conn = mysql.connector.connect(host="192.168.0.117",port="8457" , user='jhong', password='test', database="db_sorting_machine")

## =====> GET RGB FROM COLORED PAPER
## =====> ATTACH MOTOR DRIVER
## =====> GET ANOTHER SERVO FOR RELEASING OF PAPER
def UDS_START(UDS):
	if (UDS == True):
		while (1):
			time.sleep(0)
			GPIO.setmode(GPIO.BCM)
			GPIO.setwarnings(False)
			TRIG = 23 
			ECHO = 24
			GPIO.setup(TRIG,GPIO.OUT)
			GPIO.setup(ECHO,GPIO.IN)
			GPIO.output(TRIG, False)
			time.sleep(2)
			GPIO.output(TRIG, True)
			time.sleep(0.00001)
			GPIO.output(TRIG, False)
			while GPIO.input(ECHO)==0:
					pulse_start = time.time()
			while GPIO.input(ECHO)==1:
					pulse_end = time.time()
			pulse_duration = pulse_end - pulse_start
			distance = pulse_duration * 17150
			distance = round(distance, 2)
			if distance >= 5.00:
					print ("OUT OF RANGE")
					print ("Distance:",distance,"cm")
			elif distance <= 9.00:
					print ("IN RANGE")
					print ("Distance:",distance,"cm")
					## ==> ACTIVATE MOTOR A
					#MOTOR_START(True)
					SELECT_PLACER()
					continue
			GPIO.cleanup()

def TCS_START():
	s2 = 20
	s3 = 21
	signal = 16
	NUM_CYCLES = 10
	GPIO.setmode(GPIO.BCM)
	GPIO.setup(signal,GPIO.IN, pull_up_down=GPIO.PUD_UP)
	GPIO.setup(s2,GPIO.OUT)
	GPIO.setup(s3,GPIO.OUT)
	GPIO.setwarnings(False)
	print("\n")
	temp = 1
	GPIO.output(s2,GPIO.LOW)
	GPIO.output(s3,GPIO.LOW)
	time.sleep(0.3)
	start = time.time()
	for impulse_count in range(NUM_CYCLES):
			GPIO.wait_for_edge(signal, GPIO.FALLING)
	duration = time.time() - start
	red  = NUM_CYCLES / duration
	print("red value - ",int(red))
	GPIO.output(s2,GPIO.LOW)
	GPIO.output(s3,GPIO.HIGH)
	time.sleep(0.3)
	
	start = time.time()
	for impulse_count in range(NUM_CYCLES):
			GPIO.wait_for_edge(signal, GPIO.FALLING)
	duration = time.time() - start
	blue = NUM_CYCLES / duration
	print("blue value - ",int(blue))
	GPIO.output(s2,GPIO.HIGH)
	GPIO.output(s3,GPIO.HIGH)
	time.sleep(0.3)
	
	start = time.time()
	for impulse_count in range(NUM_CYCLES):
			GPIO.wait_for_edge(signal, GPIO.FALLING)
	duration = time.time() - start
	green = NUM_CYCLES / duration
	print("green value - ",int(green))

	VALUE_ARRAY=[]
	VALUE_ARRAY.insert (0, int(red))
	VALUE_ARRAY.insert (1, int(green))
	VALUE_ARRAY.insert (2, int(blue))
	COLOR_DESC=""
	if green<1400 and blue<1300 and red>150:
		#print("Red")
		COLOR_DESC = "Red"
	elif red<180 and  blue<1300 and green>1500:
		#print("Yellow")
		COLOR_DESC = "Yellow"
	elif green<1300 and red<170 and blue>1100:
		#print("Blue")
		COLOR_DESC = "Blue"
	GPIO.cleanup()
	return COLOR_DESC, VALUE_ARRAY

"""def MOTOR_START(STATE):
	in1 = 27
	in2 = 22
	en = 17
	temp1=1
	
	GPIO.setmode(GPIO.BCM)
	GPIO.setup(in1,GPIO.OUT)
	GPIO.setup(in2,GPIO.OUT)
	GPIO.setup(en,GPIO.OUT)
	GPIO.output(in1,GPIO.LOW)
	GPIO.output(in2,GPIO.LOW)
	p=GPIO.PWM(en,1000)
	p.start(25)
	if (STATE == True):	
		## ==> RUN MOTOR
		GPIO.output(in1,GPIO.HIGH)
		GPIO.output(in2,GPIO.LOW)
		p.ChangeDutyCycle(100)
		time.sleep(5)
		GPIO.output(in1,GPIO.LOW)
		GPIO.output(in2,GPIO.LOW)
	else:
		GPIO.output(in1,GPIO.LOW)
		GPIO.output(in2,GPIO.LOW)"""
		
def SELECT_PLACER():

		tup = TCS_START()
		elem_0 = tup[0]
		elem_1 = tup[1]
		COLOR_VAL_DESC = elem_0
		COLOR_VAL_RGB = str(elem_1)

		print(COLOR_VAL_DESC)
		print(COLOR_VAL_RGB)

		## ========> MANUAL INPUT
		#to_sort = ['Blue','Green','Yellow','Orange']
		COLOR_VAL_DESC = "Nyu"
		CURRENT_DATE = today.strftime("%Y-%m-%d")
		conn_cursor = conn.cursor(prepared= True)
		sql = "SELECT id, color_desc, color_value, array_index, set_angle, total_count, DATE_FORMAT(date_started, '%Y-%m-%d') FROM  `TBL_ACTUAL_COUNT` WHERE DATE(date_started) = CURDATE() AND color_desc = %s"
		val =(COLOR_VAL_DESC,)
		conn_cursor.execute(sql,val)
		result = conn_cursor.fetchall()
		print("Total number: ", conn_cursor.rowcount)
		if conn_cursor.rowcount >= 1:
			for x in result:
				print("id =",x[0],)
				print("color_desc =",x[1])
				print("color_value =",x[2])
				print("array_index =",x[3])
				print("set_angle =",x[4])
				print("total_count =",x[5])
				print("date_started =",x[6])
			try:
				result_id = x[0]
				result_color_desc= x[1]
				result_color_value= x[2]
				result_array_index= x[3]
				result_set_angle= x[4]
				result_total_count= x[5]
				result_date_started= x[6]
				print("=======================")
				print("\nMove Servo to",result_array_index,"index and ",result_set_angle,"then Release")
				if result_set_angle == '0':
					command1 = 'A'
					command_fin = command1+"\n"
					ser.write(command_fin.encode('utf-8'))
					line = ser.readline().decode('utf-8').rstrip()
					print(line)
					time.sleep(1)
					conn_cursor = conn.cursor()
					sql = "UPDATE `TBL_ACTUAL_COUNT` SET total_count = %s WHERE id = %s"
					val= (int(result_total_count) + 1,int(result_id))
					conn_cursor.execute(sql,val)
					conn.commit()
					print(conn_cursor.rowcount, "Record Inserted")
				elif result_set_angle == '45':
					command1 = 'B'
					command_fin = command1+"\n"
					ser.write(command_fin.encode('utf-8'))
					line = ser.readline().decode('utf-8').rstrip()
					print(line)
					time.sleep(1)
					conn_cursor = conn.cursor()
					sql = "UPDATE `TBL_ACTUAL_COUNT` SET total_count = %s WHERE id = %s"
					val= (int(result_total_count) + 1,int(result_id))
					conn_cursor.execute(sql,val)
					conn.commit()
					print(conn_cursor.rowcount, "Record Inserted")
				elif result_set_angle == '90':
					command1 = 'C'
					command_fin = command1+"\n"
					ser.write(command_fin.encode('utf-8'))
					line = ser.readline().decode('utf-8').rstrip()
					print(line)
					time.sleep(1)
					conn_cursor = conn.cursor()
					sql = "UPDATE `TBL_ACTUAL_COUNT` SET total_count = %s WHERE id = %s"
					val= (int(result_total_count) + 1,int(result_id))
					conn_cursor.execute(sql,val)
					conn.commit()
					print(conn_cursor.rowcount, "Record Inserted")
				elif result_set_angle == '135':
					command1 = 'D'
					command_fin = command1+"\n"
					ser.write(command_fin.encode('utf-8'))
					line = ser.readline().decode('utf-8').rstrip()
					print(line)
					time.sleep(1)
					conn_cursor = conn.cursor()
					sql = "UPDATE `TBL_ACTUAL_COUNT` SET total_count = %s WHERE id = %s"
					val= (int(result_total_count) + 1,int(result_id))
					conn_cursor.execute(sql,val)
					conn.commit()
					print(conn_cursor.rowcount, "Record Inserted")
				elif result_set_angle == '180':
					command1 = 'E'
					command_fin = command1+"\n"
					ser.write(command_fin.encode('utf-8'))
					line = ser.readline().decode('utf-8').rstrip()
					print(line)
					time.sleep(1)
					conn_cursor = conn.cursor()
					sql = "UPDATE `TBL_ACTUAL_COUNT` SET total_count = %s WHERE id = %s"
					val= (int(result_total_count) + 1,int(result_id))
					conn_cursor.execute(sql,val)
					conn.commit()
					print(conn_cursor.rowcount, "Record Inserted")	
			except mysql.connector.Error as error:
				print("Failed to get record from MySQL table: {}".format(error))
		else:
			try:
				to_sort = ['Blue','Green','Yellow','Orange']
				occupied_slot = []
				available_slot = ['0','1','3','4']
				occupied_angle_slot = []
				available_angle_slot = ['0','45','135','180']
				conn_cursor = conn.cursor(prepared= True)
				sql = "SELECT array_index, set_angle, DATE_FORMAT(date_started, '%Y-%m-%d') FROM  `TBL_ACTUAL_COUNT` WHERE DATE(date_started) = CURDATE()"
				conn_cursor.execute(sql)
				result2 = conn_cursor.fetchall()
				print("Total number: ", conn_cursor.rowcount)
				if conn_cursor.rowcount >= 1:
						for y in result2:
							print("=======================")
							print("array_index = ",y[0],)
							result2_array_index= y[0]
							occupied_slot.append(result2_array_index)
							print("set_angle = ",y[1])
							result2_set_angle= y[1]
							occupied_angle_slot.append(result2_set_angle)
							print("date =" ,y[2])
				print(occupied_slot)
				diff = lambda available_slot,occupied_slot: [x for x in available_slot if x not in occupied_slot]
				res = (diff(available_slot,occupied_slot))
				print(res)
				slot_index = (res[0])
				print(slot_index)
				print(occupied_angle_slot)
				diff = lambda available_angle_slot,occupied_angle_slot: [x for x in available_angle_slot if x not in occupied_angle_slot]
				res1 = (diff(available_angle_slot,occupied_angle_slot))
				print(res1)
				slot_angle= (res1[0])
				print(slot_angle)
				if COLOR_VAL_DESC not in to_sort:
					print("COLOR NOT IN LIST")
					command1 = 'C'
					command_fin = command1+"\n"
					ser.write(command_fin.encode('utf-8'))
					line = ser.readline().decode('utf-8').rstrip()
					print(line)
					time.sleep(1)
				else:
					if slot_angle == '0':
						command1 = 'A'
						command_fin = command1+"\n"
						ser.write(command_fin.encode('utf-8'))
						line = ser.readline().decode('utf-8').rstrip()
						print(line)
						time.sleep(1)
						conn_cursor = conn.cursor()
						conn_cursor.execute("SELECT id, ctrl_count_number FROM `TBL_ACTUAL_COUNT` ORDER BY id DESC LIMIT 0,1")
						resl = conn_cursor.fetchall()
						if conn_cursor.rowcount >= 1:
							for c in resl:
								eec = c[1]
							ctrl_slice= eec[5:12]
							get_num = (int(ctrl_slice)+1)
							x = get_num
							add_zero ='%07d' % x
							ctrl_count_num= ("ctrl-"+add_zero)
							print(ctrl_count_num)
							time.sleep(1)
							conn_cursor = conn.cursor()
							sql = "INSERT INTO `TBL_ACTUAL_COUNT` (ctrl_count_number, color_desc, color_value, array_index, set_angle, date_started, total_count) VALUES (%s,%s,%s,%s,%s,%s,%s)"
							val= (ctrl_count_num, COLOR_VAL_DESC, COLOR_VAL_RGB, slot_index, slot_angle, today, "1")
							conn_cursor.execute(sql,val)
							conn.commit()
							print(conn_cursor.rowcount, "Record Inserted")
							time.sleep(1)
						else:
							eec="ctrl-0000001"
							ctrl_slice= eec[5:12]
							get_num = (int(ctrl_slice)+0)
							x = get_num
							add_zero ='%07d' % x
							ctrl_count_num= ("ctrl-"+add_zero)
							print(ctrl_count_num)
							time.sleep(1)
							conn_cursor = conn.cursor()
							sql = "INSERT INTO `TBL_ACTUAL_COUNT` (ctrl_count_number, color_desc, color_value, array_index, set_angle, date_started, total_count) VALUES (%s,%s,%s,%s,%s,%s,%s)"
							val= (ctrl_count_num, COLOR_VAL_DESC, COLOR_VAL_RGB, slot_index, slot_angle, today, "1")
							conn_cursor.execute(sql,val)
							conn.commit()
							print(conn_cursor.rowcount, "Record Inserted")
							time.sleep(1)
					elif slot_angle == '45':
							command1 = 'B'
							command_fin = command1+"\n"
							ser.write(command_fin.encode('utf-8'))
							line = ser.readline().decode('utf-8').rstrip()
							print(line)
							time.sleep(1)
							conn_cursor = conn.cursor()
							conn_cursor.execute("SELECT id, ctrl_count_number FROM `TBL_ACTUAL_COUNT` ORDER BY id DESC LIMIT 0,1")
							resl = conn_cursor.fetchall()
							if conn_cursor.rowcount >= 1:
								for c in resl:
									eec = c[1]
								ctrl_slice= eec[5:12]
								get_num = (int(ctrl_slice)+1)
								x = get_num
								add_zero ='%07d' % x
								ctrl_count_num= ("ctrl-"+add_zero)
								print(ctrl_count_num)
								time.sleep(1)
								conn_cursor = conn.cursor()
								sql = "INSERT INTO `TBL_ACTUAL_COUNT` (ctrl_count_number, color_desc, color_value, array_index, set_angle, date_started, total_count) VALUES (%s,%s,%s,%s,%s,%s,%s)"
								val= (ctrl_count_num, COLOR_VAL_DESC, COLOR_VAL_RGB, slot_index, slot_angle, today, "1")
								conn_cursor.execute(sql,val)
								conn.commit()
								print(conn_cursor.rowcount, "Record Inserted")
								time.sleep(1)
							else:
								eec="ctrl-0000001"
								ctrl_slice= eec[5:12]
								get_num = (int(ctrl_slice)+0)
								x = get_num
								add_zero ='%07d' % x
								ctrl_count_num= ("ctrl-"+add_zero)
								print(ctrl_count_num)
								time.sleep(1)
								conn_cursor = conn.cursor()
								sql = "INSERT INTO `TBL_ACTUAL_COUNT` (ctrl_count_number, color_desc, color_value, array_index, set_angle, date_started, total_count) VALUES (%s,%s,%s,%s,%s,%s,%s)"
								val= (ctrl_count_num, COLOR_VAL_DESC, COLOR_VAL_RGB, slot_index, slot_angle, today, "1")
								conn_cursor.execute(sql,val)
								conn.commit()
								print(conn_cursor.rowcount, "Record Inserted")
								time.sleep(1)	
					elif slot_angle == '90':
							command1 = 'C'
							command_fin = command1+"\n"
							ser.write(command_fin.encode('utf-8'))
							line = ser.readline().decode('utf-8').rstrip()
							print(line)
							time.sleep(1)
							conn_cursor = conn.cursor()
							conn_cursor.execute("SELECT id, ctrl_count_number FROM `TBL_ACTUAL_COUNT` ORDER BY id DESC LIMIT 0,1")
							resl = conn_cursor.fetchall()
							if conn_cursor.rowcount >= 1:
								for c in resl:
									eec = c[1]
								ctrl_slice= eec[5:12]
								get_num = (int(ctrl_slice)+1)
								x = get_num
								add_zero ='%07d' % x
								ctrl_count_num= ("ctrl-"+add_zero)
								print(ctrl_count_num)
								time.sleep(1)
								conn_cursor = conn.cursor()
								sql = "INSERT INTO `TBL_ACTUAL_COUNT` (ctrl_count_number, color_desc, color_value, array_index, set_angle, date_started, total_count) VALUES (%s,%s,%s,%s,%s,%s,%s)"
								val= (ctrl_count_num, COLOR_VAL_DESC, COLOR_VAL_RGB, slot_index, slot_angle, today, "1")
								conn_cursor.execute(sql,val)
								conn.commit()
								print(conn_cursor.rowcount, "Record Inserted")
								time.sleep(1)
							else:
								eec="ctrl-0000001"
								ctrl_slice= eec[5:12]
								get_num = (int(ctrl_slice)+0)
								x = get_num
								add_zero ='%07d' % x
								ctrl_count_num= ("ctrl-"+add_zero)
								print(ctrl_count_num)
								time.sleep(1)
								conn_cursor = conn.cursor()
								sql = "INSERT INTO `TBL_ACTUAL_COUNT` (ctrl_count_number, color_desc, color_value, array_index, set_angle, date_started, total_count) VALUES (%s,%s,%s,%s,%s,%s,%s)"
								val= (ctrl_count_num, COLOR_VAL_DESC, COLOR_VAL_RGB, slot_index, slot_angle, today, "1")
								conn_cursor.execute(sql,val)
								conn.commit()
								print(conn_cursor.rowcount, "Record Inserted")
								time.sleep(1)						
					elif slot_angle == '135':
							command1 = 'D'
							command_fin = command1+"\n"
							ser.write(command_fin.encode('utf-8'))
							line = ser.readline().decode('utf-8').rstrip()
							print(line)
							time.sleep(1)
							conn_cursor = conn.cursor()
							conn_cursor.execute("SELECT id, ctrl_count_number FROM `TBL_ACTUAL_COUNT` ORDER BY id DESC LIMIT 0,1")
							resl = conn_cursor.fetchall()
							if conn_cursor.rowcount >= 1:
								for c in resl:
									eec = c[1]
								ctrl_slice= eec[5:12]
								get_num = (int(ctrl_slice)+1)
								x = get_num
								add_zero ='%07d' % x
								ctrl_count_num= ("ctrl-"+add_zero)
								print(ctrl_count_num)
								time.sleep(1)
								conn_cursor = conn.cursor()
								sql = "INSERT INTO `TBL_ACTUAL_COUNT` (ctrl_count_number, color_desc, color_value, array_index, set_angle, date_started, total_count) VALUES (%s,%s,%s,%s,%s,%s,%s)"
								val= (ctrl_count_num, COLOR_VAL_DESC, COLOR_VAL_RGB, slot_index, slot_angle, today, "1")
								conn_cursor.execute(sql,val)
								conn.commit()
								print(conn_cursor.rowcount, "Record Inserted")
								time.sleep(1)
							else:
								eec="ctrl-0000001"
								ctrl_slice= eec[5:12]
								get_num = (int(ctrl_slice)+0)
								x = get_num
								add_zero ='%07d' % x
								ctrl_count_num= ("ctrl-"+add_zero)
								print(ctrl_count_num)
								time.sleep(1)
								conn_cursor = conn.cursor()
								sql = "INSERT INTO `TBL_ACTUAL_COUNT` (ctrl_count_number, color_desc, color_value, array_index, set_angle, date_started, total_count) VALUES (%s,%s,%s,%s,%s,%s,%s)"
								val= (ctrl_count_num, COLOR_VAL_DESC, COLOR_VAL_RGB, slot_index, slot_angle, today, "1")
								conn_cursor.execute(sql,val)
								conn.commit()
								print(conn_cursor.rowcount, "Record Inserted")
								time.sleep(1)			
					elif slot_angle == '180':
							command1 = 'E'
							command_fin = command1+"\n"
							ser.write(command_fin.encode('utf-8'))
							line = ser.readline().decode('utf-8').rstrip()
							print(line)
							time.sleep(1)
							conn_cursor = conn.cursor()
							conn_cursor.execute("SELECT id, ctrl_count_number FROM `TBL_ACTUAL_COUNT` ORDER BY id DESC LIMIT 0,1")
							resl = conn_cursor.fetchall()
							if conn_cursor.rowcount >= 1:
								for c in resl:
									eec = c[1]
								ctrl_slice= eec[5:12]
								get_num = (int(ctrl_slice)+1)
								x = get_num
								add_zero ='%07d' % x
								ctrl_count_num= ("ctrl-"+add_zero)
								print(ctrl_count_num)
								time.sleep(1)
								conn_cursor = conn.cursor()
								sql = "INSERT INTO `TBL_ACTUAL_COUNT` (ctrl_count_number, color_desc, color_value, array_index, set_angle, date_started, total_count) VALUES (%s,%s,%s,%s,%s,%s,%s)"
								val= (ctrl_count_num, COLOR_VAL_DESC, COLOR_VAL_RGB, slot_index, slot_angle, today, "1")
								conn_cursor.execute(sql,val)
								conn.commit()
								print(conn_cursor.rowcount, "Record Inserted")
								time.sleep(1)
							else:
								eec="ctrl-0000001"
								ctrl_slice= eec[5:12]
								get_num = (int(ctrl_slice)+0)
								x = get_num
								add_zero ='%07d' % x
								ctrl_count_num= ("ctrl-"+add_zero)
								print(ctrl_count_num)
								time.sleep(1)
								conn_cursor = conn.cursor()
								sql = "INSERT INTO `TBL_ACTUAL_COUNT` (ctrl_count_number, color_desc, color_value, array_index, set_angle, date_started, total_count) VALUES (%s,%s,%s,%s,%s,%s,%s)"
								val= (ctrl_count_num, COLOR_VAL_DESC, COLOR_VAL_RGB, slot_index, slot_angle, today, "1")
								conn_cursor.execute(sql,val)
								conn.commit()
								print(conn_cursor.rowcount, "Record Inserted")
								time.sleep(1)
			except:
				print("CHUPAPI MUNYANYU")

UDS_START(True)


	






