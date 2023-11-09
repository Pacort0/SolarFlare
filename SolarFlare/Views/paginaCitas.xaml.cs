using System.Collections.ObjectModel;
using SolarFlare.DAL;
using SolarFlare.Entities;

namespace SolarFlare.Views;

public partial class paginaCitas : ContentPage
{
	public ObservableCollection<clsCita> Citas
	{
		get { return clsListadoCitas.getListadoCitas(); }
	}
	public paginaCitas()
	{
		InitializeComponent();
		CitasListView.ItemsSource = Citas;
	}

    private async void CitasListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
		await Navigation.PushAsync(new paginaDetalles { BindingContext = e.SelectedItem as clsCita});
    }
}