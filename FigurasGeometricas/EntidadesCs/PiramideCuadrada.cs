namespace EntidadesCs
{
	public class PiramideCuadrada : Figura, Figura3D
	{
		public float Altura { get; set; }
		public float Base { get; set; }
		public PiramideCuadrada(string nombre, float @base, float altura) : base(nombre)
		{
			Base = @base;
			Altura = altura;
		}
		public float CalcularVolumen()
		{
			return (float)(1 / 3f * Math.Pow( Base, 2) * Altura);
		}
		public override string ToString()
		{
			return $"Soy {Nombre} y tengo la base de {Base} y la altura de {Altura}";
		}
	}
}
