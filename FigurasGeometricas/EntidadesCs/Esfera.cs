namespace EntidadesCs
{
	public class Esfera : Figura, Figura3D
	{
		public float Radio { get; set; }
		public Esfera(string nombre, float radio) : base(nombre)
		{
			Radio = radio;
		}
		public float CalcularVolumen()
		{
			return (float)(4 / 3f * Math.PI * Math.Pow(Radio, 3));
		}
		public override string ToString()
		{
			return $"Soy {Nombre} y tengo mi radio de {Radio}";
		}
	}
}
