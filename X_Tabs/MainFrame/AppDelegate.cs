using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using CoreGraphics;

namespace X_Tabs
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the
	// User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
	[Register("AppDelegate")]
	public class AppDelegate : UIApplicationDelegate
	{
		// class-level declarations

		public override UIWindow Window
		{
			get;
			set;
		}

		UICollectionViewController FourthViewController;
		CircleLayout circleLayout;
		LineLayout lineLayout;
		UICollectionViewFlowLayout flowLayout;

		public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
		{
			// Override point for customization after application launch.
			// If not required for your application you can safely delete this method

			flowLayout = new UICollectionViewFlowLayout()
			{
				HeaderReferenceSize = new CGSize(100, 100),
				SectionInset = new UIEdgeInsets(20, 20, 20, 20),
				ScrollDirection = UICollectionViewScrollDirection.Vertical,
				MinimumInteritemSpacing = 50, // minimum spacing between cells
				MinimumLineSpacing = 50 // minimum spacing between rows if ScrollDirection is Vertical or between columns if Horizontal
			};

			// Line Layout
			lineLayout = new LineLayout()
			{
				HeaderReferenceSize = new CGSize(160, 100),
				ScrollDirection = UICollectionViewScrollDirection.Horizontal
			};

			// Circle Layout
			circleLayout = new CircleLayout();
			FourthViewController = new FourthViewController(circleLayout);

			FourthViewController.CollectionView.ContentInset = new UIEdgeInsets(50, 0, 0, 0);
			UIWindow window;
			window = new UIWindow(UIScreen.MainScreen.Bounds);
			window.RootViewController = FourthViewController;
			window.MakeKeyAndVisible();


			return true;
		}

		public override void OnResignActivation(UIApplication application)
		{
			// Invoked when the application is about to move from active to inactive state.
			// This can occur for certain types of temporary interruptions (such as an incoming phone call or SMS message) 
			// or when the user quits the application and it begins the transition to the background state.
			// Games should use this method to pause the game.
		}

		public override void DidEnterBackground(UIApplication application)
		{
			// Use this method to release shared resources, save user data, invalidate timers and store the application state.
			// If your application supports background exection this method is called instead of WillTerminate when the user quits.
		}

		public override void WillEnterForeground(UIApplication application)
		{
			// Called as part of the transiton from background to active state.
			// Here you can undo many of the changes made on entering the background.
		}

		public override void OnActivated(UIApplication application)
		{
			// Restart any tasks that were paused (or not yet started) while the application was inactive. 
			// If the application was previously in the background, optionally refresh the user interface.
		}

		public override void WillTerminate(UIApplication application)
		{
			// Called when the application is about to terminate. Save data, if needed. See also DidEnterBackground.
		}
	}
}

