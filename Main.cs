using System;

namespace ejemploHerencia
{
	class Principal
	{
		public static void Main (string[] args)
		{
			Perro perrito = new Perro();
			perrito.pedirDatos(perrito);
			perrito.pedirRaza(perrito);
			perrito.mostrarDatos(perrito);
			perrito.mostrarRaza(perrito);
			perrito.comunicarse();
			perrito.olfatear();
			
		}
	}
}
