using System;
using System.Collections.Generic;
using System.IO;
using Android;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V4.View;
using Android.Support.V4.Widget;
using Android.Support.V7.App;
using Android.Text.Method;
using Android.Util;
using Android.Views;
using Android.Widget;
using SQLite;
using UNIVPM.Resources;
using UNIVPM.Resources.DataHelper;
using UNIVPM.Resources.Model;
using static Android.Provider.ContactsContract;

namespace UNIVPM
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true, Icon = "@drawable/logo_app")]
    public class MainActivity : AppCompatActivity, NavigationView.IOnNavigationItemSelectedListener
    {
        ListView lstData;
        List<Eventi> lstSource = new List<Eventi>();
        Database db;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            Android.Support.V7.Widget.Toolbar toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            DrawerLayout drawer = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            ActionBarDrawerToggle toggle = new ActionBarDrawerToggle(this, drawer, toolbar, Resource.String.navigation_drawer_open, Resource.String.navigation_drawer_close);
            drawer.AddDrawerListener(toggle);
            toggle.SyncState();

            NavigationView navigationView = FindViewById<NavigationView>(Resource.Id.nav_view);
            navigationView.SetNavigationItemSelectedListener(this);

            //Create DataBase
            db = new Database();
            //Delete all previous events
            db.deleteTableEventi();
            //Create a new empty table "Eventi" 
            db.createDatabase();
            string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            Log.Info("DB_PATH", folder);

            lstData = FindViewById<ListView>(Resource.Id.listViewHome);

            //Insert events
            Eventi evento1 = new Eventi()
            {
                Descrizione = "Sessione di laurea triennale Autunnale, Aula Magna - Polo Monte Dago, 60121 Ancona",
                Data = "28-10-2019",
            };
            db.insertIntoTableEventi(evento1);

            Eventi evento2 = new Eventi()
            {
                Descrizione = "Sessione di laurea triennale Invernale, Aula Magna - Polo Monte Dago, 60121 Ancona",
                Data = "18/12/2019",
            };
            db.insertIntoTableEventi(evento2);

            Eventi evento3 = new Eventi()
            {
                Descrizione = "Corso di perfezionamento in Computer Music Production & Sound Design, scadenza iscrizioni 11/10/2019",
                Data = "",
            };
            db.insertIntoTableEventi(evento3);

            Eventi evento4 = new Eventi()
            {
                Descrizione = "Corso di Perfezionamento in Ingegneria dei materiali compositi, scadenza iscrizioni 14/10/2019",
                Data = "",
            };
            db.insertIntoTableEventi(evento4);

            Eventi evento5 = new Eventi()
            {
                Descrizione = "La condizione delle persone con DSA nel 2019 - Incontri sul tema dislessia ad Ancona e Osimo, presso Facoltà di Medicina e Chirurgia, Torrette di Ancona (AN) e Osimo - Scuola Marta Russo",
                Data = "10 e 11/10/2019",
            };
            db.insertIntoTableEventi(evento5);

            LoadData();

            //Drop table
            db.deleteTableEventi();

        }

        private void LoadData()
        {
            lstSource = db.selectTableEventi();
            var adapter = new ListViewAdapter(this, lstSource);
            lstData.Adapter = adapter;
        }

        public override void OnBackPressed()
        {
            DrawerLayout drawer = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            if (drawer.IsDrawerOpen(GravityCompat.Start))
            {
                drawer.CloseDrawer(GravityCompat.Start);
            }
            else
            {
                base.OnBackPressed();
            }
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

        public bool OnNavigationItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.nav_cdl)
            {
                var activity_agr = new Intent(this, typeof(CdL_Agr));
                StartActivity(activity_agr);
            }
            else if (id == Resource.Id.nav_doc)
            {
                var activity_doc = new Intent(this, typeof(SearchDoc));
                StartActivity(activity_doc);
            }
            else if (id == Resource.Id.nav_map)
            {
                var activity_map = new Intent(this, typeof(Map_Eco));
                StartActivity(activity_map);
            }
            else if (id == Resource.Id.nav_seg)
            {
                var activity_seg = new Intent(this, typeof(Seg_Agr));
                StartActivity(activity_seg);
            }

            DrawerLayout drawer = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            drawer.CloseDrawer(GravityCompat.Start);
            return true;
        }
    }
}