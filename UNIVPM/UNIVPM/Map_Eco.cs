using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V4.View;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace UNIVPM
{
    [Activity(Label = "Mappe Economia")]
    public class Map_Eco : AppCompatActivity, BottomNavigationView.IOnNavigationItemSelectedListener
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.page_maps_eco);

            BottomNavigationView nav_eco = FindViewById<BottomNavigationView>(Resource.Id.maps_eco_top_nav);
            nav_eco.SetOnNavigationItemSelectedListener(this);
            var viewPager = FindViewById<ViewPager>(Resource.Id.viewPager);
            ImageSliderEco slider = new ImageSliderEco(this);
            viewPager.Adapter = slider;
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
                /*case Resource.Id.nav_ing:
                    var activity_ing = new Intent(this, typeof(Seg_Ing));
                    StartActivity(activity_ing);
                    return true;*/
                case Resource.Id.nav_med:
                    var activity_med = new Intent(this, typeof(Map_Med));
                    StartActivity(activity_med);
                    return true;
                /*case Resource.Id.nav_sci:
                    var activity_sci = new Intent(this, typeof(Map_Scie));
                    StartActivity(activity_sci);
                    return true;*/
            }
            return false;
        }

    }
}