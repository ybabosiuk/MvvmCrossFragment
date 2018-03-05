using System;
using System.Threading.Tasks;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;

namespace TestFragment.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public IMvxCommand ShowMyChannelsCommand => new MvxAsyncCommand(ShowMyChannelsView);

        public MainViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService ?? throw new ArgumentNullException(nameof(navigationService));
        }

        private async Task ShowMyChannelsView()
        {
            await _navigationService.Navigate<InnerViewModel>();
        }
    }
}