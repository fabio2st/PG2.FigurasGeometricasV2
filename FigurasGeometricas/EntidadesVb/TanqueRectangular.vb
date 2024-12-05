Public Class TanqueRectangular
	Inherits Figura
	Implements Figura3D

	Public Property Base As Single
	Public Property Altura As Single
	Public Property Profundidad As Single
	Public Sub New(nombre As String, base As Single, altura As Single, profundidad As Single)
		MyBase.New(nombre)
		Me.Base = base
		Me.Altura = altura
		Me.Profundidad = profundidad
	End Sub

	Public Function CalcularVolumen() As Single Implements Figura3D.CalcularVolumen
		Return Base * Altura * Profundidad
	End Function
	Public Overrides Function ToString() As String
		Return $"Soy {Nombre} y tengo la altura de {Altura}, la base de {Base} y la profundidad de {Profundidad}"
	End Function
End Class
