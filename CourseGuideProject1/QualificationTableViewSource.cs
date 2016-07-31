using System;
using UIKit;
using Foundation;
using System.Collections.Generic;

namespace CourseGuideProject1
{
	public class QualificationTableViewSource : UITableViewSource
	{
		List<Qualification> qualificationsList;
		List<UIColor> bachelorColors;
		List<UIColor> postgraduateColors;

		public QualificationTableViewSource(List<Qualification> qualifications, List<UIColor> bColors, List<UIColor> pgColors)
		{
			qualificationsList = qualifications; 
			bachelorColors = bColors;
			postgraduateColors = pgColors;
		}

		public override nint NumberOfSections(UITableView tableView)
		{
			return qualificationsList.Count;
		}

		public override nint RowsInSection(UITableView tableview, nint section)
		{
			return qualificationsList[(int)section].degreeNames.Length;
		}

		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{
			var cell = tableView.DequeueReusableCell("qualificationCellID");

			if (indexPath.Section == 0)
			{
				cell.TextLabel.Text = qualificationsList[0].degreeNames[indexPath.Row];
				cell.BackgroundColor = bachelorColors[indexPath.Row];
			}

			if (indexPath.Section == 1)
			{
				cell.TextLabel.Text = qualificationsList[1].degreeNames[indexPath.Row];
				cell.BackgroundColor = postgraduateColors[indexPath.Row];
			}

			return cell;
		}

		public override string TitleForHeader(UITableView tableView, nint section)
		{
			return qualificationsList[(int)section].qualificationName;
		}

		public override nfloat GetHeightForHeader(UITableView tableView, nint section)
		{
			return 40f;
		}

		public override nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
		{
			return 70f;
		}

		public override UIView GetViewForHeader(UITableView tableView, nint section)
		{
			var headerView = new UITableViewHeaderFooterView();
			//UIColor lightGrey = 
			//headerView.BackgroundColor = UIColor.FromRGB(224, 224, 224);
			//headerView.TextLabel.BackgroundColor = lightGrey;
			headerView.TextLabel.TextColor = UIColor.FromRGB(255, 255, 255);
			return headerView;
		}


		/*
		public override void WillDisplayHeaderView(UITableView tableView, UIView headerView, nint section)
		{
			UIColor lightGrey = new UIColor(192/255.0f, 192/255.0f, 192/255.0f, 1.0f);
			headerView..BackgroundColor = lightGrey;
			headerView.t
		}
		*/

	}
}

