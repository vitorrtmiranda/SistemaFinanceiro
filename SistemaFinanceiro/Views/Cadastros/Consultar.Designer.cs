namespace SistemaFinanceiro.Cadastros
{
    partial class FrmConsultar
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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultar));
            this.buscaDataTxt = new System.Windows.Forms.MaskedTextBox();
            this.cbMeses = new System.Windows.Forms.ComboBox();
            this.btnBuscaData = new System.Windows.Forms.Button();
            this.btnBuscaMes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buscaDataTxt
            // 
            this.buscaDataTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(80)))), ((int)(((byte)(84)))));
            this.buscaDataTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.buscaDataTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscaDataTxt.ForeColor = System.Drawing.SystemColors.Info;
            this.buscaDataTxt.Location = new System.Drawing.Point(105, 218);
            this.buscaDataTxt.Mask = "00/00/0000";
            this.buscaDataTxt.Name = "buscaDataTxt";
            this.buscaDataTxt.Size = new System.Drawing.Size(224, 46);
            this.buscaDataTxt.TabIndex = 1;
            this.buscaDataTxt.ValidatingType = typeof(System.DateTime);
            this.buscaDataTxt.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.buscaDataTxt_MaskInputRejected);
            this.buscaDataTxt.Click += new System.EventHandler(this.buscaDataTxt_Click);
            // 
            // cbMeses
            // 
            this.cbMeses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(80)))), ((int)(((byte)(84)))));
            this.cbMeses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbMeses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMeses.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMeses.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cbMeses.FormattingEnabled = true;
            this.cbMeses.ItemHeight = 46;
            this.cbMeses.Items.AddRange(new object[] {
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"});
            this.cbMeses.Location = new System.Drawing.Point(88, 366);
            this.cbMeses.Name = "cbMeses";
            this.cbMeses.Size = new System.Drawing.Size(293, 54);
            this.cbMeses.TabIndex = 3;
            // 
            // btnBuscaData
            // 
            this.btnBuscaData.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscaData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBuscaData.Font = new System.Drawing.Font("Bahnschrift Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaData.Location = new System.Drawing.Point(403, 209);
            this.btnBuscaData.Name = "btnBuscaData";
            this.btnBuscaData.Size = new System.Drawing.Size(212, 63);
            this.btnBuscaData.TabIndex = 2;
            this.btnBuscaData.Text = "BUSCAR";
            this.btnBuscaData.UseVisualStyleBackColor = false;
            this.btnBuscaData.Click += new System.EventHandler(this.btnBuscaData_Click);
            // 
            // btnBuscaMes
            // 
            this.btnBuscaMes.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscaMes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBuscaMes.Font = new System.Drawing.Font("Bahnschrift Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaMes.Location = new System.Drawing.Point(403, 364);
            this.btnBuscaMes.Name = "btnBuscaMes";
            this.btnBuscaMes.Size = new System.Drawing.Size(212, 63);
            this.btnBuscaMes.TabIndex = 4;
            this.btnBuscaMes.Text = "BUSCAR";
            this.btnBuscaMes.UseVisualStyleBackColor = false;
            this.btnBuscaMes.Click += new System.EventHandler(this.btnBuscaMes_Click);
            // 
            // FrmConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(704, 484);
            this.Controls.Add(this.btnBuscaMes);
            this.Controls.Add(this.btnBuscaData);
            this.Controls.Add(this.cbMeses);
            this.Controls.Add(this.buscaDataTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmConsultar";
            this.Text = "Consultar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox buscaDataTxt;
        private System.Windows.Forms.ComboBox cbMeses;
        private System.Windows.Forms.Button btnBuscaData;
        private System.Windows.Forms.Button btnBuscaMes;
    }
}