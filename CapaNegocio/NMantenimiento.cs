using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public  class NMantenimiento
    {
        public static DataTable CargarComboUsuario()
        {
            DMantenimiento Datos = new DMantenimiento();
            return Datos.CargarComboUsuario();
        }
        public static string AgregarTablaGestor(string id_usuario)
        {
            DMantenimiento Datos = new DMantenimiento();
            return Datos.AgregarTablaGestor(id_usuario);
        }
        public static string DarQuitarPermiso(string permiso, int id_gestor)
        {
            DMantenimiento Datos = new DMantenimiento();
            return Datos.DarQuitarPermiso(permiso, id_gestor);
        }
        public static string EliminarTablaGestor(string id_usuario)
        {
            DMantenimiento Datos = new DMantenimiento();
            return Datos.EliminarTablaGestor(id_usuario);
        }
        public static DataTable CargarUsuariosCobranzas()
        {
            DMantenimiento Datos = new DMantenimiento();
            return Datos.CargarUsuariosCobranzas();
        }
    }
}
