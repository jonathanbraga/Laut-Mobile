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
	public class ProjectPageViewModel : BindableBase
	{
        #region Global
        private readonly INavigationService _navigationService;
        private readonly ILautData _lautData;
        #endregion

        #region Binding
        private ObservableCollection<Project> _projects;
        public ObservableCollection<Project> Projects
        {
            get { return _projects; }
            set { SetProperty(ref _projects, value); }
        }
        #endregion

        #region Command
        public DelegateCommand<Project> ItemProjectCommand { get; set; }
        #endregion

        public ProjectPageViewModel(INavigationService navigationService, ILautData lautData)
        {
            _navigationService = navigationService;
            _lautData = lautData;

            Projects = _lautData.GetProjects();

            ItemProjectCommand = new DelegateCommand<Project>(ExecuteItemProjectCommand);
        }

        private void ExecuteItemProjectCommand(Project obj)
        {
            var navigationItem = new NavigationParameters
            {
                {"item",obj}
            };

            _navigationService.NavigateAsync("DetailProjectPage",navigationItem);
        }
    }
}
