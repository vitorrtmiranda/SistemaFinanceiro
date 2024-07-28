namespace SistemaFinanceiro.Relatorios
{
    partial class Relatorios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Relatorios));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConfirmarDiario = new System.Windows.Forms.Button();
            this.btnConfirmarMensal = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpRelatiroDiario = new System.Windows.Forms.DateTimePicker();
            this.cbRelatorioMensal = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbRelatorioAnual = new System.Windows.Forms.ComboBox();
            this.btnConfirmarAnual = new System.Windows.Forms.Button();
            this.btnConfirmarSemanal = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSemanal = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 37);
            this.label1.TabIndex = 20;
            this.label1.Text = "Relatórios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Relatório diário";
            // 
            // btnConfirmarDiario
            // 
            this.btnConfirmarDiario.BackColor = System.Drawing.Color.LimeGreen;
            this.btnConfirmarDiario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarDiario.Location = new System.Drawing.Point(16, 114);
            this.btnConfirmarDiario.Name = "btnConfirmarDiario";
            this.btnConfirmarDiario.Size = new System.Drawing.Size(173, 37);
            this.btnConfirmarDiario.TabIndex = 22;
            this.btnConfirmarDiario.Text = "Diário";
            this.btnConfirmarDiario.UseVisualStyleBackColor = false;
            this.btnConfirmarDiario.Click += new System.EventHandler(this.btnConfirmarDiario_Click);
            // 
            // btnConfirmarMensal
            // 
            this.btnConfirmarMensal.BackColor = System.Drawing.Color.LimeGreen;
            this.btnConfirmarMensal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarMensal.Location = new System.Drawing.Point(16, 252);
            this.btnConfirmarMensal.Name = "btnConfirmarMensal";
            this.btnConfirmarMensal.Size = new System.Drawing.Size(173, 37);
            this.btnConfirmarMensal.TabIndex = 24;
            this.btnConfirmarMensal.Text = "Mensal";
            this.btnConfirmarMensal.UseVisualStyleBackColor = false;
            this.btnConfirmarMensal.Click += new System.EventHandler(this.btnConfirmarMensal_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 24);
            this.label3.TabIndex = 23;
            this.label3.Text = "Relatório mensal";
            // 
            // dtpRelatiroDiario
            // 
            this.dtpRelatiroDiario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpRelatiroDiario.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRelatiroDiario.Location = new System.Drawing.Point(16, 88);
            this.dtpRelatiroDiario.Name = "dtpRelatiroDiario";
            this.dtpRelatiroDiario.Size = new System.Drawing.Size(173, 20);
            this.dtpRelatiroDiario.TabIndex = 25;
            // 
            // cbRelatorioMensal
            // 
            this.cbRelatorioMensal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRelatorioMensal.FormattingEnabled = true;
            this.cbRelatorioMensal.Items.AddRange(new object[] {
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
            this.cbRelatorioMensal.Location = new System.Drawing.Point(16, 225);
            this.cbRelatorioMensal.Name = "cbRelatorioMensal";
            this.cbRelatorioMensal.Size = new System.Drawing.Size(173, 21);
            this.cbRelatorioMensal.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(262, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 24);
            this.label4.TabIndex = 27;
            this.label4.Text = "Relatório anual";
            // 
            // cbRelatorioAnual
            // 
            this.cbRelatorioAnual.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRelatorioAnual.FormattingEnabled = true;
            this.cbRelatorioAnual.Items.AddRange(new object[] {
            "1900",
            "1901",
            "1902",
            "1903",
            "1904",
            "1905",
            "1906",
            "1907",
            "1908",
            "1909",
            "1910",
            "1911",
            "1912",
            "1913",
            "1914",
            "1915",
            "1916",
            "1917",
            "1918",
            "1919",
            "1920",
            "1921",
            "1922",
            "1923",
            "1924",
            "1925",
            "1926",
            "1927",
            "1928",
            "1929",
            "1930",
            "1931",
            "1932",
            "1933",
            "1934",
            "1935",
            "1936",
            "1937",
            "1938",
            "1939",
            "1940",
            "1941",
            "1942",
            "1943",
            "1944",
            "1945",
            "1946",
            "1947",
            "1948",
            "1949",
            "1950",
            "1951",
            "1952",
            "1953",
            "1954",
            "1955",
            "1956",
            "1957",
            "1958",
            "1959",
            "1960",
            "1961",
            "1962",
            "1963",
            "1964",
            "1965",
            "1966",
            "1967",
            "1968",
            "1969",
            "1970",
            "1971",
            "1972",
            "1973",
            "1974",
            "1975",
            "1976",
            "1977",
            "1978",
            "1979",
            "1980",
            "1981",
            "1982",
            "1983",
            "1984",
            "1985",
            "1986",
            "1987",
            "1988",
            "1989",
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024"});
            this.cbRelatorioAnual.Location = new System.Drawing.Point(249, 225);
            this.cbRelatorioAnual.Name = "cbRelatorioAnual";
            this.cbRelatorioAnual.Size = new System.Drawing.Size(173, 21);
            this.cbRelatorioAnual.TabIndex = 28;
            // 
            // btnConfirmarAnual
            // 
            this.btnConfirmarAnual.BackColor = System.Drawing.Color.LimeGreen;
            this.btnConfirmarAnual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarAnual.Location = new System.Drawing.Point(249, 252);
            this.btnConfirmarAnual.Name = "btnConfirmarAnual";
            this.btnConfirmarAnual.Size = new System.Drawing.Size(173, 37);
            this.btnConfirmarAnual.TabIndex = 29;
            this.btnConfirmarAnual.Text = "Anual";
            this.btnConfirmarAnual.UseVisualStyleBackColor = false;
            this.btnConfirmarAnual.Click += new System.EventHandler(this.btnConfirmarAnual_Click);
            // 
            // btnConfirmarSemanal
            // 
            this.btnConfirmarSemanal.BackColor = System.Drawing.Color.LimeGreen;
            this.btnConfirmarSemanal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarSemanal.Location = new System.Drawing.Point(249, 114);
            this.btnConfirmarSemanal.Name = "btnConfirmarSemanal";
            this.btnConfirmarSemanal.Size = new System.Drawing.Size(173, 37);
            this.btnConfirmarSemanal.TabIndex = 31;
            this.btnConfirmarSemanal.Text = "Semanal";
            this.btnConfirmarSemanal.UseVisualStyleBackColor = false;
            this.btnConfirmarSemanal.Click += new System.EventHandler(this.btnConfirmarSemanal_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(249, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 24);
            this.label5.TabIndex = 30;
            this.label5.Text = "Relatório semanal";
            // 
            // cbSemanal
            // 
            this.cbSemanal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSemanal.FormattingEnabled = true;
            this.cbSemanal.Items.AddRange(new object[] {
            "Semana 1",
            "Semana 2",
            "Semana 3",
            "Semana 4"});
            this.cbSemanal.Location = new System.Drawing.Point(249, 88);
            this.cbSemanal.Name = "cbSemanal";
            this.cbSemanal.Size = new System.Drawing.Size(173, 21);
            this.cbSemanal.TabIndex = 32;
            // 
            // Relatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(434, 461);
            this.Controls.Add(this.cbSemanal);
            this.Controls.Add(this.btnConfirmarSemanal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnConfirmarAnual);
            this.Controls.Add(this.cbRelatorioAnual);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbRelatorioMensal);
            this.Controls.Add(this.dtpRelatiroDiario);
            this.Controls.Add(this.btnConfirmarMensal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnConfirmarDiario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Relatorios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorios";
            this.Load += new System.EventHandler(this.Relatorios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConfirmarDiario;
        private System.Windows.Forms.Button btnConfirmarMensal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpRelatiroDiario;
        private System.Windows.Forms.ComboBox cbRelatorioMensal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbRelatorioAnual;
        private System.Windows.Forms.Button btnConfirmarAnual;
        private System.Windows.Forms.Button btnConfirmarSemanal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbSemanal;
    }
}