using PC2.Domain.Concessionaire.Commands.Handlers;
using PC2.Domain.Concessionaire.Commands.Inputs.VehiclesSales;
using PC2.Domain.Concessionaire.Entities;
using PC2.Domain.Customers.Commands.Handlers;
using PC2.Domain.Customers.Entities;
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
    public partial class frmListSale : Form
    {
        private frmSale _frmSale;
        private VehicleSalesHandler _salesHandler;


        public frmListSale(frmSale frmSale, VehicleSalesHandler salesHandler)
        {
            _frmSale = frmSale;
            _salesHandler = salesHandler;
            InitializeComponent();
            
        }


        private void bntAdd_Click(object sender, EventArgs e)
        {
            _frmSale.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void frmListSale_Load(object sender, EventArgs e)
        {
            listVehicleSaleDataGridView.DataSource = ListSales();
        }

        private IEnumerable<ListVehicleSale> ListSales()
        {

            var listarSale = (List<VehicleSales>)_salesHandler.ListSales();
            var listHandler = new List<ListVehicleSale>();
            foreach (var item in listarSale)
            {

                listHandler.Add(new ListVehicleSale()
                {

                    Version = item.Vehicle.Version,
                    //Renavam = item.Vehicle.Renavan,
                    Color = item.Vehicle.Color,
                    Note = item.Note,
                    Name = item.Buyer.ToString(),
                    InputPrice = item.InputPrice,
                    InputDate = item.InputDate,
                    LicensePlate = item.LicensePlate,

                });
            }
            return listHandler;

        }

    }
}

