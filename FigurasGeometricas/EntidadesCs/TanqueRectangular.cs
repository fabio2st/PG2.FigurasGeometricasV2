namespace EntidadesCs
{
	public class TanqueRectangular : Figura, Figura3D
	{
		public float Altura { get; set; }
		public float Base { get; set; }
		public float Profundidad { get; set; }
		public TanqueRectangular(string nombre, float @base, float altura, float profundidad) : base(nombre)
		{
			Base = @base;
			Altura = altura;
			Profundidad = profundidad;
		}
		public float CalcularVolumen()
		{
			return Base * Altura * Profundidad;
		}
		public override string ToString()
		{
			return $"Soy {Nombre} y tengo la base de {Base}, la altura de {Altura} y la profundidad de {Profundidad}";
		}

	}
}
