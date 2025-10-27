using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_4._3_TransaccionBD.pojo
{
    public class clsProducts
    {
        private int idProducto;
        private string nombre;
        private string codigo;
        private string descripcion;
        private int stock;
        private decimal precio;
        private bool estado;
        private DateTime fecha_actualizacion;

        public int IdProducto {
            get
            {
                return idProducto;
            }
            set
            {
                idProducto = value;
            }
        }

        public string Nombre {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public string Codigo {
            get
            {
                return codigo;
            }
            set
            {
                codigo = value;
            }
        }
        public string Descripcion {
            get
            {
                return descripcion;
            }
            set
            {
                descripcion = value;
            }
        }
        public int Stock {
            get
            {
                return stock;
            }
            set
            {
                stock = value;
            }
        }
        public decimal Precio {
            get
            {
                return precio;
            }
            set
            {
                precio = value;
            }
        }
        public bool Estado {
            get
            {
                return estado;
            }
            set
            {
                estado = value;
            }
        }
        public DateTime Fecha_actualizacion {
            get
            {
                return fecha_actualizacion;
            }
            set
            {
                fecha_actualizacion = value;
            }
        }

    }
}
