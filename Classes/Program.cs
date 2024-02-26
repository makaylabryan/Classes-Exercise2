namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
           Car myCar = new Car();
            myCar.Make = "Kia";
            myCar.Model = "Forte";
            myCar.Year = 2015;

            Console.WriteLine($"My car is a {myCar.Year} {myCar.Make} {myCar.Model}.");
        }
    }
}
