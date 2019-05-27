using PC2.WinApplication.Forms.AddsEdits;
using PC2.WinApplication.Forms.Lists;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC2.WinApplication.Forms
{
    public partial class frmPrincipal : Form
    {

        private frmListModel _frmListModel;
        private frmListBuyer _frmListBuyer;
        private frmListVehicle _frmListVehicle;
        private frmListSale _frmListSale;
        private frmAddVehicle _frmAddVehicle;
        private frmAddBuyer _frmAddBuyer;
        private frmAddModel _frmAddModel;
        private frmSale _frmSale;

        public frmPrincipal(frmListModel frmListModel, frmListBuyer frmListBuyer,
            frmListVehicle frmListVehicle, frmListSale frmListSale, frmAddVehicle frmAddVehicle,
            frmAddBuyer frmAddBuyer, frmAddModel frmAddModel, frmSale frmSale)
        {
            _frmListModel = frmListModel;
            _frmListBuyer = frmListBuyer;
            _frmListVehicle = frmListVehicle;
            _frmListSale = frmListSale;
            _frmAddVehicle = frmAddVehicle;
            _frmAddBuyer = frmAddBuyer;
            _frmAddModel = frmAddModel;
            _frmSale = frmSale;
            InitializeComponent();
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            _frmListSale.ShowDialog();
        }

        private void btnVehicle_Click(object sender, EventArgs e)
        {
            _frmListVehicle.ShowDialog();
        }

        private void frmBuyer_Click(object sender, EventArgs e)
        {
            _frmListBuyer.ShowDialog();
        }

        private void frmModel_Click(object sender, EventArgs e)
        {
            _frmListModel.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _frmAddVehicle.ShowDialog();
        }

        private void cadastroToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _frmAddBuyer.ShowDialog();
        }

        private void entradaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _frmAddVehicle.ShowDialog();
        }

        private void saídaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _frmListSale.ShowDialog();
        }

        private void estoqueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _frmListBuyer.ShowDialog();
        }

        private void modelosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _frmAddModel.ShowDialog();
        }

        private void veículosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _frmListVehicle.ShowDialog();
        }

        private void estoqueToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void veículosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            _frmAddVehicle.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frmListSale.ShowDialog();
        }
    }
}
