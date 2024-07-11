using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Dog :Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Sound From Dog");
        }

        public void MakeSound(int number)
        {
            Console.WriteLine("Sound Based Overload");
        }
    }
}
