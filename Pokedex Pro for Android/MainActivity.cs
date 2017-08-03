using Android.App;
using Android.Widget;
using Android.OS;

namespace Pokedex_Pro_for_Android
{
    [Activity(Label = "Pokedex Pro", MainLauncher = true, Icon = "@drawable/app_icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView (Resource.Layout.Main);
        }
    }
}

