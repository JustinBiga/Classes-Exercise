using System.Reflection;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create a new instance of the Car class

          Car myCar = new Car();

            myCar.Make = "Chevy";
            myCar.Model = "Malibu";
            myCar.Year = 2016;

            Console.WriteLine($"My Car's info");

            Console.WriteLine("Make: " + myCar.Make);
            Console.WriteLine("Model: " + myCar.Model);
            Console.WriteLine("Year: " + myCar.Year);

        }

    }
}
