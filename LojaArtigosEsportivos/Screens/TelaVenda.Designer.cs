namespace LojaArtigosEsportivos
{
    partial class TelaVenda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaVenda));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.produtoVendaGridView = new System.Windows.Forms.DataGridView();
            this.cpfPesqVendaMskBx = new System.Windows.Forms.MaskedTextBox();
            this.cpfPesqVendaLbl = new System.Windows.Forms.Label();
            this.nomeClientePesqTbx = new System.Windows.Forms.TextBox();
            this.consultaVendaGridView = new System.Windows.Forms.DataGridView();
            this.nomeClientePesqLbl = new System.Windows.Forms.Label();
            this.excluirVendaBtn = new System.Windows.Forms.Button();
            this.cancelarTelaVendaBtn = new System.Windows.Forms.Button();
            this.gerarRelatorioVendaBtn = new System.Windows.Forms.Button();
            this.pesquisaVendaBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtoVendaGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaVendaGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.produtoVendaGridView);
            this.panel1.Controls.Add(this.cpfPesqVendaMskBx);
            this.panel1.Controls.Add(this.cpfPesqVendaLbl);
            this.panel1.Controls.Add(this.nomeClientePesqTbx);
            this.panel1.Controls.Add(this.consultaVendaGridView);
            this.panel1.Controls.Add(this.nomeClientePesqLbl);
            this.panel1.Controls.Add(this.excluirVendaBtn);
            this.panel1.Controls.Add(this.cancelarTelaVendaBtn);
            this.panel1.Controls.Add(this.gerarRelatorioVendaBtn);
            this.panel1.Controls.Add(this.pesquisaVendaBtn);
            this.panel1.Location = new System.Drawing.Point(9, 41);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 620);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(277, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 31);
            this.label2.TabIndex = 36;
            this.label2.Text = "DETALHES  DA VENDA";
            // 
            // produtoVendaGridView
            // 
            this.produtoVendaGridView.BackgroundColor = System.Drawing.Color.White;
            this.produtoVendaGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.produtoVendaGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.produtoVendaGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.produtoVendaGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produtoVendaGridView.GridColor = System.Drawing.Color.Silver;
            this.produtoVendaGridView.Location = new System.Drawing.Point(117, 363);
            this.produtoVendaGridView.Name = "produtoVendaGridView";
            this.produtoVendaGridView.ReadOnly = true;
            this.produtoVendaGridView.RowHeadersVisible = false;
            this.produtoVendaGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.produtoVendaGridView.Size = new System.Drawing.Size(618, 151);
            this.produtoVendaGridView.TabIndex = 35;
            // 
            // cpfPesqVendaMskBx
            // 
            this.cpfPesqVendaMskBx.Location = new System.Drawing.Point(230, 23);
            this.cpfPesqVendaMskBx.Mask = "000.000.000-00";
            this.cpfPesqVendaMskBx.Name = "cpfPesqVendaMskBx";
            this.cpfPesqVendaMskBx.Size = new System.Drawing.Size(101, 20);
            this.cpfPesqVendaMskBx.TabIndex = 29;
            this.cpfPesqVendaMskBx.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // cpfPesqVendaLbl
            // 
            this.cpfPesqVendaLbl.AutoSize = true;
            this.cpfPesqVendaLbl.BackColor = System.Drawing.Color.Transparent;
            this.cpfPesqVendaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpfPesqVendaLbl.Location = new System.Drawing.Point(178, 27);
            this.cpfPesqVendaLbl.Name = "cpfPesqVendaLbl";
            this.cpfPesqVendaLbl.Size = new System.Drawing.Size(46, 16);
            this.cpfPesqVendaLbl.TabIndex = 28;
            this.cpfPesqVendaLbl.Text = "CPF:";
            // 
            // nomeClientePesqTbx
            // 
            this.nomeClientePesqTbx.Location = new System.Drawing.Point(230, 61);
            this.nomeClientePesqTbx.Name = "nomeClientePesqTbx";
            this.nomeClientePesqTbx.Size = new System.Drawing.Size(221, 20);
            this.nomeClientePesqTbx.TabIndex = 30;
            // 
            // consultaVendaGridView
            // 
            this.consultaVendaGridView.BackgroundColor = System.Drawing.Color.White;
            this.consultaVendaGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.consultaVendaGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.consultaVendaGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.consultaVendaGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consultaVendaGridView.GridColor = System.Drawing.Color.Silver;
            this.consultaVendaGridView.Location = new System.Drawing.Point(117, 104);
            this.consultaVendaGridView.Name = "consultaVendaGridView";
            this.consultaVendaGridView.ReadOnly = true;
            this.consultaVendaGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.consultaVendaGridView.RowHeadersVisible = false;
            this.consultaVendaGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.consultaVendaGridView.Size = new System.Drawing.Size(618, 209);
            this.consultaVendaGridView.TabIndex = 26;
            this.consultaVendaGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.consultaVendaGridView_CellClick);
            this.consultaVendaGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.consultaVendaGridView_CellDoubleClick);
            // 
            // nomeClientePesqLbl
            // 
            this.nomeClientePesqLbl.AutoSize = true;
            this.nomeClientePesqLbl.BackColor = System.Drawing.Color.Transparent;
            this.nomeClientePesqLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeClientePesqLbl.Location = new System.Drawing.Point(114, 61);
            this.nomeClientePesqLbl.Name = "nomeClientePesqLbl";
            this.nomeClientePesqLbl.Size = new System.Drawing.Size(110, 16);
            this.nomeClientePesqLbl.TabIndex = 25;
            this.nomeClientePesqLbl.Text = "Nome Cliente:";
            // 
            // excluirVendaBtn
            // 
            this.excluirVendaBtn.BackColor = System.Drawing.Color.Teal;
            this.excluirVendaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.excluirVendaBtn.FlatAppearance.BorderSize = 0;
            this.excluirVendaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excluirVendaBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excluirVendaBtn.ForeColor = System.Drawing.Color.White;
            this.excluirVendaBtn.Location = new System.Drawing.Point(388, 556);
            this.excluirVendaBtn.Name = "excluirVendaBtn";
            this.excluirVendaBtn.Size = new System.Drawing.Size(117, 50);
            this.excluirVendaBtn.TabIndex = 33;
            this.excluirVendaBtn.Text = "Excluir";
            this.excluirVendaBtn.UseVisualStyleBackColor = false;
            this.excluirVendaBtn.Click += new System.EventHandler(this.excluirVendaBtn_Click);
            // 
            // cancelarTelaVendaBtn
            // 
            this.cancelarTelaVendaBtn.BackColor = System.Drawing.Color.Teal;
            this.cancelarTelaVendaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelarTelaVendaBtn.FlatAppearance.BorderSize = 0;
            this.cancelarTelaVendaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarTelaVendaBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarTelaVendaBtn.ForeColor = System.Drawing.Color.White;
            this.cancelarTelaVendaBtn.Location = new System.Drawing.Point(721, 556);
            this.cancelarTelaVendaBtn.Name = "cancelarTelaVendaBtn";
            this.cancelarTelaVendaBtn.Size = new System.Drawing.Size(117, 50);
            this.cancelarTelaVendaBtn.TabIndex = 34;
            this.cancelarTelaVendaBtn.Text = "Cancelar";
            this.cancelarTelaVendaBtn.UseVisualStyleBackColor = false;
            this.cancelarTelaVendaBtn.Click += new System.EventHandler(this.cancelarTelaVendaBtn_Click);
            // 
            // gerarRelatorioVendaBtn
            // 
            this.gerarRelatorioVendaBtn.BackColor = System.Drawing.Color.Teal;
            this.gerarRelatorioVendaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gerarRelatorioVendaBtn.FlatAppearance.BorderSize = 0;
            this.gerarRelatorioVendaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gerarRelatorioVendaBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gerarRelatorioVendaBtn.ForeColor = System.Drawing.Color.White;
            this.gerarRelatorioVendaBtn.Location = new System.Drawing.Point(117, 556);
            this.gerarRelatorioVendaBtn.Name = "gerarRelatorioVendaBtn";
            this.gerarRelatorioVendaBtn.Size = new System.Drawing.Size(107, 50);
            this.gerarRelatorioVendaBtn.TabIndex = 32;
            this.gerarRelatorioVendaBtn.Text = "Gerar Relatorio";
            this.gerarRelatorioVendaBtn.UseVisualStyleBackColor = false;
            this.gerarRelatorioVendaBtn.Click += new System.EventHandler(this.novaVendaBtn_Click);
            // 
            // pesquisaVendaBtn
            // 
            this.pesquisaVendaBtn.BackColor = System.Drawing.Color.Teal;
            this.pesquisaVendaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pesquisaVendaBtn.FlatAppearance.BorderSize = 0;
            this.pesquisaVendaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pesquisaVendaBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesquisaVendaBtn.ForeColor = System.Drawing.Color.White;
            this.pesquisaVendaBtn.Image = global::LojaArtigosEsportivos.Properties.Resources.LUPAPEQUENA;
            this.pesquisaVendaBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pesquisaVendaBtn.Location = new System.Drawing.Point(530, 23);
            this.pesquisaVendaBtn.Name = "pesquisaVendaBtn";
            this.pesquisaVendaBtn.Size = new System.Drawing.Size(130, 58);
            this.pesquisaVendaBtn.TabIndex = 31;
            this.pesquisaVendaBtn.Text = "Pesquisar";
            this.pesquisaVendaBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.pesquisaVendaBtn.UseVisualStyleBackColor = false;
            this.pesquisaVendaBtn.Click += new System.EventHandler(this.pesquisaVendaBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(393, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 30);
            this.label1.TabIndex = 30;
            this.label1.Text = "Vendas";
            // 
            // TelaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LojaArtigosEsportivos.Properties.Resources.Blue_Abstract_Background_Design;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(874, 678);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "TelaVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.TelaVenda_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtoVendaGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaVendaGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox cpfPesqVendaMskBx;
        private System.Windows.Forms.Label cpfPesqVendaLbl;
        private System.Windows.Forms.TextBox nomeClientePesqTbx;
        private System.Windows.Forms.DataGridView consultaVendaGridView;
        private System.Windows.Forms.Label nomeClientePesqLbl;
        private System.Windows.Forms.Button excluirVendaBtn;
        private System.Windows.Forms.Button cancelarTelaVendaBtn;
        private System.Windows.Forms.Button gerarRelatorioVendaBtn;
        private System.Windows.Forms.Button pesquisaVendaBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView produtoVendaGridView;
        private System.Windows.Forms.Label label2;
    }
}