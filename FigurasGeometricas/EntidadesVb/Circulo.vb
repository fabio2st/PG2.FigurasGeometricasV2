Public Class Circulo
	Inherits Figura
	Public Property Radio As Single
	Public Sub New(nombre As String, radio As Single)
		MyBase.New(nombre)
		Me.Radio = radio
	End Sub
	Public Overrides Function CalcularArea() As Single
		Return Math.PI * Math.Pow(Radio, 2)
	End Function
	Public Overrides Function ToString() As String
		Return $"Soy {Nombre} y tengo el radio de {Radio}"
	End Function
End Class
