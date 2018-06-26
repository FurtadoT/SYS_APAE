using SYS_APAE.SYS_APAE.Data;
using SYS_APAE.SYS_APAE.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYS_APAE.SYS_APAE.View
{
    public partial class ActivityDetail : Form
    {
        private Activity activityToEdit;

        public ActivityDetail(string id)
        {
            InitializeComponent();
            this.CenterToScreen();

            activityToEdit = ActivityDTO.getActivities(new Dictionary<string, string> { { "id", id } })[0];
            setFields();
            setLabels();
        }

        private bool _validateFields()
        {
            if (txtTitleActivity.Text == String.Empty)
                txtTitleActivity.ErrorMessage = "*requerido";

            return (txtTitleActivity.Text != String.Empty);
        }

        private void setFields()
        {
            txtTitleActivity.Text = activityToEdit.Title;
            txtDescriptionActivity.Text = activityToEdit.Description;
        }

        private void setLabels()
        {
            lblId.Text = activityToEdit.Id.ToString();
            lblCreated.Text = activityToEdit.Dt_created.ToString("dd/MM/yyyy");
        }

        private bool UpdateActivity()
        {
            Activity newActivity = new Activity(
                activityToEdit.Id,
                txtTitleActivity.Text,
                txtDescriptionActivity.Text,
                activityToEdit.Dt_created
                );

            if (ActivityDTO.UpdateActivity(newActivity))
            {
                this.activityToEdit = newActivity;
                return true;
            }

            return false;
        }

        private void _handlerRefresh()
        {
            setLabels();
        }

        private void pnlSave_Click(object sender, EventArgs e)
        {
            btnSave_Click(sender, e);
        }

        private void lblSave_Click(object sender, EventArgs e)
        {
            btnSave_Click(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            lblSave.Focus();
            if (_validateFields() && UpdateActivity())
            {
                MessageBox.Show("Atividade alterada com sucesso!");
                _handlerRefresh();
            }
        }

        private void pnlSave_MouseEnter(object sender, EventArgs e)
        {
            btnSave_MouseEnter(sender, e);
        }

        private void lblSave_MouseEnter(object sender, EventArgs e)
        {
            btnSave_MouseEnter(sender, e);
        }

        private void btnSave_MouseEnter(object sender, EventArgs e)
        {
            pnlSave.BackColor = SystemColors.ControlLightLight;
        }

        private void pnlSave_MouseLeave(object sender, EventArgs e)
        {
            btnSave_MouseLeave(sender, e);
        }

        private void lblSave_MouseLeave(object sender, EventArgs e)
        {
            btnSave_MouseLeave(sender, e);
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            pnlSave.BackColor = SystemColors.Control;
        }

        private void pnlCancel_Click(object sender, EventArgs e)
        {
            btnCancel_Click(sender, e);
        }

        private void lblCancel_Click(object sender, EventArgs e)
        {
            btnCancel_Click(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            setFields();
        }

        private void pnlCancel_MouseEnter(object sender, EventArgs e)
        {
            btnCancel_MouseEnter(sender, e);
        }

        private void lblCancel_MouseEnter(object sender, EventArgs e)
        {
            btnCancel_MouseEnter(sender, e);
        }

        private void btnCancel_MouseEnter(object sender, EventArgs e)
        {
            pnlCancel.BackColor = SystemColors.ControlLightLight;
        }

        private void pnlCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancel_MouseLeave(sender, e);
        }

        private void lblCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancel_MouseLeave(sender, e);
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            pnlCancel.BackColor = SystemColors.Control;
        }
    }
}
