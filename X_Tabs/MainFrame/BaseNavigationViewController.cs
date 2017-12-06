using System;

using UIKit;

namespace X_Tabs
{
	public partial class BaseNavigationViewController : UINavigationController
	{
		protected BaseNavigationViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override UIStatusBarStyle PreferredStatusBarStyle()
		{
			return UIStatusBarStyle.LightContent;
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.

			//UIApplication.SharedApplication.SetStatusBarStyle(UIStatusBarStyle.LightContent, true);

			UINavigationBar.Appearance.BarTintColor = UIColor.FromRGB(0, 153, 255);
			UINavigationBar.Appearance.SetTitleTextAttributes(new UITextAttributes { TextColor = UIColor.White } );
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

