using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    internal class Toyota : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Started Car");
        }

        public void Stop()
        {
            Console.WriteLine("Stopped Car");
        }

        public void StartHeadLight(int brightness)
        {
            Console.WriteLine($"Headline Started From Toyota: {brightness}");
        }

        void IVehicle.StartHeadLight(int brightness)
        {
            Console.WriteLine($"Headline Started From (Modified): {brightness}");
        }

    }
}
