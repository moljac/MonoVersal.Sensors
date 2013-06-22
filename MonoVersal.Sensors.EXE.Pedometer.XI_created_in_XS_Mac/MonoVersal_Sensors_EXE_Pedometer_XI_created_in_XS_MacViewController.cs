using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace MonoVersal.Sensors.EXE.Pedometer.XI_created_in_XS_Mac
{
    public partial class MonoVersal_Sensors_EXE_Pedometer_XI_created_in_XS_MacViewController : UIViewController
    {
        static bool UserInterfaceIdiomIsPhone
        {
            get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
        }

        public MonoVersal_Sensors_EXE_Pedometer_XI_created_in_XS_MacViewController()
			: base (UserInterfaceIdiomIsPhone ? "MonoVersal_Sensors_EXE_Pedometer_XI_created_in_XS_MacViewController_iPhone" : "MonoVersal_Sensors_EXE_Pedometer_XI_created_in_XS_MacViewController_iPad", null)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();
			
            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
			
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override bool ShouldAutorotateToInterfaceOrientation(UIInterfaceOrientation toInterfaceOrientation)
        {
            // Return true for supported orientations
            if (UserInterfaceIdiomIsPhone)
            {
                return (toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown);
            } else
            {
                return true;
            }
        }
    }
}

