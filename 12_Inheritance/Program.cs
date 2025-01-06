using _12_Inheritance;

internal class Program
{
    private static void Main(string[] args)
    {
        //Device device = new Device(); error
        TV tV = new TV("LG");
        Smartphone smartphone = new Smartphone("Nokia");
        tV.Print();
        smartphone.Print();

        Console.WriteLine($"\n{new string('=',50)}\n");
        Device[] tvs = new Device[] { tV, smartphone , new SmartTV()};
        foreach (Device device in tvs)
        {
            device.Print();
            // ((TV)device).NextChannel(); error
            // 1)
            /*try
            {
                ((TV)device).NextChannel();
                ((Smartphone)device).Call();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }*/

            // 2)
            /*TV tmp_tv = device as TV;
            if(tmp_tv != null)
            {
                tmp_tv.NextChannel();
            }
            Smartphone tmp_smart = device as Smartphone;
            if(tmp_smart != null)
            {
                tmp_smart.Call();
            }*/
            //3)
            if(device is TV)
            {
                (device as TV)?.NextChannel();
            }
            if (device is Smartphone)
            {
                (device as Smartphone)?.Call();
            }
        }
    }
}