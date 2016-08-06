using Foundation;
using System;
using UIKit;
using MapKit;
using CoreLocation;

namespace CourseGuideProject1
{
    public partial class CampusMapViewController : UIViewController
    {
		public string institutionName;
		public string campusName;

		//CLLocation location;

		Double campusLatitude;
		Double campusLongitude;

		public CampusMapViewController (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			setCampusCoordinates();
			setMap();
		}

		void setCampusCoordinates()
		{
			if (institutionName == "Deakin University")
			{
				if (campusName == "Burwood (Melbourne)")
				{
					campusLatitude = -37.847776;
					campusLongitude = 145.114905;
				}
				else if (campusName == "Waurn Ponds (Geelong)")
				{
					campusLatitude = -38.198379;
					campusLongitude = 144.298850;
				}
				else if (campusName == "Waterfront (Geelong)")
				{
					campusLatitude = -38.143734;
					campusLongitude = 144.360252;
				}
				else if (campusName == "Warrnambool")
				{
					campusLatitude = -38.387435;
					campusLongitude = 142.539967;
				}
				else
				{
					Console.WriteLine("No coordinates provided");
				}
			}
			else
			{
				Console.WriteLine("Not Deakin");
			}
		}

		void setMap()
		{
			var coordinate = new CLLocationCoordinate2D(campusLatitude, campusLongitude);
			var region = new MKCoordinateRegion(coordinate, new MKCoordinateSpan(0.05, 0.05));

			CampusMap.SetRegion(region, true);

			var pin = new MKPointAnnotation();
			pin.Coordinate = coordinate;
			pin.Title = institutionName + " - " + campusName;
			CampusMap.AddAnnotation(pin);
		}

    }
}