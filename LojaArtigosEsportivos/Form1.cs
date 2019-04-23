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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<ProdutosVenda> vendas = new List<ProdutosVenda>();
        public Form1(List<ProdutosVenda> vendas)
        {
            InitializeComponent();
            this.vendas = vendas;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            DALRelatorio dALRelatorio = new DALRelatorio();
            reportViewer1.LocalReport.DataSources.Clear(); //clear report
            reportViewer1.LocalReport.ReportEmbeddedResource = "LojaArtigosEsportivos.Report1.rdlc"; // bind reportviewer with .rdlc

            //List<ObjRelatorioProd> objRelatorioProd = dALRelatorio.PesquisaProdutosVendidos(Convert.ToDateTime(dataInicioMskBx.Text), Convert.ToDateTime(dataFinalMskBx.Text));
            Microsoft.Reporting.WinForms.ReportDataSource dataset = new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", vendas); // set the datasource
            reportViewer1.LocalReport.DataSources.Add(dataset);
           

            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport(); // refresh report
        }
    }
}
