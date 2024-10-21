using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_21._10_
{
    public class Book : Product
    {
        public string Author;

        public string Genre;

        public Book(string author, string genre, string name, double price) : base(name, price)
        {
            Author = author;
            Genre = genre;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Kitabin adi: {Name}, Kitabin qiymeti: {Price}, Kitabin muellifi: {Author}, Kitabin janri: {Genre}");
        }
    }
}
