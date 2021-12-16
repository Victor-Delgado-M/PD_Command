using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_EJ
{
    class ControlRemoto
    {
        private COMANDO[] comandos = new COMANDO[4];

        public ControlRemoto(Automovil pAuta) // creamos el constructor
        {
            comandos[0] = new C_Encender(pAuta);
            comandos[1] = new C_Apagar(pAuta);
            comandos[2] = new C_Prende_Alarma(pAuta);
            comandos[3] = new C_Apagar_Alarma(pAuta);

        }
        public void Boton(int pIndice) // metodo boton 
        {
            comandos[pIndice].ejecutar();

        }
    }
}
