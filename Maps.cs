using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace OpenDay
{
    [Activity(Label ="@string/Maps")]
    public class Maps : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Maps);

            RadioButton radio_Burwood = FindViewById<RadioButton>(Resource.Id.radio_Burwood);
            RadioButton radio_Geelong = FindViewById<RadioButton>(Resource.Id.radio_Geelong);
            RadioButton radio_Warrnambool = FindViewById<RadioButton>(Resource.Id.radio_Warrnambool);

            radio_Burwood.Click += RadioButtonBurwood;
            radio_Geelong.Click += RadioButtonGeelong;
            radio_Warrnambool.Click += RadioButtonWarrnambool;

            Button Return = FindViewById<Button>(Resource.Id.buttonreturn);
            Return.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(MainActivity));
                StartActivity(intent);
            };
        }

        private void RadioButtonBurwood (object sender, EventArgs e)
        {
            RadioButton button = (RadioButton)sender;
            button.Click += delegate {
                var imageView = FindViewById<ImageView>(Resource.Id.Maps);
                imageView.SetImageResource(Resource.Drawable.Burwood);
            };
            
        }
        private void RadioButtonGeelong(object sender, EventArgs e)
        {
            RadioButton button = (RadioButton)sender;
            button.Click += delegate {
                var imageView = FindViewById<ImageView>(Resource.Id.Maps);
                imageView.SetImageResource(Resource.Drawable.Geelong);
            };

        }
        private void RadioButtonWarrnambool(object sender, EventArgs e)
        {
            RadioButton button = (RadioButton)sender;
            button.Click += delegate {
                var imageView = FindViewById<ImageView>(Resource.Id.Maps);
                imageView.SetImageResource(Resource.Drawable.Warrnambool);
            };

        }
    }
}