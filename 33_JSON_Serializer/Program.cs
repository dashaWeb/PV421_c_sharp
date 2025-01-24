using _33_JSON_Serializer;
using Newtonsoft.Json;
using System.Text.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        Car car = new Car(111, "Toyota", 2.3);
        Car car_2 = new Car(222, "Ford", 2.6);
        string fname = "../../../car.json";

        /*string json = JsonSerializer.Serialize<Car>(car); // only property
        Console.WriteLine(json);
        File.WriteAllText(fname, json);

        Car res = JsonSerializer.Deserialize<Car>(File.ReadAllText(fname))!;*/

        /*Console.WriteLine(car);
        Console.WriteLine(res);*/

        /*string json = JsonConvert.SerializeObject(car);
        File.WriteAllText(fname, json);
        Console.WriteLine(JsonConvert.DeserializeObject<Car>(File.ReadAllText(fname)));*/

        string fname_2 = "../../../salon.json";
        /*List<Car> salonList = new List<Car>()
        {
            car,
            car_2,
            new Car(333,"BMW",2.9)
        };*/

        /*string json = JsonSerializer.Serialize<List<Car>>(salonList); // only property
        Console.WriteLine(json);
        File.WriteAllText(fname_2, json);

        List<Car> res = JsonSerializer.Deserialize<List<Car>>(File.ReadAllText(fname_2))!;
        Console.WriteLine(String.Join<Car>("\n", res));*/

        /*File.WriteAllText(fname_2, JsonConvert.SerializeObject(salonList));
        Console.WriteLine(String.Join<Car>("\n",JsonConvert.DeserializeObject<List<Car>>(File.ReadAllText(fname_2))));*/

        Dictionary<int, Car> salonList = new Dictionary<int, Car>()
        {
            [car.id] = car,
            [car_2.id] = car_2,
            [333] = new Car(333, "BMW", 2.9)
        };

        /*string json = JsonSerializer.Serialize<Dictionary<int, Car>>(salonList); // only property
        Console.WriteLine(json);
        File.WriteAllText(fname_2, json);

        Dictionary<int, Car> res = JsonSerializer.Deserialize<Dictionary<int, Car>>(File.ReadAllText(fname_2))!;
        foreach (var item in res)
        {
            item.Value.id = item.Key;
            Console.WriteLine($"{item.Value}");
        }*/
        File.WriteAllText(fname_2, JsonConvert.SerializeObject(salonList));
        foreach (var item in JsonConvert.DeserializeObject<Dictionary<int,Car>>(File.ReadAllText(fname_2)))
        {
            Console.WriteLine(item.Value);
        }
    }
}