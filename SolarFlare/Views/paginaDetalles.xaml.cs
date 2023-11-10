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
}