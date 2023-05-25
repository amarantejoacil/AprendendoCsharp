using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_RelacionarClasses
{
    public class Banda
    {

        private List<Album> listaAlbuns = new List<Album>();
        public string nome { get; set; }
        public void adicionarAlbum(Album album)
        {
            listaAlbuns.Add(album);
        }

        public void exibirBanda()
        {
            Console.WriteLine($"O album: -------->  {nome}");
            foreach (Album album in listaAlbuns)
            {
                Console.WriteLine("album nome ------>" + album.nome);
            }
        }
    }
}
