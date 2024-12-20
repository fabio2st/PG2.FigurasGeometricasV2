﻿Public Class Cuadrado
	Inherits Figura
	Implements Figura2D

	Public Property Lado As Single
	Public Sub New(nombre As String, lado As Single)
		MyBase.New(nombre)
		Me.Lado = lado
	End Sub

	Public Overrides Function ToString() As String
		Return $"Soy {Nombre} y tengo mis lados de {Lado}"
	End Function

	Public Function CalcularArea() As Single Implements Figura2D.CalcularArea
		Return Lado * Lado
	End Function
End Class
