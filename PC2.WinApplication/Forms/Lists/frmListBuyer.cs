using PC2.Domain.Customers.Commands.Handlers;
using PC2.Domain.Customers.Commands.Inputs;
using PC2.Domain.Customers.Entities;
using PC2.Domain.Shared.Commands.Handlers;
using PC2.Domain.Shared.Commands.Inputs;
using PC2.Domain.Shared.Entities;
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
    public partial class frmListBuyer : Form
    {
        private frmAddBuyer _frmAddBuyer;
        private BuyerHandler _buyerHandler;
        private AddressHandler _addressHandler;

        public frmListBuyer(frmAddBuyer frmAddBuyer, BuyerHandler buyerHandler)
        {
            _frmAddBuyer = frmAddBuyer;
            _buyerHandler = buyerHandler;
            InitializeComponent();
        }

        public frmListBuyer(frmAddBuyer frmAddBuyer, BuyerHandler buyerHandler, AddressHandler addressHandler)
        {
            _frmAddBuyer = frmAddBuyer;
            _buyerHandler = buyerHandler;
            _addressHandler = addressHandler;
            InitializeComponent();

        }

        private void frmListBuyer_Load(object sender, EventArgs e)
        {
            listBuyerDataGridView.DataSource = /*_buyerHandler.ListBuyer();*/ListBuyers();
            listBuyerDataGridView.Refresh();


        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            _frmAddBuyer.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private IEnumerable<ListBuyer> ListBuyers()
        {
         
            var listarBuyer = (List<Buyer>)_buyerHandler.ListBuyer();
            var listHandler = new List<ListBuyer>();
            foreach (var item in listarBuyer)
            {

                listHandler.Add(new ListBuyer()
                {
                    Name = item.Name.ToString(),
                    Phone = item.Phone, 
                    City = item.Address.City,
                    State = item.Address.State,
                    ZipCode = item.Address.ZipCode,
                });
            }


            return listHandler;
        }
    }
}
