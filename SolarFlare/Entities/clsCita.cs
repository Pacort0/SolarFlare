using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarFlare.Entities
{
    public class clsCita
    {
        #region atributos
        int id;
        string cliente;
        string direccion;
        string descripcion;
        long telefono;
        #endregion

        #region constructores
        public clsCita(int id, string cliente, string direccion, string descripcion, long telefono) { 
            this.id = id;
            this.cliente = cliente;
            this.direccion = direccion;
            this.descripcion = descripcion;
            this.telefono = telefono;
        }
        public clsCita() {
            this.id = -1;
            this.cliente = "";
            this.direccion = "";
            this.telefono = 0;
            this.descripcion = "";
        }
        #endregion

        #region propiedades
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Cliente
        {
            get { return cliente; } 
            set { cliente = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public long Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        #endregion
    }
}
