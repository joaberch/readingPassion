namespace readingPassion;

public partial class Login : ContentPage
{
    public Login()
    {
        InitializeComponent();
    }
    int nbrPasswordEntered = 0;
    string[] password = new string[6];
    private void Button_Clicked(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        if (nbrPasswordEntered < 6 && button.Text != "V")
        {
            password[nbrPasswordEntered] = button.Text;
            ++nbrPasswordEntered;
        }
        else
        {
            if (nbrPasswordEntered > 0 && button.Text == "V")
            {
                nbrPasswordEntered--;
                password[nbrPasswordEntered] = null;
            }
        }
        Console.WriteLine(password[0] + " " + password[1] + " " + password[2] + " " + password[3] + " " + password[4] + " " + password[5]);
    }
}