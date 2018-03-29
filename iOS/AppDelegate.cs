using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using Foundation;
using UIKit;

namespace Aspronto.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            Xamarin.FormsMaps.Init();

            // Code for starting up the Xamarin Test Cloud Agent
#if DEBUG
			Xamarin.Calabash.Start();
#endif

            string dbname = "aspronto_db";

            string folderpath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "..", "Library");

            string fullpath = Path.Combine(folderpath, dbname);

            LoadApplication(new App(fullpath));

            return base.FinishedLaunching(app, options);
        }
    }
}
