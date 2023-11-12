using System.Collections.ObjectModel;
using SolarFlare.DAL;
using SolarFlare.Entities;

namespace SolarFlare.Views;

public partial class paginaCitas : ContentPage
{
	/// <summary>
	/// Función que recupera una lista de objetos clsCita de la clase clsListadoCitas
	/// </summary>
	public ObservableCollection<clsCita> Citas
	{
		get { return clsListadoCitas.getListadoCitas(); }
	}
	public paginaCitas()
	{
		InitializeComponent();
		CitasListView.ItemsSource = Citas;
		lblDia.Text = DateTime.Now.ToString(); //Ponemos la fecha a hoy
	}

	/// <summary>
	/// Cuando se seleccione un elemento de la lista se viaja a la paginaTabbed con el elemento seleccionado como parámetro
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
    private async void CitasListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
		await Navigation.PushAsync(new paginaTabbed { BindingContext = e.SelectedItem as clsCita});
    }
}