using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.IO;
using Plugin.CurrentActivity;

namespace Aspronto.Droid
{
    [Activity(Label = "Aspronto.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            Xamarin.FormsMaps.Init(this, bundle);

            string dbname = "aspronto_db";

            string folderpath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

            string fullpath = Path.Combine(folderpath, dbname);

            LoadApplication(new App(fullpath));
        }
    }
}
