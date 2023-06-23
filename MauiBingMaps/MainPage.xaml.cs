using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;

namespace MauiBingMaps;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        var p = new Pin()
        {
             Location = new Location(50, 44121),
             Label = "Subscrib to this channel form this location",
             Address = "Ferrara 44212"
        };
        p.MarkerClicked += P_MarkerClicked;

        myMaps.Pins.Add(p);

        myMaps.MoveToRegion(MapSpan.
            FromCenterAndRadius(new Location(50, 44121), 
            Distance.FromKilometers(10)));
    }

    private void P_MarkerClicked(object sender, PinClickedEventArgs e)
    {
        DisplayAlert("Clicked", "Subscribe", "Ok");
    }
}
