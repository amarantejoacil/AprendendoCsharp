using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListReadyOnly
{
    public class Aula : IComparable
    {

        public string titulo { get; set; }
        public int tempo { get; set; }

        public Aula(string titulo, int tempo)
        {
            this.titulo = titulo;
            this.tempo = tempo;
        }

        public override string ToString()
        {
            return $"[título:{titulo} , tempo:{tempo} minutos]";
        }

        public int CompareTo(object? obj)
        {
            Aula that = obj as Aula;
            return this.titulo.CompareTo(that.titulo);
        }
    }
}
