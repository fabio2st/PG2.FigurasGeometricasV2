Public Class Triangulo
	Inherits Figura
	Implements Figura2D

	Public Property Base As Single
	Public Property Altura As Single
	Public Sub New(nombre As String, base As Single, altura As Single)
		MyBase.New(nombre)
		Me.Base = base
		Me.Altura = altura
	End Sub
	Public Overrides Function ToString() As String
		Return $"Soy {Nombre} y tengo la altura de {Altura} y la base de {Base}"
	End Function

	Public Function CalcularArea() As Single Implements Figura2D.CalcularArea
		Return (Base * Altura) / 2
	End Function
End Class
