using SetNoModelos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListReadyOnly
{
    public class Curso
    {

        private IDictionary<int, Aluno> dicionarioAlunos = new Dictionary<int, Aluno>();

        private IList<Aula> aulas;
        private ISet<Aluno> alunos = new HashSet<Aluno>();
        public IList<Aluno> Alunos
        {
            get
            {
                return new ReadOnlyCollection<Aluno>(alunos.ToList());
            }
        }



        public IList<Aula> Aulas
        {
            get { return new ReadOnlyCollection<Aula>(aulas); }
            //set { aulas = value; } //protegendo de adicicoes de aulas.
        }

        private string nome;
        private string instrutor;

        public Curso(string nome, string instrutor)
        {
            this.nome = nome;
            this.instrutor = instrutor;
            this.aulas = new List<Aula>();
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }


        public string Instrutor
        {
            get { return instrutor; }
            set { instrutor = value; }
        }

        public int TempoTotal
        {
            get
            {
                //int total = 0;
                //foreach (var aula in aulas)
                //{
                //    total += aula.tempo;
                //}
                //return total;

                //para cada aula, retorne o tempo da aula.
                return aulas.Sum(aula => aula.tempo);
                //retorno para minha coleção de aulas, a soma dos tempos de cada aula.
            }
        }

        internal void Adiciona(Aula aula)
        {
            this.aulas.Add(aula);
        }

        public override string ToString()
        {
            return $"O nome do curso é: {nome}, tem o tempo de: {TempoTotal}, e as aulas: {string.Join(",", aulas)}";
        }

        internal void matricula(Aluno aluno)
        {
            alunos.Add(aluno);
            this.dicionarioAlunos.Add(aluno.NumeroMatricula, aluno);
        }

        public bool EstraMatriculado(Aluno aluno)
        {
            return alunos.Contains(aluno);
        }

        internal Aluno buscaMatriculado(int numeroMatricula)
        {
            foreach (var aluno in alunos)
            {
                if (aluno.NumeroMatricula == numeroMatricula)
                {
                    return aluno;
                }
            }
            throw new Exception("Matricula não encontrada: " + numeroMatricula);
        }

        internal Aluno buscaMatriculadoDicionario(int numeroMatricula)
        {
            Aluno aluno = null;
            this.dicionarioAlunos.TryGetValue(numeroMatricula, out aluno);
            return aluno;
        }

        internal void substituiAluno(Aluno aluno)
        {
            this.dicionarioAlunos[aluno.NumeroMatricula] = aluno;
        }
    }
}
