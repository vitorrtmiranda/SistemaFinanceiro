namespace SistemaFinanceiro.Cadastros
{
    partial class MostraDadosMes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MostraDadosMes));
            this.btnEditarDados = new System.Windows.Forms.Button();
            this.btnExluir = new System.Windows.Forms.Button();
            this.dgvMostraDados = new System.Windows.Forms.DataGridView();
            this.lblMeuPerfil = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostraDados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditarDados
            // 
            this.btnEditarDados.BackColor = System.Drawing.Color.LimeGreen;
            this.btnEditarDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarDados.Location = new System.Drawing.Point(483, 407);
            this.btnEditarDados.Name = "btnEditarDados";
            this.btnEditarDados.Size = new System.Drawing.Size(204, 36);
            this.btnEditarDados.TabIndex = 19;
            this.btnEditarDados.Text = "Editar dado selecionado";
            this.btnEditarDados.UseVisualStyleBackColor = false;
            this.btnEditarDados.Click += new System.EventHandler(this.btnEditarDados_Click);
            // 
            // btnExluir
            // 
            this.btnExluir.BackColor = System.Drawing.Color.Red;
            this.btnExluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExluir.Location = new System.Drawing.Point(258, 407);
            this.btnExluir.Name = "btnExluir";
            this.btnExluir.Size = new System.Drawing.Size(204, 36);
            this.btnExluir.TabIndex = 18;
            this.btnExluir.Text = "Excluir dado selecionado";
            this.btnExluir.UseVisualStyleBackColor = false;
            this.btnExluir.Click += new System.EventHandler(this.btnExluir_Click);
            // 
            // dgvMostraDados
            // 
            this.dgvMostraDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostraDados.Location = new System.Drawing.Point(12, 72);
            this.dgvMostraDados.Name = "dgvMostraDados";
            this.dgvMostraDados.Size = new System.Drawing.Size(936, 319);
            this.dgvMostraDados.TabIndex = 17;
            // 
            // lblMeuPerfil
            // 
            this.lblMeuPerfil.AutoSize = true;
            this.lblMeuPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeuPerfil.Location = new System.Drawing.Point(309, 17);
            this.lblMeuPerfil.Name = "lblMeuPerfil";
            this.lblMeuPerfil.Size = new System.Drawing.Size(314, 37);
            this.lblMeuPerfil.TabIndex = 16;
            this.lblMeuPerfil.Text = "Dados recuperados";
            // 
            // MostraDadosMes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(960, 461);
            this.Controls.Add(this.btnEditarDados);
            this.Controls.Add(this.btnExluir);
            this.Controls.Add(this.dgvMostraDados);
            this.Controls.Add(this.lblMeuPerfil);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MostraDadosMes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MostraDadosMes";
            this.Load += new System.EventHandler(this.MostraDadosMes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostraDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnEditarDados;
        public System.Windows.Forms.Button btnExluir;
        public System.Windows.Forms.DataGridView dgvMostraDados;
        public System.Windows.Forms.Label lblMeuPerfil;
    }
}