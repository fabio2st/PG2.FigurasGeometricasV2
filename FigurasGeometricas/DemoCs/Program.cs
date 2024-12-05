using EntidadesCs;

namespace DemoCs
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Figura figura = new Figura(); No se puede instanciar por ser abstracta la clase
			float lado1 = 10;
			Figura2D cuadrado = new Cuadrado("Mi cuadrado", lado1);
            Console.WriteLine($"{cuadrado} con superficie de {cuadrado.CalcularArea()}");

			float lado2 = 5;
			Figura2D rectangulo = new Rectangulo("Mi rectangulo", lado1, lado2);
            Console.WriteLine($"{rectangulo} con superficie de {rectangulo.CalcularArea()}");

			Figura2D triangulo = new Triangulo("Mi triangulo rectangulo", lado1, lado2);
            Console.WriteLine($"{triangulo} con superficie de {triangulo.CalcularArea()}");

			Figura2D circulo = new Circulo("Mi circulo", lado1);
            Console.WriteLine($"{circulo} con superficie de {circulo.CalcularArea()}");

			Figura3D cubo = new Cubo("Mi cubo", lado1);
            Console.WriteLine($"{cubo} con volumén de {cubo.CalcularVolumen()}");

			float lado3 = 2;
			Figura3D tanqueRectangular = new TanqueRectangular("Mi Tanque Rectangular", lado1, lado2, lado3);
            Console.WriteLine($"{tanqueRectangular} con volumén de {tanqueRectangular.CalcularVolumen()}");

			Figura3D piramideCuadrada = new PiramideCuadrada("Mi Piramide Cuadrada", lado1, lado2);
            Console.WriteLine($"{piramideCuadrada} con volumén de {piramideCuadrada.CalcularVolumen()}");

			Figura3D esfera = new Esfera("Mi Esfera", lado1);
            Console.WriteLine($"{esfera} con volumén de {esfera.CalcularVolumen()}");
        }
	}
}
