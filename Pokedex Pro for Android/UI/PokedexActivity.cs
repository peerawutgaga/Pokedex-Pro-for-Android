using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Pokedex_Pro_for_Android.UI
{
    [Activity(Label = "Pokedex")]
    public class PokedexActivity : ListActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            String[] values = new String[] { "Android", "iPhone", "WindowsMobile",
                "Blackberry", "WebOS", "Ubuntu", "Windows7", "Max OS X",
                "Linux", "OS/2","Android", "iPhone", "WindowsMobile",
                "Blackberry", "WebOS", "Ubuntu", "Windows7", "Max OS X",
                "Linux", "OS/2" };
            int[] iconIds = new int[] { Resource.Drawable.ability_icon,Resource.Drawable.item_icon,
            Resource.Drawable.app_icon,Resource.Drawable.egg_group_icon,
            Resource.Drawable.location_icon,Resource.Drawable.move_icon,
            Resource.Drawable.nature_icon,Resource.Drawable.pokedex_icon,
            Resource.Drawable.setting_icon,Resource.Drawable.team_icon,
            Resource.Drawable.ability_icon,Resource.Drawable.item_icon,
            Resource.Drawable.app_icon,Resource.Drawable.egg_group_icon,
            Resource.Drawable.location_icon,Resource.Drawable.move_icon,
            Resource.Drawable.nature_icon,Resource.Drawable.pokedex_icon,
            Resource.Drawable.setting_icon,Resource.Drawable.team_icon};
            this.ListAdapter = new Adapter.RowAdapter(this, values, iconIds);
        }
    }
}