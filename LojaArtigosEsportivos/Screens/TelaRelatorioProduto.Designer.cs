namespace LojaArtigosEsportivos
{
    partial class TelaRelatorioProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pesquisarBtn = new System.Windows.Forms.Button();
            this.dataInicioMskBx = new System.Windows.Forms.MaskedTextBox();
            this.dataFinalMskBx = new System.Windows.Forms.MaskedTextBox();
            this.inicDataLbl = new System.Windows.Forms.Label();
            this.dataFinalLbl = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ObjRelatorioProdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProdutosVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ObjRelatorioProdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdutosVendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VendaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pesquisarBtn
            // 
            this.pesquisarBtn.BackColor = System.Drawing.Color.Teal;
            this.pesquisarBtn.FlatAppearance.BorderSize = 0;
            this.pesquisarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pesquisarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesquisarBtn.ForeColor = System.Drawing.Color.White;
            this.pesquisarBtn.Image = global::LojaArtigosEsportivos.Properties.Resources.LUPAPEQUENA;
            this.pesquisarBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pesquisarBtn.Location = new System.Drawing.Point(480, 12);
            this.pesquisarBtn.Name = "pesquisarBtn";
            this.pesquisarBtn.Size = new System.Drawing.Size(128, 53);
            this.pesquisarBtn.TabIndex = 1;
            this.pesquisarBtn.Text = "Pesquisar";
            this.pesquisarBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pesquisarBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.pesquisarBtn.UseVisualStyleBackColor = false;
            this.pesquisarBtn.Click += new System.EventHandler(this.pesquisarBtn_Click);
            // 
            // dataInicioMskBx
            // 
            this.dataInicioMskBx.Location = new System.Drawing.Point(176, 32);
            this.dataInicioMskBx.Mask = "00-00-0000";
            this.dataInicioMskBx.Name = "dataInicioMskBx";
            this.dataInicioMskBx.Size = new System.Drawing.Size(63, 20);
            this.dataInicioMskBx.TabIndex = 2;
            this.dataInicioMskBx.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // dataFinalMskBx
            // 
            this.dataFinalMskBx.Location = new System.Drawing.Point(338, 32);
            this.dataFinalMskBx.Mask = "00-00-0000";
            this.dataFinalMskBx.Name = "dataFinalMskBx";
            this.dataFinalMskBx.Size = new System.Drawing.Size(62, 20);
            this.dataFinalMskBx.TabIndex = 3;
            this.dataFinalMskBx.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // inicDataLbl
            // 
            this.inicDataLbl.AutoSize = true;
            this.inicDataLbl.BackColor = System.Drawing.Color.Transparent;
            this.inicDataLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inicDataLbl.Location = new System.Drawing.Point(80, 33);
            this.inicDataLbl.Name = "inicDataLbl";
            this.inicDataLbl.Size = new System.Drawing.Size(86, 16);
            this.inicDataLbl.TabIndex = 4;
            this.inicDataLbl.Text = "Data Inicio:";
            // 
            // dataFinalLbl
            // 
            this.dataFinalLbl.AutoSize = true;
            this.dataFinalLbl.BackColor = System.Drawing.Color.Transparent;
            this.dataFinalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataFinalLbl.Location = new System.Drawing.Point(245, 33);
            this.dataFinalLbl.Name = "dataFinalLbl";
            this.dataFinalLbl.Size = new System.Drawing.Size(83, 16);
            this.dataFinalLbl.TabIndex = 5;
            this.dataFinalLbl.Text = "Data Final:";
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSize = true;
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportViewer1.Location = new System.Drawing.Point(1, 73);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(657, 565);
            this.reportViewer1.TabIndex = 6;
            // 
            // ObjRelatorioProdBindingSource
            // 
            this.ObjRelatorioProdBindingSource.DataSource = typeof(LojaArtigosEsportivos.ObjRelatorioProd);
            // 
            // ProdutosVendaBindingSource
            // 
            this.ProdutosVendaBindingSource.DataSource = typeof(LojaArtigosEsportivos.ProdutosVenda);
            // 
            // VendaBindingSource
            // 
            this.VendaBindingSource.DataSource = typeof(LojaArtigosEsportivos.Venda);
            // 
            // TelaRelatorioProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::LojaArtigosEsportivos.Properties.Resources.Blue_Abstract_Background_Design;
            this.ClientSize = new System.Drawing.Size(657, 637);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.dataFinalLbl);
            this.Controls.Add(this.inicDataLbl);
            this.Controls.Add(this.dataFinalMskBx);
            this.Controls.Add(this.dataInicioMskBx);
            this.Controls.Add(this.pesquisarBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TelaRelatorioProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaRelatorioProduto";
            this.Load += new System.EventHandler(this.TelaRelatorioProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ObjRelatorioProdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdutosVendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VendaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource ProdutosVendaBindingSource;
        private System.Windows.Forms.BindingSource VendaBindingSource;
        private System.Windows.Forms.Button pesquisarBtn;
        private System.Windows.Forms.MaskedTextBox dataInicioMskBx;
        private System.Windows.Forms.MaskedTextBox dataFinalMskBx;
        private System.Windows.Forms.Label inicDataLbl;
        private System.Windows.Forms.Label dataFinalLbl;
        private System.Windows.Forms.BindingSource ObjRelatorioProdBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}