using System;
using UIKit;
using Foundation;

namespace CourseGuideProject1
{
	public class Institution1TableViewSource : UITableViewSource
	{
		// Re-usable cell identifier
		string cellIdentifier = "institutionCellID";

		// Declaration of a institutions array
		string[] institutionsArray;

		// Declaration of a institutions colour array
		UIColor[] institutionsColorArray;

		// Initialization of arrays 
		public Institution1TableViewSource(string[] institutions, UIColor[] colors)
		{
			institutionsArray = institutions;
			institutionsColorArray = colors;
		}

		// Set number of sections
		public override nint NumberOfSections(UITableView tableView)
		{
			return 1;
		}

		// Set number of rows to the institutions array's length
		public override nint RowsInSection(UITableView tableview, nint section)
		{
			return institutionsArray.Length;
		}

		// Create the prototype cell
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

		// Set height for each row
		public override nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
		{
			return 90f;
		}
	}
}

