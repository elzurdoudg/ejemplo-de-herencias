using System;

namespace ejemploHerencia
{
	public class Animal
	{
		private String nombre;
		private double peso;
		private double tamanio;
		private String genero;
		private String especie;
		
		public Animal ()
		{
			this.peso = 0.0;
			this.tamanio = 0.0;
			this.genero = "" ;
			this.especie= "";
		}
		
		public virtual void comunicarse(){
			Console.WriteLine("El animal esta tratando de comunicarse");
		}
		
		public void pedirDatos(Animal animalTipo){
		Console.WriteLine("Dame el nombre del animal");
		animalTipo.nombre = Console.ReadLine();
		Console.WriteLine("Dame el peso del animal");
		animalTipo.peso = double.Parse(Console.ReadLine());	
		Console.WriteLine("Dame el tamaño del animal");
		animalTipo.tamanio = double.Parse(Console.ReadLine());	
		Console.WriteLine("Dame el genero del animal");
		animalTipo.genero = Console.ReadLine();	
		Console.WriteLine("Dame el tipo de especie del animal");
		animalTipo.especie = Console.ReadLine();	
		}
		
		public void mostrarDatos(Animal animalTipo){
		Console.WriteLine("Nombre:"+animalTipo.nombre);
		Console.WriteLine("Peso:"+animalTipo.peso);
		Console.WriteLine("Tamaño:"+animalTipo.tamanio);
		Console.WriteLine("genero:"+animalTipo.genero);
		Console.WriteLine("Especie:"+animalTipo.especie);
		}
	}
}

