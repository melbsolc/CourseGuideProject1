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
    [Register ("Institution1TableViewController")]
    partial class Institution1TableViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView Institution1Table { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (Institution1Table != null) {
                Institution1Table.Dispose ();
                Institution1Table = null;
            }
        }
    }
}