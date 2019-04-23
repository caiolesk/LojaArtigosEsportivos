using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaArtigosEsportivos
{
    public class ValidarCamposVenda
    {
        public int ValidarCampos(Venda venda)
        {
            if (string.IsNullOrEmpty(venda.NomeCliente))
            {
                return 1;
            }
            if (venda.ValorTotal == 0)
            {
                return 2;
            }
            if (string.IsNullOrEmpty(venda.FormaPagamento))
            {
                return 3;
            }
            return 0;
        }
    }
}
