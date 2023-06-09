﻿using SobreCargaESobreEscrita;

class Progran
{



    static void Main(string[] args)
    {

        /*
         Sobrecarga: Metodos com mesmo nome, Parametros diferentes

        Csharp defini qual método usar de acordo com o parâmetro especificado.       
         
         */

        Calculadora calculadora = new Calculadora();
        Console.WriteLine(calculadora.Somar(3, 5));
        Console.WriteLine(calculadora.Somar(5.0, 5.0));


        /*
         Sobreescrita: Um classe derivada(subclasse), substitui a implentação de um método da classe.
         
        public virtual void EmitirSom()
        Quando um método é declarado como virtual, 
        ele permite que as classes derivadas forneçam sua própria implementação para o método, 
        alterando o comportamento padrão definido na classe base. 

        */

        Animal animal = new Animal();
        animal.EmitirSom();

        Cachorro cachorro = new Cachorro();
        cachorro.EmitirSom();


        /*
         Polimorfismo:Capacidade de um objeto ser tratado de diferentes formas, dependendo do contexto em que é usado. 
        No C#, o polimorfismo é alcançado através da sobrescrita de métodos, interfaces e herança.
                
         */

        List<Animal> animais = new List<Animal>();
        animais.Add(new Cachorro());
        animais.Add(new Gato());

        Console.WriteLine("----------------------------------------------");
        foreach (Animal resultado in animais)
        {
            resultado.EmitirSom();
        }

    }
}