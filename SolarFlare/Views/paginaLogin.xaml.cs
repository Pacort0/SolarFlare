namespace SolarFlare.Views;

public partial class paginaLogin : ContentPage
{
	public paginaLogin()
	{
		InitializeComponent();
	}
    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new paginaCitas());
    }
}