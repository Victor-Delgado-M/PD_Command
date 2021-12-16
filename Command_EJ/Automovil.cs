using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_EJ
{
    class Automovil // lleva a cabo las acciones
    {
        public void Encender()  // comezamos a definir los metodos
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("SE HA ENCENDIDO EL AUTO");
        }
        public void Apagar()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("SE HA apagado EL AUTO");
        }
        public void ColocarAlarma()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("alarma encendida del auto");
        }
        public void QuitarAlarma()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("ALARMA DEL AUTO APAGADA");
        }
    }
}
