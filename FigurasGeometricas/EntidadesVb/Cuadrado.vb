Public Class Cuadrado
	Inherits Figura

	Public Property Lado As Single
	Public Sub New(nombre As String, lado As Single)
		MyBase.New(nombre)
		Me.Lado = lado
	End Sub
	Public Overrides Function CalcularArea() As Single
		Return Lado * Lado
	End Function
	Public Overrides Function ToString() As String
		Return $"Soy {Nombre} y tengo mis lados de {Lado}"
	End Function
End Class
