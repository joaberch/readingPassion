using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.EntityFrameworkCore.Storage;
using readingPassion.Models;
using readingPassion.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VersOne.Epub;

namespace readingPassion.ViewModel
{
    public partial class Mvvm1ViewModel : ObservableObject
    {
        //La liste récupérant les livres
        [ObservableProperty]
        private ObservableCollection<string> books = new() {"test" };

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

        //La méthode qui rajoute des livres
        [RelayCommand]
        private void AddBook(string title)
        {
            books.Add("test");
        }

        public Mvvm1ViewModel()
        {
            RefreshBooksFromDB();
            readEpub();
        }

        private void RefreshBooksFromDB(ReaderContext? context = null)
        {
            books.Clear();
            using (var dbContext = context ?? new ReaderContext())
            {
                foreach (var dbBook in dbContext.books)
                {
                    bookss.Add(dbBook);
                }
            }
        }

        private async void readEpub()
        {
            await FileSystem.Current.OpenAppPackageFileAsync("");

        }
        /// <summary>
        /// Go to the main page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void goToMainPage(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//MainPage");
        }
    }
}
