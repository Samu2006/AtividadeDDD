using PC2.Domain.Concessionaire.Commands.Handlers;
using PC2.Domain.Concessionaire.Commands.Inputs.Vehicles;
using PC2.Domain.Concessionaire.Entities;
using PC2.Domain.Customers.Commands.Inputs;
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
    public partial class frmListVehicle : Form
    {
        private VehicleHandler _vehicleHandler;
        private frmAddVehicle _frmAddVehicle;


        public frmListVehicle(VehicleHandler vehicleHandler, frmAddVehicle frmAddVehicle)
        {
            _vehicleHandler = vehicleHandler;
            _frmAddVehicle = frmAddVehicle;
            InitializeComponent();
        }

        private void frmListVehicle_Load(object sender, EventArgs e)
        {
            listVehicleDataGridView.DataSource = ListVehicles(); /*_vehicleHandler.ListVehicle();*/
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            _frmAddVehicle.ShowDialog();
        }

        private IEnumerable<ListVehicle> ListVehicles()
        {

            var listarVehicle = (List<Vehicle>)_vehicleHandler.ListVehicle();
            var listHandler = new List<ListVehicle>();
            foreach (var item in listarVehicle)
            {

                listHandler.Add(new ListVehicle()
                {

                    NameModel = item.Model.ToString(),
                    Version = item.Version,
                    Brand = item.Brand,
                    Year = item.Year,
                    YearFabrication = item.YearFabrication,
                    Color = item.Color,
                    Renavan = item.Renavan
                });
            }


            return listHandler;
        }
    }
}
