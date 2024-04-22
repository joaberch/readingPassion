namespace readingPassion;

public partial class Parameter : ContentPage
{
	public Parameter()
	{
		InitializeComponent();
	}

    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync("//MainPage");
    }
}