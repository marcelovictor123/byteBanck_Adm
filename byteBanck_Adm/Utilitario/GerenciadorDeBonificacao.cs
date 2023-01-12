using byteBanck_Adm.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBanck_Adm.Utilitario
{
    public class GerenciadorDeBonificacao
    {
        public double TotalDeBonificacao { get; private set; }

        public void Registrar(Funcionario funcionario)
        {
            this.TotalDeBonificacao += funcionario.GetBonificacao();
        }

    }
}
