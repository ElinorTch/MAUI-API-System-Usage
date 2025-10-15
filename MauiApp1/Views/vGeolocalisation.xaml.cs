using System.Threading.Tasks;

namespace MauiApp1.Views;

public partial class vGeolocalisation : ContentPage
{
	private CancellationTokenSource _cancelTokenSource;
	private bool _isCheckingLocation;
	public vGeolocalisation()
	{
		InitializeComponent();
	}

	private async void Geolocalisation_click(object sender, EventArgs e)
	{
		await GetCurrentLocation();
	}

	public async Task GetCurrentLocation()
	{
		try
		{
			_isCheckingLocation = true;
			GeolocationRequest geolocationRequest = new GeolocationRequest(GeolocationAccuracy.Medium, TimeSpan.FromSeconds(10));
			_cancelTokenSource = new CancellationTokenSource();
			Location loc = await Geolocation.Default.GetLocationAsync(geolocationRequest, _cancelTokenSource.Token);
			if (loc != null)
			{
				lb_longitude.Text = "Longitude: " + loc.Longitude.ToString();
                lb_latitude.Text = "Latitude: " + loc.Latitude.ToString();
			}
		}
		catch (Exception ex) { }
		finally
		{
			_isCheckingLocation = false;
		}
	}

	private void Annulation_click(object sender, EventArgs e)
	{
		if (_isCheckingLocation && _cancelTokenSource != null && _cancelTokenSource.IsCancellationRequested == false)
			_cancelTokenSource.Cancel();

    }
}