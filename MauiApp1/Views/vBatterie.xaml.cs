using System.Linq.Expressions;

namespace MauiApp1.Views;

public partial class vBatterie : ContentPage
{
    public vBatterie()
    {
        InitializeComponent();
    }

    private void Alimentation_click(object sender, EventArgs e)
    {
        string stext = "";
        switch (Battery.Default.PowerSource)
        {
            case BatteryPowerSource.AC:
                stext = "Alimentation secteur";
                break;

            case BatteryPowerSource.Battery:
                stext = "Alimentation batterie";
                break;

            case BatteryPowerSource.Usb:
                stext = "Alimentation USB";
                break;
        }
        lb_Alim.Text = "Alimentation: " + stext;
    }

    private async void Battery_ModeEcoChanged()
    {

    }

    private void Battery_InfoChanged(object sender, BatteryInfoChangedEventArgs e)
    {
        string stext = "";
        switch (e.State)
        {
            case BatteryState.Full:
                stext = "Charge maximale";
                break;
            case BatteryState.Charging:
                stext = "En charge";
                break;
            case BatteryState.Discharging:
                stext = "Decharge";
                break;
            case BatteryState.NotPresent:
                stext = "Pas de batterie";
                break;
            case BatteryState.Unknown:
                stext = "INconnu";
                break
        }
        lb_Alim.Text = "Alimentation: " + stext;
    }
}