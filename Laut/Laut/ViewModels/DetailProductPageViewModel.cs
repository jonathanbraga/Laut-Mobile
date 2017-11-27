using Laut.Models;
using Prism.Mvvm;
using Prism.Navigation;


namespace Laut.ViewModels
{
    public class DetailProductPageViewModel : BindableBase, INavigatingAware
    {
        private Product _item;
        public Product Item
        {
            get { return _item; }
            set { SetProperty(ref _item, value); }
        }
        public DetailProductPageViewModel()
        {

        }
        public void OnNavigatingTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("item"))
            {
                Item = (Product)parameters["item"];
            }
        }
    }
}
