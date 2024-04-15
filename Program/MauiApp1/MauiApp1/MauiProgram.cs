using Microsoft.Extensions.Logging;

namespace MauiApp1
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            string[] listBooks = ["a1984a.png", "fondation.png", "fondationfoudroyee.png", "maitrehautchateau.png", "origineespece.png", "prince.png", "romanrenart.png", "toursombre.png", "zarathoustra.png"];
            string randomBook = listBooks[0];
            int userSelected;

            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
