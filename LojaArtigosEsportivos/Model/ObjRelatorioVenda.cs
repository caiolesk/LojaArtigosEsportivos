using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaArtigosEsportivos
{
    public class ObjRelatorioVenda
    {
        public int idCompra { get; set; }
        public string cpf { get; set; }
        public string nomeCliente { get; set; }
        public string data { get; set; }
        public DateTime dataVenda
        {
            get { return Convert.ToDateTime(data); }
            set
            {
                data = value.ToShortDateString();
            }
        }
        public decimal valorTotal { get; set; }
        public string formaPagamento { get; set; }
        public string modelo { get; set; }
        public string categoria { get; set; }
        public int qtdProduto { get; set; }
        public decimal precoUnitario { get; set; }
        public decimal precoVenda { get; set; }
        public decimal desconto { get; set; }
    }
}
