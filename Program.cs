
namespace LibraryBookRecommendation
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            ApiCaller bookData = new ApiCaller();
            LibraryClerk libraryClerk = new LibraryClerk();
            User userOne = new User("Kuba");

            Dictionary<string, string> chosenBooks = await libraryClerk.PrintTenBooksOfInterest(bookData);
            userOne.BorrowBook(chosenBooks);
            userOne.BorrowBook(chosenBooks);
            userOne.BorrowBook(chosenBooks);
            userOne.SetUpFavouriteBooks();


        }
    }
}
