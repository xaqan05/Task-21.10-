using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_21._10_
{
    public class Library
    {
        public Book[] Books;

        public Journal[] Journals;

        public Library()
        {
            Books = new Book[0];
            Journals = new Journal[0];
        }

        public void AddBook(Book book)
        {
            Book[] newBooks = new Book[Books.Length + 1];

            for (int i = 0; i < Books.Length; i++)
            {
                newBooks[i] = Books[i];
            }

            newBooks[newBooks.Length - 1] = book;

            Books = newBooks;
        }

        public void AddJournal(Journal journal)
        {
            Journal[] newJournal = new Journal[Journals.Length + 1];

            for (int i = 0; i < Journals.Length; i++)
            {
                newJournal[i] = Journals[i];
            }

            newJournal[newJournal.Length - 1] = journal;

            Journals = newJournal;
        }

        public Book GetBooksByPrice(double minPrice, double maxPrice)
        {
            Book book = null;
            for (int i = 0; i < Books.Length; i++)
            {
                if (minPrice < Books[i].Price && maxPrice > Books[i].Price)
                {
                    book = Books[i];
                    return book;
                }
            }

            return book;
        }

        public Book GetBooksByName(string name)
        {
            Book book = null;
            for (int i = 0; i < Books.Length; i++)
            {
                if (name == Books[i].Name)
                {
                    book = Books[i];
                    return book;
                }
            }

            return book;
        }

        public Journal GetJournalsByPrice(double minPrice, double maxPrice)
        {
            Journal journal = null;
            for (int i = 0; i < Books.Length; i++)
            {
                if (minPrice < Journals[i].Price && maxPrice > Journals[i].Price)
                {
                    journal = Journals[i];
                    return journal;
                }
            }

            return journal;
        }

        public Journal GetJournalsByName(string name)
        {
            Journal journal = null;
            for (int i = 0; i < Journals.Length; i++)
            {
                if (name == Journals[i].Name)
                {
                    journal = Journals[i];
                    return journal;
                }
            }
            return journal;
        }


        public void GetInfoBooks()
        {
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books.Length > 0)
                {
                    Books[i].GetInfo();

                }
                else
                {
                    Console.WriteLine("Kitabxanada hec bir kitab tapilmadi.");
                }
            }
        }
    }
}
