using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace netcore30_buildin_json_serialize_demo
{



        class WeatherForecast
        {
            public DateTimeOffset Date { get; set; }
            public int TemperatureC { get; set; }
            public string Summary { get; set; }
        }

        class Program
        {
            static void Main(string[] args)
            {
                var w = new WeatherForecast() { Date = DateTime.Now, TemperatureC = 30, Summary = "Hot" };
                Console.WriteLine(JsonSerializer.Serialize<WeatherForecast>(w));
            }
        }

}
