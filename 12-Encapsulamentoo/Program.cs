







using _12_Encapsulamentoo;

Aluno aluno1 = new Aluno();

// quando o atributo é privado não é possível acesso de modo direto. É necessário acessar através de um método publico. Se o método for privado tb não é possível.
//aluno1.Nome
aluno1.SetNome("Maria");
Console.WriteLine(aluno1.GetNome());











