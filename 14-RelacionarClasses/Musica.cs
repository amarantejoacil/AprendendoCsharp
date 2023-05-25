using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_RelacionarClasses
{
    public class Musica
    {

        public Musica(Banda artistaParm)
        {
            artista = artistaParm;
        }

        public string nome { get; set; }
        public Banda artista { get; set; }
        public int duracao { get; set; }
        public bool disponivel { get; set; }


    }
}
