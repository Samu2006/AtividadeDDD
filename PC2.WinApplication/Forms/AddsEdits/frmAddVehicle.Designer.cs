namespace PC2.WinApplication.Forms.AddsEdits
{
    partial class frmAddVehicle
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label brandLabel;
            System.Windows.Forms.Label colorLabel;
            System.Windows.Forms.Label modelLabel;
            System.Windows.Forms.Label renavanLabel;
            System.Windows.Forms.Label versionLabel;
            System.Windows.Forms.Label yearLabel;
            System.Windows.Forms.Label yearFabricationLabel;
            this.brandTextBox = new System.Windows.Forms.TextBox();
            this.vehiclesInputBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.modelComboBox = new System.Windows.Forms.ComboBox();
            this.renavanTextBox = new System.Windows.Forms.TextBox();
            this.versionTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.yearFabricationTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            brandLabel = new System.Windows.Forms.Label();
            colorLabel = new System.Windows.Forms.Label();
            modelLabel = new System.Windows.Forms.Label();
            renavanLabel = new System.Windows.Forms.Label();
            versionLabel = new System.Windows.Forms.Label();
            yearLabel = new System.Windows.Forms.Label();
            yearFabricationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesInputBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // brandLabel
            // 
            brandLabel.AutoSize = true;
            brandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            brandLabel.Location = new System.Drawing.Point(20, 131);
            brandLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            brandLabel.Name = "brandLabel";
            brandLabel.Size = new System.Drawing.Size(56, 20);
            brandLabel.TabIndex = 21;
            brandLabel.Text = "Marca";
            brandLabel.Click += new System.EventHandler(this.brandLabel_Click);
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            colorLabel.Location = new System.Drawing.Point(498, 204);
            colorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new System.Drawing.Size(36, 20);
            colorLabel.TabIndex = 23;
            colorLabel.Text = "Cor";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            modelLabel.Location = new System.Drawing.Point(251, 131);
            modelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(63, 20);
            modelLabel.TabIndex = 25;
            modelLabel.Text = "Modelo";
            modelLabel.Click += new System.EventHandler(this.modelLabel_Click);
            // 
            // renavanLabel
            // 
            renavanLabel.AutoSize = true;
            renavanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            renavanLabel.Location = new System.Drawing.Point(251, 274);
            renavanLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            renavanLabel.Name = "renavanLabel";
            renavanLabel.Size = new System.Drawing.Size(91, 20);
            renavanLabel.TabIndex = 27;
            renavanLabel.Text = "RENAVAM";
            // 
            // versionLabel
            // 
            versionLabel.AutoSize = true;
            versionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            versionLabel.Location = new System.Drawing.Point(498, 131);
            versionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            versionLabel.Name = "versionLabel";
            versionLabel.Size = new System.Drawing.Size(62, 20);
            versionLabel.TabIndex = 29;
            versionLabel.Text = "Versão";
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            yearLabel.Location = new System.Drawing.Point(251, 204);
            yearLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new System.Drawing.Size(97, 20);
            yearLabel.TabIndex = 31;
            yearLabel.Text = "Ano Modelo";
            // 
            // yearFabricationLabel
            // 
            yearFabricationLabel.AutoSize = true;
            yearFabricationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            yearFabricationLabel.Location = new System.Drawing.Point(20, 204);
            yearFabricationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            yearFabricationLabel.Name = "yearFabricationLabel";
            yearFabricationLabel.Size = new System.Drawing.Size(126, 20);
            yearFabricationLabel.TabIndex = 33;
            yearFabricationLabel.Text = "Ano Fabricação";
            // 
            // brandTextBox
            // 
            this.brandTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.brandTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiclesInputBindingSource, "Brand", true));
            this.brandTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandTextBox.Location = new System.Drawing.Point(20, 155);
            this.brandTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.Size = new System.Drawing.Size(195, 27);
            this.brandTextBox.TabIndex = 22;
            this.brandTextBox.TextChanged += new System.EventHandler(this.brandTextBox_TextChanged);
            // 
            // vehiclesInputBindingSource
            // 
            this.vehiclesInputBindingSource.DataSource = typeof(PC2.Domain.Concessionaire.Commands.Inputs.Vehicles.VehiclesInput);
            // 
            // colorTextBox
            // 
            this.colorTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.colorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiclesInputBindingSource, "Color", true));
            this.colorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorTextBox.Location = new System.Drawing.Point(498, 230);
            this.colorTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(211, 27);
            this.colorTextBox.TabIndex = 24;
            // 
            // modelComboBox
            // 
            this.modelComboBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.modelComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiclesInputBindingSource, "Model", true));
            this.modelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modelComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelComboBox.FormattingEnabled = true;
            this.modelComboBox.Location = new System.Drawing.Point(251, 154);
            this.modelComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.modelComboBox.Name = "modelComboBox";
            this.modelComboBox.Size = new System.Drawing.Size(212, 28);
            this.modelComboBox.TabIndex = 26;
            // 
            // renavanTextBox
            // 
            this.renavanTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.renavanTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiclesInputBindingSource, "Renavan", true));
            this.renavanTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renavanTextBox.Location = new System.Drawing.Point(251, 300);
            this.renavanTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.renavanTextBox.Name = "renavanTextBox";
            this.renavanTextBox.Size = new System.Drawing.Size(212, 27);
            this.renavanTextBox.TabIndex = 28;
            // 
            // versionTextBox
            // 
            this.versionTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.versionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiclesInputBindingSource, "Version", true));
            this.versionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionTextBox.Location = new System.Drawing.Point(498, 155);
            this.versionTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.versionTextBox.Name = "versionTextBox";
            this.versionTextBox.Size = new System.Drawing.Size(310, 27);
            this.versionTextBox.TabIndex = 30;
            // 
            // yearTextBox
            // 
            this.yearTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.yearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiclesInputBindingSource, "Year", true));
            this.yearTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearTextBox.Location = new System.Drawing.Point(251, 230);
            this.yearTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(147, 27);
            this.yearTextBox.TabIndex = 32;
            // 
            // yearFabricationTextBox
            // 
            this.yearFabricationTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.yearFabricationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiclesInputBindingSource, "YearFabrication", true));
            this.yearFabricationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearFabricationTextBox.Location = new System.Drawing.Point(20, 230);
            this.yearFabricationTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.yearFabricationTextBox.Name = "yearFabricationTextBox";
            this.yearFabricationTextBox.Size = new System.Drawing.Size(130, 27);
            this.yearFabricationTextBox.TabIndex = 34;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiclesInputBindingSource, "Renavan", true));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(20, 300);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 27);
            this.textBox1.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Placa";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(162)))), ((int)(((byte)(134)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 89);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(771, 7);
            this.panel3.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 44);
            this.label2.TabIndex = 29;
            this.label2.Text = "Cadastro de Veículos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(835, 89);
            this.panel2.TabIndex = 20;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(162)))), ((int)(((byte)(134)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::PC2.WinApplication.Properties.Resources.check1;
            this.btnSave.Location = new System.Drawing.Point(639, 2);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(60, 45);
            this.btnSave.TabIndex = 0;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(162)))), ((int)(((byte)(134)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = global::PC2.WinApplication.Properties.Resources.x1;
            this.btnCancel.Location = new System.Drawing.Point(742, 2);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(60, 45);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(162)))), ((int)(((byte)(134)))));
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 376);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 55);
            this.panel1.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(162)))), ((int)(((byte)(134)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 89);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(835, 7);
            this.panel4.TabIndex = 37;
            // 
            // frmAddVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(835, 431);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(brandLabel);
            this.Controls.Add(this.brandTextBox);
            this.Controls.Add(colorLabel);
            this.Controls.Add(this.colorTextBox);
            this.Controls.Add(modelLabel);
            this.Controls.Add(this.modelComboBox);
            this.Controls.Add(renavanLabel);
            this.Controls.Add(this.renavanTextBox);
            this.Controls.Add(versionLabel);
            this.Controls.Add(this.versionTextBox);
            this.Controls.Add(yearLabel);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(yearFabricationLabel);
            this.Controls.Add(this.yearFabricationTextBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmAddVehicle";
            this.Text = "Cadastro de Veículos";
            this.Load += new System.EventHandler(this.frmAddVehicle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesInputBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource vehiclesInputBindingSource;
        private System.Windows.Forms.TextBox brandTextBox;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.ComboBox modelComboBox;
        private System.Windows.Forms.TextBox renavanTextBox;
        private System.Windows.Forms.TextBox versionTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox yearFabricationTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
    }
}