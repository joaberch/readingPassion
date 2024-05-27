using System.IO;
using VersOne.Epub;
using MySqlConnector;

//TODO - use view-model

namespace readingPassion;

public partial class reading : ContentPage
{
    public reading()
    {
        InitializeComponent();
    }


    //EpubBook book = EpubReader.ReadBook("La_Fontaine_Jean_de-Fables.epub");
    string excerpt;

    private void VerticalStackLayout_Loaded(object sender, EventArgs e)
    {
        //Get epub from container
        LoadAsset();
        Label text = new Label
        {
            Text = excerpt,
        };

        Content = text;
    }

    async void LoadAsset()
    {
        try
        {
            string connectionString = "host=10.0.2.2;port=6033;user=root;password=root;database=db_books";
            string request = "SELECT excerpt FROM t_books;";

            using (var connection = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(request, connection);

                connection.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    excerpt = reader.GetString(0);
                }

            }
        }
        catch (Exception ex) { Console.WriteLine(ex.Message); Console.WriteLine("LOG ERROR UPWARD"); }
    }
}