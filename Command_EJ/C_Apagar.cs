using System;


namespace Command_EJ
{
    class C_Apagar:COMANDO
    {
        Automovil auto;
        public C_Apagar(Automovil pAuto)
        {
            auto = pAuto;
        }
        public void ejecutar()
        { 
            auto.Apagar();
         }
    }
}
