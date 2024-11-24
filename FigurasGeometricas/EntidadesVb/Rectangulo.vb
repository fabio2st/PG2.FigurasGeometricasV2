Public Class Rectangulo
	Inherits Figura
	Public Property Base As Single
	Public Property Altura As Single
	Public Sub New(nombre As String, base As Single, altura As Single)
		MyBase.New(nombre)
		Me.Base = base
		Me.Altura = altura
	End Sub
	Public Overrides Function CalcularArea() As Single
		Return Base * Altura
	End Function
	Public Overrides Function ToString() As String
		Return $"Soy {Nombre} y tengo la altura de {Altura} y la base de {Base}"
	End Function
End Class
