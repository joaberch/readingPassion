using CommunityToolkit.Mvvm.Input;
using Microsoft.EntityFrameworkCore.Storage;
using readingPassion.Models;
using readingPassion.Services;
using System.Collections.ObjectModel;

namespace readingPassion
{
    public partial class MainPage : ContentPage
    {
        
        public List<Book> bookss =
            [
                new Book(title: "1984", category: "novel", nbrPage: 438, author: "George Orwell", tags: ["politique", "dystopique", "économique", "fiction"], coverImage: "a1984a", state: "Current"),
                new Book(title: "fondation", category: "roman", nbrPage: 256, author: "Isaac Asimov", tags: ["sci-fi", "série"], coverImage: "fondation", state: "TODO"),
                new Book(title: "fondation foudroyée", category: "roman", nbrPage: 508, author: "Isaac Asmov", tags: ["sci-fi", "série"], coverImage: "fondationfoudroyee", state: "TODO"),
                new Book(title: "L'origine des espèces", category: "ouvrage scientifique", nbrPage: 600, author: "Charles Darwin", tags: ["science", "long", "animaux"], coverImage: "origineespece", state: "TODO"),
                new Book(title: "Le prince", category: "traité politique", nbrPage: 192, author: "Nicolas Machiavel", tags: ["moral", "politique", "philosophie", "histoire"], coverImage: "prince", state: "Current"),
                new Book(title: "Le roman de renart", category: "recueil", nbrPage: 96, author: "unknown", tags: ["animaux"], coverImage: "romanrenart", state: "Current"),
                new Book(title: "La tour sombre", category: "série", nbrPage: 376, author: "Stephen King", tags: ["fantastique", "western"], coverImage: "toursombre", state: "Done")
        ];
        
        public MainPage()
        {
            InitializeComponent();
            testc();
        }
        private async void testc()
        {
            await FileSystem.Current.OpenAppPackageFileAsync("La_Fontaine_Jean_de-Fables.epub");
        }
        private void ImageButton_Loaded(object sender, EventArgs e)
        {
            var image = (ImageButton)sender;
            int rand = new Random().Next(0, bookss.Count);
            image.Source = bookss[rand].coverImage;
        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new reading());
        }
    }

    public class Book
    {
        public string title;
        public string category;
        public int nbrPage;
        public string author;
        public string[] tags;
        public string coverImage;
        public string state;

        public Book(string title, string category, int nbrPage, string author, string[] tags, string coverImage, string state)
        {
            this.title = title;
            this.category = category;
            this.nbrPage = nbrPage;
            this.author = author;
            this.tags = tags;
            this.coverImage = coverImage;
            this.state = state;
        }
    }
}
