using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.OS;
using Com.OneSignal;
using Com.OneSignal.Core;

namespace APPNotions.Droid
{
    [Activity(Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, Exported = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Orientation, ScreenOrientation = ScreenOrientation.Portrait)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Window.AddFlags(WindowManagerFlags.Fullscreen);
            Window.ClearFlags(WindowManagerFlags.ForceNotFullscreen);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);

            // Remove this method to stop OneSignal Debugging  
            // No está en v4
            //OneSignal.Default.SetLogLevel(LOG_LEVEL.VERBOSE, LOG_LEVEL.NONE);

            // OneSignal v4
            OneSignal.Default.Initialize("f8a0c2c3-1256-4bf3-91b8-bec7e20f058f");
            
            // OneSignal v3 
            //OneSignal.Default.StartInit("f8a0c2c3-1256-4bf3-91b8-bec7e20f058f")
            // .InFocusDisplaying(OSInFocusDisplayOption.Notification)
            // .EndInit();
            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}