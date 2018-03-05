using Android.App;
using Android.OS;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.Droid.Views;
using MvvmCross.Droid.Views.Attributes;
using TestFragment.Core.ViewModels;

namespace TestFragment.Droid.Views
{
    [Activity(Label = "MainView")]
    [MvxActivityPresentation]
    public class MainView : MvxAppCompatActivity<MainViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.MainView);

            if (bundle == null)
            {
                ViewModel.ShowMyChannelsCommand.Execute();
            }

        }
    }
}
