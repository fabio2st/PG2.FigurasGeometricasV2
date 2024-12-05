Public Class Esfera
	Inherits Figura
	Implements Figura3D
	Public Property Radio As Single
	Public Sub New(nombre As String, radio As Single)
		MyBase.New(nombre)
		Me.Radio = radio
	End Sub

	Public Function CalcularVolumen() As Single Implements Figura3D.CalcularVolumen
		Return 4 / 3 * Math.PI * Math.Pow(Radio, 3)
	End Function
	Public Overrides Function ToString() As String
		Return $"Soy {Nombre} y tengo el radio de {Radio}"
	End Function
End Class
