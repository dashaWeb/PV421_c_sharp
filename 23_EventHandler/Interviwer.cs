using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_EventHandler
{
    internal class Interviwer
    {
        public string Name { get; set; }

        public void Dosomething(object sender, MyArgs args)
        {
            Console.WriteLine($"Interviwer {Name} notified about {args.Description} Date :: {args.Date} from Company {args.CompanyName}");
        }
    }
}
