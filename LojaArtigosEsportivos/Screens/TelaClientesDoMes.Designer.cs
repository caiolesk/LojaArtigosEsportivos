namespace LojaArtigosEsportivos
{
    partial class TelaClientesDoMes
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
            this.clienteDoMesGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.sairTelaAniversariantesBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDoMesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // clienteDoMesGridView
            // 
            this.clienteDoMesGridView.BackgroundColor = System.Drawing.Color.White;
            this.clienteDoMesGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clienteDoMesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.clienteDoMesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clienteDoMesGridView.GridColor = System.Drawing.Color.Silver;
            this.clienteDoMesGridView.Location = new System.Drawing.Point(73, 66);
            this.clienteDoMesGridView.Name = "clienteDoMesGridView";
            this.clienteDoMesGridView.ReadOnly = true;
            this.clienteDoMesGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.clienteDoMesGridView.RowHeadersVisible = false;
            this.clienteDoMesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clienteDoMesGridView.Size = new System.Drawing.Size(485, 404);
            this.clienteDoMesGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aniversariantes do Mês";
            // 
            // sairTelaAniversariantesBtn
            // 
            this.sairTelaAniversariantesBtn.BackColor = System.Drawing.Color.Teal;
            this.sairTelaAniversariantesBtn.FlatAppearance.BorderSize = 0;
            this.sairTelaAniversariantesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sairTelaAniversariantesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sairTelaAniversariantesBtn.ForeColor = System.Drawing.Color.White;
            this.sairTelaAniversariantesBtn.Location = new System.Drawing.Point(524, 485);
            this.sairTelaAniversariantesBtn.Name = "sairTelaAniversariantesBtn";
            this.sairTelaAniversariantesBtn.Size = new System.Drawing.Size(88, 48);
            this.sairTelaAniversariantesBtn.TabIndex = 2;
            this.sairTelaAniversariantesBtn.Text = "Sair";
            this.sairTelaAniversariantesBtn.UseVisualStyleBackColor = false;
            this.sairTelaAniversariantesBtn.Click += new System.EventHandler(this.sairTelaAniversariantesBtn_Click);
            // 
            // TelaClientesDoMes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::LojaArtigosEsportivos.Properties.Resources.Blue_Abstract_Background_Design;
            this.ClientSize = new System.Drawing.Size(644, 545);
            this.Controls.Add(this.sairTelaAniversariantesBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clienteDoMesGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TelaClientesDoMes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaClientesDoMes";
            this.Load += new System.EventHandler(this.TelaClientesDoMes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clienteDoMesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView clienteDoMesGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sairTelaAniversariantesBtn;
    }
}