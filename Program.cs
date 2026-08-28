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

            GetWeatherAsync(client, city).Wait();
        }

        public static async Task GetWeatherAsync(HttpClient client, string city)
        {
            
            string response = await client.GetStringAsync($"https://geocoding-api.open-meteo.com/v1/search?name={city}");
            Console.WriteLine(response);
        }
    }
}
