namespace MauiApp1.Views;

public partial class vPhone : ContentPage
{
	public vPhone()
	{
		InitializeComponent();
        phone_Info();
	}
	private void phone_Info()
	{
        System.Text.StringBuilder sb = new System.Text.StringBuilder();
		sb.AppendLine($"Modèle: {DeviceInfo.Current.Model}");
        sb.AppendLine($"Modèle: {DeviceInfo.Current.Model.ToString()}");
        sb.AppendLine($"Constructeur: {DeviceInfo.Current.Manufacturer}");
        sb.AppendLine($"Nom: {DeviceInfo.Current.Name}");
        sb.AppendLine($"Os {DeviceInfo.Current.VersionString}");
        sb.AppendLine($"Platform: {DeviceInfo.Current.Platform}");
        sb.AppendLine($"Materiel:{Get_Idiom()}");
        lbPhoneInfo.Text=sb.ToString();
    }
    private string Get_Idiom()
    {
        return "";
    }
}