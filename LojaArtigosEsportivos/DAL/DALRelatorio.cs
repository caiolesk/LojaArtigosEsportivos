using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Windows;

namespace LojaArtigosEsportivos
{
    public class DALRelatorio
    {
        MySqlConnection conn = new Conexao().ObjetoConexao();

        public int _idVenda;
        public DALRelatorio()
        {

        }

        public DataTable Pesquisar(DateTime inicio, DateTime fim)
        {
            string dataInicio = Convert.ToString(inicio.Year) + "-" + Convert.ToString(inicio.Month) + "-" + Convert.ToString(inicio.Day);
            string dataFinal = Convert.ToString(fim.Year) + "-" + Convert.ToString(fim.Month) + "-" + Convert.ToString(fim.Day);

            DataTable tabela = new DataTable();
            MySqlDataAdapter dataRelatorio = new MySqlDataAdapter("select p.modelo,p.categoria,p.quantidade,p.preco_venda,p.desconto,p.preco_unitario,v.data_venda from compra v join produto_compra p where v.id_compra like p.id_compra and data_venda between '" + dataInicio + "' and '" + dataFinal + "';", conn);
            dataRelatorio.Fill(tabela);
            return tabela;
        }

        public DataTable PesquisarClientesDoMes()
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter dataRelatorio = new MySqlDataAdapter("SELECT data_nascimento,nome,cpf,email from cliente where Month(data_nascimento) = Month(Now()) ORDER BY EXTRACT(Day From data_nascimento);", conn);
            dataRelatorio.Fill(tabela);
            return tabela;
        }

        public List<ObjRelatorioProd> PesquisaProdutosVendidos(DateTime inicio, DateTime fim)
        {
            string dataInicio = Convert.ToString(inicio.Year) + "-" + Convert.ToString(inicio.Month) + "-" + Convert.ToString(inicio.Day);
            string dataFinal = Convert.ToString(fim.Year) + "-" + Convert.ToString(fim.Month) + "-" + Convert.ToString(fim.Day);
            List<ObjRelatorioProd> produtos = new List<ObjRelatorioProd>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select p.modelo,p.categoria,p.quantidade,p.preco_venda,p.desconto,p.preco_unitario,v.data_venda from compra v join produto_compra p where v.id_compra like p.id_compra and data_venda between '" + dataInicio + "' and '" + dataFinal + "';";
            conn.Open();
            decimal total = 0;
            MySqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                while (registro.Read())
                {
                    ObjRelatorioProd produto = new ObjRelatorioProd();

                    produto.modelo = Convert.ToString(registro["modelo"]);
                    produto.categoria = Convert.ToString(registro["categoria"]);
                    produto.qtdProduto = Convert.ToInt32(registro["quantidade"]);
                    produto.precoVenda = Convert.ToDecimal(registro["preco_venda"]);
                    produto.desconto = Convert.ToDecimal(registro["desconto"]);
                    produto.precoUnitario = Convert.ToDecimal(registro["preco_unitario"]);
                    produto.dataVenda = Convert.ToDateTime(registro["data_venda"]);

                    total = total + produto.precoVenda;
                    produto.valorTotal = total;
                    produtos.Add(produto);
                   
                }
            }
            conn.Close();
            return produtos;
        }
        public List<ObjRelatorioVenda> PesquisaVenda(int idCompra)
        {           
            List<ObjRelatorioVenda> vendas = new List<ObjRelatorioVenda>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select p.modelo,p.categoria,p.quantidade,p.preco_venda,p.desconto,p.preco_unitario,v.data_venda,v.id_compra, v.nome_cliente, v.valor_total,v.forma_pagamento,c.cpf from compra v join produto_compra p join cliente c on v.id_cliente = c.id_cliente where v.id_compra like p.id_compra and v.id_compra ="+ idCompra +";";
            conn.Open();        
            MySqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                while (registro.Read())
                {
                    ObjRelatorioVenda venda = new ObjRelatorioVenda();
                    venda.idCompra = Convert.ToInt32(registro["id_compra"]);
                    venda.nomeCliente = Convert.ToString(registro["nome_cliente"]);
                    venda.valorTotal = Convert.ToDecimal(registro["valor_total"]);
                    venda.formaPagamento = Convert.ToString(registro["forma_pagamento"]);
                    venda.cpf = Convert.ToString(registro["cpf"]);
                    venda.modelo = Convert.ToString(registro["modelo"]);
                    venda.categoria = Convert.ToString(registro["categoria"]);
                    venda.qtdProduto = Convert.ToInt32(registro["quantidade"]);
                    venda.precoVenda = Convert.ToDecimal(registro["preco_venda"]);
                    venda.desconto = Convert.ToDecimal(registro["desconto"]);
                    venda.precoUnitario = Convert.ToDecimal(registro["preco_unitario"]);
                    venda.dataVenda = Convert.ToDateTime(registro["data_venda"]);

                    vendas.Add(venda);

                }
            }
            conn.Close();
            return vendas;
        }     
    }
}
