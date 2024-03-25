namespace MauiApp1;

public partial class chooseUser : ContentPage
{
	public chooseUser()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }
}