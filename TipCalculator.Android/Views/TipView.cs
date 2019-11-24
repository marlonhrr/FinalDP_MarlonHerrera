using Android.App;
using Android.OS;
using MvvmCross.Platforms.Android.Views;
using TipCalculator.Core.ViewModels;
using Android.Content.PM;
using MvvmCross.Platforms.Android.Core;
using TipCalculator.Core;
using TipCalculator.Android;

[Activity(Label = "@string/app_name")]
public class TipView : MvxActivity<TipViewModel>
{
    protected override void OnCreate(Bundle savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
        this.SetContentView(Resource.Layout.TipPage);
    }
}
