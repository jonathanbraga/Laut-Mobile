using Laut.Models;
using Laut.Services.Interfaces;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System.Collections.ObjectModel;
using System;

namespace Laut.ViewModels
{
    public class MenuPageViewModel : BindableBase
	{
        #region Global
        private readonly INavigationService _navigationService;
        private readonly ILautData _lautData;
        #endregion

        #region Binding
        private ObservableCollection<Menu> _menuList;
        public ObservableCollection<Menu> MenuList
        {
            get { return _menuList; }
            set { SetProperty(ref _menuList, value); }
        }
        #endregion

        #region Command
        public DelegateCommand<Menu> ItemListCommand { get; set; }
        public DelegateCommand AboutCommand { get; set; }
        #endregion

        public MenuPageViewModel(INavigationService navigationService, ILautData lautData)
        {
            _navigationService = navigationService;
            _lautData = lautData;            

            MenuList = _lautData.GetMenuItens();
            ItemListCommand = new DelegateCommand<Menu>(ExecuteItemListCommand);
            AboutCommand = new DelegateCommand(ExecuteAboutCommand);
        }

        private void ExecuteAboutCommand()
        {
            _navigationService.NavigateAsync("NavigationPage/MainPage/AboutPage");
        }

        private void ExecuteItemListCommand(Menu obj)
        {
            switch (obj.ID)
            {
                case 1:
                    _navigationService.NavigateAsync("NavigationPage/MainPage/ServicePage");
                    break;
                case 2:
                    _navigationService.NavigateAsync("NavigationPage/MainPage/ProjectPage");
                    break;
                case 3:
                    _navigationService.NavigateAsync("NavigationPage/MainPage/ProductPage");
                    break;
            }
        }
    }
}
