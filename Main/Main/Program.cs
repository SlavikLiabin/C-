using System;
					
public class Program
{
	public static void Main(string[] args)
	{
		Random rand = new Random();
		
		int health1 = rand.Next(90, 100);
		int damage1 = rand.Next(5, 20);
		int armor1 = rand.Next(25, 65);
		
		int health2 = rand.Next(80, 150);
		int damage2 = rand.Next(20, 40);
		int armor2 = rand.Next(65, 100);
		
		Console.WriteLine($"Гладиатор 1 - {health1} здоровье, {damage1} наносимый урон, {armor1} броня");
		Console.WriteLine($"Гладиатор 2 - {health2} здоровье, {damage2} наносимый урон, {armor2} броня");

	}
}
