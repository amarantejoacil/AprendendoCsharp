using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_DesafioPodCast
{
    public class PodCast
    {

        List<Epsodio> epsodios = new List<Epsodio>();

        public string nome { get; set; }
        public string host { get; set; }
        public int totalEpisodio { get; set; }

        public PodCast(string nome, string host)
        {
            this.nome = nome;
            this.host = host;
        }

        public void adicionarEpsodio(Epsodio epsodioParm)
        {
            epsodios.Add(epsodioParm);
            Console.WriteLine("Um novo epsodio foi adicionado");
        }

        public void exibirDetalhes()
        {
            Console.WriteLine($"O PodCast: {nome} acaba de iniciar!!!");
            foreach (var epsodio in epsodios)
            {
                Console.WriteLine(epsodio.resumoEpidosio());
            }
        }


    }

}

