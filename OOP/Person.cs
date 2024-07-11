using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal abstract class Person
    {
        public int Id { get; set; }

        public string Name { get; set; }



        public DateOnly BirthDate { get; private set; }

        public void SetName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException("Error  name");
            this.Name = name;
        }

        
        public void SetBirthDate(DateOnly birthDate)
        {
            if (birthDate < new DateOnly(1930, 1, 1))

                throw new ArgumentException();
            this.BirthDate = birthDate;

        }

    }
}
