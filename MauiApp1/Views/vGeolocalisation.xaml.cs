namespace MauiApp1.Views;

public partial class vGeolocalisation : ContentPage
{
	private CancellationTokenSource _cancelTkenSource;
	private bool _isCheckingLocation;
	public vGeolocalisation()
	{
		InitializeComponent();
	}

	private void Geolocalisation_click(object sender, EventArgs e)
	{

	}

	public async Task GetCurrentLocationn()
	{
		try
		{
			_isCheckingLocation = true;
			GeolocationRequest geolocationRequest = new GeolocationRequest(GeolocationAccuracy.Medium, TimeSpan.FromSeconds(10));
			_cancelTkenSource = new CancellationTokenSource();
			Location loc = await Geolocation.Default.GetLocationAsync(geolocationRequest, _cancelTkenSource.Token);
			if (loc != null)
			{
				lb_longitude.Text = loc.Longitude.ToString();
                lb_latitude.Text = loc.Latitude.ToString();
			}
		}
		catch (Exception ex) { }
		finally
		{
			_isCheckingLocation = false;
		}
	}
}