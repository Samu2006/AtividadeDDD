namespace PC2.WinApplication.Forms
{
    partial class frmPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnVehicle = new System.Windows.Forms.Button();
            this.frmModel = new System.Windows.Forms.Button();
            this.btnSale = new System.Windows.Forms.Button();
            this.frmBuyer = new System.Windows.Forms.Button();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saídaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modelosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.veículosToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.veículosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentaçãoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnVehicle);
            this.panel1.Controls.Add(this.frmModel);
            this.panel1.Controls.Add(this.btnSale);
            this.panel1.Controls.Add(this.frmBuyer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 46);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 180);
            this.panel1.TabIndex = 20;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::PC2.WinApplication.Properties.Resources.entradas_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(276, 16);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 140);
            this.button1.TabIndex = 4;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVehicle
            // 
            this.btnVehicle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.btnVehicle.FlatAppearance.BorderSize = 0;
            this.btnVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehicle.ForeColor = System.Drawing.Color.White;
            this.btnVehicle.Image = global::PC2.WinApplication.Properties.Resources.estoque_1;
            this.btnVehicle.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVehicle.Location = new System.Drawing.Point(614, 16);
            this.btnVehicle.Margin = new System.Windows.Forms.Padding(5);
            this.btnVehicle.Name = "btnVehicle";
            this.btnVehicle.Size = new System.Drawing.Size(133, 140);
            this.btnVehicle.TabIndex = 1;
            this.btnVehicle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVehicle.UseVisualStyleBackColor = false;
            this.btnVehicle.Click += new System.EventHandler(this.btnVehicle_Click);
            // 
            // frmModel
            // 
            this.frmModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.frmModel.FlatAppearance.BorderSize = 0;
            this.frmModel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.frmModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmModel.ForeColor = System.Drawing.Color.White;
            this.frmModel.Image = global::PC2.WinApplication.Properties.Resources.modelos_;
            this.frmModel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.frmModel.Location = new System.Drawing.Point(783, 16);
            this.frmModel.Margin = new System.Windows.Forms.Padding(5);
            this.frmModel.Name = "frmModel";
            this.frmModel.Size = new System.Drawing.Size(130, 140);
            this.frmModel.TabIndex = 3;
            this.frmModel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.frmModel.UseVisualStyleBackColor = false;
            this.frmModel.Click += new System.EventHandler(this.frmModel_Click);
            // 
            // btnSale
            // 
            this.btnSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.btnSale.FlatAppearance.BorderSize = 0;
            this.btnSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSale.ForeColor = System.Drawing.Color.White;
            this.btnSale.Image = global::PC2.WinApplication.Properties.Resources.saídas_;
            this.btnSale.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSale.Location = new System.Drawing.Point(445, 16);
            this.btnSale.Margin = new System.Windows.Forms.Padding(5);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(133, 140);
            this.btnSale.TabIndex = 0;
            this.btnSale.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSale.UseMnemonic = false;
            this.btnSale.UseVisualStyleBackColor = false;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // frmBuyer
            // 
            this.frmBuyer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.frmBuyer.FlatAppearance.BorderSize = 0;
            this.frmBuyer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.frmBuyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmBuyer.ForeColor = System.Drawing.Color.White;
            this.frmBuyer.Image = global::PC2.WinApplication.Properties.Resources.clientes_1;
            this.frmBuyer.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.frmBuyer.Location = new System.Drawing.Point(107, 16);
            this.frmBuyer.Margin = new System.Windows.Forms.Padding(5);
            this.frmBuyer.Name = "frmBuyer";
            this.frmBuyer.Size = new System.Drawing.Size(133, 140);
            this.frmBuyer.TabIndex = 2;
            this.frmBuyer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.frmBuyer.UseVisualStyleBackColor = false;
            this.frmBuyer.Click += new System.EventHandler(this.frmBuyer_Click);
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.clienteToolStripMenuItem.Text = "Clientes";
            // 
            // veículosToolStripMenuItem
            // 
            this.veículosToolStripMenuItem.Name = "veículosToolStripMenuItem";
            this.veículosToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.veículosToolStripMenuItem.Text = "Veículos";
            // 
            // movimentaçãoToolStripMenuItem
            // 
            this.movimentaçãoToolStripMenuItem.Name = "movimentaçãoToolStripMenuItem";
            this.movimentaçãoToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.movimentaçãoToolStripMenuItem.Text = "Movimentação";
            // 
            // entradaToolStripMenuItem
            // 
            this.entradaToolStripMenuItem.Name = "entradaToolStripMenuItem";
            this.entradaToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.entradaToolStripMenuItem.Text = "Entrada";
            // 
            // saídaToolStripMenuItem
            // 
            this.saídaToolStripMenuItem.Name = "saídaToolStripMenuItem";
            this.saídaToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.saídaToolStripMenuItem.Text = "Saída";
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // modelosToolStripMenuItem
            // 
            this.modelosToolStripMenuItem.Name = "modelosToolStripMenuItem";
            this.modelosToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.modelosToolStripMenuItem.Text = "Modelos";
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.estoqueToolStripMenuItem.Text = "Estoque";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(162)))), ((int)(((byte)(134)))));
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem1,
            this.consultaToolStripMenuItem1,
            this.movimentaçãoToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(9, 9);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(285, 28);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem1
            // 
            this.cadastroToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem1,
            this.modelosToolStripMenuItem1,
            this.veículosToolStripMenuItem2});
            this.cadastroToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.cadastroToolStripMenuItem1.Name = "cadastroToolStripMenuItem1";
            this.cadastroToolStripMenuItem1.Size = new System.Drawing.Size(80, 24);
            this.cadastroToolStripMenuItem1.Text = "Cadastro";
            this.cadastroToolStripMenuItem1.Click += new System.EventHandler(this.cadastroToolStripMenuItem1_Click);
            // 
            // clienteToolStripMenuItem1
            // 
            this.clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
            this.clienteToolStripMenuItem1.Size = new System.Drawing.Size(142, 26);
            this.clienteToolStripMenuItem1.Text = "Clientes";
            this.clienteToolStripMenuItem1.Click += new System.EventHandler(this.clienteToolStripMenuItem1_Click);
            // 
            // modelosToolStripMenuItem1
            // 
            this.modelosToolStripMenuItem1.Name = "modelosToolStripMenuItem1";
            this.modelosToolStripMenuItem1.Size = new System.Drawing.Size(142, 26);
            this.modelosToolStripMenuItem1.Text = "Modelos";
            this.modelosToolStripMenuItem1.Click += new System.EventHandler(this.modelosToolStripMenuItem1_Click);
            // 
            // veículosToolStripMenuItem2
            // 
            this.veículosToolStripMenuItem2.Name = "veículosToolStripMenuItem2";
            this.veículosToolStripMenuItem2.Size = new System.Drawing.Size(142, 26);
            this.veículosToolStripMenuItem2.Text = "Veículos";
            this.veículosToolStripMenuItem2.Click += new System.EventHandler(this.veículosToolStripMenuItem2_Click);
            // 
            // consultaToolStripMenuItem1
            // 
            this.consultaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estoqueToolStripMenuItem1,
            this.veículosToolStripMenuItem1});
            this.consultaToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.consultaToolStripMenuItem1.Name = "consultaToolStripMenuItem1";
            this.consultaToolStripMenuItem1.Size = new System.Drawing.Size(78, 24);
            this.consultaToolStripMenuItem1.Text = "Consulta";
            // 
            // estoqueToolStripMenuItem1
            // 
            this.estoqueToolStripMenuItem1.Name = "estoqueToolStripMenuItem1";
            this.estoqueToolStripMenuItem1.Size = new System.Drawing.Size(137, 26);
            this.estoqueToolStripMenuItem1.Text = "Clientes";
            this.estoqueToolStripMenuItem1.Click += new System.EventHandler(this.estoqueToolStripMenuItem1_Click);
            // 
            // veículosToolStripMenuItem1
            // 
            this.veículosToolStripMenuItem1.Name = "veículosToolStripMenuItem1";
            this.veículosToolStripMenuItem1.Size = new System.Drawing.Size(137, 26);
            this.veículosToolStripMenuItem1.Text = "Estoque";
            this.veículosToolStripMenuItem1.Click += new System.EventHandler(this.veículosToolStripMenuItem1_Click);
            // 
            // movimentaçãoToolStripMenuItem1
            // 
            this.movimentaçãoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendasToolStripMenuItem});
            this.movimentaçãoToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.movimentaçãoToolStripMenuItem1.Name = "movimentaçãoToolStripMenuItem1";
            this.movimentaçãoToolStripMenuItem1.Size = new System.Drawing.Size(120, 24);
            this.movimentaçãoToolStripMenuItem1.Text = "Movimentação";
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.vendasToolStripMenuItem.Text = "Vendas";
            this.vendasToolStripMenuItem.Click += new System.EventHandler(this.vendasToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(162)))), ((int)(((byte)(134)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1028, 46);
            this.panel2.TabIndex = 24;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PC2.WinApplication.Properties.Resources.multimarcas_logo;
            this.pictureBox3.Location = new System.Drawing.Point(290, 304);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(445, 108);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PC2.WinApplication.Properties.Resources._180160394;
            this.pictureBox1.Location = new System.Drawing.Point(123, 419);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(779, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PC2.WinApplication.Properties.Resources.multimarcas_logo;
            this.pictureBox2.Location = new System.Drawing.Point(262, 293);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(441, 112);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 667);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MULTIMARCAS - Gestão Empresarial";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Button btnVehicle;
        private System.Windows.Forms.Button frmBuyer;
        private System.Windows.Forms.Button frmModel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saídaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modelosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ToolStripMenuItem modelosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem veículosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem veículosToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem movimentaçãoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
    }
}