﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class Cliente
    {

        public string nome;
        public string cpf;
        public bool ativo;



        public Cliente(string nome, string cpf)
        {
            this.nome = nome;
            this.cpf = cpf;

        }


    }
}
