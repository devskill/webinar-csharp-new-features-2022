using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    internal interface IVehicle
    {
        void Start();
        void Stop();
        public void StartHeadLight(int brightness)
        {
            Console.WriteLine($"Headline Started: {brightness}");
        }
    }
}
