using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_RelacionarClasses
{
    public class Album
    {

        private List<Musica> musicas = new List<Musica>();
        public string nome { get; set; }
        public int duracaoTotal { get; set; }

        public void AdicionarMusica(Musica musicaParm)
        {
            musicas.Add(musicaParm);
        }

        public void ExibirMusicaDoAlbum()
        {
            Console.WriteLine($"Lista de músicas do álbum: {nome}\n");
            foreach (var i in musicas)
            {
                Console.WriteLine($"Músicas: {i.nome} ");
            }
        }

    }
}
