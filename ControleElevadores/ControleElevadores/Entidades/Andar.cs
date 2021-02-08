using System.Collections.Generic;

namespace ControleElevadores
{
    public class Andar
    {
        public List<Chamada> chamadas;
        public int andar;
        public List<TurnoUtilizacao> utilizacaoPorTurno;

        public Andar(int andar)
        {
            this.andar = andar;
            chamadas = new List<Chamada>();
            utilizacaoPorTurno = InicializaUtilizacaoPorTurno();
        }

        private List<TurnoUtilizacao> InicializaUtilizacaoPorTurno()
        {
            return new List<TurnoUtilizacao>()
                {
                new TurnoUtilizacao() { Turno = "M", NumeroChamadas = 0 },
                new TurnoUtilizacao() { Turno = "V", NumeroChamadas = 0 },
                new TurnoUtilizacao() { Turno = "N", NumeroChamadas = 0 }
                };
        }

        public void adicionaChamada(Chamada chamada)
        {
            chamadas.Add(chamada);
            var indiceTurno = utilizacaoPorTurno.FindIndex(turno => turno.Turno.ToUpper() == chamada.Turno.ToUpper());
            utilizacaoPorTurno[indiceTurno].NumeroChamadas++;
        }
    }
}