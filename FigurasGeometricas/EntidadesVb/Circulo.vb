﻿Public Class Circulo
	Inherits Figura
	Implements Figura2D

	Public Property Radio As Single
	Public Sub New(nombre As String, radio As Single)
		MyBase.New(nombre)
		Me.Radio = radio
	End Sub
	Public Overrides Function ToString() As String
		Return $"Soy {Nombre} y tengo el radio de {Radio}"
	End Function

	Public Function CalcularArea() As Single Implements Figura2D.CalcularArea
		Return Math.PI * Math.Pow(Radio, 2)
	End Function
End Class
