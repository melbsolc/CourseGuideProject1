using Foundation;
using System;
using UIKit;

namespace CourseGuideProject1
{
    public partial class TopicTableViewController : UITableViewController
    {
		string[] topicArray = new string[] { "Arts", "Law", "Business", "Technology", "Engineering", "Science", "Other" };
		UIColor[] rowColorArray = new UIColor[] {
			new UIColor(255/255.0f, 102/255.0f, 102/255.0f, 1.0f),
			new UIColor(204/255.0f, 204/255.0f, 0/255.0f, 1.0f),
			new UIColor(255/255.0f, 178/255.0f, 102/255.0f, 1.0f),
			new UIColor(51/255.0f, 153/255.0f, 255/255.0f, 1.0f),
			new UIColor(51/255.0f, 255/255.0f, 153/255.0f, 1.0f),
			new UIColor(0/255.0f, 153/255.0f, 153/255.0f, 1.0f),
			new UIColor(255/255.0f, 255/255.0f, 204/255.0f, 1.0f)
		};

		public TopicTableViewController (IntPtr handle) : base (handle)
        {
			
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			View.BackgroundColor = UIColor.Black;
			TopicTable.Source = new TopicTableViewSource(topicArray, rowColorArray);
		}

		public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
		{
			if (segue.Identifier.Equals("SubTopicSegue"))
			{
				var viewController = segue.DestinationViewController as SubTopicTableViewController;
				if (viewController != null)
				{
					var rowPath = TopicTable.IndexPathForSelectedRow;
					var topic = topicArray[rowPath.Row];
					viewController.topicName = topic;
				}
			}
		}
    }
}