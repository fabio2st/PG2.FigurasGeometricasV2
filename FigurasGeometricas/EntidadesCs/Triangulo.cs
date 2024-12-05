using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesCs
{
	public class Triangulo : Figura, Figura2D
	{
		public float Altura { get; set; }
		public float Base { get; set; }
		public Triangulo(string nombre, float @base, float altura) : base(nombre)
		{
			Base = @base;
			Altura = altura;
		}
		public float CalcularArea()
		{
			return (Base * Altura) / 2;
		}
		public override string ToString()
		{
			return $"Soy {Nombre} y tengo la base de {Base} y la altura de {Altura}";
		}
	}
}
