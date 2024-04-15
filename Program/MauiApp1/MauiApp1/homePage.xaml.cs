using System.Text;
using VersOne.Epub;

namespace MauiApp1;

public partial class homePage : ContentPage
{
	public homePage()
	{
		//EpubBook book = EpubReader.ReadBook("Verne_Jules-Le_tour_du_monde_en_quatre-vingts_jours.epub");

		//Console.WriteLine($"Title: {book.Title}");

		InitializeComponent();
        BackgroundColor = Microsoft.Maui.Graphics.Color.FromArgb("ABABAB");
    }
}