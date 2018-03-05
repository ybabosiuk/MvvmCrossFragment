using System;
using System.Threading.Tasks;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;

namespace TestFragment.Core.ViewModels
{
    public class InnerViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public IMvxCommand ClickCommand => new MvxAsyncCommand(Click);

        public string Title { get; set; }

        public InnerViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService ?? throw new ArgumentNullException(nameof(navigationService));
            Title = "New Title";
        }

        private async Task Click()
        {
            await Task.Delay(5000);
        }

    }
}