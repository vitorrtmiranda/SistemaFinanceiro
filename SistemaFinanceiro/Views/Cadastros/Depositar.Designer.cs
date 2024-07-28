namespace SistemaFinanceiro.Cadastros
{
    partial class Depositar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Depositar));
            this.lblMeuPerfil = new System.Windows.Forms.Label();
            this.lblSaldoAtual = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDepositar = new System.Windows.Forms.TextBox();
            this.btnConfirmarDeposito = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMeuPerfil
            // 
            this.lblMeuPerfil.AutoSize = true;
            this.lblMeuPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeuPerfil.Location = new System.Drawing.Point(139, 37);
            this.lblMeuPerfil.Name = "lblMeuPerfil";
            this.lblMeuPerfil.Size = new System.Drawing.Size(163, 37);
            this.lblMeuPerfil.TabIndex = 1;
            this.lblMeuPerfil.Text = "Depositar";
            // 
            // lblSaldoAtual
            // 
            this.lblSaldoAtual.AutoSize = true;
            this.lblSaldoAtual.Location = new System.Drawing.Point(54, 152);
            this.lblSaldoAtual.Name = "lblSaldoAtual";
            this.lblSaldoAtual.Size = new System.Drawing.Size(71, 13);
            this.lblSaldoAtual.TabIndex = 4;
            this.lblSaldoAtual.Text = "Carregando...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Saldo atual";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bahnschrift SemiLight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(12, 144);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 23);
            this.label12.TabIndex = 5;
            this.label12.Text = "R$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Depositar";
            // 
            // txtDepositar
            // 
            this.txtDepositar.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDepositar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDepositar.Location = new System.Drawing.Point(16, 219);
            this.txtDepositar.Multiline = true;
            this.txtDepositar.Name = "txtDepositar";
            this.txtDepositar.Size = new System.Drawing.Size(186, 27);
            this.txtDepositar.TabIndex = 1;
            // 
            // btnConfirmarDeposito
            // 
            this.btnConfirmarDeposito.BackColor = System.Drawing.Color.LimeGreen;
            this.btnConfirmarDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarDeposito.Location = new System.Drawing.Point(189, 412);
            this.btnConfirmarDeposito.Name = "btnConfirmarDeposito";
            this.btnConfirmarDeposito.Size = new System.Drawing.Size(77, 37);
            this.btnConfirmarDeposito.TabIndex = 3;
            this.btnConfirmarDeposito.Text = "Confirmar";
            this.btnConfirmarDeposito.UseVisualStyleBackColor = false;
            this.btnConfirmarDeposito.Click += new System.EventHandler(this.btnConfirmarDeposito_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricao.Location = new System.Drawing.Point(16, 289);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(406, 117);
            this.txtDescricao.TabIndex = 2;
            // 
            // Depositar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(434, 461);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnConfirmarDeposito);
            this.Controls.Add(this.txtDepositar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblSaldoAtual);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMeuPerfil);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Depositar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Depositar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMeuPerfil;
        private System.Windows.Forms.Label lblSaldoAtual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDepositar;
        private System.Windows.Forms.Button btnConfirmarDeposito;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescricao;
    }
}