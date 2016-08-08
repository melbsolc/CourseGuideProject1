using Foundation;
using System;
using UIKit;

namespace CourseGuideProject1
{
    public partial class Institution1TableViewController : UITableViewController
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


		public Institution1TableViewController (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Set the background colour to black
			View.BackgroundColor = UIColor.Black;
			// Set the Institution Table's source to a new instance of the
			// custom table view source Institution1TableViewSource passing in the institutions array 
			// and colour array
			Institution1Table.Source = new Institution1TableViewSource(institutionsArray, rowColorArray);
		}
    }
}