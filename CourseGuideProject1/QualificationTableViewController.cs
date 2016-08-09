using Foundation;
using System;
using UIKit;
using System.Collections.Generic;

namespace CourseGuideProject1
{
	public partial class QualificationTableViewController : UITableViewController
	{
		// Create qualification list
		List<Qualification> qualificationsList = new List<Qualification>();

		// Array of Colors
		UIColor[] rowColorArray = new UIColor[] {
			new UIColor(255/255.0f, 102/255.0f, 102/255.0f, 1.0f),
			new UIColor(204/255.0f, 204/255.0f, 0/255.0f, 1.0f),
			new UIColor(255/255.0f, 178/255.0f, 102/255.0f, 1.0f),
			new UIColor(51/255.0f, 153/255.0f, 255/255.0f, 1.0f),
			new UIColor(51/255.0f, 255/255.0f, 153/255.0f, 1.0f),
			new UIColor(0/255.0f, 153/255.0f, 153/255.0f, 1.0f),
			new UIColor(255/255.0f, 255/255.0f, 204/255.0f, 1.0f)
		};

		// Create new colour lists for each qualification
		List<UIColor> bachelorColorList = new List<UIColor>();
		List<UIColor> postgraduateColorList = new List<UIColor>();

		public QualificationTableViewController (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Set the background colour to black
			View.BackgroundColor = UIColor.Black;

			// Call functions
			CreateQualificationList();
			adjustColors();

			// Set the Qualification Table's source to a new instance of the
			// custom table view source QualificationTableViewSource passing in the 
			// qualification and colour listsy
			QualificationTable.Source = new QualificationTableViewSource(qualificationsList, bachelorColorList, postgraduateColorList);
		}

		// This function creates an array for each qualification. It creates two qualification 
		// objects and adds the arrays to them and then adds these objects to the list
		private void CreateQualificationList()
		{
			string[] bDegreeNames = {"Bachelor of Arts",
					"Bachelor of Creative Arts (Animation and Motion Capture)",
				"Bachelor of Creative Arts (Honours)"};

			string[] pgDegreeNames = {"Master of Creative Arts", "Graduate Diploma of Creative Arts",
				"Research Degree - Doctor of Philosophy"};

			Qualification qual1 = new Qualification("Bachelor Degrees", bDegreeNames);
			Qualification qual2 = new Qualification("Postgraduate Degrees", pgDegreeNames);

			qualificationsList.Add(qual1);
			qualificationsList.Add(qual2);
		}

		// Adds the required number of colors to each qualification color list
		void adjustColors()
		{
			for (var i = 0; i < qualificationsList.Count; i++)
			{
				for (var j = 0; j < qualificationsList[i].degreeNames.Length; j++)
				{
					if (j >= rowColorArray.Length)
					{
						if (qualificationsList[i].qualificationName == "Bachelor Degrees")
						{
							bachelorColorList.Add(rowColorArray[j - rowColorArray.Length]);
						}

						if (qualificationsList[i].qualificationName == "Postgraduate Degrees")
						{
							postgraduateColorList.Add(rowColorArray[j - rowColorArray.Length]);
						}
					}
					else
					{
						if (qualificationsList[i].qualificationName == "Bachelor Degrees")
						{
							bachelorColorList.Add(rowColorArray[j]);
						}

						if (qualificationsList[i].qualificationName == "Postgraduate Degrees")
						{
							postgraduateColorList.Add(rowColorArray[j]);
						}
					} // end of if else
				} // end of for with variable j
			} // end of for with variable i
		}

		public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
		{
			if (segue.Identifier.Equals("Institution1Segue"))
			{
				var viewController = segue.DestinationViewController as Institution1TableViewController;
				if (viewController != null)
				{
					var rowPath = QualificationTable.IndexPathForSelectedRow;
					var course = qualificationsList[rowPath.Section].degreeNames[rowPath.Row];
					viewController.courseName = course;
				}
			}
		}

    }

	// Qualification class declaration
	public class Qualification
	{
		// class fields/properties
		public string qualificationName { get; set; }
		public string[] degreeNames { get; set; }

		// Initialization of class fields
		public Qualification(string name, string[] degrees)
		{
			qualificationName = name;
			degreeNames = degrees;
		}
	};
}