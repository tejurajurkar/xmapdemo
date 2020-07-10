using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Gms.Maps;
using Android.Gms.Maps.Model;

namespace XamarinGoogleMapDemo
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity,IOnMapReadyCallback
    {
        public void OnMapReady(GoogleMap googleMap)
        {
            MarkerOptions markerOptions = new MarkerOptions();
            markerOptions.SetPosition(new LatLng(21.03, 76.06));
            markerOptions.SetTitle("My Position");
            googleMap.AddMarker(markerOptions);
            //optional
            googleMap.UiSettings.ZoomControlsEnabled = true;
            googleMap.UiSettings.CompassEnabled = true;
            googleMap.MoveCamera(CameraUpdateFactory.ZoomIn());
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            MapFragment mapFragment = (MapFragment)FragmentManager.FindFragmentById(Resource.Id.map);
            mapFragment.GetMapAsync(this);

        }
    }
}