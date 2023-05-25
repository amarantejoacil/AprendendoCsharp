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

        public List<string> convidadoEpisodio = new List<string>();


        public string resumoEpidosio()
        {
            string resumo = "Resumão de hoje!!! Número: " + this.numeroEpisodio.ToString() + " | Tema: " + this.tituloEpisodio + " | Duração: " + this.duracaoEpisodio.ToString();


            foreach (var item in convidadoEpisodio)
            {
                resumo = resumo + " Convidado(a): " + item.ToString() + "";
            }

            return resumo;
        }


        public void adicionarConvidado(string nome)
        {
            convidadoEpisodio.Add(nome);
        }
    }
}
