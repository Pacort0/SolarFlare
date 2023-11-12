using SolarFlare.Entities;

namespace SolarFlare.Views;

public partial class paginaDetalles : ContentPage
{
	public paginaDetalles()
	{
		InitializeComponent();
	}

	private async void btnAddFoto_Clicked(object sender, EventArgs e)
	{
		FileResult photo = await MediaPicker.Default.CapturePhotoAsync();
	}

    private void btnEnviar_Clicked(object sender, EventArgs e)
    {
		lblEnvio.Text = "Datos guardados correctamente";
    }
}