﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.View;
using Android.Views;
using Android.Widget;
using Java.Lang;

namespace UNIVPM
{
    public class ImageSliderEco : PagerAdapter
    {
        private Context context;
        private int[] imageList =
        {
            Resource.Drawable.img_maps_eco_semint,
            Resource.Drawable.img_maps_eco_0,
            Resource.Drawable.img_maps_eco_0d,
            Resource.Drawable.img_maps_eco_1,
            Resource.Drawable.img_maps_eco_2,
            Resource.Drawable.img_maps_eco_3,
        };

        public ImageSliderEco (Context context)
        {
            this.context = context;
        }

        public override int Count
        {
            get
            {
                return imageList.Length;
            }
        }

        public override bool IsViewFromObject(View view, Java.Lang.Object @object)
        {
            return view == ((ImageView)@object);
        }

        public override Java.Lang.Object InstantiateItem(View container, int position)
        {
            ImageView imageView = new ImageView(context);
            imageView.SetScaleType(ImageView.ScaleType.FitCenter);
            imageView.SetImageResource(imageList[position]);
            ((ViewPager)container).AddView(imageView, 0);
            return imageView;
        }

        public override void DestroyItem(View container, int position, Java.Lang.Object @object)
        {
            ((ViewPager)container).RemoveView((ImageView)@object);
        }
    }
}