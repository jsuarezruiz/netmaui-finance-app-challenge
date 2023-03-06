using FinanceApp.ViewModels;

namespace FinanceApp.Views;

public partial class OverviewView : ContentPage
{
	public OverviewView(OverviewViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = viewModel;
	}
}