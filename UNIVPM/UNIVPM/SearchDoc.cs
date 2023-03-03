using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.Widget;
using Android.Support.V7.App;
using Android.Util;
using Android.Views;
using Android.Widget;
using UNIVPM.Resources;
using UNIVPM.Resources.DataHelper;
using UNIVPM.Resources.Model;

namespace UNIVPM
{
    [Activity(Label = "Ricerca docenti")]
    public class SearchDoc : AppCompatActivity
    {
        ListView lstData;
        List<Docenti> lstSource = new List<Docenti>();
        Database2 db2;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.page_doc);
            
            //Create DataBase
            db2 = new Database2();
            db2.createDatabase();
            string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            Log.Info("DB_PATH", folder);

            lstData = FindViewById<ListView>(Resource.Id.listView);

            Docenti docente = new Docenti()
            {
                Nome = "Gianni",
                Cognome = "Albertini",
                Settore = "FIS/01- Fisica sperimentale",
                Ruolo = "Professore associato",
                Struttura = "Dip. di Scienze e Ingegneria della Materia dell'Ambiente ed Urbanistica (SIMAU)",
                Indirizzo = "Via Brecce Bianche - 60131 Ancona",
                Telefono = "+39 3387099058",
                Email = "g.albertini@univpm.it"
            };
            db2.insertIntoTableDocenti(docente);

            var edtName = FindViewById<EditText>(Resource.Id.editText1);
            var btnSearch = FindViewById<Button>(Resource.Id.button1);

            btnSearch.Click += delegate
            {
                string value = edtName.Text;
                LoadData(value);
            };
        }

        private void LoadData(string value)
        {
            lstSource = db2.selectTableDocenti(value);
            var adapter = new ListViewAdapterDoc(this, lstSource);
            lstData.Adapter = adapter;
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_home)
            {
                var activity_home = new Intent(this, typeof(MainActivity));
                StartActivity(activity_home);
            }
            return base.OnOptionsItemSelected(item);
        }
    }
}