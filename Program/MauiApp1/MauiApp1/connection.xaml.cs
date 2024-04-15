namespace MauiApp1;

public partial class Connection : ContentPage
{
	public Connection()
	{
		InitializeComponent();
        BackgroundColor = Microsoft.Maui.Graphics.Color.FromArgb("ABABAB");
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new homePage());
    }
}