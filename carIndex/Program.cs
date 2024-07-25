namespace carIndex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cars car = new Cars("2.0", "VW", "2007", 108000, 200000);

            Console.WriteLine(car[0]);
            Console.WriteLine(car[1]);
            Console.WriteLine(car[2]);
            Console.WriteLine(car[3]);
            Console.WriteLine(car[4]);

            Console.WriteLine("engine capacity " + car["engineCapacity"]);
            Console.WriteLine("Car Model " + car["model"]);
            Console.WriteLine("Year " + car["year"]);
            Console.WriteLine("Milage " + car["Milage"]);
            Console.WriteLine("price " + car["price"]);
        }
    }
}
