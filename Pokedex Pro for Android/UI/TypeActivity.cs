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
    [Activity(Label = "TypeActivity")]
    public class TypeActivity : ListActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            String[] type = new String[] {"Normal","Fire","Fighting","Water","Flying","Grass","Poison","Electric",
            "Ground","Psychic","Rock","Ice","Bug","Dragon","Ghost","Dark","Fairy"};
            this.ListAdapter = new ArrayAdapter<String>(this,Android.Resource.Layout.SimpleListItem1,type);
        }
    }
}