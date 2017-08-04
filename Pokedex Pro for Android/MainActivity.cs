using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using System;

namespace Pokedex_Pro_for_Android
{
    [Activity(Label = "Pokedex Pro", MainLauncher = true, Icon = "@drawable/app_icon")]
    public class MainActivity : Activity
    {
        Button pokedexButton;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView (Resource.Layout.Main);
            initialButton();
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

