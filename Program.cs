// Author: Joanne

namespace ZooAnimals;

class Program
{
	abstract class Animal
	{
		public string m_Name { get; set; }
		public int m_Age { get; set; }

		public Animal(string name, int age){
			m_Name = name;
			m_Age = age;
		}
		
		public abstract void MakeSound();
	}
	
	class Lion : Animal
	{
		public Lion(string name, int age) : base(name, age){
		}
		
		public override void MakeSound(){
			Console.WriteLine(Roar());
		}
		
		private string Roar(){
			return "Roar!";
		}
	}
		
		interface ISwim
		{
			void Swim();
		}
		
	class Penguin : Animal, ISwim
	{
		public Penguin(string name, int age) : base(name, age){
		}
		
		public override void MakeSound(){
			Console.WriteLine(Honk());
		}
		
		public void Swim(){
			Console.WriteLine("Splash!");
		}
		
		private string Honk(){
			return "Honk!";
		}
	}	
		
	class Elephant : Animal
	{
		public Elephant(string name, int age) : base(name, age){
		}
		
		public override void MakeSound(){
			Console.WriteLine(Trumpet());
		}
		
		private string Trumpet(){
			return "Trumpet!";
		}
	}
	 
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Zoo Animals!");

		List<Animal> Zoo = new List<Animal>();

		Zoo.Add(new Lion("Felix", 7));		
		Zoo.Add(new Lion("Felicity", 3));		
		Zoo.Add(new Penguin("James", 2));	
		Zoo.Add(new Elephant("Ellie", 17));	

		foreach(var animal in Zoo){
			Console.WriteLine(animal.m_Name);
			animal.MakeSound();			
		}
		
		try{
			Penguin penguin = (Penguin)(Zoo[2]);
		
			penguin.Swim();
		}catch(Exception){
		}
		
    }
}
