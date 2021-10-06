using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Escuela
{
    public class SeguridadBL
    {
       public bool Autorizar(string usuario, string contrasena, string usuario1, string contrasena1)
        {
            if (usuario == "master" && contrasena == "123")
            {
                return true;
            }
            else
            {
                if (usuario1 == "estu" && contrasena1 == "456")
                {
                    return true;
                }
            }
                return false;
        }
    }
}
