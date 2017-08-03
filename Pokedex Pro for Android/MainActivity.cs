using Android.App;
using Android.Widget;
using Android.OS;

namespace Pokedex_Pro_for_Android
{
    [Activity(Label = "Pokedex Pro for Android", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView (Resource.Layout.Main);
        }
    }
}

