using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V4.Widget;
using Android.Support.V7.App;
using Android.Text;
using Android.Text.Method;
using Android.Text.Util;
using Android.Views;
using Android.Widget;

namespace UNIVPM
{
    [Activity(Label = "Corsi di Laurea - Ingegneria")]
    public class CdL_Ing : AppCompatActivity, BottomNavigationView.IOnNavigationItemSelectedListener
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.page_cdl_ing);
            BottomNavigationView nav = FindViewById<BottomNavigationView>(Resource.Id.cdl_nav_ing);
            nav.SetOnNavigationItemSelectedListener(this);
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
            switch (item.ItemId)
            {
                case Resource.Id.nav_agr:
                    var activity_agr = new Intent(this, typeof(CdL_Agr));
                    StartActivity(activity_agr);
                    return true;
                case Resource.Id.nav_eco:
                    /*var activity_eco = new Intent(this, typeof(CdL_Eco));
                    StartActivity(activity_eco);*/
                    return true;
                case Resource.Id.nav_med:
                    /*var activity_med = new Intent(this, typeof(CdL_Med));
                    StartActivity(activity_med);*/
                    return true;
                case Resource.Id.nav_sci:
                    /*var activity_sci = new Intent(this, typeof(CdL_Scie));
                    StartActivity(activity_sci);*/
                    return true;
            }
            return false;
        }

    }
}