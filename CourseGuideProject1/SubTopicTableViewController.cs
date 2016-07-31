using Foundation;
using System;
using UIKit;
using System.Collections.Generic;

namespace CourseGuideProject1
{
    public partial class SubTopicTableViewController : UITableViewController
    {
		public string topicName;

		string[] artSubTopicArray = { "Animation", "Anthropology", "Australian Studies", "Children's Literature",
			"Criminology", "Dance", "Drama", "Education", "Film and Television", "History" };

		string[] lawSubTopicArray = { "Law" };
		string[] techSubTopicArray = { "Mobile Development" };
		string[] blankArray = { " ", " ", " " };
		List<string> subTopicList = new List<string>();

		UIColor[] rowColorArray = new UIColor[] {
			new UIColor(255/255.0f, 102/255.0f, 102/255.0f, 1.0f),
			new UIColor(204/255.0f, 204/255.0f, 0/255.0f, 1.0f),
			new UIColor(255/255.0f, 178/255.0f, 102/255.0f, 1.0f),
			new UIColor(51/255.0f, 153/255.0f, 255/255.0f, 1.0f),
			new UIColor(51/255.0f, 255/255.0f, 153/255.0f, 1.0f),
			new UIColor(0/255.0f, 153/255.0f, 153/255.0f, 1.0f),
			new UIColor(255/255.0f, 255/255.0f, 204/255.0f, 1.0f)
		};


		List <UIColor> subTopicColorList = new List<UIColor> ();

		public SubTopicTableViewController (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			View.BackgroundColor = UIColor.Black;
			createSubTopics(topicName);
			adjustColorArray();
			SubTopicTable.Source = new SubTopicTableViewSource(subTopicList, subTopicColorList);
		}

		void adjustColorArray()
		{
			for (var i = 0; i < artSubTopicArray.Length; i++)
			{
				
				if (i >= rowColorArray.Length)
				{
					subTopicColorList.Add(rowColorArray[i - rowColorArray.Length]); 
				}
				else
				{
					//Console.WriteLine(i);
					subTopicColorList.Add(rowColorArray[i]);
				}
			}
		}

		void createSubTopics(string topic)
		{
			string[] subTopicArray = getSubTopicArray(topic);

			for (var i = 0; i < subTopicArray.Length; i++)
			{
				subTopicList.Add(subTopicArray[i]);
			}
		}

		string[] getSubTopicArray(string topic)
		{
			switch (topic)
			{
				case "Arts":
					return artSubTopicArray;
				case "Law":
					return lawSubTopicArray;
				case "Technology":
					return techSubTopicArray;
				default:
					return blankArray;

			}
		}
    }
}