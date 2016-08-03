using System;
using UIKit;
using Foundation;

namespace CourseGuideProject1
{
	public class Institution1TableViewSource : UITableViewSource
	{
		string cellIdentifier = "institutionCellID";

		string[] institutionsArray;

		UIColor[] institutionsColorArray;

		public Institution1TableViewSource(string[] institutions, UIColor[] colors)
		{
			institutionsArray = institutions;
			institutionsColorArray = colors;
		}

		public override nint NumberOfSections(UITableView tableView)
		{
			return 1;
		}

		public override nint RowsInSection(UITableView tableview, nint section)
		{
			return institutionsArray.Length;
		}

		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{
			var cell = tableView.DequeueReusableCell(cellIdentifier);

			if (cell == null)
			{
				cell = new UITableViewCell(UITableViewCellStyle.Default, cellIdentifier);
			}

			cell.TextLabel.Text = institutionsArray[indexPath.Row];
			cell.BackgroundColor = institutionsColorArray[indexPath.Row];

			return cell;
		}

		public override nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
		{
			return 90f;
		}
	}
}

