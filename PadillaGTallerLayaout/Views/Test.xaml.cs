namespace PadillaGTallerLayaout;

public partial class Test : ContentPage
{
	public Test()
	{
		InitializeComponent();
	}

    private void BtnCambiarPagina_Clicked(object sender, EventArgs e)
    {
		Navigation.PopToRootAsync();
    }
}