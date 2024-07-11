using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Sound From Cat");
        }

        public void MakeSound(int number)
        {
            Console.WriteLine("Sound Based Overload");
        }
    }
}
