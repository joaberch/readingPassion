namespace readingPassion
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            List<Book> books = new List<Book> ();
        }
    }

    internal class Book
    {
        public string title;
        public string category;
        public int nbrPage;
        public string author;
        public string[] tags;

        public Book(string title, string category, int nbrPage, string author, string[] tags)
        {
            this.title = title;
            this.category = category;
            this.nbrPage = nbrPage;
            this.author = author;
            this.tags = tags;
        }
    }
}
