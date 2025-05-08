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

        public void BorrowBook()
        {

        }

        public void ReturnBook()
        {

        }
    }
}
