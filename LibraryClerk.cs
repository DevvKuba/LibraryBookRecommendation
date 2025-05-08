namespace LibraryBookRecommendation
{
    public class LibraryClerk
    {

        public LibraryClerk()
        {
        }

        public async Task PrintTenBooksOfInterest(ApiCaller apiCaller)
        {
            string interest = apiCaller.GetUserInterest();
            // NEED to await to actually retrieve the list from Task<List<LibraryModel>>
            var bookData = await apiCaller.InitialiseApi(interest);


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Bookname: {bookData[i].Title}, Access status: {bookData[i].Ebook_Access}, Editions in stock: {bookData[i].Edition_count}");
            }
        }
    }
}
