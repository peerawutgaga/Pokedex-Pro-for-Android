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

namespace Pokedex_Pro_for_Android.Adapter
{
    class RowAdapter : BaseAdapter
    {

        Context context;
        String[] labels;
        int[] iconIdList;

        public RowAdapter(Context context, String[] labels, int[] iconIdList)
        {
            this.context = context;
            this.labels = labels;
            this.iconIdList = iconIdList;
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return position;
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var row = convertView;
            RowAdapterViewHolder holder = null;

            if (row != null)
                holder = row.Tag as RowAdapterViewHolder;

            if (holder == null)
            {
                holder = new RowAdapterViewHolder();
                var inflater = context.GetSystemService(Context.LayoutInflaterService).JavaCast<LayoutInflater>();
                row = inflater.Inflate(Resource.Layout.Row, parent, false);
                TextView rowTextView = row.FindViewById<TextView>(Resource.Id.rowLabel);
                rowTextView.SetText(labels[position],TextView.BufferType.Normal);
                ImageView rowImageView = row.FindViewById<ImageView>(Resource.Id.rowIcon);
                rowImageView.SetImageResource(iconIdList[position]);
            }

            return row;
        }

        public override int Count
        {
            get
            {
                return labels.Length;
            }
        }

    }

    class RowAdapterViewHolder : Java.Lang.Object
    {
        //Your adapter views to re-use
        //public TextView Title { get; set; }
    }
}