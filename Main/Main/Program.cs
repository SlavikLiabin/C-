using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLight
{
    internal class Program
    {
      static void Main(string[] args)
      {
        Car ferrari = new Car();
      }
    }

    class Car
    {
      public string Name;
      public int HorsePower;
      public int Age;
      public float MaxSpeed;

      public Car(string name, int horsePower, int age, float maxSpeed)
      {
        Name = name;
        HorsePower = horsePower;
        Age = age;
        MaxSpeed = maxSpeed;
      }
    }
}
