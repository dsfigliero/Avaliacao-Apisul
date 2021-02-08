using System;
using System.Collections.Generic;
using System.Text;

namespace ControleElevadores
{
    class Predio
    {
        public List<Andar> andares;
        public List<Elevador> elevadores;
        public Predio(int numeroDeAndares)
        {
            elevadores = new List<Elevador>();
            andares = inicializarAndaresPredio(numeroDeAndares);
        }

        private List<Andar> inicializarAndaresPredio(int numeroAndares)
        {
            var andaresPredio = new List<Andar>(numeroAndares);
            for (int i = 0; i < numeroAndares; i++)
            {
                andaresPredio.Add(new Andar(i));
            }

            return andaresPredio;
        }

        public void AdicionaChamadasElevador(List<Chamada> chamadas)
        {
            foreach (Chamada item in chamadas)
            {
                andares[item.Andar].adicionaChamada(item);
            }
        }
    }
}
