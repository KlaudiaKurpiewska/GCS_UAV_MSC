using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;
using GMap.NET;
using System.Collections.Generic;
using GMap.NET.MapProviders;
using System.Drawing;

namespace Avionics
{
    class GoogleMap
    {
        private GMapControl map;
        GMapOverlay markers;
        GMapOverlay routes;
        GMapRoute route;
        List<PointLatLng> points;

        public GoogleMap(GMapControl map)
        {
            this.map = map;
        }

        public void Initialize()
        {
            map.MapProvider = GoogleSatelliteMapProvider.Instance;
            map.ShowCenter = false;
            map.MarkersEnabled = true;
            map.MinZoom = 10;
            map.MaxZoom = 30;
            map.Zoom = 19;
            markers = new GMapOverlay("markers");
            routes = new GMapOverlay("routes");
            points = new List<PointLatLng>();
        }

        public void AddPoint(double lat, double lon)
        {
            map.Position = new PointLatLng(lat, lon);
            AddMarker(lat, lon);
            AddRoute(lat, lon);
            map.Refresh();
        }

        private void AddMarker(double lat, double lon)
        {
            GMapMarker marker = new GMarkerGoogle(new PointLatLng(lat, lon), new Bitmap("dron.png"));
            markers.Markers.Clear();
            markers.Markers.Add(marker);
            map.Overlays.Add(markers);
        }

        private void AddRoute(double lat, double lon)
        {
            points.Add(new PointLatLng(lat, lon));
            route = new GMapRoute(points, "UAV route");
            route.Stroke = new Pen(Color.Magenta, 4);
            routes.Routes.Clear();
            routes.Routes.Add(route);
            map.Overlays.Add(routes);
            map.UpdateRouteLocalPosition(route);
        }

        public double GetDistance()
        {
            return route.Distance; 
        }
    }
}
