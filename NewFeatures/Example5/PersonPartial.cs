using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example5
{
    internal partial class Person
    {
        public string Address { get; set; }

        public partial void Run()
        {
            throw new NotImplementedException();
        }

        public void Walk(int speed)
        {
            Console.WriteLine($"Walking at speed: {speed}");
        }
    }
}
