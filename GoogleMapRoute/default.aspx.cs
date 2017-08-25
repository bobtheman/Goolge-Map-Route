using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GoogleMapRoute
{
	public partial class _default : System.Web.UI.Page
	{
		string GoogleKey = "AIzaSyDN4JQdz3RONNI-LiFDp0iIUivZf3EnUPA";
		//string GoogleKey = "-- Your Key Here --";

		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void btnGetDirections_Click(object sender, EventArgs e)
		{
			GetGoogleDirections(txtfrom.Text.Trim(), txtto.Text.Trim());
		}

		protected void GetGoogleDirections(string From, string To)
		{
			try
			{
				string GoogleUrl = ("https://maps.googleapis.com/maps/api/directions/json?units=imperial&origin=" + (From.Trim()) + ("&destination=") + (To.Trim()) + (",&key=") + (GoogleKey));
				var result = new System.Net.WebClient().DownloadString(GoogleUrl);
				var root = JsonConvert.DeserializeObject<MapDirections>(result);
				lblDistance.Text = root.routes[0].legs[0].distance.text;
				lblDuration.Text = root.routes[0].legs[0].duration.text;
			}
			catch (Exception ex)
			{
				string ErrorMessage = ex.ToString();
			}

		}
		public class MapDirections
		{
			public IList<GeocodedWaypoint> geocoded_waypoints { get; set; }
			public IList<Route> routes { get; set; }
			public string status { get; set; }
		}

		public class GeocodedWaypoint
		{
			public string geocoder_status { get; set; }
			public string place_id { get; set; }
			public IList<string> types { get; set; }
		}

		public class Route
		{
			public string copyrights { get; set; }
			public IList<Leg> legs { get; set; }
			public string summary { get; set; }
			public IList<object> warnings { get; set; }
			public IList<object> waypoint_order { get; set; }
		}

		public class Leg
		{
			public Distance distance { get; set; }
			public Duration duration { get; set; }
			public string end_address { get; set; }
			public EndLocation end_location { get; set; }
			public string start_address { get; set; }
			public StartLocation start_location { get; set; }
			public IList<object> traffic_speed_entry { get; set; }
			public IList<object> via_waypoint { get; set; }
		}

		public class Distance
		{
			public string text { get; set; }
			public int value { get; set; }
		}

		public class Duration
		{
			public string text { get; set; }
			public int value { get; set; }
		}

		public class EndLocation
		{
			public double lat { get; set; }
			public double lng { get; set; }
		}

		public class StartLocation
		{
			public double lat { get; set; }
			public double lng { get; set; }
		}

	}
}