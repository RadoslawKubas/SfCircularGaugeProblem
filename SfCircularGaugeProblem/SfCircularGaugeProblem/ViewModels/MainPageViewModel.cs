using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SfCircularGaugeProblem.Views;
using Xamarin.Forms;

namespace SfCircularGaugeProblem.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public DelegateCommand NavigateCommand { get; set; }

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";

            NavigateCommand=new DelegateCommand(Navigate);
        }

        private void Navigate()
        {
            NavigationService.NavigateAsync($"{nameof(PrismContentPage)}");
        }
    }
}
