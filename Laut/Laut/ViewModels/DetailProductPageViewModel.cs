using Laut.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;


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
