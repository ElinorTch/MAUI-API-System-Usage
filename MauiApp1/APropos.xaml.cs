namespace MauiApp1;

public partial class APropos : ContentPage
{
	public APropos()
	{
		InitializeComponent();
	}

    private async void APropos_Clicked(object sender, EventArgs e)
    {
        await Launcher.Default.OpenAsync("https://www.3il-ingenieurs.fr/");
    }
}