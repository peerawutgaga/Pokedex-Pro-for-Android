using System;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Pokedex_Pro_for_Android.Adapter
{
    class TwoLineRowAdapter : BaseAdapter
    {
        private Context context;
        private String[] firstLineLabels;
        private String[] secondLineLabels;

        public TwoLineRowAdapter(Context context, String[] firstLineLabels, String[] secondLineLabels)
        {
            this.context = context;
            this.firstLineLabels = firstLineLabels;
            this.secondLineLabels = secondLineLabels;
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
            TwoRowAdapterViewHolder holder = null;

            if (row != null)
                holder = row.Tag as TwoRowAdapterViewHolder;

            if (holder == null)
            {
                holder = new TwoRowAdapterViewHolder();
                var inflater = context.GetSystemService(Context.LayoutInflaterService).JavaCast<LayoutInflater>();
                row = inflater.Inflate(Resource.Layout.TwoLinesRow, parent, false);
                TextView firstLineTextView = row.FindViewById<TextView>(Resource.Id.firstLineLabel);
                firstLineTextView.SetText(firstLineLabels[position], TextView.BufferType.Normal);
                TextView secondLineTextView = row.FindViewById<TextView>(Resource.Id.secondLineLabel);
                secondLineTextView.SetText(secondLineLabels[position], TextView.BufferType.Normal);
            }

            return row;
        }

        public override int Count
        {
            get
            {
                return firstLineLabels.Length;
            }
        }

    }

    class TwoRowAdapterViewHolder : Java.Lang.Object
    {
        //Your adapter views to re-use
        //public TextView Title { get; set; }
    }
}