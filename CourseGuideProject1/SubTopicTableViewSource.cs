using System;
using UIKit;
using Foundation;
using System.Collections.Generic;

namespace CourseGuideProject1
{
	public class SubTopicTableViewSource : UITableViewSource
	{
		// Re-usable cell identifier
		string cellIdentifier = "subTopicCellID";

		// Declarations of lists
		List<string> subTopicsList;
		List<UIColor> subTopicColors;

		// Initialization of lists
		public SubTopicTableViewSource(List<string> subTopics, List<UIColor> colors)
		{
			subTopicsList = subTopics;
			subTopicColors = colors;
		}

		// Set number of sections
		public override nint NumberOfSections(UITableView tableView)
		{
			return 1;
		}

		// Set number of rows to the sub topic list's count
		public override nint RowsInSection(UITableView tableview, nint section)
		{
			return subTopicsList.Count;
		}

		// Create the prototype cell
		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{
			var cell = tableView.DequeueReusableCell(cellIdentifier);

			if (cell == null)
			{
				cell = new UITableViewCell(UITableViewCellStyle.Default, cellIdentifier);
			}

			cell.TextLabel.Text = subTopicsList[indexPath.Row];
			cell.BackgroundColor = subTopicColors[indexPath.Row];

			return cell;
		}

		// Set height for each row
		public override nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
		{
			return 70f;
		}

	}
}

