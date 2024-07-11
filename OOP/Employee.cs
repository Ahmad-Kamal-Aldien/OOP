using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Employee :Person
    {
       
        public decimal BasicSalary {  get; set; }

        public decimal TaxPercentage {  get; set; }

        public void SetTaxPercentage(decimal salary)
        {
            if (TaxPercentage > BasicSalary)
                throw new Exception();
            TaxPercentage = TaxPercentage;
        }
    }
}
