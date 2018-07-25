﻿using Android.App;
using Android.Content.PM;
using Android.OS;

namespace AccelerometerApp.Droid
{
    [Activity(Label = "AccelerometerApp", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            #error Syncfusion License Key Missing. Retrive your key here: https://www.syncfusion.com/account/downloads
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Your SyncFusion License Key");

            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }
    }
}
