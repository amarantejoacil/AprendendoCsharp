using _18_TrabalhoComArquivo;
using System;
using System.IO;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        CriarArquivo();
        CriarArquivoComWriter();
        var enderecoDoArquivo = "flashcard.csv";

        using (var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        {
            var leitor = new StreamReader(fluxoDeArquivo);

            while (!leitor.EndOfStream)
            {
                var linha = leitor.ReadLine();
                Console.WriteLine(linha);

                var flashcard = ConverConvertoFlashCards(linha);

                var msg = $"cadastro de pergunta: {flashcard.pergunta}";

                Console.WriteLine(msg);

            }
        }
        Console.ReadLine();

    }


    static Flashcard ConverConvertoFlashCards(string linha)
    {
        var campos = linha.Split('\n');
        var pergunta = campos[0];
        var resultado = new Flashcard(pergunta);
        return resultado;
    }

    //modelo antigo
    static void CriarArquivo()
    {
        var caminhoNovoArquivo = "contasExportadasFileStream.csv";

        using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        {
            var contaComoString = "456, 7895, 4785.40, Gustavo Santos";

            var encoding = Encoding.UTF8;

            var bytes = encoding.GetBytes(contaComoString);

            fluxoDeArquivo.Write(bytes, 0, bytes.Length);

        }

    }

    //modelo novo para escrever arquivo
    static void CriarArquivoComWriter()
    {
        var caminhoNovoArquivo = "contasExportadasComWrite.csv";

        using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        using (var escritor = new StreamWriter(fluxoDeArquivo))
        {
            escritor.Write("456,65465,456.0,Pedro");
        }
    }

}