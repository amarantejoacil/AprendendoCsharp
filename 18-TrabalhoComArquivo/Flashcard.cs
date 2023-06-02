using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_TrabalhoComArquivo
{
    public class Flashcard
    {

        public string pergunta { get; set; }



        public Flashcard(string pergunta)
        {
            this.pergunta = pergunta;

        }


        public void exibirFlashCard(string texto)
        {
            Console.WriteLine("Pergunta: " + this.pergunta + " Resposta: ");
        }
    }
}
