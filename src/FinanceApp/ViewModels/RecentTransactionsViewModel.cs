using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FinanceApp.Services;
using System.Collections.ObjectModel;

namespace FinanceApp.ViewModels
{
    public partial class RecentTransactionsViewModel : ObservableObject
    {
        readonly FinanceService _financeService;

        public RecentTransactionsViewModel(FinanceService financeService)
        {
            _financeService = financeService;

            LoadData();
        }

        public ObservableCollection<string> TransactionTypes { get; } = new();

        [ObservableProperty]
        string selectedTransactionType;

        [RelayCommand]
        async Task GoBack()
        {
            await Shell.Current.GoToAsync("..");
        }

        void LoadData()
        {
            var result = _financeService.GetTransactionTypes();

            if (TransactionTypes.Count != 0)
                TransactionTypes.Clear();

            foreach (var transactionType in result)
                TransactionTypes.Add(transactionType);

            SelectedTransactionType = TransactionTypes.FirstOrDefault();
        }
    }
}
