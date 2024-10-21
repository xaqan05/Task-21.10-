using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_21._10_
{
    public class Journal : Product
    {
        public string Company;

        public Journal(string company,string name,double price) : base(name,price)
        {
            Company = company;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Jurnalin adi: {Name}, Jurnalin qiymeti: {Price}, Jurnalin company: {Company}");
        }
    }
}
