using FinanceApp.ViewModels;

namespace FinanceApp.Views;

public partial class RecentTransactionsView : ContentPage
{
	public RecentTransactionsView(RecentTransactionsViewModel viewModel)
    {
		InitializeComponent(); 
        
        BindingContext = viewModel;
    }
}