namespace MauiApp1.Views;

public partial class vEcran : ContentPage
{
	public vEcran()
	{
		InitializeComponent();
		InfoEcran();
        //Routing.RegisterRoute($"{nameof(vEcran)}", typeof(vEcran));
    }

	private async void Ecran_Clicked(object sender, EventArgs e)
	{
        await Shell.Current.GoToAsync(nameof(vEcran));
    }

	public void InfoEcran()
	{
		lb_Info.Text = "Resolution : " + DeviceDisplay.Current.MainDisplayInfo.Width.ToString() + " ";
		lb_Info.Text += DeviceDisplay.Current.MainDisplayInfo.Height.ToString() + Environment.NewLine;
		lb_Info.Text = "Densite : " + DeviceDisplay.Current.MainDisplayInfo.Density.ToString();
		lb_Info.Text = "Orientation : " + DeviceDisplay.Current.MainDisplayInfo.Orientation.ToString();
		lb_Info.Text = "Rotation : " + DeviceDisplay.Current.MainDisplayInfo.Rotation.ToString();
        lb_Info.Text = "Vitesse de raffraichissement : " + DeviceDisplay.Current.MainDisplayInfo.RefreshRate.ToString("0.00");
	}
}