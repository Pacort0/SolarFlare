using SolarFlare.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarFlare.DAL
{
    public static class clsListadoCitas
    {
        public static ObservableCollection<clsCita> getListadoCitas()
        {
            ObservableCollection<clsCita> listadoCitas = new ObservableCollection<clsCita>()
            { 
                new clsCita() {Id = 1, Cliente = "Luisa Gameplays", Direccion="Calle El Nano, 8", Telefono=653873241, Descripcion="Instalación de placas de tipo A"},
                new clsCita() {Id = 2, Cliente = "Miguel Cabezón", Direccion="Calle Victoria, 14", Telefono=648372943, Descripcion="Revisión de tejado"},
                new clsCita() {Id = 3, Cliente = "Fernando Galiana", Direccion="Calle Derrota, 1", Telefono=692373928, Descripcion="Instalación de placas de tipo F en finca"},
                new clsCita() {Id = 4, Cliente = "Pedro Conejo", Direccion="Calle Mariano Urbano, 2", Telefono=688931231, Descripcion="Instalación de placas de tipo C en bloque de pisos"},
                new clsCita() {Id = 5, Cliente = "Isaac Ramoneti", Direccion="Calle Empate, 5", Telefono=690098472, Descripcion="Reparación de placas tipo C"},
                new clsCita() {Id = 6, Cliente = "Isabela Katharina", Direccion="Calle Placas, 1", Telefono=632582423, Descripcion="Evaluación de azotea"}
            };
            return listadoCitas;    
        }
    }
}
