using Laut.Models;
using Laut.Services.Interfaces;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System.Collections.ObjectModel;

namespace Laut.ViewModels
{
    public class ProductPageViewModel : BindableBase
	{
        #region Global
        private readonly INavigationService _navigationService;
        private readonly ILautData _lautData;
        #endregion

        #region Binding
        private ObservableCollection<Product> _products;
        public ObservableCollection<Product> Products
        {
            get { return _products; }
            set { SetProperty(ref _products, value); }
        }
        #endregion

        #region Command
        public DelegateCommand<Product> ItemProductCommand { get; set; }
        #endregion

        public ProductPageViewModel(INavigationService navigationService, ILautData lautData)
        {
            _navigationService = navigationService;
            _lautData = lautData;

            Products = _lautData.GetProducts();

            ItemProductCommand = new DelegateCommand<Product>(ExecuteItemProductCommand);
        }

        private void ExecuteItemProductCommand(Product obj)
        {
            var itemNavigation = new NavigationParameters
            {
                {"item",obj}
            };

            _navigationService.NavigateAsync("DetailProductPage", itemNavigation);
        }
    }
}
