using PC2.Domain.Customers.Commands.Handlers;
using PC2.Domain.Customers.Commands.Inputs;
using PC2.Domain.Customers.Commands.Results;
using PC2.Domain.Customers.Enums;
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
    public partial class frmAddBuyer : Form
    {
        private BuyerHandler _buyerHandler;

        public frmAddBuyer(BuyerHandler buyerHandler)
        {
            _buyerHandler = buyerHandler;
            InitializeComponent();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var registeVehicle = (BuyerInput)buyerInputBindingSource.Current;
            var message = (CustomerResult)_buyerHandler.Handle(registeVehicle);
            MessageBox.Show(message.Message.ToString(), "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAddBuyer_Load(object sender, EventArgs e)
        {
            buyerInputBindingSource.AddNew();


            genderComboBox.DisplayMember = "Description";
            genderComboBox.ValueMember = "value";
            genderComboBox.DataSource = Enum.GetValues(typeof(EGender))

.Cast<Enum>().ToList();
//.Select(value => new
//{
//    (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute))
//as DescriptionAttribute).Description,
//    value
//}).ToList();

        }

        private void numberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void genderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
