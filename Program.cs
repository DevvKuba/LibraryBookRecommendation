
namespace LibraryBookRecommendation
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            ApiCaller bookData = new ApiCaller();
            //await bookData.InitialiseApi();

            LibraryClerk libraryClerk = new LibraryClerk();
            User userOne = new User("Kuba");
            await libraryClerk.PrintTenBooksOfInterest(bookData);


        }
    }
}
