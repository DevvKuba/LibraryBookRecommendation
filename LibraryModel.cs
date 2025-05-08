namespace LibraryBookRecommendation
{
    public class DocsData
    {
        public List<LibraryModel> Docs { get; set; }
    }
    public class LibraryModel
    {
        public string Title { get; set; }
        public string[] Author_name { get; set; }

        public string Ebook_Access { get; set; }
        public int Edition_count { get; set; }
    }
}
