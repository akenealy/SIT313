using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace OpenDay
{
    [Activity(Label ="@string/News")]
    public class News : Activity
    {
        NewsFiles[] news;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.News);

            news = new NewsFiles[] { new NewsFiles("test")};
            ListView newslist = FindViewById<ListView>(Resource.Id.listview2);
            newslist.Adapter = new ArrayAdapter<NewsFiles>(this, Resource.Layout.List, news);

            newslist.ItemClick += (object sender, AdapterView.ItemClickEventArgs args) => OnNewsClick(sender, args);

            Button Return = FindViewById<Button>(Resource.Id.buttonreturn);
            Return.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(MainActivity));
                StartActivity(intent);
            };
        }

        protected void OnNewsClick(object sender, EventArgs e)
        {
            AdapterView.ItemClickEventArgs args = (AdapterView.ItemClickEventArgs) e;
            var newslist = news[args.Position];
        }
    }

    public class NewsFiles
    {
        public NewsFiles(string test)
        {
            Testnews = test;
        }

        public string Testnews { get; set; }
    }
}