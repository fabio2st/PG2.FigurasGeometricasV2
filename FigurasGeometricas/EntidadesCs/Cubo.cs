namespace EntidadesCs
{
	public class Cubo : Figura, Figura3D
	{
		public float Lado { get; set; }
		public Cubo(string nombre, float lado) : base(nombre)
		{
			Lado = lado;
		}
		public override string ToString()
		{
			return $"Soy {Nombre} y tengo mis lados de {Lado}";
		}

		public float CalcularVolumen()
		{
			return (float)Math.Pow(Lado, 3);
		}
	}
}
