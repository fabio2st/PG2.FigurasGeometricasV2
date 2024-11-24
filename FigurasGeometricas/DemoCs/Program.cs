using EntidadesCs;

namespace DemoCs
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Figura figura = new Figura(); No se puede instanciar por ser abstracta la clase
			float lado1 = 10;
			Figura cuadrado = new Cuadrado("Mi cuadrado", lado1);
            Console.WriteLine($"{cuadrado} con superficie de {cuadrado.CalcularArea()}");

			float lado2 = 5;
			Figura rectangulo = new Rectangulo("Mi rectangulo", lado1, lado2);
            Console.WriteLine($"{rectangulo} con superficie de {rectangulo.CalcularArea()}");

			Figura triangulo = new Triangulo("Mi triangulo rectangulo", lado1, lado2);
            Console.WriteLine($"{triangulo} con superficie de {triangulo.CalcularArea()}");

			Figura circulo = new Circulo("Mi circulo", lado1);
            Console.WriteLine($"{circulo} con superficie de {circulo.CalcularArea()}");
        }
	}
}
