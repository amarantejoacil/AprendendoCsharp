using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreCargaESobreEscrita
{
    public class Animal
    {
        /*
         
         Quando um método é declarado como virtual, 
        ele permite que as classes derivadas forneçam sua própria implementação para o método, 
        alterando o comportamento padrão definido na classe base. 

         */
        public virtual void EmitirSom()
        {
            Console.WriteLine("O animal faz um som.");
        }



    }
}
