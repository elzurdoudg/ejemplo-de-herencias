using System;

namespace ejemploHerencia
{
	public class Perro : Animal
	{
		private String raza;
		
		public String Raza {
            get {
                return raza; 
            }
            set  {
                raza = value; 
            }
        }
		
		public Perro ()
		{
			this.raza="";
		}
	
		
		public override void comunicarse(){
			Console.WriteLine("El perro esta ladrando: GUAU GUAU!");
	
		}
		public void olfatear(){
			Console.WriteLine("El perro empezó a olfatear");

		}
		
		public void pedirRaza(Perro animal){
		Console.WriteLine("Dame la raza del perro");
			animal.raza = Console.ReadLine();
		}
		
		public void mostrarRaza(Animal animal){
			Console.WriteLine("La raza del perro es:"+Raza);
		}
	}
}

