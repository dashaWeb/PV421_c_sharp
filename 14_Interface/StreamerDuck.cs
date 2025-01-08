using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Interface
{
    internal class StreamerDuck:Duck, IFly
    {
        public override void Fly()
        {
            Console.WriteLine("Streamer duck can not fly");
        }
    }
}
