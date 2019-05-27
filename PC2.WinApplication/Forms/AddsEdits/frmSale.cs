using PC2.Domain.Concessionaire.Commands.Handlers;
using PC2.Domain.Concessionaire.Commands.Inputs.VehiclesSales;
using PC2.Domain.Concessionaire.Commands.Results;
using PC2.Domain.Concessionaire.Entities;
using PC2.Domain.Customers.Commands.Handlers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC2.WinApplication.Forms.AddsEdits
{
    public partial class frmSale : Form
    {
        private VehicleSalesHandler _salesHandler;
        private VehicleHandler _vehicleHandler;
        private BuyerHandler _buyerHandler;
        private Vehicle _vehicle;

        public frmSale(VehicleSalesHandler salesHandler, VehicleHandler vehicleHandler, BuyerHandler buyerHandler)
        {
            _salesHandler = salesHandler;
            _vehicleHandler = vehicleHandler;
            _buyerHandler = buyerHandler;
            InitializeComponent();
        }

        public frmSale(VehicleSalesHandler salesHandler, VehicleHandler vehicleHandler,
            BuyerHandler buyerHandler, Vehicle vehicle)
        {
            _salesHandler = salesHandler;
            _vehicleHandler = vehicleHandler;
            _buyerHandler = buyerHandler;
            _vehicle = vehicle;
            InitializeComponent();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
          
            var registeSale = (VehicleSalesInput)vehicleSalesInputBindingSource.Current;
            registeSale.Buyer = buyerComboBox.SelectedValue.ToString();
            registeSale.Color = colorComboBox.SelectedValue.ToString();
            registeSale.Vehicle = vehicleComboBox.SelectedValue.ToString();
            var message = (ConcessionaireResult)_salesHandler.Handle(registeSale);
            
            MessageBox.Show(message.Message.ToString(), "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmSale_Load(object sender, EventArgs e)
        {
            vehicleSalesInputBindingSource.AddNew();
            buyerComboBox.DisplayMember = "Buyer";
            buyerComboBox.ValueMember = "Id";
            buyerComboBox.DataSource = _buyerHandler.ListBuyer();
            

            vehicleComboBox.DisplayMember = "Vehicle";
            vehicleComboBox.ValueMember = "Id";
            vehicleComboBox.DataSource = _vehicleHandler.ListVehicle();
            vehicleComboBox.Refresh();
            

            //versionComboBox.DataSource = _vehicleHandler.HandlerListByModel(_vehicle.ModelId);

            colorComboBox.DisplayMember = "Color";
            colorComboBox.ValueMember = "Id";
            colorComboBox.DataSource = _vehicleHandler.HandlerListByModel();

            //colorComboBox.DataSource = _vehicleHandler.HandlerListByModel(_vehicle.Model.Id);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
