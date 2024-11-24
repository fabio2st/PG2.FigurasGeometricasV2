Public MustInherit Class Figura
	Public Property Nombre As String
	Public Sub New(nombre As String)
		Me.Nombre = nombre
	End Sub

	Public MustOverride Function CalcularArea() As Single
End Class
