using Foundation;
using System;
using UIKit;
using MapKit;
using CoreLocation;

namespace CourseGuideProject1
{
    public partial class CampusMapViewController : UIViewController
    {
		// Variable declarations
		public string institutionName;
		public string campusName;
		Double campusLatitude;
		Double campusLongitude;

		public CampusMapViewController (IntPtr handle) : base (handle)
        {
        }


		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			// Function calls
			setCampusCoordinates();
			setMap();
		}

		// Sets the co-ordinates according to the
		// institution and campus
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

		// Creates the map, using the specified co-ordinates
		// Creates and adds a pin with the specified title to the map
		void setMap()
		{
			// https://developer.xamarin.com/recipes/ios/content_controls/map_view/display_a_location/
			var coordinate = new CLLocationCoordinate2D(campusLatitude, campusLongitude);
			var region = new MKCoordinateRegion(coordinate, new MKCoordinateSpan(0.05, 0.05));

			CampusMap.SetRegion(region, true);

			// https://developer.xamarin.com/recipes/ios/content_controls/map_view/add_an_annotation_to_a_map/
			var pin = new MKPointAnnotation();
			pin.Coordinate = coordinate;
			pin.Title =  campusName;
			pin.Subtitle = institutionName;
			CampusMap.AddAnnotation(pin);
		}

    }
}