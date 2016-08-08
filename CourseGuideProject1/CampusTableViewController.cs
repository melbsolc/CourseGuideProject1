using Foundation;
using System;
using UIKit;

namespace CourseGuideProject1
{
    public partial class CampusTableViewController : UITableViewController
    {
		// Variable declaration
		public string instituteName;

		// Arrays of campuses for each institution
		string[] deakinCampusArray = { "Burwood (Melbourne)", "Waurn Ponds (Geelong)", "Waterfront (Geelong)",
			"Warrnambool" };

		string[] monashCampusArray = { "Berwick", "Caulfield", "Clayton", "Penninsula" };
		string[] rmitCampusArray = { "Brunswick", "Bundoora", "Melbourne City" };
		string[] swinburneCampusArray = { "Croydon", "Hawthorn", "Wantirna" };
		string[] vicUniCampusArray = { "Parkville" };
		string[] blankArray = { " " };

		string[] campusArray;

 		// Array of Colourss
		UIColor[] rowColorArray = new UIColor[] {
			new UIColor(255/255.0f, 102/255.0f, 102/255.0f, 1.0f),
			new UIColor(204/255.0f, 204/255.0f, 0/255.0f, 1.0f),
			new UIColor(255/255.0f, 178/255.0f, 102/255.0f, 1.0f),
			new UIColor(51/255.0f, 153/255.0f, 255/255.0f, 1.0f),
			new UIColor(51/255.0f, 255/255.0f, 153/255.0f, 1.0f),
			new UIColor(0/255.0f, 153/255.0f, 153/255.0f, 1.0f),
			new UIColor(255/255.0f, 255/255.0f, 204/255.0f, 1.0f)
		};

		public CampusTableViewController (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Set the background colour to black
			View.BackgroundColor = UIColor.Black;

			// assigns the result of the function call to campusArray
			campusArray = getCampusArray();

			// Set the Campus Table's source to a new instance of the
			// custom table view source CampusTableViewSource passing in the campus array 
			// and colour arrayy
			CampusTable.Source = new CampusTableViewSource(campusArray, rowColorArray);
		}

		// This function returns the campus array based on the institution
		string[] getCampusArray()
		{
			if (instituteName == "Deakin University")
			{
				return deakinCampusArray;
			}
			else if (instituteName == "Monash University")
			{
				return monashCampusArray;
			}
			else if (instituteName == "RMIT University")
			{
				return rmitCampusArray;
			}
			else if (instituteName == "Swinburne University")
			{
				return swinburneCampusArray;
			}
			else if (instituteName == "Victoria University")
			{
				return vicUniCampusArray;
			}
			else
			{
				return blankArray;
			}
		}

		// This function is called when a campus is selected and the user is directed
		// to the map page. It passes the institution and campus names to 
		// the map page.
		public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
		{
			if (segue.Identifier.Equals("CampusMapSegue"))
			{
				var viewController = segue.DestinationViewController as CampusMapViewController;
				if (viewController != null)
				{
					var rowPath = CampusTable.IndexPathForSelectedRow;
					var campus = campusArray[rowPath.Row];
					viewController.institutionName = instituteName;
					viewController.campusName = campus;
				}
			}    
		}
    }
}