using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace OpenDay
{
    [Activity(Label ="@string/Labs")]
    public class Labs : Activity
    {
        LabData[] labs;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Labs);

            labs = new LabData[] { new LabData("1", "2", "3"), new LabData("4", "5", "6") };
            ListView lablist = FindViewById<ListView>(Resource.Id.listview1);
            lablist.Adapter = new ArrayAdapter<LabData>(this, Resource.Layout.List, labs);

            lablist.ItemClick += (object sender, AdapterView.ItemClickEventArgs args) => OnLabClick(sender, args);


            Button Return = FindViewById<Button>(Resource.Id.buttonreturn);
            Return.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(MainActivity));
                StartActivity(intent);
            };
        }

        protected void OnLabClick(object sender, EventArgs e)
        {
            AdapterView.ItemClickEventArgs args = (AdapterView.ItemClickEventArgs) e;
            var lab = labs[args.Position];
        }
    }

    public class LabData
    {
        public LabData(string room, string building, string type)
        {
            LabRoom = room;
            LabBuilding = building;
            LabType = type;
        }

        public string LabRoom { get; set; }
        public string LabBuilding { get; set; }
        public string LabType { get; set; }
    }

}