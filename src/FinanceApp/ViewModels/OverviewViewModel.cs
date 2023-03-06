using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FinanceApp.Views;

namespace FinanceApp.ViewModels
{
    public partial class OverviewViewModel : ObservableObject
    {
        [RelayCommand]
        async Task GoToDetails()
        {
            await Shell.Current.GoToAsync(nameof(RecentTransactionsView), true);
        }     
    }
}