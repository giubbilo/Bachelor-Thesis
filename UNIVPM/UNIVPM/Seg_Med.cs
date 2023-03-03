using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace UNIVPM
{
    [Activity(Label = "Segreteria Medicina")]
    public class Seg_Med : AppCompatActivity, BottomNavigationView.IOnNavigationItemSelectedListener
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.page_seg_med);
            BottomNavigationView navigation = FindViewById<BottomNavigationView>(Resource.Id.nav_seg_med);
            navigation.SetOnNavigationItemSelectedListener(this);

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
                    var activity_agr = new Intent(this, typeof(Seg_Agr));
                    StartActivity(activity_agr);
                    return true;
                case Resource.Id.nav_eco:
                    var activity_eco = new Intent(this, typeof(Seg_Eco));
                    StartActivity(activity_eco);
                    return true;
                case Resource.Id.nav_ing:
                    var activity_ing = new Intent(this, typeof(Seg_Ing));
                    StartActivity(activity_ing);
                    return true;
                case Resource.Id.nav_sci:
                    var activity_sci = new Intent(this, typeof(Seg_Scie));
                    StartActivity(activity_sci);
                    return true;
            }
            return false;
        }

    }
}