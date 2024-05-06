namespace readingPassion;

public partial class Parameter : ContentPage
{
	public Parameter()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new Login());
    }
}