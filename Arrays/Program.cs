class Program
{
    static void Main(string[] args)
    {

        string aulaIntro = "Introdução a coleções";
        string aulaMod = "Modelando a Classe";
        string aulaSet = "Trabalhando com Set";

        //1 forma: forma dinamica
        string[] aulas = new string[]
        {
            aulaIntro, aulaMod, aulaSet
        };

        //2 forma: forma manual
        //string[] aulas = new string[3];
        //aulas[0] = aulaIntro;
        //aulas[1] = aulaMod;
        //aulas[2] = aulaSet;


        Console.WriteLine("-------------------------Imprimindo Array-------------------------");
        foreach (string s in aulas)
        {
            Console.WriteLine(s);
        }

        Console.WriteLine("-------------------------Usando o Reverse-------------------------");
        Array.Reverse(aulas);
        foreach (string s in aulas)
        {
            Console.WriteLine(s);
        }


        Console.WriteLine("-------------------------Redimensionando o Array para 2 -------------------------");
        Array.Resize(ref aulas, 2);
        foreach (string s in aulas)
        {
            Console.WriteLine(s);
        }


        Console.WriteLine("-------------------------Ordernar o Array -------------------------");

        Array.Resize(ref aulas, 3);//retornando para 3 elementos

        Array.Sort(aulas);
        foreach (string s in aulas)
        {
            if (s == null)
            {
                Console.WriteLine("valor nulo");
            }
            else
            {
                Console.WriteLine(s);
            }

        }

        Console.WriteLine("-------------------------Copiando o Array -------------------------");

        string[] copiaDoarray = new string[3];
        Array.Copy(aulas, 0, copiaDoarray, 0, aulas.Length);
        foreach (string sCopia in copiaDoarray)
        {
            Console.WriteLine(sCopia);
        }

        Console.WriteLine("-------------------------Clone o Array -------------------------");
        string[] clone = aulas.Clone() as string[];
        foreach (string sClone in copiaDoarray)
        {
            Console.WriteLine(sClone);
        }

        Console.WriteLine("-------------------------Limpando Clone o Array -------------------------");
        Array.Clear(clone, 1, 2);

    }
}