Imports System
Imports EntidadesVb

Module Program
	Sub Main(args As String())
		'Dim figura As New Figura("") Figura no se puede instanciar
		Dim lado1 As Single = 10
		Dim cuadrado As Figura
		cuadrado = New Cuadrado("Mi cuadrado", lado1)
		Console.WriteLine($"{cuadrado} con superficie de {cuadrado.CalcularArea()}")

		Dim lado2 As Single = 5
		Dim rectangulo As Figura = New Rectangulo("Mi rectangulo", lado1, lado2)
		Console.WriteLine($"{rectangulo} con superficie de {rectangulo.CalcularArea()}")

		Dim triangulo As Figura = New Triangulo("Mi triangulo", lado1, lado2)
		Console.WriteLine($"{triangulo} con superficie de {triangulo.CalcularArea()}")

		Dim circulo As Figura = New Circulo("Mi circulo", lado1)
		Console.WriteLine($"{circulo} con superficie de {circulo.CalcularArea()}")
	End Sub
End Module
