namespace SolarFlare.Views;

public partial class paginaLogin : ContentPage
{
	public paginaLogin()
	{
		InitializeComponent();
	}
    /// <summary>
    /// Cuando se pulse el botón de login se viaja a la pagina de citas
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new paginaCitas());
    }
}