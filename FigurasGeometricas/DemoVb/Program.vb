Imports System
Imports EntidadesVb

Module Program
	Sub Main(args As String())
		'Dim figura As New Figura("") Figura no se puede instanciar
		Dim lado1 As Single = 10
		Dim cuadrado As Figura2D
		cuadrado = New Cuadrado("Mi cuadrado", lado1)
		Console.WriteLine($"{cuadrado} con superficie de {cuadrado.CalcularArea()}")

		Dim lado2 As Single = 5
		Dim rectangulo As Figura2D = New Rectangulo("Mi rectangulo", lado1, lado2)
		Console.WriteLine($"{rectangulo} con superficie de {rectangulo.CalcularArea()}")

		Dim triangulo As Figura2D = New Triangulo("Mi triangulo", lado1, lado2)
		Console.WriteLine($"{triangulo} con superficie de {triangulo.CalcularArea()}")

		Dim circulo As Figura2D = New Circulo("Mi circulo", lado1)
		Console.WriteLine($"{circulo} con superficie de {circulo.CalcularArea()}")

		Dim cubo As Figura3D = New Cubo("Mi Cubo", lado1)
		Console.WriteLine($"{cubo} con volumén de {cubo.CalcularVolumen()}")

		Dim lado3 = 2
		Dim tanqueRectangular As Figura3D = New TanqueRectangular("Mi Tanque rectangular", lado1, lado2, lado3)
		Console.WriteLine($"{tanqueRectangular} con volumén de {tanqueRectangular.CalcularVolumen()}")

		Dim piramideCuadrada As Figura3D = New PiramideCuadrada("Mi Piramide Cuadrada", lado1, lado2)
		Console.WriteLine($"{piramideCuadrada} con volumén de {piramideCuadrada.CalcularVolumen()}")

		Dim esfera As Figura3D = New Esfera("Mi Esfera", lado1)
		Console.WriteLine($"{esfera} con volumén de {esfera.CalcularVolumen()}")
	End Sub
End Module
