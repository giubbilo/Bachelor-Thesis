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
using UNIVPM.Resources.Model;
using Java.Lang;

namespace UNIVPM.Resources
{
    public class ViewHolder : Java.Lang.Object
    {
        public TextView txtNome { get; set; }
        public TextView txtCognome { get; set; }
        public TextView txtSettore { get; set; }
        public TextView txtRuolo { get; set; }
        public TextView txtStruttura { get; set; }
        public TextView txtIndirizzo { get; set; }
        public TextView txtTelefono { get; set; }
        public TextView txtEmail { get; set; }
    }
    public class ListViewAdapterDoc : BaseAdapter
    {
        private Activity activity;
        private List<Model.Docenti> lstDocenti;
        public ListViewAdapterDoc(Activity activity, List<UNIVPM.Resources.Model.Docenti> lstDocenti)
        {
            this.activity = activity;
            this.lstDocenti = lstDocenti;
        }

        public override int Count
        {
            get
            {
                return lstDocenti.Count;
            }
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return null;
        }

        public override long GetItemId(int position)
        {
            return lstDocenti[position].CodDoc;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView ?? activity.LayoutInflater.Inflate(Resource.Layout.list_view_template_doc, parent, false);

            var txtNome = view.FindViewById<TextView>(Resource.Id.textView1);
            var txtCognome = view.FindViewById<TextView>(Resource.Id.textView2);
            var txtSettore = view.FindViewById<TextView>(Resource.Id.textView3);
            var txtRuolo = view.FindViewById<TextView>(Resource.Id.textView4);
            var txtStruttura = view.FindViewById<TextView>(Resource.Id.textView5);
            var txtIndirizzo = view.FindViewById<TextView>(Resource.Id.textView6);
            var txtTelefono = view.FindViewById<TextView>(Resource.Id.textView7);
            var txtEmail = view.FindViewById<TextView>(Resource.Id.textView8);


            txtNome.Text = lstDocenti[position].Nome;
            txtCognome.Text = lstDocenti[position].Cognome;
            txtSettore.Text = lstDocenti[position].Settore;
            txtRuolo.Text = lstDocenti[position].Ruolo;
            txtStruttura.Text = lstDocenti[position].Struttura;
            txtIndirizzo.Text = lstDocenti[position].Indirizzo;
            txtTelefono.Text = lstDocenti[position].Telefono;
            txtEmail.Text = lstDocenti[position].Email;

            return view;
        }
    }
}