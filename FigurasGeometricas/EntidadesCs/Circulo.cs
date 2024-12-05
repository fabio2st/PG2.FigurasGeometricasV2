namespace EntidadesCs
{
	public class Circulo : Figura, Figura2D
	{
		public float Radio {  get; set; }
		public Circulo(string nombre, float radio) : base(nombre)
		{
			Radio = radio;
		}
		public float CalcularArea()
		{
			return (float)(Math.PI * Math.Pow(Radio, 2));
		}
		public override string ToString()
		{
			return $"Soy {Nombre} y tengo mi radio de {Radio}";
		}
	}
}
