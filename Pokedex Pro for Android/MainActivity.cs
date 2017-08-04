using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace Pokedex_Pro_for_Android
{
    [Activity(Label = "Pokedex Pro", MainLauncher = true, Icon = "@drawable/app_icon")]
    public class MainActivity : Activity
    {
        private Button pokedexButton;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            initialButton();
            SetContentView (Resource.Layout.Main);
        }
        private void initialButton()
        {
            pokedexButton = FindViewById<Button>(Resource.Id.pokedexButton);
            if (pokedexButton != null)
            {
                pokedexButton.Click += (sender, e) =>
                {
                    StartActivity(typeof(UI.PokedexActivity));
                };
            }
        }
        
    }
}

