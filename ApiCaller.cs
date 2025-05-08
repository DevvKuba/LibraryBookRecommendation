using System.Net.Http.Json;

namespace LibraryBookRecommendation
{
    public class ApiCaller
    {

        public string GetUserInterest()
        {
            Console.WriteLine("What primary subject do you like reading?");
            string subject = Console.ReadLine();
            return subject;
        }
        public async Task<List<LibraryModel>> InitialiseApi(string subject)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri($"https://openlibrary.org/search.json?q={subject}");
            var data = await RetrieveData(client);
            return data;

        }

        public async Task<List<LibraryModel>> RetrieveData(HttpClient client)
        {
            // access outer docs containing all info
            var response = await client.GetFromJsonAsync<DocsData>(client.BaseAddress);

            //return adhering to LibraryModel model by querying through the response.Data (List<LibraryModel>)
            return response.Docs.Select(x => new LibraryModel
            {
                Title = x.Title,
                Author_name = x.Author_name,
                Ebook_Access = x.Ebook_Access,
                Edition_count = x.Edition_count,

            }).ToList();

        }


    }
}
