// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace CourseGuideProject1
{
    [Register ("CourseWebViewController")]
    partial class CourseWebViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIWebView CourseWebView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (CourseWebView != null) {
                CourseWebView.Dispose ();
                CourseWebView = null;
            }
        }
    }
}