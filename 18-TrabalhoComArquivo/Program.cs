class Program
{
    static void Main(string[] args)
    {
        var enderecoDoArquivo = "flashcard.csv";
        var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open);

        //public override int Read(byte[] array, int offset, int count);
        //(byte[] array = é onde vão ser armazenado
        //int offset = indica a posição da onde deve começar preencher... ex: valor 10, ele reserva a posição de 0 a 9 para algo
        //int count =  indica o quanto eu quero preencher.

        var buffer = new byte[1024];
        fluxoDoArquivo.Read(buffer, 0, 1024);


    }
}