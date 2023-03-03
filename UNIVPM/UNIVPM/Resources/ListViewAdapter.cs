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

namespace UNIVPM.Resources
{
    public class ViewHolderDoc : Java.Lang.Object
    {
        public TextView txtDescr { get; set; }
        public TextView txtData { get; set; }
    }
    public class ListViewAdapter : BaseAdapter
    {
        private Activity activity;
        private List<UNIVPM.Resources.Model.Eventi> lstEventi;
        public ListViewAdapter(Activity activity, List<UNIVPM.Resources.Model.Eventi> lstEventi)
        {
            this.activity = activity;
            this.lstEventi = lstEventi;
        }

        public override int Count
        {
            get
            {
                return lstEventi.Count;
            }
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return null;
        }

        public override long GetItemId(int position)
        {
            return lstEventi[position].CodEv;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView ?? activity.LayoutInflater.Inflate(Resource.Layout.list_view_template, parent, false);

            var txtDescr = view.FindViewById<TextView>(Resource.Id.listText1);
            var txtData = view.FindViewById<TextView>(Resource.Id.listText2);
            //var txtCod = view.FindViewById<TextView>(Resource.Id.listText3);

            txtDescr.Text = lstEventi[position].Descrizione;
            txtData.Text = lstEventi[position].Data;
            //txtCod.Text = "" + lstEventi[position].CodEv;

            return view;
        }
    }
}