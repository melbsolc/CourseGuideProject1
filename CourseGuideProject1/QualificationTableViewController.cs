using Foundation;
using System;
using UIKit;
using System.Collections.Generic;

namespace CourseGuideProject1
{
	public partial class QualificationTableViewController : UITableViewController
	{

		List<Qualification> qualificationsList = new List<Qualification>();
		//[] qualificationArray;



		UIColor[] rowColorArray = new UIColor[] {
			new UIColor(255/255.0f, 102/255.0f, 102/255.0f, 1.0f),
			new UIColor(204/255.0f, 204/255.0f, 0/255.0f, 1.0f),
			new UIColor(255/255.0f, 178/255.0f, 102/255.0f, 1.0f),
			new UIColor(51/255.0f, 153/255.0f, 255/255.0f, 1.0f),
			new UIColor(51/255.0f, 255/255.0f, 153/255.0f, 1.0f),
			new UIColor(0/255.0f, 153/255.0f, 153/255.0f, 1.0f),
			new UIColor(255/255.0f, 255/255.0f, 204/255.0f, 1.0f)
		};

		List<UIColor> bachelorColorList = new List<UIColor>();
		List<UIColor> postgraduateColorList = new List<UIColor>();

		public QualificationTableViewController (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			View.BackgroundColor = UIColor.Black;
			CreateQualificationList();
			adjustColors();
			QualificationTable.Source = new QualificationTableViewSource(qualificationsList, bachelorColorList, postgraduateColorList);
		}

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

    }


	public class Qualification
	{
		public string qualificationName { get; set; }
		public string[] degreeNames { get; set; }

		public Qualification(string name, string[] degrees)
		{
			qualificationName = name;
			degreeNames = degrees;
		}
	};
}