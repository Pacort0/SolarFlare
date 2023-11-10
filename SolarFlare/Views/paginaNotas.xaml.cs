namespace SolarFlare.Views;

public partial class paginaNotas : ContentPage
{
	public paginaNotas()
	{
		InitializeComponent();
	}

    private void btnGuardar_Clicked(object sender, EventArgs e)
    {
        Estado.Text = "Datos guardados correctamente";
        Estado.TextColor = Colors.Green;
    }

    private void btnBorrar_Clicked(object sender, EventArgs e)
    {
        Estado.Text = "Datos eliminados";
        Anotaciones.Text = string.Empty;
        Estado.TextColor = Colors.Red;
    }
}