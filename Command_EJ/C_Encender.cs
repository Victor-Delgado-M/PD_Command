using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_EJ
{
    class C_Encender : COMANDO
    {
        Automovil auto;  // variable de referencia
        public C_Encender(Automovil pAuto)  // a travez de nuestro constructor tenemos nuestra referencia 
        {
            auto = pAuto;
        }
        public void ejecutar()  // implementacion del comando
        { 
            auto.Encender();
         }
    }
}
