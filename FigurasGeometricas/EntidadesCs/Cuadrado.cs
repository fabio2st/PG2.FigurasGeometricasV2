﻿namespace EntidadesCs
{
	public class Cuadrado : Figura, Figura2D
	{
		public float Lado { get; set; }
		public Cuadrado(string nombre, float lado) : base(nombre)
		{
			Lado = lado;
		}
		public override string ToString()
		{
			return $"Soy {Nombre} y tengo mis lados de {Lado}";
		}

		public float CalcularArea()
		{
			return Lado * Lado;
		}
	}
}
