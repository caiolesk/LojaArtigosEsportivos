namespace LojaArtigosEsportivos
{
    partial class TelaDevolveProduto
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
            this.OkBtn = new System.Windows.Forms.Button();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.quantidadeLbl = new System.Windows.Forms.Label();
            this.quantidadeDevolvidaTbx = new System.Windows.Forms.TextBox();
            this.qtdAserDevolvidaLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OkBtn
            // 
            this.OkBtn.BackColor = System.Drawing.Color.Teal;
            this.OkBtn.FlatAppearance.BorderSize = 0;
            this.OkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OkBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OkBtn.ForeColor = System.Drawing.Color.White;
            this.OkBtn.Location = new System.Drawing.Point(91, 199);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(69, 45);
            this.OkBtn.TabIndex = 0;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = false;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.BackColor = System.Drawing.Color.Teal;
            this.cancelarBtn.FlatAppearance.BorderSize = 0;
            this.cancelarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarBtn.ForeColor = System.Drawing.Color.White;
            this.cancelarBtn.Location = new System.Drawing.Point(206, 199);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(74, 45);
            this.cancelarBtn.TabIndex = 1;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = false;
            this.cancelarBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
            // 
            // quantidadeLbl
            // 
            this.quantidadeLbl.AutoSize = true;
            this.quantidadeLbl.BackColor = System.Drawing.Color.Transparent;
            this.quantidadeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantidadeLbl.Location = new System.Drawing.Point(76, 106);
            this.quantidadeLbl.Name = "quantidadeLbl";
            this.quantidadeLbl.Size = new System.Drawing.Size(124, 24);
            this.quantidadeLbl.TabIndex = 2;
            this.quantidadeLbl.Text = "Quantidade:";
            // 
            // quantidadeDevolvidaTbx
            // 
            this.quantidadeDevolvidaTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantidadeDevolvidaTbx.Location = new System.Drawing.Point(206, 102);
            this.quantidadeDevolvidaTbx.Multiline = true;
            this.quantidadeDevolvidaTbx.Name = "quantidadeDevolvidaTbx";
            this.quantidadeDevolvidaTbx.Size = new System.Drawing.Size(40, 33);
            this.quantidadeDevolvidaTbx.TabIndex = 3;
            this.quantidadeDevolvidaTbx.Tag = "";
            this.quantidadeDevolvidaTbx.Text = "1";
            // 
            // qtdAserDevolvidaLbl
            // 
            this.qtdAserDevolvidaLbl.AutoSize = true;
            this.qtdAserDevolvidaLbl.BackColor = System.Drawing.Color.Transparent;
            this.qtdAserDevolvidaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtdAserDevolvidaLbl.Location = new System.Drawing.Point(30, 23);
            this.qtdAserDevolvidaLbl.Name = "qtdAserDevolvidaLbl";
            this.qtdAserDevolvidaLbl.Size = new System.Drawing.Size(308, 25);
            this.qtdAserDevolvidaLbl.TabIndex = 4;
            this.qtdAserDevolvidaLbl.Text = "Quantidade a ser devolvida!";
            // 
            // TelaDevolveProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LojaArtigosEsportivos.Properties.Resources.Blue_Abstract_Background_Design;
            this.ClientSize = new System.Drawing.Size(371, 271);
            this.Controls.Add(this.qtdAserDevolvidaLbl);
            this.Controls.Add(this.quantidadeDevolvidaTbx);
            this.Controls.Add(this.quantidadeLbl);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.OkBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TelaDevolveProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devolver Produto";
            this.Load += new System.EventHandler(this.TelaDevolveProduto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Button cancelarBtn;
        private System.Windows.Forms.Label quantidadeLbl;
        private System.Windows.Forms.TextBox quantidadeDevolvidaTbx;
        private System.Windows.Forms.Label qtdAserDevolvidaLbl;
    }
}