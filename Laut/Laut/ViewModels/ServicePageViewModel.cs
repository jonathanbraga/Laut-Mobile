using Laut.Models;
using Laut.Services.Interfaces;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Laut.ViewModels
{
	public class ServicePageViewModel : BindableBase
	{
        #region Global
        private readonly INavigationService _navigationService;
        private readonly ILautData _lautData;
        #endregion

        #region Binding
        private ObservableCollection<Service> _services;
        public ObservableCollection<Service> Services
        {
            get { return _services; }
            set { SetProperty(ref _services, value); }
        }
        #endregion

        #region Command
        public DelegateCommand<Service> ItemServiceCommand { get; set; }
        public DelegateCommand NavigateToFormCommand { get; set; }
        #endregion

        public ServicePageViewModel(INavigationService navigationService, ILautData lautData)
        {
            _navigationService = navigationService;
            _lautData = lautData;

            Services = _lautData.GetServices();

            ItemServiceCommand = new DelegateCommand<Service>(ExecuteItemServiceCommand);
            NavigateToFormCommand = new DelegateCommand(ExecuteNavigateToFormCommand);
        }

        private void ExecuteNavigateToFormCommand()
        {
            _navigationService.NavigateAsync("FormPage");
        }

        private void ExecuteItemServiceCommand(Service obj)
        {
            var navigationItem = new NavigationParameters
            {
                { "item", obj }
            };

            _navigationService.NavigateAsync("DetailPage", navigationItem);
        }
    }
}
