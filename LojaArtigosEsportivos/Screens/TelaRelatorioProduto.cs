using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaArtigosEsportivos
{
    public partial class TelaRelatorioProduto : Form
    {
        public TelaRelatorioProduto()
        {
            InitializeComponent();
        }

        private void TelaRelatorioProduto_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        private void pesquisarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (LiberaPesquisa())
                {
                    DALRelatorio dALRelatorio = new DALRelatorio();
                    reportViewer1.LocalReport.DataSources.Clear(); //clear report
                    reportViewer1.LocalReport.ReportEmbeddedResource = "LojaArtigosEsportivos.RelatorioProdutos.rdlc"; // bind reportviewer with .rdlc

                    List<ObjRelatorioProd> objRelatorioProd = dALRelatorio.PesquisaProdutosVendidos(Convert.ToDateTime(dataInicioMskBx.Text), Convert.ToDateTime(dataFinalMskBx.Text));
                    Microsoft.Reporting.WinForms.ReportDataSource dataset = new Microsoft.Reporting.WinForms.ReportDataSource("ObjRelatorioProdDS", objRelatorioProd); // set the datasource
                    reportViewer1.LocalReport.DataSources.Add(dataset);
                    dataset.Value = objRelatorioProd;

                    reportViewer1.LocalReport.Refresh();
                    reportViewer1.RefreshReport(); // refresh report
                }
                else
                {
                    MessageBox.Show("Preencher as datas sao obrigatorio!");
                }            
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }   

        private bool LiberaPesquisa()
        {
            if (string.IsNullOrEmpty(dataInicioMskBx.Text))
            {
                return false;
            }
            if (string.IsNullOrEmpty(dataFinalMskBx.Text))
            {
                return false;
            }
            return true;
        }
    }
}
