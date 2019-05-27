namespace PC2.WinApplication.Forms.AddsEdits
{
    partial class frmSale
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
            System.Windows.Forms.Label buyerLabel;
            System.Windows.Forms.Label colorLabel;
            System.Windows.Forms.Label inputDateLabel;
            System.Windows.Forms.Label inputPriceLabel;
            System.Windows.Forms.Label inputValueLabel;
            System.Windows.Forms.Label licensePlateLabel;
            System.Windows.Forms.Label noteLabel;
            System.Windows.Forms.Label yearLabel;
            System.Windows.Forms.Label yearFabricationLabel;
            System.Windows.Forms.Label vehicleLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.inputDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.buyerComboBox = new System.Windows.Forms.ComboBox();
            this.colorComboBox = new System.Windows.Forms.ComboBox();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.yearFabricationTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.vehicleSalesInputBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehicleComboBox = new System.Windows.Forms.ComboBox();
            buyerLabel = new System.Windows.Forms.Label();
            colorLabel = new System.Windows.Forms.Label();
            inputDateLabel = new System.Windows.Forms.Label();
            inputPriceLabel = new System.Windows.Forms.Label();
            inputValueLabel = new System.Windows.Forms.Label();
            licensePlateLabel = new System.Windows.Forms.Label();
            noteLabel = new System.Windows.Forms.Label();
            yearLabel = new System.Windows.Forms.Label();
            yearFabricationLabel = new System.Windows.Forms.Label();
            vehicleLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleSalesInputBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buyerLabel
            // 
            buyerLabel.AutoSize = true;
            buyerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buyerLabel.Location = new System.Drawing.Point(21, 103);
            buyerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            buyerLabel.Name = "buyerLabel";
            buyerLabel.Size = new System.Drawing.Size(61, 20);
            buyerLabel.TabIndex = 28;
            buyerLabel.Text = "Cliente";
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            colorLabel.Location = new System.Drawing.Point(319, 290);
            colorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new System.Drawing.Size(36, 20);
            colorLabel.TabIndex = 30;
            colorLabel.Text = "Cor";
            // 
            // inputDateLabel
            // 
            inputDateLabel.AutoSize = true;
            inputDateLabel.ForeColor = System.Drawing.Color.White;
            inputDateLabel.Location = new System.Drawing.Point(299, 17);
            inputDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            inputDateLabel.Name = "inputDateLabel";
            inputDateLabel.Size = new System.Drawing.Size(28, 17);
            inputDateLabel.TabIndex = 32;
            inputDateLabel.Text = "Em";
            // 
            // inputPriceLabel
            // 
            inputPriceLabel.AutoSize = true;
            inputPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            inputPriceLabel.Location = new System.Drawing.Point(21, 235);
            inputPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            inputPriceLabel.Name = "inputPriceLabel";
            inputPriceLabel.Size = new System.Drawing.Size(53, 20);
            inputPriceLabel.TabIndex = 34;
            inputPriceLabel.Text = "Preço";
            // 
            // inputValueLabel
            // 
            inputValueLabel.AutoSize = true;
            inputValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            inputValueLabel.Location = new System.Drawing.Point(319, 235);
            inputValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            inputValueLabel.Name = "inputValueLabel";
            inputValueLabel.Size = new System.Drawing.Size(134, 20);
            inputValueLabel.TabIndex = 36;
            inputValueLabel.Text = "Valor de Entrada";
            // 
            // licensePlateLabel
            // 
            licensePlateLabel.AutoSize = true;
            licensePlateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            licensePlateLabel.Location = new System.Drawing.Point(21, 290);
            licensePlateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            licensePlateLabel.Name = "licensePlateLabel";
            licensePlateLabel.Size = new System.Drawing.Size(51, 20);
            licensePlateLabel.TabIndex = 38;
            licensePlateLabel.Text = "Placa";
            // 
            // noteLabel
            // 
            noteLabel.AutoSize = true;
            noteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            noteLabel.Location = new System.Drawing.Point(24, 423);
            noteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            noteLabel.Name = "noteLabel";
            noteLabel.Size = new System.Drawing.Size(108, 20);
            noteLabel.TabIndex = 42;
            noteLabel.Text = "Observações";
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            yearLabel.Location = new System.Drawing.Point(21, 345);
            yearLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new System.Drawing.Size(38, 20);
            yearLabel.TabIndex = 46;
            yearLabel.Text = "Ano";
            // 
            // yearFabricationLabel
            // 
            yearFabricationLabel.AutoSize = true;
            yearFabricationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            yearFabricationLabel.Location = new System.Drawing.Point(161, 345);
            yearFabricationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            yearFabricationLabel.Name = "yearFabricationLabel";
            yearFabricationLabel.Size = new System.Drawing.Size(126, 20);
            yearFabricationLabel.TabIndex = 48;
            yearFabricationLabel.Text = "Ano Fabricação";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.inputDateDateTimePicker);
            this.panel1.Controls.Add(inputDateLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 89);
            this.panel1.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 44);
            this.label1.TabIndex = 28;
            this.label1.Text = "Vendas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // inputDateDateTimePicker
            // 
            this.inputDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vehicleSalesInputBindingSource, "InputDate", true));
            this.inputDateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputDateDateTimePicker.Location = new System.Drawing.Point(301, 38);
            this.inputDateDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputDateDateTimePicker.Name = "inputDateDateTimePicker";
            this.inputDateDateTimePicker.Size = new System.Drawing.Size(284, 24);
            this.inputDateDateTimePicker.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(162)))), ((int)(((byte)(134)))));
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 563);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(612, 57);
            this.panel2.TabIndex = 27;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Image = global::PC2.WinApplication.Properties.Resources.x1;
            this.btnCancel.Location = new System.Drawing.Point(509, 6);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(60, 46);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::PC2.WinApplication.Properties.Resources.check1;
            this.btnSave.Location = new System.Drawing.Point(411, 6);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(60, 46);
            this.btnSave.TabIndex = 0;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // buyerComboBox
            // 
            this.buyerComboBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buyerComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleSalesInputBindingSource, "Buyer", true));
            this.buyerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.buyerComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyerComboBox.FormattingEnabled = true;
            this.buyerComboBox.Location = new System.Drawing.Point(21, 126);
            this.buyerComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buyerComboBox.Name = "buyerComboBox";
            this.buyerComboBox.Size = new System.Drawing.Size(333, 28);
            this.buyerComboBox.TabIndex = 29;
            // 
            // colorComboBox
            // 
            this.colorComboBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.colorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleSalesInputBindingSource, "Color", true));
            this.colorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorComboBox.FormattingEnabled = true;
            this.colorComboBox.Location = new System.Drawing.Point(319, 311);
            this.colorComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.colorComboBox.Name = "colorComboBox";
            this.colorComboBox.Size = new System.Drawing.Size(231, 28);
            this.colorComboBox.TabIndex = 31;
            // 
            // noteTextBox
            // 
            this.noteTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.noteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleSalesInputBindingSource, "Note", true));
            this.noteTextBox.Location = new System.Drawing.Point(24, 446);
            this.noteTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.noteTextBox.Multiline = true;
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.Size = new System.Drawing.Size(561, 93);
            this.noteTextBox.TabIndex = 43;
            // 
            // yearTextBox
            // 
            this.yearTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.yearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleSalesInputBindingSource, "Year", true));
            this.yearTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearTextBox.Location = new System.Drawing.Point(21, 367);
            this.yearTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(119, 27);
            this.yearTextBox.TabIndex = 47;
            // 
            // yearFabricationTextBox
            // 
            this.yearFabricationTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.yearFabricationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleSalesInputBindingSource, "YearFabrication", true));
            this.yearFabricationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearFabricationTextBox.Location = new System.Drawing.Point(168, 367);
            this.yearFabricationTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.yearFabricationTextBox.Name = "yearFabricationTextBox";
            this.yearFabricationTextBox.Size = new System.Drawing.Size(119, 27);
            this.yearFabricationTextBox.TabIndex = 49;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(162)))), ((int)(((byte)(134)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 89);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(612, 7);
            this.panel3.TabIndex = 50;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(162)))), ((int)(((byte)(134)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 89);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(612, 7);
            this.panel4.TabIndex = 50;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.maskedTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleSalesInputBindingSource, "LicensePlate", true));
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(21, 313);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maskedTextBox1.Mask = "AAA-9999";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(224, 27);
            this.maskedTextBox1.TabIndex = 51;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleSalesInputBindingSource, "InputPrice", true));
            this.maskedTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox2.Location = new System.Drawing.Point(21, 260);
            this.maskedTextBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(224, 27);
            this.maskedTextBox2.TabIndex = 52;
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleSalesInputBindingSource, "InputValue", true));
            this.maskedTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox3.Location = new System.Drawing.Point(319, 260);
            this.maskedTextBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(231, 27);
            this.maskedTextBox3.TabIndex = 53;
            // 
            // vehicleSalesInputBindingSource
            // 
            this.vehicleSalesInputBindingSource.DataSource = typeof(PC2.Domain.Concessionaire.Commands.Inputs.VehiclesSales.VehicleSalesInput);
            // 
            // vehicleLabel
            // 
            vehicleLabel.AutoSize = true;
            vehicleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            vehicleLabel.Location = new System.Drawing.Point(25, 164);
            vehicleLabel.Name = "vehicleLabel";
            vehicleLabel.Size = new System.Drawing.Size(69, 20);
            vehicleLabel.TabIndex = 54;
            vehicleLabel.Text = "Vehicle:";
            // 
            // vehicleComboBox
            // 
            this.vehicleComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleSalesInputBindingSource, "Vehicle", true));
            this.vehicleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vehicleComboBox.FormattingEnabled = true;
            this.vehicleComboBox.Location = new System.Drawing.Point(28, 188);
            this.vehicleComboBox.Name = "vehicleComboBox";
            this.vehicleComboBox.Size = new System.Drawing.Size(452, 24);
            this.vehicleComboBox.TabIndex = 55;
            // 
            // frmSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(612, 620);
            this.Controls.Add(vehicleLabel);
            this.Controls.Add(this.vehicleComboBox);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(buyerLabel);
            this.Controls.Add(this.buyerComboBox);
            this.Controls.Add(colorLabel);
            this.Controls.Add(this.colorComboBox);
            this.Controls.Add(inputPriceLabel);
            this.Controls.Add(inputValueLabel);
            this.Controls.Add(licensePlateLabel);
            this.Controls.Add(noteLabel);
            this.Controls.Add(this.noteTextBox);
            this.Controls.Add(yearLabel);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(yearFabricationLabel);
            this.Controls.Add(this.yearFabricationTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmSale";
            this.Text = "in";
            this.Load += new System.EventHandler(this.frmSale_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vehicleSalesInputBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource vehicleSalesInputBindingSource;
        private System.Windows.Forms.ComboBox buyerComboBox;
        private System.Windows.Forms.ComboBox colorComboBox;
        private System.Windows.Forms.DateTimePicker inputDateDateTimePicker;
        private System.Windows.Forms.TextBox noteTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox yearFabricationTextBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.ComboBox vehicleComboBox;
    }
}