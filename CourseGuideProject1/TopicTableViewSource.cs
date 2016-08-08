using System;
using UIKit;
using Foundation;

namespace CourseGuideProject1
{
	public class TopicTableViewSource : UITableViewSource
	{
		// Re-usable cell identifier
		string cellIdentifier = "topicCellID";

		// Declaration of a topics array
		string[] topicsArray;

		// Declaration of a color array
		UIColor[] topicColorArray; 

		// Initialization of arrays 
		public TopicTableViewSource(string[] topics, UIColor[] colors)
		{
			topicsArray = topics;
			topicColorArray = colors;
		}

		// Set number of sections
		public override nint NumberOfSections(UITableView tableView)
		{
			return 1;
		}

		// Set number of rows to the topic array's length
		public override nint RowsInSection(UITableView tableview, nint section)
		{
			return topicsArray.Length;
		}

		// Create the prototype cell
		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{
			var cell = tableView.DequeueReusableCell(cellIdentifier);

			if (cell == null)
			{
				cell = new UITableViewCell(UITableViewCellStyle.Default, cellIdentifier);
			}

			cell.TextLabel.Text = topicsArray[indexPath.Row];
			cell.BackgroundColor = topicColorArray[indexPath.Row];

			return cell;
		}

		// Set height for each row
		public override nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
		{
			return 100f;
		}
	}
}

