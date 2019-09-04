using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace br.com.maktuber.tecnico.Droid
{
    [Activity(Label = "br.com.maktuber.tecnico", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.SetFlags("CollectionView_Experimental");
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            var pixelWidth = (int)Resources.DisplayMetrics.WidthPixels;
            var pixelHeight = (int)Resources.DisplayMetrics.HeightPixels;
            var screenPixelDensity = (double)Resources.DisplayMetrics.Density;


            App.ScreenHeight = (double)((pixelHeight - 0.5f) / screenPixelDensity);
            App.ScreenWidth = (double)((pixelWidth - 0.5f) / screenPixelDensity);

            StatusBarHelper.DecorView = this.Window.DecorView;
            XF.Material.Droid.Material.Init(this, savedInstanceState);
            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}