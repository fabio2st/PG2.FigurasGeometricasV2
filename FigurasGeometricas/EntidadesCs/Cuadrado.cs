namespace EntidadesCs
{
	public class Cuadrado : Figura
	{
		public float Lado { get; set; }
		public Cuadrado(string nombre, float lado) : base(nombre)
		{
			Lado = lado;
		}
		public override float CalcularArea()
		{
			return Lado * Lado;
		}
		public override string ToString()
		{
			return $"Soy {Nombre} y tengo mis lados de {Lado}";
		}
	}
}
