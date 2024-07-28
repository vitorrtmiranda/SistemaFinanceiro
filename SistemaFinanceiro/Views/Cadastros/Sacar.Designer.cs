namespace SistemaFinanceiro.Cadastros
{
    partial class Sacar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sacar));
            this.txtDescricaoSacar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConfirmarSaque = new System.Windows.Forms.Button();
            this.txtSacar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblSaldoAtual = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMeuPerfil = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDescricaoSacar
            // 
            this.txtDescricaoSacar.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDescricaoSacar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricaoSacar.Location = new System.Drawing.Point(16, 276);
            this.txtDescricaoSacar.Multiline = true;
            this.txtDescricaoSacar.Name = "txtDescricaoSacar";
            this.txtDescricaoSacar.Size = new System.Drawing.Size(406, 117);
            this.txtDescricaoSacar.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "Descrição";
            // 
            // btnConfirmarSaque
            // 
            this.btnConfirmarSaque.BackColor = System.Drawing.Color.LimeGreen;
            this.btnConfirmarSaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarSaque.Location = new System.Drawing.Point(189, 399);
            this.btnConfirmarSaque.Name = "btnConfirmarSaque";
            this.btnConfirmarSaque.Size = new System.Drawing.Size(77, 37);
            this.btnConfirmarSaque.TabIndex = 3;
            this.btnConfirmarSaque.Text = "Confirmar";
            this.btnConfirmarSaque.UseVisualStyleBackColor = false;
            this.btnConfirmarSaque.Click += new System.EventHandler(this.btnConfirmarSaque_Click);
            // 
            // txtSacar
            // 
            this.txtSacar.BackColor = System.Drawing.SystemColors.Menu;
            this.txtSacar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSacar.Location = new System.Drawing.Point(16, 206);
            this.txtSacar.Multiline = true;
            this.txtSacar.Name = "txtSacar";
            this.txtSacar.Size = new System.Drawing.Size(186, 27);
            this.txtSacar.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Sacar";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bahnschrift SemiLight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(12, 131);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 23);
            this.label12.TabIndex = 14;
            this.label12.Text = "R$";
            // 
            // lblSaldoAtual
            // 
            this.lblSaldoAtual.AutoSize = true;
            this.lblSaldoAtual.Location = new System.Drawing.Point(54, 139);
            this.lblSaldoAtual.Name = "lblSaldoAtual";
            this.lblSaldoAtual.Size = new System.Drawing.Size(71, 13);
            this.lblSaldoAtual.TabIndex = 13;
            this.lblSaldoAtual.Text = "Carregando...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Saldo atual";
            // 
            // lblMeuPerfil
            // 
            this.lblMeuPerfil.AutoSize = true;
            this.lblMeuPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeuPerfil.Location = new System.Drawing.Point(171, 19);
            this.lblMeuPerfil.Name = "lblMeuPerfil";
            this.lblMeuPerfil.Size = new System.Drawing.Size(106, 37);
            this.lblMeuPerfil.TabIndex = 11;
            this.lblMeuPerfil.Text = "Sacar";
            // 
            // Sacar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(434, 461);
            this.Controls.Add(this.txtDescricaoSacar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnConfirmarSaque);
            this.Controls.Add(this.txtSacar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblSaldoAtual);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMeuPerfil);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sacar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sacar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescricaoSacar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConfirmarSaque;
        private System.Windows.Forms.TextBox txtSacar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblSaldoAtual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMeuPerfil;
    }
}