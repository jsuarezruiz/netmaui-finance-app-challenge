using FinanceApp.Services;
using FinanceApp.ViewModels;
using FinanceApp.Views;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.Controls.Compatibility.Hosting;

namespace FinanceApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold"); 
				fonts.AddFont("cocogoose.otf", "Cocogoose");
            })
			.UseMauiCompatibility();

#if DEBUG
		builder.Logging.AddDebug();
#endif

        builder.Services.AddSingleton<FinanceService>();
        builder.Services.AddSingleton<OverviewViewModel>();
        builder.Services.AddSingleton<OverviewView>();

        builder.Services.AddTransient<RecentTransactionsViewModel>();
        builder.Services.AddTransient<RecentTransactionsView>();

        return builder.Build();
	}
}
