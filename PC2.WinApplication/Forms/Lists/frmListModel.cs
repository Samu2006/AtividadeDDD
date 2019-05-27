using PC2.Domain.Concessionaire.Commands.Handlers;
using PC2.WinApplication.Forms.AddsEdits;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC2.WinApplication.Forms.Lists
{
    public partial class frmListModel : Form
    {
        private frmAddModel _frmAddModel;
        private ModelHandler _modelHandler;

        public frmListModel(frmAddModel frmAddModel, ModelHandler modelHandler)
        {
            _frmAddModel = frmAddModel;
            _modelHandler = modelHandler;
            InitializeComponent();

        }

        private void frmListModel_Load(object sender, EventArgs e)
        {
            listModelDataGridView.DataSource = _modelHandler.List();
            listModelDataGridView.Refresh();
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            _frmAddModel.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
