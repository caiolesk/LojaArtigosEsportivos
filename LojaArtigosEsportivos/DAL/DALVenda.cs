using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LojaArtigosEsportivos
{
    public class DALVenda
    {
        MySqlConnection conn = new Conexao().ObjetoConexao();
        public int _idCompra;
        public DALVenda()
        {

        }
        public void Inserir(Venda venda)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            conn.Open();

            cmd.CommandText = "insert into compra(id_cliente, nome_cliente, valor_total, data_venda,forma_pagamento) values (@id_cliente, @nome_cliente, @valor_total, @data_venda,@forma_pagamento);";
            cmd.Parameters.AddWithValue("@id_cliente", venda.IdCliente);
            cmd.Parameters.AddWithValue("@nome_cliente", venda.NomeCliente);
            cmd.Parameters.AddWithValue("@valor_total", venda.ValorTotal);
            cmd.Parameters.AddWithValue("@data_venda", venda.DataVenda);
            cmd.Parameters.AddWithValue("@forma_pagamento", venda.FormaPagamento);

            cmd.ExecuteNonQuery();

            _idCompra = Convert.ToInt32(cmd.LastInsertedId);

            conn.Close();
        }
        public void Devolucao(Venda venda,int qtdDevolucao, decimal valorTotal)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            conn.Open();
            int qtdDoEstoque = 0;
            cmd.CommandText = "select quantidade from produto where produto.id_produto = '" + venda.produtosVenda.IdProduto + "';";
            MySqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                qtdDoEstoque = Convert.ToInt32(registro["quantidade"]);            
            }
            conn.Close();
            conn.Open();
            int quantidadeAtualizadaNoEstoque = qtdDoEstoque + qtdDevolucao;
            cmd.CommandText = "update produto set quantidade=@quantidade where id_produto=@id_produto;";
            cmd.Parameters.AddWithValue("@id_produto", venda.produtosVenda.IdProduto);
            cmd.Parameters.AddWithValue("@quantidade", quantidadeAtualizadaNoEstoque);
            cmd.ExecuteNonQuery();
            conn.Close();
            conn.Open();
            int qtdAtualizadaNaVenda = venda.produtosVenda.QtdProduto - qtdDevolucao;
            string Nome = venda.produtosVenda.Modelo + "(DEVOLUÇÃO) QTD:" + qtdDevolucao;
            decimal valorProdudoVenda = venda.produtosVenda.PrecoVenda / venda.produtosVenda.QtdProduto;
            decimal valorProdutoDevolvido = valorProdudoVenda * qtdDevolucao;
            decimal valorTotalVendaAtualizado = valorTotal - valorProdutoDevolvido;

            cmd.CommandText = "update produto_compra set modelo=@nome,quantidade=@quantidadeNaVenda,preco_venda=@preco_venda where id_produto=@idProduto and id_compra=@id_compra;";
            cmd.Parameters.AddWithValue("@idProduto", venda.produtosVenda.IdProduto);
            cmd.Parameters.AddWithValue("@quantidadeNaVenda", qtdAtualizadaNaVenda);
            cmd.Parameters.AddWithValue("@id_compra", venda.produtosVenda.IdCompra);
            cmd.Parameters.AddWithValue("@preco_venda", (venda.produtosVenda.PrecoVenda - valorProdutoDevolvido));
            cmd.Parameters.AddWithValue("@nome", Nome);
            cmd.ExecuteNonQuery();
            conn.Close();
            conn.Open();
                   
            cmd.CommandText = "update compra set valor_total=@valor_total where id_compra=@id_compra;";
            cmd.Parameters.AddWithValue("@valor_total", valorTotalVendaAtualizado);
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public void AtualizarEstoque(decimal quantidade, int idProdutoEstoque)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            conn.Open();

            cmd.CommandText = "update produto set quantidade=@quantidade where id_produto=@idProduto;";
            cmd.Parameters.AddWithValue("@idProduto", idProdutoEstoque);
            cmd.Parameters.AddWithValue("@quantidade", quantidade);
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public void Excluir(int codigo)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            conn.Open();

            cmd.CommandText = "SET FOREIGN_KEY_CHECKS = 0;";
            cmd.ExecuteNonQuery();

            cmd.Parameters.AddWithValue("@idCompra", codigo);
            cmd.CommandText = "DELETE FROM compra, produto_compra USING compra, produto_compra WHERE compra.id_compra = @idCompra AND produto_compra.id_compra = @idCompra;";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "SET FOREIGN_KEY_CHECKS = 1;";
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public DataTable PesquisarPorNomeCliente(String valor)
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter dadosVenda = new MySqlDataAdapter("select v.id_compra, v.nome_cliente, c.cpf, v.valor_total,v.forma_pagamento,v.data_venda from compra v join cliente c on v.id_cliente = c.id_cliente where v.nome_cliente like '%" + valor + "%'", conn);

            dadosVenda.Fill(tabela);
            return tabela;
        }
        public DataTable PesquisarPorCpf(String valor)
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter dadosVenda = new MySqlDataAdapter("select v.id_compra, v.nome_cliente, c.cpf, v.valor_total,v.forma_pagamento,v.data_venda from compra v join cliente c on v.id_cliente = c.id_cliente where c.cpf like '%" + valor + "%'", conn);

            dadosVenda.Fill(tabela);
            return tabela;
        }
        public DataTable PesquisarProdutosVenda(String valor)
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter dadosVenda = new MySqlDataAdapter("select p.modelo,p.categoria,p.quantidade,p.preco_venda,p.desconto,p.preco_unitario,p.id_compra,p.id_produto from produto_compra p inner join compra v where p.id_compra = " + valor + " and v.id_compra = " + valor +";", conn);
            
            dadosVenda.Fill(tabela);
            return tabela;
        }
        public DataTable Pesquisar()
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter dadosVenda = new MySqlDataAdapter("select v.id_compra, v.nome_cliente, c.cpf, v.valor_total,v.forma_pagamento,v.data_venda from compra v, cliente c where v.id_cliente = c.id_cliente;", conn);
            dadosVenda.Fill(tabela);
            return tabela;
        }
        public DataTable PesquisarPorData(DateTime data)
        {
            string dataCerta = Convert.ToString(data.Year) + "-" + Convert.ToString(data.Month) + "-" + Convert.ToString(data.Day);
            DataTable tabela = new DataTable();
            MySqlDataAdapter dadosVenda = new MySqlDataAdapter("select v.id_compra, v.nome_cliente, c.cpf, v.valor_total,v.forma_pagamento,v.data_venda from compra v join cliente c on v.id_cliente = c.id_cliente where v.data_venda = '" +  dataCerta + "';", conn);
            dadosVenda.Fill(tabela);
            return tabela;
        }
        /*
        public Venda carregaVenda(int codigo)
        {
            Venda venda = new Venda();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from compra where compra.id_compra =" + codigo.ToString();
            conn.Open();
            MySqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                venda.IdVenda = Convert.ToInt32(registro["id_venda"]);
                venda.NomeCliente = Convert.ToString(registro["nome_cliente"]);
                venda.ValorTotal = Convert.ToDecimal(registro["valor_total"]);
                venda.produtosVenda.Modelo = Convert.ToString(registro["modelo"]);
                venda.produtosVenda.QtdProduto = Convert.ToInt32(registro["quantidade"]);
                venda.produtosVenda.TipoProduto = Convert.ToString(registro["tipo_produto"]);
            }
            return venda;
        }*/

        public void InserirProdutos(Venda venda)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            conn.Open();

            cmd.CommandText = "insert into produto_compra(id_produto, categoria, modelo, quantidade, id_compra, preco_unitario,preco_venda,desconto) values (@id_produto, @categoria, @modelo, @quantidade, @id_compra, @preco_unitario,@preco_venda,@desconto);";
            cmd.Parameters.AddWithValue("@id_compra", _idCompra);
            cmd.Parameters.AddWithValue("@categoria", venda.produtosVenda.Categoria);
            cmd.Parameters.AddWithValue("@id_produto", venda.produtosVenda.IdProduto);
            cmd.Parameters.AddWithValue("@modelo", venda.produtosVenda.Modelo);
            cmd.Parameters.AddWithValue("@quantidade", venda.produtosVenda.QtdProduto);
            cmd.Parameters.AddWithValue("@preco_unitario", venda.produtosVenda.PrecoUnitario);
            cmd.Parameters.AddWithValue("@preco_venda", venda.produtosVenda.PrecoVenda);
            cmd.Parameters.AddWithValue("@desconto", venda.produtosVenda.Desconto);
            cmd.ExecuteNonQuery();

            conn.Close();

        }

        public Produto getValorAndQtdProduto(string modelo)
        {

            Produto produto = new Produto();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select preco,quantidade,id_produto,descricao from produto where produto.modelo = '" + modelo + "';";
            conn.Open();
            MySqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                produto.IdProduto = Convert.ToInt32(registro["id_produto"]);
                produto.Quantidade = Convert.ToInt32(registro["quantidade"]);
                produto.Preco = Convert.ToDecimal(registro["preco"]);
                produto.Descricao = Convert.ToString(registro["descricao"]);
            }
            conn.Close();
            return produto;
        }


        public DataTable carregaComboBoxProduto(string categoria)
        {

            DataTable dtTabelas = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select modelo from produto where categoria = '" + categoria + "';", conn);
            da.Fill(dtTabelas);

            conn.Close();

            return dtTabelas;
        }

        public decimal calculaPrecoDesconto(decimal qtdValorVenda, decimal precoProduto, decimal desconto)
        {
            decimal precoAPagar = 0;
            decimal valorDescontado = 0;
            decimal precoProdutoComDesconto = 0;

            if (desconto != 0)
            {

                valorDescontado = ((desconto / 100) * precoProduto);
                precoProdutoComDesconto = precoProduto - valorDescontado;

                precoAPagar = (qtdValorVenda * precoProdutoComDesconto);

                return precoAPagar;
            }
            else
            {
                precoAPagar = precoProduto;

                return precoAPagar;
            }
        }
        public decimal calculaPrecoVendaSemDesconto(decimal qtdValorVenda, decimal precoProduto)
        {
            decimal precoAPagar = 0;

            precoAPagar = (qtdValorVenda * precoProduto);

            return precoAPagar;
        }

        public decimal calculaPrecoVendaTotal(decimal valorAtualVenda, decimal precoProdDesconto)
        {
            decimal totalAPagar = 0;

            totalAPagar = valorAtualVenda + precoProdDesconto;

            return totalAPagar;
        }

        public decimal calculaValorTotalExclusaoProdCarrinho(decimal valorProduto, decimal valorTotal)
        {
            decimal valorAtualizado;

            valorAtualizado = (valorTotal - valorProduto);

            return valorAtualizado;
        }
    }
}
