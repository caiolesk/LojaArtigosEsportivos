using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaArtigosEsportivos
{
    public class ProdutosVenda
    {
        private int idProduto;
        private int idCompra;
        private string modelo;
        private string categoria;
        private int qtdProduto;
        private decimal precoUnitario;
        private decimal precoVenda;
        private decimal desconto;
        public ProdutosVenda()
        {
        }
        public ProdutosVenda(ProdutosVenda produtosVenda)
        {
            idProduto = produtosVenda.idProduto;
            idCompra = produtosVenda.IdCompra;
            modelo = produtosVenda.modelo;
            categoria = produtosVenda.categoria;
            qtdProduto = produtosVenda.qtdProduto;
            precoUnitario = produtosVenda.precoUnitario;
            precoVenda = produtosVenda.PrecoVenda;
            desconto = produtosVenda.desconto;
        }
        public void clear()
        {
            idProduto = 0;
            idCompra = 0;
            precoUnitario = 0;
            desconto = 0;
            categoria = null;
            modelo = null;
            precoVenda = 0;
            qtdProduto = 0;
        }
        public decimal Desconto
        {
            get { return desconto; }
            set
            {
                desconto = value;
            }
        }
        public int IdProduto
        {
            get { return idProduto; }
            set
            {
                idProduto = value;
            }
        }
        public int IdCompra
        {
            get { return idCompra; }
            set
            {
                idCompra = value;
            }
        }
        public string Modelo
        {
            get { return modelo; }
            set
            {
                modelo = value;
            }
        }
        public string Categoria
        {
            get { return categoria; }
            set
            {
                categoria = value;
            }
        }
        public int QtdProduto
        {
            get { return qtdProduto; }
            set
            {
                qtdProduto = value;
            }
        }
        public decimal PrecoUnitario
        {
            get { return precoUnitario; }
            set
            {
                precoUnitario = value;

            }
        }
        public decimal PrecoVenda
        {
            get { return precoVenda; }
            set
            {
                precoVenda = value;
            }
        }
    }
}
