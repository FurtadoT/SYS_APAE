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
    public partial class InstructorDetail : Form
    {
        private Instructor instructorToEdit;

        public InstructorDetail(string id)
        {
            InitializeComponent();
            this.CenterToScreen();

            instructorToEdit = InstructorDTO.getInstructorById(new Dictionary<string, string> { { "id", id } });
            setFields();
            setLabels();
        }

        private void setFields()
        {
            txtName.Text = instructorToEdit.Name;
            txtEmail.Text = instructorToEdit.Email;
            txtCPF.Text = instructorToEdit.Cpf;
            txtProntuarioInstructor.Text = instructorToEdit.Prontuario;
            txtTipoInstructor.Text = instructorToEdit.Tipo_monitor;
            txtCargaInstructor.Value = instructorToEdit.Carga_horaria;
            txtCargaInstructor.Text = instructorToEdit.Carga_horaria.ToString();

            txtName.ErrorMessage = String.Empty;
            txtEmail.ErrorMessage = String.Empty;
            txtCPF.ErrorMessage = String.Empty;
            txtProntuarioInstructor.ErrorMessage = String.Empty;
            txtTipoInstructor.ErrorMessage = String.Empty;
        }

        private void setLabels()
        {
            lblName.Text = instructorToEdit.Name;
            lblId.Text = instructorToEdit.Id.ToString();
            lblCreated.Text = instructorToEdit.Dt_created.ToString("dd/MM/yyyy");
            lblEmail.Text = instructorToEdit.Email;
        }

        private bool _validateFields()
        {
            if (txtName.Text == String.Empty)
                txtName.ErrorMessage = "*requerido";

            if (txtEmail.Text == String.Empty)
                txtEmail.ErrorMessage = "*requerido";

            if (txtProntuarioInstructor.Text == String.Empty || !txtProntuarioInstructor.MaskCompleted)
                txtProntuarioInstructor.ErrorMessage = "*requerido";

            if (txtCPF.Text == String.Empty || !txtCPF.MaskCompleted)
                txtCPF.ErrorMessage = "*requerido";

            if (txtTipoInstructor.Text == String.Empty)
                txtTipoInstructor.ErrorMessage = "*requerido";

            return (txtName.Text != String.Empty && txtEmail.Text != String.Empty &&
                (txtProntuarioInstructor.Text != String.Empty && txtProntuarioInstructor.MaskCompleted) &&
                (txtCPF.Text != String.Empty && txtCPF.MaskCompleted) && txtTipoInstructor.Text != String.Empty);
        }

        private bool UpdateInstructor()
        {
            Instructor newInstructor = new Instructor(
                instructorToEdit.Id,
                txtName.Text,
                txtCPF.Text,
                instructorToEdit.Password,
                txtEmail.Text,
                txtProntuarioInstructor.Text,
                txtTipoInstructor.Text,
                Convert.ToInt32(txtCargaInstructor.Value),
                instructorToEdit.Dt_created
                );

            if (InstructorDTO.UpdateInstructor(newInstructor))
            {
                this.instructorToEdit = newInstructor;
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
            if (_validateFields() && UpdateInstructor())
            {
                MessageBox.Show("Monitor alterado com sucesso!");
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
