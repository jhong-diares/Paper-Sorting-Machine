Imports System.ComponentModel
Imports System.Text
Imports DevComponents.DotNetBar

Namespace PaperSortingMachine
    Partial Public Class StartControl
        Inherits DevComponents.DotNetBar.Controls.SlidePanel
        Public Sub New()
            InitializeComponent()
        End Sub

        Protected Overrides Sub OnResize(ByVal e As EventArgs)
            ' Center the panel
            itemPanel1.Location = New Point((Me.Width - itemPanel1.Width) / 2 + 16, ((Me.Height - labelX1.Height - 16) - itemPanel1.Height) / 2 + labelX1.Height + 16)
            MyBase.OnResize(e)
        End Sub

        Private _Commands As PaperSortingMachineCommands
        Public Property Commands() As PaperSortingMachineCommands
            Get
                Return _Commands
            End Get
            Set(ByVal value As PaperSortingMachineCommands)
                If value IsNot _Commands Then
                    Dim oldValue As PaperSortingMachineCommands = _Commands
                    _Commands = value
                    'OnCommandsChanged(oldValue, value)
                End If
            End Set
        End Property
    End Class
End Namespace
