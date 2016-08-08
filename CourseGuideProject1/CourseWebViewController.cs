using Foundation;
using System;
using UIKit;

namespace CourseGuideProject1
{
    public partial class CourseWebViewController : UIViewController
    {
        public CourseWebViewController (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			// https://developer.xamarin.com/recipes/ios/content_controls/web_view/load_a_web_page/
			// Create url
			var url = "https://www.deakin.edu.au";

			// Load url to web view
			CourseWebView.LoadRequest(new NSUrlRequest(new NSUrl(url)));

			// Specifies that the web page should scale to fit the view
			CourseWebView.ScalesPageToFit = true;
		}
    }
}