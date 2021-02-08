using System;
using System.Collections.Generic;
using System.Text;

namespace ControleElevadores
{
    [Serializable]
    public class Chamada
    {
        public int Andar { get; set; }
        public char Elevador { get; set; }
        public String Turno { get; set; }

        public Chamada()
        {
            
        }
        public Chamada(int andar, char elevador, String turno)
        {
            this.Andar = andar;
            this.Elevador = elevador;
            this.Turno = turno;
        }

    }

}
