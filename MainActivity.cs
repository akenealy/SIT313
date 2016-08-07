using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace OpenDay
{
    [Activity(Label = "OpenDay", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Button Support = FindViewById<Button>(Resource.Id.Support);
            Support.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(SupportActivity));
                StartActivity(intent);
            };

            Button Maps = FindViewById<Button>(Resource.Id.Maps);
            Maps.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(Maps));
                StartActivity(intent);
            };
            Button Labs = FindViewById<Button>(Resource.Id.Labs);
            Labs.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(Labs));
                StartActivity(intent);
            };
            Button News = FindViewById<Button>(Resource.Id.News);
            News.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(News));
                StartActivity(intent);
            };
        }
    }
}

