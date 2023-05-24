using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Encapsulamentoo
{
    public class Aluno
    {
        private string nome;

        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }
        public string cpf { get; set; }

        //private Curso nomeCurso { get; set; }


        public Aluno()
        {

        }

    }
}
