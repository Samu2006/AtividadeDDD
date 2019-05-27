using PC2.Domain.Concessionaire.Commands.Handlers;
using PC2.Domain.Concessionaire.Commands.Inputs.Vehicles;
using PC2.Domain.Concessionaire.Commands.Results;
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
    public partial class frmAddVehicle : Form
    {
        private VehicleHandler _vehicleHandler;
        private ModelHandler _modelHandler;

        public frmAddVehicle(VehicleHandler vehicleHandler, ModelHandler modelHandler)
        {
            _vehicleHandler = vehicleHandler;
            _modelHandler = modelHandler;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var registeVehicle = (VehiclesInput)vehiclesInputBindingSource.Current;
            registeVehicle.Model = modelComboBox.SelectedValue.ToString();
            var message = (ConcessionaireResult)_vehicleHandler.Handle(registeVehicle);
            MessageBox.Show(message.Message.ToString(), "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAddVehicle_Load(object sender, EventArgs e)
        {
            modelComboBox.DisplayMember = "NameModel";
            modelComboBox.ValueMember = "Id";
            modelComboBox.DataSource = _modelHandler.List();
            modelComboBox.Refresh();



            vehiclesInputBindingSource.AddNew();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void brandLabel_Click(object sender, EventArgs e)
        {

        }

        private void brandTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void modelLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
