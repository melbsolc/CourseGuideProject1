using Foundation;
using System;
using UIKit;

namespace CourseGuideProject1
{
    public partial class Institutions2TableViewController : UITableViewController
    {
		// Array of institutionss
		string[] institutionsArray = new string[] { "Deakin University", "Monash University",
			"RMIT University", "Swinburne University", "The University of Melbourne", "Victoria University" };

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

		public Institutions2TableViewController (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
 			// Set the background colour to blackk
			View.BackgroundColor = UIColor.Black;
			// Set the Institution Table's source to a new instance of the
			// custom table view source Institution2TableViewSource passing in the institutions array 
			// and colour arrayy
			Institution2Table.Source = new Institutions2TableViewSource(institutionsArray, rowColorArray);
		}

		// This function is called when an institution is selected and the user is directed
		// to the campus page. It passes the institution name that was selected, to 
		// the campus page.
		public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
		{
			if (segue.Identifier.Equals("CampusSegue"))
			{
				var viewController = segue.DestinationViewController as CampusTableViewController;
				if (viewController != null)
				{
					var rowPath = Institution2Table.IndexPathForSelectedRow;
					var name = institutionsArray[rowPath.Row];
					viewController.instituteName = name;
				}
			}
		}
    }
}