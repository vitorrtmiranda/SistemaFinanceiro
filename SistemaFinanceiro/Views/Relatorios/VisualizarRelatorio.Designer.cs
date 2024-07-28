namespace SistemaFinanceiro.Relatorios
{
    partial class VisualizarRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualizarRelatorio));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvMostraRelatoriosDisponiveis = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.dgvMostraRelatoriosSelecionados = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostraRelatoriosDisponiveis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostraRelatoriosSelecionados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 37);
            this.label1.TabIndex = 33;
            this.label1.Text = "Visualizar relatórios";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.btnConfirmar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dgvMostraRelatoriosDisponiveis);
            this.panel1.Location = new System.Drawing.Point(19, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 379);
            this.panel1.TabIndex = 34;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.dgvMostraRelatoriosSelecionados);
            this.panel2.Location = new System.Drawing.Point(337, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(451, 426);
            this.panel2.TabIndex = 35;
            // 
            // dgvMostraRelatoriosDisponiveis
            // 
            this.dgvMostraRelatoriosDisponiveis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostraRelatoriosDisponiveis.Location = new System.Drawing.Point(3, 33);
            this.dgvMostraRelatoriosDisponiveis.Name = "dgvMostraRelatoriosDisponiveis";
            this.dgvMostraRelatoriosDisponiveis.Size = new System.Drawing.Size(306, 304);
            this.dgvMostraRelatoriosDisponiveis.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 29);
            this.label2.TabIndex = 36;
            this.label2.Text = "Relatórios disponíveis";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(3, 343);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(306, 33);
            this.btnConfirmar.TabIndex = 37;
            this.btnConfirmar.Text = "Confirmar seleção";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // dgvMostraRelatoriosSelecionados
            // 
            this.dgvMostraRelatoriosSelecionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostraRelatoriosSelecionados.Location = new System.Drawing.Point(3, 3);
            this.dgvMostraRelatoriosSelecionados.Name = "dgvMostraRelatoriosSelecionados";
            this.dgvMostraRelatoriosSelecionados.Size = new System.Drawing.Size(445, 420);
            this.dgvMostraRelatoriosSelecionados.TabIndex = 38;
            // 
            // VisualizarRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VisualizarRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar Relatorio";
            this.Load += new System.EventHandler(this.VisualizarRelatorio_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostraRelatoriosDisponiveis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostraRelatoriosSelecionados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvMostraRelatoriosDisponiveis;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.DataGridView dgvMostraRelatoriosSelecionados;
    }
}