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
    public partial class ClassDetail : Form
    {
        private Class classToEdit;
        private Dictionary<string, int> radioControl = new Dictionary<string, int>();

        public ClassDetail(string id)
        {
            InitializeComponent();
            this.CenterToScreen();

            classToEdit = ClassDTO.getClassById(new Dictionary<string, string> { { "id", id } });
            this.radioControl.Add("dig", classToEdit.Dif_dig);
            this.radioControl.Add("lei", classToEdit.Dif_lei);
            this.radioControl.Add("rec", classToEdit.Dif_rec);
            this.radioControl.Add("atv", classToEdit.Dif_atv);
            this.radioControl.Add("int", classToEdit.Dif_atv);
            setFields();
            setLabels();
        }

        private void setFields()
        {
            ((RadioButton)this.Controls.Find("radioDig" + classToEdit.Dif_dig, true)[0]).Checked = true;
            ((RadioButton)this.Controls.Find("radioLeitura" + classToEdit.Dif_lei, true)[0]).Checked = true;
            ((RadioButton)this.Controls.Find("radioReconhecer" + classToEdit.Dif_rec, true)[0]).Checked = true;
            ((RadioButton)this.Controls.Find("radioAtividade" + classToEdit.Dif_atv, true)[0]).Checked = true;
            ((RadioButton)this.Controls.Find("radioInteressante" + classToEdit.Dif_atv, true)[0]).Checked = true;

            txtObs.Text = classToEdit.Obs_atv;
            txtObsInteressante.Text = classToEdit.Obs_int;
        }

        private void setLabels()
        {
            lblTitle.Text = classToEdit.Activity.Title;
            lblInstructor.Text = classToEdit.Instructor.Name;
            lblStudent.Text = classToEdit.Student.Name;
            lblCreated.Text = classToEdit.Dt_created.ToString("dd/MM/yyyy");
        }

        private bool UpdateClass()
        {
            Class newClass = new Class(
                classToEdit.Id,
                this.radioControl["dig"],
                this.radioControl["lei"],
                this.radioControl["rec"],
                this.radioControl["atv"],
                this.radioControl["int"],
                classToEdit.Student,
                classToEdit.Instructor,
                classToEdit.Activity,
                classToEdit.Dt_created,
                txtObs.Text,
                txtObsInteressante.Text
                );

            if (ClassDTO.UpdateClass(newClass))
            {
                this.classToEdit = newClass;
                return true;
            }

            return false;
        }

        private void _handlerRefresh()
        {
            setLabels();
        }

        private void radioButton_Click(object sender, EventArgs e)
        {
            this.radioControl[((RadioButton)sender).Tag.ToString()] = Convert.ToInt32(((RadioButton)sender).Text);
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
            if (UpdateClass())
            {
                MessageBox.Show("Aula alterada com sucesso!");
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
