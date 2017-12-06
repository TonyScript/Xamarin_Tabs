using System;
using UIKit;

namespace X_Tabs
{
	public class Monkey : IAnimal
	{
		public Monkey()
		{
		}

		public string Name
		{
			get
			{
				return "Monkey";
			}
		}

		public UIImage Image
		{
			get
			{
				return UIImage.FromBundle("monkey.png");
			}
		}

	}
}