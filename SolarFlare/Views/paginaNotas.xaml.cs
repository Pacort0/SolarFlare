namespace SolarFlare.Views;

public partial class paginaNotas : ContentPage
{
	public paginaNotas()
	{
		InitializeComponent();
	}
    /// <summary>
    /// Si se pulsa el botón de guardar se muestra un mensaje en verde
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnGuardar_Clicked(object sender, EventArgs e)
    {
        Estado.Text = "Datos guardados correctamente";
        Estado.TextColor = Colors.Green;
    }

    /// <summary>
    /// Si se pulsa el botón de borrar el texto se muestra un mensaje en rojo y se borra el texto
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnBorrar_Clicked(object sender, EventArgs e)
    {
        Estado.Text = "Datos eliminados";
        Anotaciones.Text = string.Empty;
        Estado.TextColor = Colors.Red;
    }
}