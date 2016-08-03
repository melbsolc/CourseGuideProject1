using System;
using UIKit;
using Foundation;

namespace CourseGuideProject1
{
	public class CampusTableViewSource : UITableViewSource
	{
		string cellIdentifier = "campusCellID";

		string[] campusArray;

		UIColor[] campusRowColorArray;

		public CampusTableViewSource(string[] campuses, UIColor[] colors)
		{
			campusArray = campuses;
			campusRowColorArray = colors;                                                             
		}

		public override nint NumberOfSections(UITableView tableView)
		{
			return 1;
		}

		public override nint RowsInSection(UITableView tableview, nint section)
		{
			return campusArray.Length;
		}

		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{
			var cell = tableView.DequeueReusableCell(cellIdentifier);

			if (cell == null)
			{
				cell = new UITableViewCell(UITableViewCellStyle.Default, cellIdentifier);
			}

			cell.TextLabel.Text = campusArray[indexPath.Row];
			cell.BackgroundColor = campusRowColorArray[indexPath.Row];

			return cell;
		}

		public override nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
		{
			return 70f;
		}


	}
}

