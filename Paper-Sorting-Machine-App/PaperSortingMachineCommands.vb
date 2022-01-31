Imports System.Text
Imports DevComponents.DotNetBar

Namespace PaperSortingMachine
    Public Class PaperSortingMachineCommands
        Private _SlideStartControl As Command
        Public Property ToggleStartControl() As Command
            Get
                Return _SlideStartControl
            End Get
            Set(ByVal value As Command)
                _SlideStartControl = value
            End Set
        End Property

        Private _ChangeMetroTheme As Command
        Public Property ChangeMetroTheme() As Command
            Get
                Return _ChangeMetroTheme
            End Get
            Set(ByVal value As Command)
                _ChangeMetroTheme = value
            End Set
        End Property
    End Class
End Namespace
