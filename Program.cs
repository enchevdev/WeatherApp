namespace WeatherApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WEATHER APP");

            Console.WriteLine("Press Enter To Continue...");

            Console.ReadLine();


            Console.WriteLine("Enter city:");

            string city = Console.ReadLine();

            HttpClient client = new HttpClient();
        }
    }
}
