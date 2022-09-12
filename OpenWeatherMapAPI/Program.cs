using Newtonsoft.Json.Linq;

Console.WriteLine("Please enter the city you wish to see the weather for: ");
var cityName = Console.ReadLine();

var client = new HttpClient();

var weatherURL = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid=6de509898672060e0c90399fa3cdf525&units=imperial";
var weatherResponse = client.GetStringAsync(weatherURL).Result;
var weatherObject = JObject.Parse(weatherResponse);
Console.WriteLine($" Temperature: {weatherObject["main"]["temp"]}");
Console.WriteLine($" Feels like: {weatherObject["main"]["feels_like"]}");
Console.WriteLine($" Wind speed: {weatherObject["wind"]["speed"]}");
Console.WriteLine($" Description: {weatherObject["weather"][0]["description"]}");
