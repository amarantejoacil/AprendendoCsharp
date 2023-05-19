using System;

class Program
{
    static void Main(string[] args)
    {
        string categoriaAnimal = "ave";
        string tipoAnimal;

        switch (categoriaAnimal)
        {
            case "ave":
                tipoAnimal = "Passáro";
                break;
            case "réptil":
                tipoAnimal = "Cobra";
                break;
            case "mamífero":
                tipoAnimal = "Cachorro";
                break;
            default:
                tipoAnimal = "Desconhecido";
                break;
        }

        Console.WriteLine("A categoria {0} corresponde ao tipo de animal: {1}", categoriaAnimal, tipoAnimal);
    }
}