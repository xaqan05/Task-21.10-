namespace Task_21._10_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Journal journal = new Journal("Taylor & Francis Group", "Journal of Sports Sciences", 200);
            Library library = new Library();
            bool condition = false;
            string name;
            double price;
            string author;
            string genre;
            string input;

            do
            {
                Console.WriteLine("1.Kitab elave etmek ucun 1 secin.");
                Console.WriteLine("2.Kitab haqqinda melumat elde etmek ucun 2 secin.");
                Console.WriteLine("3.Qiymetine gore kitab axtarmaq ucun 3 secin");
                Console.WriteLine("4.Adina gore kitab axtarmaq ucun 4 secin.");
                Console.WriteLine("5.Jurnal elave etmek ucun 5 secin.");
                Console.WriteLine("6.Jurnal haqqinda melumat elde etmek ucun 6 secin.");
                Console.WriteLine("7.Qiymetine gore jurnal axtarmaq ucun 7 secin.");
                Console.WriteLine("0.Proqramdan cixmaq ucun 0 secin.");
                Console.WriteLine(" ");

                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.Clear();
                        Console.Write("Zehmet olmasa kitab adi daxil edin:");
                        name = Console.ReadLine();

                        Console.WriteLine(" ");

                        Console.Write("Zehmet olmasa janri daxil edin:");
                        genre = Console.ReadLine();

                        Console.WriteLine(" ");

                        Console.Write("Zehmet olmasa kitabin muellifini qeyd edin:");
                        author = Console.ReadLine();

                        Console.WriteLine(" ");

                        bool condition1 = false;

                        do
                        {
                            Console.Write("Zehmet olmasa kitabin qiymetini daxil edin:");
                            condition1 = double.TryParse(Console.ReadLine(), out price);

                        } while (!condition1);

                        Console.WriteLine(" ");

                        Book book = new Book(author, genre, name, price);

                        library.AddBook(book);

                        Console.WriteLine("Kitab ugurla kitabxanaya elave olundu.");

                        Console.WriteLine(" ");


                        break;
                    case "2":
                        Console.Clear();
                        library.GetInfoBooks();
                        Console.WriteLine(" ");
                        break;
                }
            } while (!condition);

        }
    }
}
