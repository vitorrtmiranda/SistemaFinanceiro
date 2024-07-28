namespace SistemaFinanceiro.Perfil
{
    partial class Perfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Perfil));
            this.lblMeuPerfil = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSenhaAtual = new System.Windows.Forms.TextBox();
            this.cbMostrarSenha = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNovaSenha = new System.Windows.Forms.TextBox();
            this.btnAttSenha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMeuPerfil
            // 
            this.lblMeuPerfil.AutoSize = true;
            this.lblMeuPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeuPerfil.Location = new System.Drawing.Point(102, 45);
            this.lblMeuPerfil.Name = "lblMeuPerfil";
            this.lblMeuPerfil.Size = new System.Drawing.Size(169, 37);
            this.lblMeuPerfil.TabIndex = 0;
            this.lblMeuPerfil.Text = "Meu Perfil";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Senha";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(13, 156);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(71, 13);
            this.lblSenha.TabIndex = 2;
            this.lblSenha.Text = "Carregando...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Trocar senha";
            // 
            // txtSenhaAtual
            // 
            this.txtSenhaAtual.Location = new System.Drawing.Point(16, 251);
            this.txtSenhaAtual.Name = "txtSenhaAtual";
            this.txtSenhaAtual.Size = new System.Drawing.Size(253, 20);
            this.txtSenhaAtual.TabIndex = 1;
            // 
            // cbMostrarSenha
            // 
            this.cbMostrarSenha.AutoSize = true;
            this.cbMostrarSenha.Location = new System.Drawing.Point(283, 156);
            this.cbMostrarSenha.Name = "cbMostrarSenha";
            this.cbMostrarSenha.Size = new System.Drawing.Size(93, 17);
            this.cbMostrarSenha.TabIndex = 0;
            this.cbMostrarSenha.Text = "Mostrar senha";
            this.cbMostrarSenha.UseVisualStyleBackColor = true;
            this.cbMostrarSenha.CheckedChanged += new System.EventHandler(this.cbMostrarSenha_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Senha atual";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nova senha";
            // 
            // txtNovaSenha
            // 
            this.txtNovaSenha.Location = new System.Drawing.Point(16, 294);
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.Size = new System.Drawing.Size(253, 20);
            this.txtNovaSenha.TabIndex = 2;
            // 
            // btnAttSenha
            // 
            this.btnAttSenha.Location = new System.Drawing.Point(16, 329);
            this.btnAttSenha.Name = "btnAttSenha";
            this.btnAttSenha.Size = new System.Drawing.Size(253, 23);
            this.btnAttSenha.TabIndex = 3;
            this.btnAttSenha.Text = "Atualizar senha";
            this.btnAttSenha.UseVisualStyleBackColor = true;
            this.btnAttSenha.Click += new System.EventHandler(this.btnAttSenha_Click);
            // 
            // Perfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(375, 526);
            this.Controls.Add(this.btnAttSenha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNovaSenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbMostrarSenha);
            this.Controls.Add(this.txtSenhaAtual);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMeuPerfil);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Perfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perfil";
            this.Load += new System.EventHandler(this.Perfil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMeuPerfil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSenhaAtual;
        private System.Windows.Forms.CheckBox cbMostrarSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNovaSenha;
        private System.Windows.Forms.Button btnAttSenha;
    }
}