using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace ThomasBurkhart.Droid
{
	[Activity(Label = "ThomasBurkhart.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
			//TabLayoutResource = Resource.Layout.Tabbar;
			//ToolbarResource = Resource.Layout.Toolbar;

			base.OnCreate(bundle);

			global::Xamarin.Forms.Forms.Init(this, bundle);
			Forms9Patch.Droid.Settings.LicenseKey = "YTF5-GLUF-5ZUK-ARMS-2Z9S-HTSK-2ESQ-8RZQ-KD8P-C9MV-MR5T-KYQN-7VWD";
			LoadApplication(new App());
		}
	}
}
