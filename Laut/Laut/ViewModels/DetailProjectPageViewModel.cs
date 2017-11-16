using Laut.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Laut.ViewModels
{
	public class DetailProjectPageViewModel : BindableBase, INavigatingAware
    {
        private Project _item;
        public Project Item
        {
            get { return _item; }
            set { SetProperty(ref _item, value); }
        }

        public DetailProjectPageViewModel()
        {

        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("item"))
            {
                Item = (Project)parameters["item"];
            }
        }
    }
}
