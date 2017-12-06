using System;
using Foundation;
using UIKit;

namespace X_Tabs
{
	public partial class ThirdViewController : BaseViewController
	{
		protected ThirdViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		UITableView _myTableView;

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.

			_myTableView = new UITableView(View.Bounds);
			_myTableView.BackgroundColor = UIColor.White;
			_myTableView.TableFooterView = new UIView() { BackgroundColor = UIColor.Clear };

			string[] tableItems = new string[] { "Vegetables", "Fruits", "Flower Buds", "Legumes", "Bulbs", "Tubers" };
			_myTableView.Source = new TableSource(tableItems);
			
			View.AddSubview(_myTableView);
		}
		
		public class TableSource : UITableViewSource {

			string[] TableItems;
			public TableSource(string[] items)
			{
				TableItems = items;
			}
			/// <summary>
			/// 设置section数目
			/// </summary>

			public override nint NumberOfSections(UITableView tableView)
			{
				return TableItems.Length;
			}

			/// <summary>
			/// 设置每个section行数
			/// </summary>
			public override nint RowsInSection (UITableView tableview, nint section)
			{
				if ((int)section == 0)
					return 5;
				else if ((int)section == 1)
					return 4;
				else
					return 3;
			}
			
			/// <summary>
			/// 设置tableView内容
			/// </summary>
			public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
			{
				const string cellIdentifier = "TableViewCellUserName";
				var cell = tableView.DequeueReusableCell(cellIdentifier);
				if (cell == null)
				{
					cell = new UITableViewCell(UITableViewCellStyle.Default, cellIdentifier);
					cell.TextLabel.Text = TableItems[indexPath.Row];
					cell.ImageView.Image = UIImage.FromFile("15315838.jpg");
				}

				return cell;
			}

			public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
			{
				UIAlertController okAlertController = UIAlertController.Create("Row Selected", TableItems[indexPath.Row], UIAlertControllerStyle.Alert);
				okAlertController.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));
    			tableView.DeselectRow(indexPath, true);
			}

			
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

