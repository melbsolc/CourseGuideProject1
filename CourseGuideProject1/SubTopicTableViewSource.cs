using System;
using UIKit;
using Foundation;
using System.Collections.Generic;

namespace CourseGuideProject1
{
	public class SubTopicTableViewSource : UITableViewSource
	{
		List<string> subTopicsList;
		List<UIColor> subTopicColors;

		public SubTopicTableViewSource(List<string> subTopics, List<UIColor> colors)
		{
			subTopicsList = subTopics;
			subTopicColors = colors;
		}

		public override nint NumberOfSections(UITableView tableView)
		{
			return 1;
		}

		public override nint RowsInSection(UITableView tableview, nint section)
		{
			return subTopicsList.Count;
		}

		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{
			var cell = tableView.DequeueReusableCell("subTopicCellID");

			cell.TextLabel.Text = subTopicsList[indexPath.Row];
			cell.BackgroundColor = subTopicColors[indexPath.Row];

			return cell;
		}

		public override nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
		{
			return 70f;
		}

	}
}

