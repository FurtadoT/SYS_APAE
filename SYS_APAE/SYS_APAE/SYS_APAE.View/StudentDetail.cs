using SYS_APAE.SYS_APAE.Data;
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
    public partial class StudentDetail : Form
    {
        private Student studentToEdit;

        public StudentDetail(string id)
        {
            InitializeComponent();
            this.CenterToScreen();

            studentToEdit = StudentsDTO.getStudents(new Dictionary<string, string> { { "id", id } })[0];
            setFields();
            setLabels();
        }

        private void setFields()
        {
            txtName.Text = studentToEdit.Name;
            txtNaturalidade.Text = studentToEdit.Nationality;
            txtEmail.Text = studentToEdit.Email;
            txtCPF.Text = studentToEdit.Cpf;
            txtRG.Text = studentToEdit.Rg;
            txtOrgExp.Text = studentToEdit.Org_exp;
            txtMae.Text = studentToEdit.Mother_name;
            txtPai.Text = studentToEdit.Father_name;
            txtCep.Text = studentToEdit.Cep;
            txtEnd.Text = studentToEdit.Address;
            txtEstado.Text = studentToEdit.State;
            txtBairro.Text = studentToEdit.District;
            txtCidade.Text = studentToEdit.City;
            txtCelular.Text = studentToEdit.Celphone;
            txtTel.Text = studentToEdit.Phone;
            dtpExp.Value = studentToEdit.Dt_exp;
            dtpNasc.Value = studentToEdit.Dt_nasc;

            txtName.ErrorMessage = String.Empty;
            txtNaturalidade.ErrorMessage = String.Empty;
            txtEmail.ErrorMessage = String.Empty;
            txtCPF.ErrorMessage = String.Empty;
            txtRG.ErrorMessage = String.Empty;
            txtOrgExp.ErrorMessage = String.Empty;
            txtMae.ErrorMessage = String.Empty;
            txtPai.ErrorMessage = String.Empty;
            txtCep.ErrorMessage = String.Empty;
            txtEnd.ErrorMessage = String.Empty;
            txtEstado.ErrorMessage = String.Empty;
            txtBairro.ErrorMessage = String.Empty;
            txtCidade.ErrorMessage = String.Empty;
            txtCelular.ErrorMessage = String.Empty;
            txtTel.ErrorMessage = String.Empty;
        }

        private void setLabels()
        {
            lblId.Text = studentToEdit.Id.ToString();
            lblCreated.Text = studentToEdit.Dt_created.ToString("dd/MM/yyyy");
            lblEmail.Text = studentToEdit.Email;
            lblPhone.Text = studentToEdit.GetMaskedPhone(8);
            lblCel.Text = studentToEdit.GetMaskedPhone(9);
        }

        private bool _validateFields()
        {
            if (txtName.Text == String.Empty)
                txtName.ErrorMessage = "*requerido";

            if (txtCPF.Text == String.Empty || !txtCPF.MaskCompleted)
                txtCPF.ErrorMessage = "*requerido";

            if (txtRG.Text == String.Empty || !txtRG.MaskCompleted)
                txtRG.ErrorMessage = "*requerido";

            if (txtOrgExp.Text == String.Empty)
                txtOrgExp.ErrorMessage = "*requerido";

            if (txtNaturalidade.Text == String.Empty)
                txtNaturalidade.ErrorMessage = "*requerido";

            if (txtPai.Text == String.Empty)
                txtPai.ErrorMessage = "*requerido";

            if (txtMae.Text == String.Empty)
                txtMae.ErrorMessage = "*requerido";

            if (txtEnd.Text == String.Empty)
                txtEnd.ErrorMessage = "*requerido";

            if (txtCidade.Text == String.Empty)
                txtCidade.ErrorMessage = "*requerido";

            if (txtEstado.Text == String.Empty)
                txtEstado.ErrorMessage = "*requerido";

            if (txtBairro.Text == String.Empty)
                txtBairro.ErrorMessage = "*requerido";

            if (txtCep.Text == String.Empty || !txtCep.MaskCompleted)
                txtCep.ErrorMessage = "*requerido";

            if (txtTel.Text == String.Empty || !txtTel.MaskCompleted)
                txtTel.ErrorMessage = "*requerido";

            if (txtCelular.Text == String.Empty || !txtCelular.MaskCompleted)
                txtCelular.ErrorMessage = "*requerido";

            if (txtEmail.Text == String.Empty)
                txtEmail.ErrorMessage = "*requerido";


            return (txtName.Text != String.Empty && (txtCPF.Text != String.Empty && txtCPF.MaskCompleted) &&
                (txtRG.Text != String.Empty && txtRG.MaskCompleted) && txtOrgExp.Text != String.Empty &&
                txtNaturalidade.Text != String.Empty && txtPai.Text != String.Empty && txtMae.Text != String.Empty &&
                txtEnd.Text != String.Empty && txtCidade.Text != String.Empty && txtEstado.Text != String.Empty &&
                txtBairro.Text != String.Empty && (txtCep.Text != String.Empty && txtCep.MaskCompleted) &&
                (txtTel.Text != String.Empty && txtTel.MaskCompleted) && (txtCelular.Text != String.Empty &&
                txtCelular.MaskCompleted) && txtEmail.Text != String.Empty);
        }

        private bool UpdateStudent()
        {
            Student newStudent = new Student(
                studentToEdit.Id,
                txtName.Text,
                txtCPF.Text,
                txtRG.Text,
                txtOrgExp.Text,
                dtpExp.Value.Date,
                dtpNasc.Value.Date,
                txtNaturalidade.Text,
                txtPai.Text,
                txtMae.Text,
                txtEnd.Text,
                txtCidade.Text,
                txtEstado.Text,
                txtBairro.Text,
                txtCep.Text,
                txtTel.Text,
                txtCelular.Text,
                txtEmail.Text,
                studentToEdit.Dt_created
                );

            if (StudentsDTO.UpdateStudent(newStudent))
            {
                this.studentToEdit = newStudent;
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
            if (_validateFields() && UpdateStudent())
            {
                MessageBox.Show("Aluno alterado com sucesso!");
                _handlerRefresh();
            }
        }

        private void pnlSave_MouseEnter(object sender, EventArgs e)
        {
            btnSave_MouseEnter(sender, e);
        }

        private void pnlSave_MouseLeave(object sender, EventArgs e)
        {
            btnSave_MouseLeave(sender, e);
        }

        private void lblSave_MouseEnter(object sender, EventArgs e)
        {
            btnSave_MouseEnter(sender, e);
        }

        private void lblSave_MouseLeave(object sender, EventArgs e)
        {
            btnSave_MouseLeave(sender, e);
        }

        private void btnSave_MouseEnter(object sender, EventArgs e)
        {
            pnlSave.BackColor = SystemColors.ControlLightLight;
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            pnlSave.BackColor = SystemColors.Control;
        }

        private void pnlCancel_MouseEnter(object sender, EventArgs e)
        {
            btnCancel_MouseEnter(sender, e);
        }

        private void pnlCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancel_MouseLeave(sender, e);
        }

        private void lblCancel_MouseEnter(object sender, EventArgs e)
        {
            btnCancel_MouseEnter(sender, e);
        }

        private void lblCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancel_MouseLeave(sender, e);
        }

        private void btnCancel_MouseEnter(object sender, EventArgs e)
        {
            pnlCancel.BackColor = SystemColors.ControlLightLight;
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            pnlCancel.BackColor = SystemColors.Control;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            setFields();
        }

        private void lblCancel_Click(object sender, EventArgs e)
        {
            btnCancel_Click(sender, e);
        }

        private void pnlCancel_Click(object sender, EventArgs e)
        {
            btnCancel_Click(sender, e);
        }
    }
}
