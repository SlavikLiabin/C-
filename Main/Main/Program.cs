using System;
					
public class Program
{
	public static void Main()
	{
		static void ChangeAge(ref int age){
			Console.WriteLine("Input your age");
			age = Convert.ToInt32(Console.ReadLine());
		}
		int myAge = 32;
		Console.WriteLine($"Возраст до метода ChangeAge {myAge}");
		ChangeAge(ref myAge);
		Console.WriteLine($"Возраст после метода ChangeAge {myAge}");
	}
}
