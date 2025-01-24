using _32_XML_Serializer;
using System.Xml.Serialization;

internal class Program
{
    private static void Main(string[] args)
    {
        Car car = new Car(111, "Toyota", 2.3);
        Car car_2 = new Car(222, "Ford", 2.6);

        /*Console.WriteLine($"Origin car    :: {car}");

        string fname = "../../../car.xml";
        XmlSerializer xs = new XmlSerializer(typeof(Car));
        using(FileStream fs = new FileStream(fname,FileMode.Create))
        {
            xs.Serialize(fs,car);

            fs.Position = 0;

            Car res = (xs.Deserialize(fs) as Car)!;
            Console.WriteLine($"Recovered car :: {res}");
        }*/

        string fname = "../../../salon.xml";
        List<Car> salonList = new List<Car>()
        {
            car,
            car_2,
            new Car(333,"BMW",2.9)
        };
        XmlSerializer xs = new XmlSerializer(typeof(List<Car>));
        /*using (TextWriter tw = new StreamWriter(fname))
        {
            xs.Serialize(tw, salonList);
        }*/
        using(TextReader tr = new StreamReader(fname))
        {
            var listCar = xs.Deserialize(tr) as List<Car>;
            Console.WriteLine($"Recovered cars :: \n{String.Join<Car>("\n",listCar)}");
        }
    }
}