namespace LibraryBookRecommendation
{
    public class User
    {
        public string Name { get; set; }
        public List<string> BookBag { get; set; } = new List<string>();

        public User(string name)
        {
            Name = name;
        }

        public void BorrowBook(Dictionary<string, string> books)
        {
            Console.WriteLine("Which book would you like to borrow?");
            string bookChoice = Console.ReadLine();
            if (books.ContainsKey(bookChoice.ToLower()))
            {
                if (books.TryGetValue(bookChoice.ToLower(), out string isAvailable))
                {
                    if (isAvailable == "borrowable" || isAvailable == "public")
                    {
                        BookBag.Add(bookChoice.ToLower());
                        Console.WriteLine($"The book: {bookChoice} has been added to your bookbag");
                    }
                    else
                    {
                        Console.WriteLine("Book cannot be borrowed at the moment.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Specificed book is not listed");
            }

        }


        public void SetUpFavouriteBooks()
        {
            Console.WriteLine("Here are the books from your bookbag: ");
            foreach (var book in BookBag)
            {
                Console.WriteLine("\n" + book);
            }
            Console.WriteLine("Which is your favourite?");
            GatherFavouriteBook();

            Console.WriteLine("Second favourite?");
            GatherFavouriteBook();

            Console.WriteLine("Third favourite?");
            GatherFavouriteBook();
        }

        public void GatherFavouriteBook()
        {
            string bookChoice = Console.ReadLine();
            if (BookBag.Contains(bookChoice))
            {
                File.AppendAllText("fav_books.txt", bookChoice);
            }
            else
            {
                Console.WriteLine("Book not in bag boss..");
            }
        }
    }
}
