using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_EJ
{
    class C_Prende_Alarma:COMANDO
    {
        Automovil auto;
        public C_Prende_Alarma(Automovil pAuto)
        {
            auto = pAuto;
        }
        public void ejecutar()
        {
            auto.ColocarAlarma();
        }
    }
}
