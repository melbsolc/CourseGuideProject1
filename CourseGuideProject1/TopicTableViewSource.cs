using System;
using UIKit;
using Foundation;

namespace CourseGuideProject1
{
	public class TopicTableViewSource : UITableViewSource
	{
		string[] topicsArray;

		UIColor[] topicColorArray; 

		public TopicTableViewSource(string[] topics, UIColor[] colors)
		{
			topicsArray = topics;
			topicColorArray = colors;
		}

		public override nint NumberOfSections(UITableView tableView)
		{
			return 1;
		}

		public override nint RowsInSection(UITableView tableview, nint section)
		{
			return topicsArray.Length;
		}

		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{
			var cell = tableView.DequeueReusableCell("topicCellID");

			cell.TextLabel.Text = topicsArray[indexPath.Row];
			cell.BackgroundColor = topicColorArray[indexPath.Row];

			return cell;
		}

		public override nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
		{
			return 100f;
		}
	}
}

