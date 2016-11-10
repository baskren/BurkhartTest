// /*******************************************************************
//  *
//  * AppDelegate.cs copyright 2016 ben, 42nd Parallel - ALL RIGHTS RESERVED.
//  *
//  *******************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace ThomasBurkhart.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();
			Forms9Patch.iOS.Settings.LicenseKey = "YTF5-GLUF-5ZUK-ARMS-2Z9S-HTSK-2ESQ-8RZQ-KD8P-C9MV-MR5T-KYQN-7VWD";
			LoadApplication(new App());

			return base.FinishedLaunching(app, options);
		}
	}
}
