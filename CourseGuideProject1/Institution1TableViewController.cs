using Foundation;
using System;
using UIKit;

namespace CourseGuideProject1
{
    public partial class Institution1TableViewController : UITableViewController
    {
        string[] institutionsArray = new string[] { "Deakin University", "Monash University",
			"RMIT University", "Swinburne University", "The University of Melbourne", "Victoria University" };

		UIColor[] rowColorArray = new UIColor[] {
			new UIColor(255/255.0f, 102/255.0f, 102/255.0f, 1.0f),
			new UIColor(204/255.0f, 204/255.0f, 0/255.0f, 1.0f),
			new UIColor(255/255.0f, 178/255.0f, 102/255.0f, 1.0f),
			new UIColor(51/255.0f, 153/255.0f, 255/255.0f, 1.0f),
			new UIColor(51/255.0f, 255/255.0f, 153/255.0f, 1.0f),
			new UIColor(0/255.0f, 153/255.0f, 153/255.0f, 1.0f),
			new UIColor(255/255.0f, 255/255.0f, 204/255.0f, 1.0f)
		};


		public Institution1TableViewController (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			View.BackgroundColor = UIColor.Black;
			Institution1Table.Source = new TopicTableViewSource(institutionsArray, rowColorArray);
		}
    }
}