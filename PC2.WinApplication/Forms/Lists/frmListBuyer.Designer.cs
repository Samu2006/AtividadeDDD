namespace PC2.WinApplication.Forms.Lists
{
    partial class frmListBuyer
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
            this.listBuyerDataGridView = new System.Windows.Forms.DataGridView();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvZipCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBuyerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.bntAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listBuyerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBuyerBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBuyerDataGridView
            // 
            this.listBuyerDataGridView.AutoGenerateColumns = false;
            this.listBuyerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listBuyerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvName,
            this.dgvPhone,
            this.dgvCity,
            this.dgvState,
            this.dgvZipCode});
            this.listBuyerDataGridView.DataSource = this.listBuyerBindingSource;
            this.listBuyerDataGridView.Location = new System.Drawing.Point(34, 152);
            this.listBuyerDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.listBuyerDataGridView.Name = "listBuyerDataGridView";
            this.listBuyerDataGridView.Size = new System.Drawing.Size(998, 271);
            this.listBuyerDataGridView.TabIndex = 6;
            // 
            // dgvName
            // 
            this.dgvName.DataPropertyName = "Name";
            this.dgvName.HeaderText = "Nome";
            this.dgvName.Name = "dgvName";
            this.dgvName.Width = 150;
            // 
            // dgvPhone
            // 
            this.dgvPhone.DataPropertyName = "Phone";
            this.dgvPhone.HeaderText = "Telefone";
            this.dgvPhone.Name = "dgvPhone";
            this.dgvPhone.ReadOnly = true;
            // 
            // dgvCity
            // 
            this.dgvCity.DataPropertyName = "City";
            this.dgvCity.HeaderText = "Cidade";
            this.dgvCity.Name = "dgvCity";
            this.dgvCity.ReadOnly = true;
            this.dgvCity.Width = 200;
            // 
            // dgvState
            // 
            this.dgvState.DataPropertyName = "State";
            this.dgvState.HeaderText = "Estado";
            this.dgvState.Name = "dgvState";
            this.dgvState.ReadOnly = true;
            // 
            // dgvZipCode
            // 
            this.dgvZipCode.DataPropertyName = "ZipCode";
            this.dgvZipCode.HeaderText = "CEP";
            this.dgvZipCode.Name = "dgvZipCode";
            this.dgvZipCode.ReadOnly = true;
            this.dgvZipCode.Width = 150;
            // 
            // listBuyerBindingSource
            // 
            this.listBuyerBindingSource.DataSource = typeof(PC2.Domain.Customers.Commands.Inputs.ListBuyer);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 90);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clientes";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(162)))), ((int)(((byte)(134)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1067, 7);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.bntAdd);
            this.panel3.Controls.Add(this.btnEdit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 489);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1067, 65);
            this.panel3.TabIndex = 9;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Image = global::PC2.WinApplication.Properties.Resources.x1;
            this.btnCancel.Location = new System.Drawing.Point(969, 6);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(60, 50);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // bntAdd
            // 
            this.bntAdd.FlatAppearance.BorderSize = 0;
            this.bntAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntAdd.Image = global::PC2.WinApplication.Properties.Resources.adicionar_;
            this.bntAdd.Location = new System.Drawing.Point(811, 6);
            this.bntAdd.Margin = new System.Windows.Forms.Padding(4);
            this.bntAdd.Name = "bntAdd";
            this.bntAdd.Size = new System.Drawing.Size(60, 50);
            this.bntAdd.TabIndex = 3;
            this.bntAdd.UseVisualStyleBackColor = true;
            this.bntAdd.Click += new System.EventHandler(this.bntAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Image = global::PC2.WinApplication.Properties.Resources.editar_2;
            this.btnEdit.Location = new System.Drawing.Point(890, 6);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(60, 50);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // frmListBuyer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBuyerDataGridView);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmListBuyer";
            this.Text = "frmListBuyer";
            this.Load += new System.EventHandler(this.frmListBuyer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listBuyerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBuyerBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button bntAdd;
        private System.Windows.Forms.BindingSource listBuyerBindingSource;
        private System.Windows.Forms.DataGridView listBuyerDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvState;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvZipCode;
    }
}