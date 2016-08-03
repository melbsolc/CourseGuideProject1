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

			var url = "https://www.deakin.edu.au";
			CourseWebView.LoadRequest(new NSUrlRequest(new NSUrl(url)));

			CourseWebView.ScalesPageToFit = true;
		}
    }
}