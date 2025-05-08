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
                    if (isAvailable == "borrowable")
                    {
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
                Console.WriteLine("Specificed book not an option");
            }

        }
        

        public void SetUpFavouriteBooks()
        {

        }
    }
}
