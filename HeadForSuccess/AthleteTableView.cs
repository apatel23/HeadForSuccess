using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using System.Collections.Generic;

namespace HeadForSuccess
{

	partial class AthleteTableView : UIViewController
	{
		private UITableView tableView; 
		private List<string> list;

		public AthleteTableView (IntPtr handle) : base (handle)
		{
		}

		private class TableViewDelegate : UITableViewDelegate
		{
			private List<string> list;

			public TableViewDelegate(List<string> list)
			{
				this.list = list;
			}

			public override void RowSelected (
				UITableView tableView, NSIndexPath indexPath)
			{

				//THIS IS WHERE I AM CURRENTLY PUTTING THE NAVIGATION CONTROLLER PUSHVIEWCONTROLLER. BUT ITS NOT WORKING !!!

			}
		}

		private class TableViewDataSource : UITableViewDataSource
		{
			static NSString kCellIdentifier =
				new NSString ("MyIdentifier");
			private List<string> list;

			public TableViewDataSource (List<string> list)
			{
				this.list = list;
			}

			public int RowsInSection (
				UITableView tableview, int section)
			{
				return list.Count;
			}

			public override UITableViewCell GetCell (
				UITableView tableView, NSIndexPath indexPath)
			{
				UITableViewCell cell =
					tableView.DequeueReusableCell (
						kCellIdentifier);
				if (cell == null)
				{
					cell = new UITableViewCell (
						UITableViewCellStyle.Default,
						kCellIdentifier);
				}
				cell.TextLabel.AdjustsFontSizeToFitWidth = true;
				cell.TextLabel.Font = UIFont.FromName("Helvetica", 14.0f);
				cell.TextLabel.Text = list[indexPath.Row];
				return cell;
			}
		}
	}
		
}
