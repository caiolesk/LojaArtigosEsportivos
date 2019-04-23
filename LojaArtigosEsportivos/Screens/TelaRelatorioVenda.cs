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
    public partial class TelaRelatorioVenda : Form
    {
        public TelaRelatorioVenda()
        {
            InitializeComponent();
        }
        TelaVenda telaVenda = new TelaVenda();
        public TelaRelatorioVenda(TelaVenda telaVenda)
        {
            this.telaVenda = telaVenda;
            InitializeComponent();
        }
        private int idCompra = 0;
        private void TelaRelatorioVenda_Load(object sender, EventArgs e)
        {
            try
            {
                idCompra = telaVenda._codigoVenda;
                DALRelatorio dALRelatorio = new DALRelatorio();
                reportViewer1.LocalReport.DataSources.Clear(); //clear report
                reportViewer1.LocalReport.ReportEmbeddedResource = "LojaArtigosEsportivos.RelatorioVendas.rdlc"; // bind reportviewer with .rdlc

                List<ObjRelatorioVenda> objRelatorioVendas = dALRelatorio.PesquisaVenda(idCompra);
                Microsoft.Reporting.WinForms.ReportDataSource dataset = new Microsoft.Reporting.WinForms.ReportDataSource("ObjRelatorioVendaDS", objRelatorioVendas); // set the datasource
                reportViewer1.LocalReport.DataSources.Add(dataset);
                dataset.Value = objRelatorioVendas;
       
                reportViewer1.LocalReport.Refresh();
                reportViewer1.RefreshReport(); // refresh report

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.reportViewer1.RefreshReport();
        }
    }
}
