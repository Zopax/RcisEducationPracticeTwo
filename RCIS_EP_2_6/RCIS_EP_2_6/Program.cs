using Newtonsoft.Json.Linq;
using System.Net;
using System.Text.RegularExpressions;

namespace RCIS_EP_2_6;

public class Program
{
    public static void Main()
    {
        var key = "11d6bb62d4cffe5e2e93a95d534cea5c";
        var lat = "56.5";
        var lon = "84.9667";
        var request = new GetRequest($"https://api.openweathermap.org/data/2.5/weather?lat={lat}&lon={lon}&appid={key}");
        request.Run();

        var response = request.Response;

        var json = JObject.Parse(response);
        var temps = json["main"];

        Temp temp = new Temp((int)temps["temp"],
            (int)temps["feels_like"], 
            (int)temps["temp_min"], 
            (int)temps["temp_max"],
            (int)temps["pressure"],
            (int)temps["humidity"]);

        string town = (string)json["name"];

        Console.WriteLine($"Погода: {town}");

        Console.WriteLine($"Температура: {temp.temp}°C\n" +
            $"Ощущается как: {temp.feelsLike}°C\n" +
            $"Минимальная температура: {temp.tempMin}°C\n" +
            $"Максимальная температура: {temp.tempMax}°C\n" +
            $"Давление: {temp.pressure}мм рт.ст.\n" +
            $"Влажность: {temp.humidity}%");

        var windInfo = json["wind"];
        Wind wind = new Wind((int)windInfo["speed"], 
            (int)windInfo["deg"]);

        Console.WriteLine($"Направление ветра: {wind.deg}\nСкорость ветра: {wind.speed} м/с");

        var cloudInfo = json["clouds"];
        Cloud cloud = new Cloud((int)cloudInfo["all"]);
        Console.WriteLine($"Облачность: {cloud.cloudInfo}");

        Console.Read();
    }
}