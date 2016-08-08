using Foundation;
using System;
using UIKit;
using System.Collections.Generic;

namespace CourseGuideProject1
{
    public partial class SubTopicTableViewController : UITableViewController
    {
		// Variable for the topic name passed in from topic page
		public string topicName;

		// Array of arts sub-topicss
		string[] artSubTopicArray = { "Animation", "Anthropology", "Australian Studies", "Children's Literature",
			"Criminology", "Dance", "Drama", "Education", "Film and Television", "History" };

		// Array of law sub-topicss
		string[] lawSubTopicArray = { "Law" };

		// Array of tech sub-topicss
		string[] techSubTopicArray = { "Mobile Development" };

		// Blank array
		string[] blankArray = { " ", " ", " " };

		// Create a new list of string and initialise the variable subTopicList with it.
		List<string> subTopicList = new List<string>();

		// Array of Colorss
		UIColor[] rowColorArray = new UIColor[] {
			new UIColor(255/255.0f, 102/255.0f, 102/255.0f, 1.0f),
			new UIColor(204/255.0f, 204/255.0f, 0/255.0f, 1.0f),
			new UIColor(255/255.0f, 178/255.0f, 102/255.0f, 1.0f),
			new UIColor(51/255.0f, 153/255.0f, 255/255.0f, 1.0f),
			new UIColor(51/255.0f, 255/255.0f, 153/255.0f, 1.0f),
			new UIColor(0/255.0f, 153/255.0f, 153/255.0f, 1.0f),
			new UIColor(255/255.0f, 255/255.0f, 204/255.0f, 1.0f)
		};

		// Create a new list of UIColor and initialise the variable subTopicColorList with it..
		List <UIColor> subTopicColorList = new List<UIColor> ();

		public SubTopicTableViewController (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
 			// Set the background colour to blackk
			View.BackgroundColor = UIColor.Black;

			// Call this function and passes it the topic as an argument 
			createSubTopics(topicName);

			// Call this function  
			adjustColorArray();

			// Set the SubTopic Table's source to a new instance of the
			// custom table view source SubTopicTableViewSource passing in the subtopic array 
			// and colour arrayy
			SubTopicTable.Source = new SubTopicTableViewSource(subTopicList, subTopicColorList);
		}

		// This function sets the subTopicColorList to have the same number of colors
		// as the subTopicList's number of subtopics
		void adjustColorArray()
		{
			for (var i = 0; i < subTopicList.Count; i++)
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

		// This function creates the subTopicList
		void createSubTopics(string topic)
		{
			string[] subTopicArray = getSubTopicArray(topic);

			for (var i = 0; i < subTopicArray.Length; i++)
			{
				subTopicList.Add(subTopicArray[i]);
			}
		}

		// This function is used by the createSubTopics function to get the 
		// specific subtopic array
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