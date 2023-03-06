using FinanceApp.Views;

namespace FinanceApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		
		Routing.RegisterRoute(nameof(RecentTransactionsView), typeof(RecentTransactionsView));
    }
}
