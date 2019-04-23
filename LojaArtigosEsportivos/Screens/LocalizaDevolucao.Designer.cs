namespace LojaArtigosEsportivos
{
    partial class LocalizaDevolucao
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
            this.vendasDevolucaoGridView = new System.Windows.Forms.DataGridView();
            this.produtosDevolucaoGridView = new System.Windows.Forms.DataGridView();
            this.pesquisarVendaBtn = new System.Windows.Forms.Button();
            this.cancelarTelaDevolverBtn = new System.Windows.Forms.Button();
            this.devolverProdBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pesquisaVendaMskBx = new System.Windows.Forms.MaskedTextBox();
            this.tipoPesquisaCbx = new System.Windows.Forms.ComboBox();
            this.pesquisaVendaLbl = new System.Windows.Forms.Label();
            this.tipoPesquisaLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vendasDevolucaoGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosDevolucaoGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // vendasDevolucaoGridView
            // 
            this.vendasDevolucaoGridView.BackgroundColor = System.Drawing.Color.White;
            this.vendasDevolucaoGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vendasDevolucaoGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.vendasDevolucaoGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vendasDevolucaoGridView.GridColor = System.Drawing.Color.Silver;
            this.vendasDevolucaoGridView.Location = new System.Drawing.Point(75, 112);
            this.vendasDevolucaoGridView.Name = "vendasDevolucaoGridView";
            this.vendasDevolucaoGridView.ReadOnly = true;
            this.vendasDevolucaoGridView.RowHeadersVisible = false;
            this.vendasDevolucaoGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vendasDevolucaoGridView.Size = new System.Drawing.Size(600, 150);
            this.vendasDevolucaoGridView.TabIndex = 0;
            this.vendasDevolucaoGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vendasDevolucaoGridView_CellClick);
            // 
            // produtosDevolucaoGridView
            // 
            this.produtosDevolucaoGridView.AllowUserToOrderColumns = true;
            this.produtosDevolucaoGridView.BackgroundColor = System.Drawing.Color.White;
            this.produtosDevolucaoGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.produtosDevolucaoGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.produtosDevolucaoGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produtosDevolucaoGridView.GridColor = System.Drawing.Color.Gray;
            this.produtosDevolucaoGridView.Location = new System.Drawing.Point(75, 299);
            this.produtosDevolucaoGridView.Name = "produtosDevolucaoGridView";
            this.produtosDevolucaoGridView.ReadOnly = true;
            this.produtosDevolucaoGridView.RowHeadersVisible = false;
            this.produtosDevolucaoGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.produtosDevolucaoGridView.Size = new System.Drawing.Size(600, 150);
            this.produtosDevolucaoGridView.TabIndex = 1;
            this.produtosDevolucaoGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.produtosDevolucaoGridView_CellDoubleClick);
            // 
            // pesquisarVendaBtn
            // 
            this.pesquisarVendaBtn.BackColor = System.Drawing.Color.Teal;
            this.pesquisarVendaBtn.FlatAppearance.BorderSize = 0;
            this.pesquisarVendaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pesquisarVendaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesquisarVendaBtn.ForeColor = System.Drawing.Color.White;
            this.pesquisarVendaBtn.Image = global::LojaArtigosEsportivos.Properties.Resources.LUPAPEQUENA;
            this.pesquisarVendaBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pesquisarVendaBtn.Location = new System.Drawing.Point(552, 52);
            this.pesquisarVendaBtn.Name = "pesquisarVendaBtn";
            this.pesquisarVendaBtn.Size = new System.Drawing.Size(123, 52);
            this.pesquisarVendaBtn.TabIndex = 4;
            this.pesquisarVendaBtn.Text = "Pesquisar";
            this.pesquisarVendaBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pesquisarVendaBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.pesquisarVendaBtn.UseVisualStyleBackColor = false;
            this.pesquisarVendaBtn.Click += new System.EventHandler(this.pesquisarVendaBtn_Click);
            // 
            // cancelarTelaDevolverBtn
            // 
            this.cancelarTelaDevolverBtn.BackColor = System.Drawing.Color.Teal;
            this.cancelarTelaDevolverBtn.FlatAppearance.BorderSize = 0;
            this.cancelarTelaDevolverBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarTelaDevolverBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarTelaDevolverBtn.ForeColor = System.Drawing.Color.White;
            this.cancelarTelaDevolverBtn.Location = new System.Drawing.Point(644, 455);
            this.cancelarTelaDevolverBtn.Name = "cancelarTelaDevolverBtn";
            this.cancelarTelaDevolverBtn.Size = new System.Drawing.Size(88, 52);
            this.cancelarTelaDevolverBtn.TabIndex = 5;
            this.cancelarTelaDevolverBtn.Text = "Cancelar";
            this.cancelarTelaDevolverBtn.UseVisualStyleBackColor = false;
            this.cancelarTelaDevolverBtn.Click += new System.EventHandler(this.cancelarTelaDevolverBtn_Click);
            // 
            // devolverProdBtn
            // 
            this.devolverProdBtn.BackColor = System.Drawing.Color.Teal;
            this.devolverProdBtn.FlatAppearance.BorderSize = 0;
            this.devolverProdBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.devolverProdBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devolverProdBtn.ForeColor = System.Drawing.Color.White;
            this.devolverProdBtn.Location = new System.Drawing.Point(515, 455);
            this.devolverProdBtn.Name = "devolverProdBtn";
            this.devolverProdBtn.Size = new System.Drawing.Size(88, 52);
            this.devolverProdBtn.TabIndex = 6;
            this.devolverProdBtn.Text = "Devolver";
            this.devolverProdBtn.UseVisualStyleBackColor = false;
            this.devolverProdBtn.Click += new System.EventHandler(this.devolverProdBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "DETALHES DA VENDA";
            // 
            // pesquisaVendaMskBx
            // 
            this.pesquisaVendaMskBx.Location = new System.Drawing.Point(409, 70);
            this.pesquisaVendaMskBx.Name = "pesquisaVendaMskBx";
            this.pesquisaVendaMskBx.Size = new System.Drawing.Size(100, 20);
            this.pesquisaVendaMskBx.TabIndex = 10;
            // 
            // tipoPesquisaCbx
            // 
            this.tipoPesquisaCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoPesquisaCbx.FormattingEnabled = true;
            this.tipoPesquisaCbx.Items.AddRange(new object[] {
            "Nome",
            "Data"});
            this.tipoPesquisaCbx.Location = new System.Drawing.Point(216, 72);
            this.tipoPesquisaCbx.Name = "tipoPesquisaCbx";
            this.tipoPesquisaCbx.Size = new System.Drawing.Size(80, 21);
            this.tipoPesquisaCbx.TabIndex = 11;
            this.tipoPesquisaCbx.TextChanged += new System.EventHandler(this.tipoPesquisaCbx_TextChanged);
            // 
            // pesquisaVendaLbl
            // 
            this.pesquisaVendaLbl.AutoSize = true;
            this.pesquisaVendaLbl.BackColor = System.Drawing.Color.Transparent;
            this.pesquisaVendaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesquisaVendaLbl.Location = new System.Drawing.Point(324, 71);
            this.pesquisaVendaLbl.Name = "pesquisaVendaLbl";
            this.pesquisaVendaLbl.Size = new System.Drawing.Size(82, 18);
            this.pesquisaVendaLbl.TabIndex = 12;
            this.pesquisaVendaLbl.Text = "Pesquisa:";
            // 
            // tipoPesquisaLbl
            // 
            this.tipoPesquisaLbl.AutoSize = true;
            this.tipoPesquisaLbl.BackColor = System.Drawing.Color.Transparent;
            this.tipoPesquisaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoPesquisaLbl.Location = new System.Drawing.Point(71, 72);
            this.tipoPesquisaLbl.Name = "tipoPesquisaLbl";
            this.tipoPesquisaLbl.Size = new System.Drawing.Size(143, 18);
            this.tipoPesquisaLbl.TabIndex = 13;
            this.tipoPesquisaLbl.Text = "Tipo da Pesquisa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(181, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Localiza venda para devolução";
            // 
            // LocalizaDevolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LojaArtigosEsportivos.Properties.Resources.Blue_Abstract_Background_Design;
            this.ClientSize = new System.Drawing.Size(744, 519);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tipoPesquisaLbl);
            this.Controls.Add(this.pesquisaVendaLbl);
            this.Controls.Add(this.tipoPesquisaCbx);
            this.Controls.Add(this.pesquisaVendaMskBx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.devolverProdBtn);
            this.Controls.Add(this.cancelarTelaDevolverBtn);
            this.Controls.Add(this.pesquisarVendaBtn);
            this.Controls.Add(this.produtosDevolucaoGridView);
            this.Controls.Add(this.vendasDevolucaoGridView);
            this.MaximizeBox = false;
            this.Name = "LocalizaDevolucao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Localiza Venda";
            ((System.ComponentModel.ISupportInitialize)(this.vendasDevolucaoGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosDevolucaoGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView vendasDevolucaoGridView;
        private System.Windows.Forms.DataGridView produtosDevolucaoGridView;
        private System.Windows.Forms.Button pesquisarVendaBtn;
        private System.Windows.Forms.Button cancelarTelaDevolverBtn;
        private System.Windows.Forms.Button devolverProdBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox pesquisaVendaMskBx;
        private System.Windows.Forms.ComboBox tipoPesquisaCbx;
        private System.Windows.Forms.Label pesquisaVendaLbl;
        private System.Windows.Forms.Label tipoPesquisaLbl;
        private System.Windows.Forms.Label label2;
    }
}