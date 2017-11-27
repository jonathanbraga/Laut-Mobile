using Prism.Commands;
using Prism.Navigation;

namespace Laut.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        #region Global
        private readonly INavigationService _navigationService;
        #endregion

        #region Command
        public DelegateCommand NavegateToServiceCommand { get; set; }
        public DelegateCommand NavegateToProjectCommand { get; set; }
        #endregion  
        public MainPageViewModel(INavigationService navigationService) 
            : base (navigationService)
        {
            _navigationService = navigationService;

            NavegateToServiceCommand = new DelegateCommand(ExecuteNavegateToServiceCommand);
            NavegateToProjectCommand = new DelegateCommand(ExecuteNavegateToProjectCommand);
        }

        private void ExecuteNavegateToProjectCommand()
        {
            _navigationService.NavigateAsync("ProjectPage");
        }

        private void ExecuteNavegateToServiceCommand()
        {
            _navigationService.NavigateAsync("ServicePage");
        }
    }
}
