using System;

class MainClass
{
    public static void Main(string[] args)
    {

        (string name, string type, float age) Pet;

        Console.Write("Введите имя питомца: ");
        Pet.name = Console.ReadLine();

        Console.Write("Введите его описание: ");
        Pet.type = Console.ReadLine();

        Console.Write("Введите возраст: ");
        Pet.age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Имя: {0}", Pet.name);
        Console.WriteLine("Описание: {0}", Pet.type);
        Console.WriteLine("Возраст: {0}", Pet.age);

        Console.ReadKey();

    }
}