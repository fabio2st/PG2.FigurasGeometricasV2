namespace EntidadesCs
{
	public class Rectangulo : Figura
	{
		public float Altura { get; set; }
		public float Base { get; set; }
		public Rectangulo(string nombre, float @base, float altura) : base(nombre)
		{
			Base = @base;
			Altura = altura;
		}
		public override float CalcularArea()
		{
			return Base * Altura;
		}
		public override string ToString()
		{
			return $"Soy {Nombre} y tengo la base de {Base} y la altura de {Altura}";
		}
	}
}
