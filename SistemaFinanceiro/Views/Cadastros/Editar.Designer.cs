namespace SistemaFinanceiro.Cadastros
{
    partial class Editar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editar));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConfirmarEdicao = new System.Windows.Forms.Button();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.cbTransacao = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 37);
            this.label1.TabIndex = 20;
            this.label1.Text = "Editar transação";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Editar categoria";
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricao.Location = new System.Drawing.Point(29, 211);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(393, 102);
            this.txtDescricao.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 24);
            this.label3.TabIndex = 23;
            this.label3.Text = "Editar descrição";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 24);
            this.label4.TabIndex = 25;
            this.label4.Text = "Editar tipo de transação";
            // 
            // btnConfirmarEdicao
            // 
            this.btnConfirmarEdicao.BackColor = System.Drawing.Color.LimeGreen;
            this.btnConfirmarEdicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarEdicao.Location = new System.Drawing.Point(184, 412);
            this.btnConfirmarEdicao.Name = "btnConfirmarEdicao";
            this.btnConfirmarEdicao.Size = new System.Drawing.Size(77, 37);
            this.btnConfirmarEdicao.TabIndex = 20;
            this.btnConfirmarEdicao.Text = "Confirmar";
            this.btnConfirmarEdicao.UseVisualStyleBackColor = false;
            this.btnConfirmarEdicao.Click += new System.EventHandler(this.btnConfirmarEdicao_Click);
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "Saque",
            "Depósito"});
            this.cbCategoria.Location = new System.Drawing.Point(29, 135);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(186, 21);
            this.cbCategoria.TabIndex = 27;
            // 
            // cbTransacao
            // 
            this.cbTransacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTransacao.FormattingEnabled = true;
            this.cbTransacao.Items.AddRange(new object[] {
            "Saque",
            "Depósito"});
            this.cbTransacao.Location = new System.Drawing.Point(29, 368);
            this.cbTransacao.Name = "cbTransacao";
            this.cbTransacao.Size = new System.Drawing.Size(186, 21);
            this.cbTransacao.TabIndex = 28;
            // 
            // Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(434, 461);
            this.Controls.Add(this.cbTransacao);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.btnConfirmarEdicao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Editar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar";
            this.Load += new System.EventHandler(this.Editar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConfirmarEdicao;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.ComboBox cbTransacao;
    }
}