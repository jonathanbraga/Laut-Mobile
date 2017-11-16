using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;
using Laut.Models;

namespace Laut.ViewModels
{
	public class DetailPageViewModel : BindableBase, INavigatingAware
	{
        private Service _item;
        public Service Item
        {
            get { return _item; }
            set { SetProperty(ref _item, value); }
        }

        public DetailPageViewModel()
        {

        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            if(parameters.ContainsKey("item"))
            {
                Item = (Service)parameters["item"];
            }
        }
    }
}
