using Foundation;
using System;
using UIKit;

namespace CourseGuideProject1
{
    public partial class TopicTableViewController : UITableViewController
    {
		// Array of topics
		string[] topicArray = new string[] { "Arts", "Law", "Business", "Technology", "Engineering", "Science", "Other" };

		// Array of Colours
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
			// Set the background colour to black
			View.BackgroundColor = UIColor.Black;
			// Set the Topic Table's source to a new instance of the
			// custom table view source TopicTableViewSource passing in the topic array 
			// and colour array
			TopicTable.Source = new TopicTableViewSource(topicArray, rowColorArray);
		}

		// This function is called when a topic is selected and the user is directed
		// to the sub-topic page. It passes the topic name that was selected, to 
		// the sub-topic page.
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