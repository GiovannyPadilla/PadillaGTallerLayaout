
namespace PadillaGTallerLayaout.Views;

public partial class GridLayaout : ContentPage
{
	public GridLayaout()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new StackLayout());
    }
}