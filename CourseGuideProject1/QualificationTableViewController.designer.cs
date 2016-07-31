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
    [Register ("QualificationTableViewController")]
    partial class QualificationTableViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView QualificationTable { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (QualificationTable != null) {
                QualificationTable.Dispose ();
                QualificationTable = null;
            }
        }
    }
}