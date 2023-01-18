﻿using byteBanck_Adm.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBanck_Adm.SistemaInterno
{
    public abstract class Autenticavel : Funcionario
    {
        public string Senha { get; set; }
        public abstract bool Autenticar(string senha);
        public Autenticavel(string cpf, double salario) : base(cpf, salario)
        {
        }
    }
}
