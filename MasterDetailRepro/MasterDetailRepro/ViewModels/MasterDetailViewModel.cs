using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasterDetailRepro.ViewModels
{
    class MasterDetailViewModel : ViewModelBase
    {
        public DelegateCommand<string> NavigateCommand { get; set; }
        public MasterDetailViewModel(INavigationService navigationService) : base(navigationService)
        {
            NavigateCommand = new DelegateCommand<string>(Navigate);
        }

        #region Commands
        private async void Navigate(string name)
        {
            await NavigationService.NavigateAsync(name);
        }
        #endregion
    }
}
