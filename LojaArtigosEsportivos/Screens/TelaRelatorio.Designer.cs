﻿namespace LojaArtigosEsportivos
{
    partial class TelaRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaRelatorio));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dataFinalMskBx = new System.Windows.Forms.MaskedTextBox();
            this.dataInicioMskBx = new System.Windows.Forms.MaskedTextBox();
            this.dataFinalLbl = new System.Windows.Forms.Label();
            this.dataInicioLbl = new System.Windows.Forms.Label();
            this.cancelarTelaRelatorioBtn = new System.Windows.Forms.Button();
            this.valorTotalVendaTbx = new System.Windows.Forms.TextBox();
            this.valorTotalVendaLbl = new System.Windows.Forms.Label();
            this.consultaVendaGridview = new System.Windows.Forms.DataGridView();
            this.relatorioProdLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultaVendaGridview)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnPesquisar);
            this.panel1.Controls.Add(this.dataFinalMskBx);
            this.panel1.Controls.Add(this.dataInicioMskBx);
            this.panel1.Controls.Add(this.dataFinalLbl);
            this.panel1.Controls.Add(this.dataInicioLbl);
            this.panel1.Controls.Add(this.cancelarTelaRelatorioBtn);
            this.panel1.Controls.Add(this.valorTotalVendaTbx);
            this.panel1.Controls.Add(this.valorTotalVendaLbl);
            this.panel1.Controls.Add(this.consultaVendaGridview);
            this.panel1.Location = new System.Drawing.Point(9, 46);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 473);
            this.panel1.TabIndex = 8;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.Teal;
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Location = new System.Drawing.Point(427, 18);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(113, 48);
            this.btnPesquisar.TabIndex = 33;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dataFinalMskBx
            // 
            this.dataFinalMskBx.Location = new System.Drawing.Point(292, 34);
            this.dataFinalMskBx.Mask = "00-00-0000";
            this.dataFinalMskBx.Name = "dataFinalMskBx";
            this.dataFinalMskBx.Size = new System.Drawing.Size(70, 20);
            this.dataFinalMskBx.TabIndex = 32;
            this.dataFinalMskBx.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.dataFinalMskBx.ValidatingType = typeof(System.DateTime);
            // 
            // dataInicioMskBx
            // 
            this.dataInicioMskBx.Location = new System.Drawing.Point(122, 34);
            this.dataInicioMskBx.Mask = "00-00-0000";
            this.dataInicioMskBx.Name = "dataInicioMskBx";
            this.dataInicioMskBx.Size = new System.Drawing.Size(66, 20);
            this.dataInicioMskBx.TabIndex = 31;
            this.dataInicioMskBx.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.dataInicioMskBx.ValidatingType = typeof(System.DateTime);
            // 
            // dataFinalLbl
            // 
            this.dataFinalLbl.AutoSize = true;
            this.dataFinalLbl.Location = new System.Drawing.Point(228, 37);
            this.dataFinalLbl.Name = "dataFinalLbl";
            this.dataFinalLbl.Size = new System.Drawing.Size(58, 13);
            this.dataFinalLbl.TabIndex = 30;
            this.dataFinalLbl.Text = "Data Final:";
            // 
            // dataInicioLbl
            // 
            this.dataInicioLbl.AutoSize = true;
            this.dataInicioLbl.Location = new System.Drawing.Point(55, 37);
            this.dataInicioLbl.Name = "dataInicioLbl";
            this.dataInicioLbl.Size = new System.Drawing.Size(61, 13);
            this.dataInicioLbl.TabIndex = 29;
            this.dataInicioLbl.Text = "Data Inicio:";
            // 
            // cancelarTelaRelatorioBtn
            // 
            this.cancelarTelaRelatorioBtn.BackColor = System.Drawing.Color.Teal;
            this.cancelarTelaRelatorioBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelarTelaRelatorioBtn.FlatAppearance.BorderSize = 0;
            this.cancelarTelaRelatorioBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarTelaRelatorioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarTelaRelatorioBtn.ForeColor = System.Drawing.Color.White;
            this.cancelarTelaRelatorioBtn.Location = new System.Drawing.Point(556, 419);
            this.cancelarTelaRelatorioBtn.Name = "cancelarTelaRelatorioBtn";
            this.cancelarTelaRelatorioBtn.Size = new System.Drawing.Size(107, 43);
            this.cancelarTelaRelatorioBtn.TabIndex = 28;
            this.cancelarTelaRelatorioBtn.Text = "Cancelar";
            this.cancelarTelaRelatorioBtn.UseVisualStyleBackColor = false;
            this.cancelarTelaRelatorioBtn.Click += new System.EventHandler(this.cancelarTelaRelatorioBtn_Click_1);
            // 
            // valorTotalVendaTbx
            // 
            this.valorTotalVendaTbx.Enabled = false;
            this.valorTotalVendaTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorTotalVendaTbx.Location = new System.Drawing.Point(238, 419);
            this.valorTotalVendaTbx.Name = "valorTotalVendaTbx";
            this.valorTotalVendaTbx.Size = new System.Drawing.Size(143, 29);
            this.valorTotalVendaTbx.TabIndex = 9;
            // 
            // valorTotalVendaLbl
            // 
            this.valorTotalVendaLbl.AutoSize = true;
            this.valorTotalVendaLbl.BackColor = System.Drawing.Color.Transparent;
            this.valorTotalVendaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorTotalVendaLbl.Location = new System.Drawing.Point(16, 419);
            this.valorTotalVendaLbl.Name = "valorTotalVendaLbl";
            this.valorTotalVendaLbl.Size = new System.Drawing.Size(217, 25);
            this.valorTotalVendaLbl.TabIndex = 8;
            this.valorTotalVendaLbl.Text = "Valor total vendas :";
            // 
            // consultaVendaGridview
            // 
            this.consultaVendaGridview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consultaVendaGridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.consultaVendaGridview.Location = new System.Drawing.Point(21, 72);
            this.consultaVendaGridview.Name = "consultaVendaGridview";
            this.consultaVendaGridview.ReadOnly = true;
            this.consultaVendaGridview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.consultaVendaGridview.Size = new System.Drawing.Size(646, 316);
            this.consultaVendaGridview.TabIndex = 7;
            // 
            // relatorioProdLbl
            // 
            this.relatorioProdLbl.AutoSize = true;
            this.relatorioProdLbl.BackColor = System.Drawing.Color.Transparent;
            this.relatorioProdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relatorioProdLbl.Location = new System.Drawing.Point(101, 9);
            this.relatorioProdLbl.Name = "relatorioProdLbl";
            this.relatorioProdLbl.Size = new System.Drawing.Size(434, 31);
            this.relatorioProdLbl.TabIndex = 9;
            this.relatorioProdLbl.Text = "Relatorios de produtos vendidos";
            // 
            // TelaRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LojaArtigosEsportivos.Properties.Resources.Blue_Abstract_Background_Design;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(708, 530);
            this.Controls.Add(this.relatorioProdLbl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TelaRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio de Produto ";
            this.Load += new System.EventHandler(this.TelaRelatorio_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultaVendaGridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox valorTotalVendaTbx;
        private System.Windows.Forms.Label valorTotalVendaLbl;
        private System.Windows.Forms.DataGridView consultaVendaGridview;
        private System.Windows.Forms.Button cancelarTelaRelatorioBtn;
        private System.Windows.Forms.Label relatorioProdLbl;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.MaskedTextBox dataFinalMskBx;
        private System.Windows.Forms.MaskedTextBox dataInicioMskBx;
        private System.Windows.Forms.Label dataFinalLbl;
        private System.Windows.Forms.Label dataInicioLbl;
    }
}