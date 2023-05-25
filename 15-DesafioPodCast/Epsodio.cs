using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_DesafioPodCast
{
    public class Epsodio
    {
        public int numeroEpisodio { get; set; }
        public string tituloEpisodio { get; set; }

        public int duracaoEpisodio { get; set; }



        public string resumoEpidosio()
        {
            string resumo = "Número: " + this.numeroEpisodio.ToString() + " | Tema: " + this.tituloEpisodio + " | Duração: " + this.duracaoEpisodio.ToString() + "minutos!";
            return resumo;
        }

    }
}
