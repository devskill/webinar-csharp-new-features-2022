using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example5
{
    internal partial class Person
    {
        public string Name { get; set; }

        public partial void Run();

        public void Talk(string message)
        {
            Console.WriteLine(message);
        }
    }
}
