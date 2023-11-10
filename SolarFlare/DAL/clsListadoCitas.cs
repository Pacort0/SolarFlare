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
                new clsCita() {Id = 1, Cliente = "Luisa Gameplays", Direccion="Calle El Nano, 8", Telefono=653873241, Descripcion="Instalación de placas de tipo A", Sitio="Bloque de pisos"},
                new clsCita() {Id = 2, Cliente = "Miguel Cabezón", Direccion="Calle Victoria, 14", Telefono=648372943, Descripcion="Revisión de tejado", Sitio="Casa particular"},
                new clsCita() {Id = 3, Cliente = "Fernando Galiana", Direccion="Calle Derrota, 1", Telefono=692373928, Descripcion="Instalación de placas de tipo F", Sitio="Finca"},
                new clsCita() {Id = 4, Cliente = "Pedro Conejo", Direccion="Calle Mariano Urbano, 2", Telefono=688931231, Descripcion="Instalación de placas de tipo C", Sitio="Bloque de pisos"},
                new clsCita() {Id = 5, Cliente = "Isaac Ramoneti", Direccion="Calle Empate, 5", Telefono=690098472, Descripcion="Reparación de placas tipo C", Sitio="Semáforo"},
                new clsCita() {Id = 6, Cliente = "Isabela Katharina", Direccion="Calle Placas, 1", Telefono=632582423, Descripcion="Evaluación de azotea", Sitio="Bloque de pisos"},
                new clsCita() {Id = 7, Cliente = "Juan Perea", Direccion="Calle Calvo, 1", Telefono=645789432, Descripcion="Instalación de placas tipo E" , Sitio = "Casa particular"},
                new clsCita() {Id = 8, Cliente = "Francisco Javier", Direccion="Calle Viejales, 1", Telefono=611324094, Descripcion="Evaluación de azotea", Sitio = "Empresa"},
                new clsCita() {Id = 9, Cliente = "Migue Cabezón", Direccion="Calle Pelate, 1", Telefono=688765432, Descripcion="Evaluación de terreno", Sitio = "Desierto de Almería"},
                new clsCita() {Id = 10, Cliente = "Federico Gattoni", Direccion="Calle Manta, 1", Telefono=666777888, Descripcion="Instalación de placas tipo A", Sitio = "Bloque de pisos"},
                new clsCita() {Id = 11, Cliente = "Pedro Gallardo", Direccion="Calle Bigotes, 1", Telefono=611222333, Descripcion="Revisión de tejado", Sitio="Casa particular"}
            };
            return listadoCitas;    
        }
    }
}
