using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    internal abstract class Person
    {
        public void Talk (string message)
        {
            Console.WriteLine(message);
        }

        public abstract void Walk();
    }
}
