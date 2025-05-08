namespace LibraryBookRecommendation
{
    public class LibraryClerk
    {

        public LibraryClerk()
        {
        }

        public async Task<Dictionary<string,string>> PrintTenBooksOfInterest(ApiCaller apiCaller)
        {
            Dictionary<string, string> booksSelection = new Dictionary<string, string>();
            string interest = apiCaller.GetUserInterest();
            // NEED to await to actually retrieve the list from Task<List<LibraryModel>>
            var bookData = await apiCaller.InitialiseApi(interest);


            for (int i = 0; i < 10; i++)
            {
                booksSelection.Add(bookData[i].Title.ToLower(), bookData[i].Ebook_Access);
                Console.WriteLine($"Bookname: {bookData[i].Title.ToLower()}, Access status: {bookData[i].Ebook_Access}, Editions in stock: {bookData[i].Edition_count}");
            }
            return booksSelection;

        }
    }
}
