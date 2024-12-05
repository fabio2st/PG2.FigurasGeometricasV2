Public Class Cubo
	Inherits Figura
	Implements Figura3D

	Public Property Lado As Single
	Public Sub New(nombre As String, lado As Single)
		MyBase.New(nombre)
		Me.Lado = lado
	End Sub

	Public Function CalcularVolumen() As Single Implements Figura3D.CalcularVolumen
		Return Math.Pow(Lado, 3)
	End Function
	Public Overrides Function ToString() As String
		Return $"Soy {Nombre} y tengo mis lados de {Lado}"
	End Function
End Class
