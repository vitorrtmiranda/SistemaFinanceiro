namespace SistemaFinanceiro
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuMovimentacoes = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sacarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarRelatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fazerRelatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlDireita = new System.Windows.Forms.Panel();
            this.lblSaldoAtual = new System.Windows.Forms.Label();
            this.lblDataAtual = new System.Windows.Forms.Label();
            this.lblHoraAtual = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlEsquerda = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblIdentificador = new System.Windows.Forms.Label();
            this.lblMovimentacaoDoDia = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnlDireita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlEsquerda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuMovimentacoes,
            this.MenuRelatorios,
            this.MenuSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuMovimentacoes
            // 
            this.MenuMovimentacoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarToolStripMenuItem,
            this.depositarToolStripMenuItem,
            this.sacarToolStripMenuItem});
            this.MenuMovimentacoes.Image = ((System.Drawing.Image)(resources.GetObject("MenuMovimentacoes.Image")));
            this.MenuMovimentacoes.Name = "MenuMovimentacoes";
            this.MenuMovimentacoes.Size = new System.Drawing.Size(120, 20);
            this.MenuMovimentacoes.Text = "Movimentações";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // depositarToolStripMenuItem
            // 
            this.depositarToolStripMenuItem.Name = "depositarToolStripMenuItem";
            this.depositarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.depositarToolStripMenuItem.Text = "Depositar";
            this.depositarToolStripMenuItem.Click += new System.EventHandler(this.depositarToolStripMenuItem_Click);
            // 
            // sacarToolStripMenuItem
            // 
            this.sacarToolStripMenuItem.Name = "sacarToolStripMenuItem";
            this.sacarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.sacarToolStripMenuItem.Text = "Sacar";
            this.sacarToolStripMenuItem.Click += new System.EventHandler(this.sacarToolStripMenuItem_Click);
            // 
            // MenuRelatorios
            // 
            this.MenuRelatorios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizarRelatóriosToolStripMenuItem,
            this.fazerRelatórioToolStripMenuItem});
            this.MenuRelatorios.Image = ((System.Drawing.Image)(resources.GetObject("MenuRelatorios.Image")));
            this.MenuRelatorios.Name = "MenuRelatorios";
            this.MenuRelatorios.Size = new System.Drawing.Size(87, 20);
            this.MenuRelatorios.Text = "Relatórios";
            // 
            // visualizarRelatóriosToolStripMenuItem
            // 
            this.visualizarRelatóriosToolStripMenuItem.Name = "visualizarRelatóriosToolStripMenuItem";
            this.visualizarRelatóriosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.visualizarRelatóriosToolStripMenuItem.Text = "Visualizar relatórios";
            this.visualizarRelatóriosToolStripMenuItem.Click += new System.EventHandler(this.visualizarRelatóriosToolStripMenuItem_Click_1);
            // 
            // fazerRelatórioToolStripMenuItem
            // 
            this.fazerRelatórioToolStripMenuItem.Name = "fazerRelatórioToolStripMenuItem";
            this.fazerRelatórioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fazerRelatórioToolStripMenuItem.Text = "Fazer relatório";
            this.fazerRelatórioToolStripMenuItem.Click += new System.EventHandler(this.fazerRelatórioToolStripMenuItem_Click);
            // 
            // MenuSair
            // 
            this.MenuSair.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
            this.MenuSair.Image = ((System.Drawing.Image)(resources.GetObject("MenuSair.Image")));
            this.MenuSair.Name = "MenuSair";
            this.MenuSair.Size = new System.Drawing.Size(54, 20);
            this.MenuSair.Text = "Sair";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // pnlDireita
            // 
            this.pnlDireita.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDireita.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlDireita.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDireita.Controls.Add(this.lblSaldoAtual);
            this.pnlDireita.Controls.Add(this.lblDataAtual);
            this.pnlDireita.Controls.Add(this.lblHoraAtual);
            this.pnlDireita.Controls.Add(this.lblUsuario);
            this.pnlDireita.Controls.Add(this.label5);
            this.pnlDireita.Controls.Add(this.label4);
            this.pnlDireita.Controls.Add(this.pictureBox3);
            this.pnlDireita.Controls.Add(this.pictureBox2);
            this.pnlDireita.Controls.Add(this.pictureBox1);
            this.pnlDireita.Controls.Add(this.label3);
            this.pnlDireita.Controls.Add(this.label2);
            this.pnlDireita.Controls.Add(this.label1);
            this.pnlDireita.Location = new System.Drawing.Point(548, 27);
            this.pnlDireita.Name = "pnlDireita";
            this.pnlDireita.Size = new System.Drawing.Size(250, 228);
            this.pnlDireita.TabIndex = 2;
            // 
            // lblSaldoAtual
            // 
            this.lblSaldoAtual.AutoSize = true;
            this.lblSaldoAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoAtual.Location = new System.Drawing.Point(97, 158);
            this.lblSaldoAtual.Name = "lblSaldoAtual";
            this.lblSaldoAtual.Size = new System.Drawing.Size(125, 24);
            this.lblSaldoAtual.TabIndex = 12;
            this.lblSaldoAtual.Text = "Carregando...";
            // 
            // lblDataAtual
            // 
            this.lblDataAtual.AutoSize = true;
            this.lblDataAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataAtual.Location = new System.Drawing.Point(115, 46);
            this.lblDataAtual.Name = "lblDataAtual";
            this.lblDataAtual.Size = new System.Drawing.Size(0, 24);
            this.lblDataAtual.TabIndex = 11;
            // 
            // lblHoraAtual
            // 
            this.lblHoraAtual.AutoSize = true;
            this.lblHoraAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraAtual.Location = new System.Drawing.Point(115, 13);
            this.lblHoraAtual.Name = "lblHoraAtual";
            this.lblHoraAtual.Size = new System.Drawing.Size(0, 24);
            this.lblHoraAtual.TabIndex = 10;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Bahnschrift SemiLight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUsuario.Location = new System.Drawing.Point(8, 103);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(121, 23);
            this.lblUsuario.TabIndex = 9;
            this.lblUsuario.Text = "Carregando...";
            this.lblUsuario.Click += new System.EventHandler(this.lblUsuario_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiLight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(8, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Conta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiLight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label4.Location = new System.Drawing.Point(-1, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 23);
            this.label4.TabIndex = 6;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.pictureBox3.Location = new System.Drawing.Point(12, 159);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.pictureBox2.Location = new System.Drawing.Point(12, 43);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiLight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(42, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "R$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiLight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(42, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiLight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(42, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hora:";
            // 
            // pnlEsquerda
            // 
            this.pnlEsquerda.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlEsquerda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEsquerda.Controls.Add(this.label6);
            this.pnlEsquerda.Controls.Add(this.lblIdentificador);
            this.pnlEsquerda.Controls.Add(this.lblMovimentacaoDoDia);
            this.pnlEsquerda.Controls.Add(this.label7);
            this.pnlEsquerda.Controls.Add(this.label8);
            this.pnlEsquerda.Controls.Add(this.label11);
            this.pnlEsquerda.Controls.Add(this.pictureBox5);
            this.pnlEsquerda.Controls.Add(this.label12);
            this.pnlEsquerda.Controls.Add(this.label13);
            this.pnlEsquerda.Location = new System.Drawing.Point(3, 27);
            this.pnlEsquerda.Name = "pnlEsquerda";
            this.pnlEsquerda.Size = new System.Drawing.Size(250, 228);
            this.pnlEsquerda.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiLight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(64, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "mais recente";
            // 
            // lblIdentificador
            // 
            this.lblIdentificador.AutoSize = true;
            this.lblIdentificador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentificador.Location = new System.Drawing.Point(8, 79);
            this.lblIdentificador.Name = "lblIdentificador";
            this.lblIdentificador.Size = new System.Drawing.Size(125, 24);
            this.lblIdentificador.TabIndex = 13;
            this.lblIdentificador.Text = "Carregando...";
            // 
            // lblMovimentacaoDoDia
            // 
            this.lblMovimentacaoDoDia.AutoSize = true;
            this.lblMovimentacaoDoDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovimentacaoDoDia.Location = new System.Drawing.Point(42, 103);
            this.lblMovimentacaoDoDia.Name = "lblMovimentacaoDoDia";
            this.lblMovimentacaoDoDia.Size = new System.Drawing.Size(125, 24);
            this.lblMovimentacaoDoDia.TabIndex = 12;
            this.lblMovimentacaoDoDia.Text = "Carregando...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(115, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 24);
            this.label7.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(115, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 24);
            this.label8.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift SemiLight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label11.Location = new System.Drawing.Point(-1, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 23);
            this.label11.TabIndex = 6;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.pictureBox5.Location = new System.Drawing.Point(12, 13);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(24, 24);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bahnschrift SemiLight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(3, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 23);
            this.label12.TabIndex = 2;
            this.label12.Text = "R$";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Bahnschrift SemiLight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label13.Location = new System.Drawing.Point(42, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(183, 23);
            this.label13.TabIndex = 1;
            this.label13.Text = "Movimentações hoje";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlEsquerda);
            this.Controls.Add(this.pnlDireita);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmMenu";
            this.Text = " Controle Financeiro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlDireita.ResumeLayout(false);
            this.pnlDireita.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlEsquerda.ResumeLayout(false);
            this.pnlEsquerda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem MenuMovimentacoes;
        public System.Windows.Forms.ToolStripMenuItem MenuRelatorios;
        public System.Windows.Forms.ToolStripMenuItem MenuSair;
        public System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        public System.Windows.Forms.Panel pnlDireita;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label lblUsuario;
        public System.Windows.Forms.Label lblHoraAtual;
        public System.Windows.Forms.Label lblDataAtual;
        public System.Windows.Forms.Label lblSaldoAtual;
        public System.Windows.Forms.ToolStripMenuItem depositarToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem sacarToolStripMenuItem;
        public System.Windows.Forms.Panel pnlEsquerda;
        public System.Windows.Forms.Label lblMovimentacaoDoDia;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.PictureBox pictureBox5;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label lblIdentificador;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.ToolStripMenuItem visualizarRelatóriosToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem fazerRelatórioToolStripMenuItem;
    }
}