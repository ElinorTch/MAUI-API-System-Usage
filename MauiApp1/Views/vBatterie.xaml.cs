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
}