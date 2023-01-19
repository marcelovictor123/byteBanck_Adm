using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBanck_Adm.Parceria
{
    public class ParceiroComercial
    {
        public string Senha { get; set }
    }
    public override bool Autenticar(string senha)
    {
        return this.Senha == senha;
    }
}
