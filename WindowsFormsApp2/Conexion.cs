using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos2;

namespace WindowsFormsApp2
{
    public class Conexion
    {
        CD_Login cn = new CD_Login();

        public int conSQL(string usuario, string contrasena)
        {
            return cn.conSQL(usuario, contrasena);

        }

}
}
