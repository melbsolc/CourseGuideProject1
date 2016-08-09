using Foundation;
using System;
using UIKit;

namespace CourseGuideProject1
{
    public partial class CourseWebViewController : UIViewController
    {
 		// Variable declarationsn
		public string institutionName;
		public string courseName;
		string courseURL;

		public CourseWebViewController (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			// https://developer.xamarin.com/recipes/ios/content_controls/web_view/load_a_web_page/
			// Create url
			//var url = "https://www.deakin.edu.au";
			selectWebAddress();

			// Load url to web view
			CourseWebView.LoadRequest(new NSUrlRequest(new NSUrl(courseURL)));

			// Specifies that the web page should scale to fit the view
			CourseWebView.ScalesPageToFit = true;
		}

		void selectWebAddress()
		{

			if (institutionName == "Deakin University")
			{
				if (courseName == "Bachelor of Arts")
				{
					courseURL = "https://www.deakin.edu.au/course/bachelor-of-arts-humanities-and-social-science";
				}
				else if (courseName == "Bachelor of Creative Arts (Animation and Motion Capture)")
				{
					courseURL = "https://www.deakin.edu.au/course/bachelor-of-creative-arts-animation-and-motion-capture-arts-humanities-and-social-science";
				}
				else if (courseName == "Bachelor of Creative Arts (Honours)")
				{
					courseURL = "https://www.deakin.edu.au/course/bachelor-of-creative-arts-honours-performing-and-creative-arts";
				}
				else if (courseName == "Graduate Diploma of Creative Arts")
				{
					courseURL = "https://www.deakin.edu.au/course/graduate-diploma-of-creative-arts-performing-and-creative-arts";
				}
				else if (courseName == "Master of Creative Arts")
				{
					courseURL = "https://www.deakin.edu.au/course/master-of-creative-arts-performing-and-creative-arts";
				}
				else if (courseName == "Research Degree - Doctor of Philosophy")
				{
					courseURL = "https://www.deakin.edu.au/future-students/courses/course.php?course=A900&area=BFOS-PERFORM-ARTS&stutype=local&continue=Continue";
				}
				else
				{
					Console.WriteLine("Not in course list");
				}
			}
			else 
			{
				Console.WriteLine("Not Deakin");
			}

		}

    }
}