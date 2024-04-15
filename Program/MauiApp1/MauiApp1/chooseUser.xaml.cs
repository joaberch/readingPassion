using System.Drawing;

namespace MauiApp1;

public partial class chooseUser : ContentPage
{
	public chooseUser()
	{
		InitializeComponent();
		//BackgroundColor = Microsoft.Maui.Graphics.Color.FromHex("ABABAB");
        BackgroundColor = Microsoft.Maui.Graphics.Color.FromArgb("ABABAB");
    }

    private async void firstUser(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Connection());
        
    }

    private async void secondUser(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Connection());
    }

    private async void thirdUser(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Connection());
    }

    private async void fourthUser(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Connection());
    }
}