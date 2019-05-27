using PC2.Domain.Concessionaire.Commands.Handlers;
using PC2.Domain.Concessionaire.Commands.Inputs.Models;
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
    public partial class frmAddModel : Form
    {
        private ModelHandler _modelHandler;

        public frmAddModel(ModelHandler modelHandler)
        {
            _modelHandler = modelHandler;
            InitializeComponent();
        }

        private void frmAddModel_Load(object sender, EventArgs e)
        {
            modelsInputBindingSource.AddNew();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            var registerModel = (ModelsInput)modelsInputBindingSource.Current;
            var message = (ConcessionaireResult)_modelHandler.Handle(registerModel);
            MessageBox.Show(message.Message.ToString(), "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
