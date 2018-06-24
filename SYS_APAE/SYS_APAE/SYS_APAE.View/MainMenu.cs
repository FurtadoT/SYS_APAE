using SYS_APAE.SYS_APAE.Data;
using SYS_APAE.SYS_APAE.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SYS_APAE
{
    public partial class MainMenu : Form
    {
        private Dictionary<string, int> radioControl = new Dictionary<string, int>();

        public MainMenu()
        {
            InitializeComponent();
            mnPrincipal.Renderer = new CustomMenuRender();
            this.CenterToScreen();

            this.radioControl.Add("dig", -1);
            this.radioControl.Add("lei", -1);
            this.radioControl.Add("rec", -1);
            this.radioControl.Add("atv", -1);
            this.radioControl.Add("int", -1);

            _handlerTabGeral();
            dtpNasc.Value = DateTime.Today;
            dtpExp.Value = DateTime.Today;
            dtpRelCreated.Value = DateTime.Today;
            lblWUser.Text = "Bem vindo, " + LoginDTO.getUser().Name + "!";
        }

        private void _handlerTabGeral()
        {
            tabControlGeral.TabPages.Remove(tabNewStudent);
            tabControlGeral.TabPages.Remove(tabNewInstructor);
            tabControlGeral.TabPages.Remove(tabNewActivity);
            tabControlGeral.TabPages.Remove(tabNewClass);
            tabControlGeral.TabPages.Remove(tabListStudents);
            tabControlGeral.TabPages.Remove(tabListInstructors);
            tabControlGeral.TabPages.Remove(tabListClass);
            tabControlGeral.TabPages.Remove(tabListActivity);

            mnItemNewStudents.Visible = true;
            mnItemNewInstructor.Visible = true;
            mnItemNewActivity.Visible = true;
            mnItemNewReports.Visible = true;
            mnItemShowStudents.Visible = true;
            mnItemListInstructors.Visible = true;
            mnItemShowReports.Visible = true;
            mnItemListActivities.Visible = true;

            mnItemNewStudents.Enabled = true;
            mnItemNewInstructor.Enabled = true;
            mnItemNewActivity.Enabled = true;
            mnItemNewReports.Enabled = true;
            mnItemShowStudents.Enabled = true;
            mnItemListInstructors.Enabled = true;
            mnItemShowReports.Enabled = true;
            mnItemListActivities.Enabled = true;

            if (LoginDTO.getUser().AccessLevel < 6)
            {
                mnItemNewInstructor.Visible = false;
                mnItemNewActivity.Visible = false;
            }
        }

        private void _handlerRefreshAddStudent()
        {
            txtNome.ResetText();
            txtCPF.ResetText();
            txtRG.ResetText();
            txtOrgExp.ResetText();
            dtpNasc.Value = DateTime.Today;
            dtpExp.Value = DateTime.Today;
            txtNaturalidade.ResetText();
            txtPai.ResetText();
            txtMae.ResetText();
            txtEnd.ResetText();
            txtCidade.ResetText();
            txtEstado.ResetText();
            txtBairro.ResetText();
            txtCep.ResetText();
            txtTel.ResetText();
            txtCelular.ResetText();
            txtEmail.ResetText();
        }

        private void _handlerRefreshAddInstructor()
        {
            txtNameInstructor.ResetText();
            txtEmailInstructor.ResetText();
            txtProntuarioInstructor.ResetText();
            txtTipoInstructor.ResetText();
            txtCargaInstructor.ResetText();
            txtCpfInstructor.ResetText();
            txtPasswordInstructor.ResetText();
            chkShowPassword.Checked = false;
        }

        private void _handlerRefreshRadioReprots()
        {
            radioAtividade0.Checked = false;
            radioAtividade1.Checked = false;
            radioAtividade2.Checked = false;
            radioAtividade3.Checked = false;
            radioAtividade4.Checked = false;
            radioAtividade5.Checked = false;

            radioDig0.Checked = false;
            radioDig1.Checked = false;
            radioDig2.Checked = false;
            radioDig3.Checked = false;
            radioDig4.Checked = false;
            radioDig5.Checked = false;

            radioInteressante0.Checked = false;
            radioInteressante1.Checked = false;
            radioInteressante2.Checked = false;
            radioInteressante3.Checked = false;
            radioInteressante4.Checked = false;
            radioInteressante5.Checked = false;

            radioLeitura0.Checked = false;
            radioLeitura1.Checked = false;
            radioLeitura2.Checked = false;
            radioLeitura3.Checked = false;
            radioLeitura4.Checked = false;
            radioLeitura5.Checked = false;

            radioReconhecer0.Checked = false;
            radioReconhecer1.Checked = false;
            radioReconhecer2.Checked = false;
            radioReconhecer3.Checked = false;
            radioReconhecer4.Checked = false;
            radioReconhecer5.Checked = false;
        }

        private void _handlerRefreshAddRelatorio()
        {
            _handlerRefreshRadioReprots();
            this.radioControl["dig"] = -1;
            this.radioControl["lei"] = -1;
            this.radioControl["rec"] = -1;
            this.radioControl["atv"] = -1;
            this.radioControl["int"] = -1;
            cmbNomeAluno.SelectedIndex = 0;
            cmbNomeMonitor.SelectedIndex = 0;
            cmbActivities.SelectedIndex = 0;
            dtpRelCreated.ResetText();
            txtObs.ResetText();
            txtObsInteressante.ResetText();
        }

        private void _handlerRefreshAddActivity()
        {
            this.txtTitleActivity.ResetText();
            this.txtDescriptionActivity.ResetText();
        }

        private void _handlerRelatoriosCMBox()
        {
            setCMBoxValues(StudentsDTO.getAllStudentsName(), cmbNomeAluno);
            setCMBoxValues(InstructorDTO.getAllInstructorsName(), cmbNomeMonitor);
            setCMBoxValues(ActivityDTO.getAllActivitiesTitle(), cmbActivities);
        }

        private void setCMBoxValues(DataTable dtSource, ComboBox cmbTarget)
        {
            cmbTarget.DisplayMember = "Name";
            cmbTarget.ValueMember = "Id";
            DataRow firstRow = dtSource.NewRow();
            firstRow["Name"] = "Selecionar";
            firstRow["id"] = "-1";
            dtSource.Rows.InsertAt(firstRow, 0);
            cmbTarget.DataSource = dtSource;
        }

        private bool AddNewStudent()
        {
            return StudentsDTO.AddNewStudent(new Student(
                0,
                txtNome.Text,
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
                DateTime.Today
                ));
        }

        private bool AddNewInstructor()
        {
            return InstructorDTO.AddNewInstructor(new Instructor(
                0,
                txtNameInstructor.Text,
                txtCpfInstructor.Text,
                txtPasswordInstructor.Text,
                txtEmailInstructor.Text,
                txtProntuarioInstructor.Text,
                txtTipoInstructor.Text,
                Convert.ToInt32(txtCargaInstructor.Text),
                DateTime.Today
                ));
        }

        private bool AddActivity()
        {
            return ActivityDTO.AddNewActivity(new Activity(
                0,
                txtTitleActivity.Text,
                txtDescriptionActivity.Text,
                DateTime.Today
                ));
        }

        private bool AddRelatorio()
        {
            return ReportsDTO.AddNewReport(new Report(
                0,
                this.radioControl["dig"],
                this.radioControl["lei"],
                this.radioControl["rec"],
                this.radioControl["atv"],
                this.radioControl["int"],
                StudentsDTO.getStudentById(new Dictionary<string, string> { { "id", cmbNomeAluno.SelectedValue.ToString() } }),
                InstructorDTO.getInstructorById(new Dictionary<string, string> { { "id", cmbNomeMonitor.SelectedValue.ToString() } }),
                ActivityDTO.getActivityById(new Dictionary<string, string> { { "id", cmbActivities.SelectedValue.ToString() } }),
                dtpRelCreated.Value.Date,
                txtObs.Text,
                txtObsInteressante.Text
                ));
        }

        private void radioButton_Click(object sender, EventArgs e)
        {
            this.radioControl[((RadioButton)sender).Tag.ToString()] = Convert.ToInt32(((RadioButton)sender).Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (AddNewStudent())
            {
                MessageBox.Show("Aluno cadastrado com sucesso!");
                _handlerRefreshAddStudent();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            _handlerRefreshAddStudent();
        }

        private void dtpNasc_Enter(object sender, EventArgs e)
        {

        }

        private void dtpExp_Enter(object sender, EventArgs e)
        {

        }

        private void radioListMonitor_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                dtgListStudents.DataSource = InstructorDTO.getAllInstructorsToDisplay();
                if (dtgListStudents.Columns.Count > 0)
                    dtgListStudents.Columns[0].Visible = false;
            }
        }

        private void radioListAluno_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
            }
        }

        private void cmbNomeMonitor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbNomeMonitor.SelectedValue.ToString() != "-1")
                    txtProntRelatorio.Text = InstructorDTO.getProntuario(Convert.ToInt32(cmbNomeMonitor.SelectedValue));
                else
                    txtProntRelatorio.Text = "";
            }
            catch
            {
                txtProntRelatorio.Text = "";
            }
        }

        private void btnRelAdd_Click(object sender, EventArgs e)
        {
            if (AddRelatorio())
            {
                MessageBox.Show("Relatório cadastrado com sucesso!");
                _handlerRefreshAddRelatorio();
            }
        }

        private void btnRefreshReport_Click(object sender, EventArgs e)
        {
            _handlerRefreshAddRelatorio();
        }

        private void mnItemNewStudents_Click(object sender, EventArgs e)
        {
            _handlerTabGeral();

            tabControlGeral.TabPages.Insert(0, tabNewStudent);
            mnItemNewStudents.Enabled = false;
        }

        private void mnItemShowStudents_Click(object sender, EventArgs e)
        {
            _handlerTabGeral();

            tabControlGeral.TabPages.Insert(0, tabListStudents);
            mnItemShowStudents.Enabled = false;

            dtgListStudents.DataSource = StudentsDTO.getAllStudentsToDisplay();
            if (dtgListStudents.Columns.Count > 0)
            {
                dtgListStudents.Columns[0].Visible = false;
                dtgListStudents.Visible = true;
                lblListStudentsEmpty.Visible = false;
            }
            else
            {
                dtgListStudents.Visible = false;
                lblListStudentsEmpty.Text = "Não há aluno cadastrado!";
                lblListStudentsEmpty.Visible = true;
            }
        }

        private void mnItemNewReports_Click(object sender, EventArgs e)
        {
            _handlerTabGeral();
            _handlerRelatoriosCMBox();

            tabControlGeral.TabPages.Insert(0, tabNewClass);
            mnItemNewReports.Enabled = false;
        }

        private void mnItemShowReports_Click(object sender, EventArgs e)
        {
            _handlerTabGeral();

            tabControlGeral.TabPages.Insert(0, tabListClass);
            mnItemShowReports.Enabled = false;

            dtgReports.DataSource = ReportsDTO.getAllReportsToDisplay();
            if (dtgReports.Columns.Count > 0)
            {
                dtgReports.Columns[0].Visible = false;
                dtgReports.Visible = true;
                lblListClassEmpty.Visible = false;
            }
            else
            {
                dtgReports.Visible = false;
                lblListClassEmpty.Text = "Não há aula cadastrada!";
                 lblListClassEmpty.Visible = true;
            }
        }

        private void mnItemNewInstructor_Click(object sender, EventArgs e)
        {
            _handlerTabGeral();

            tabControlGeral.TabPages.Insert(0, tabNewInstructor);
            txtNameInstructor.Focus();
            mnItemNewInstructor.Enabled = false;
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
                this.txtPasswordInstructor.PasswordChar = '\0';
            else
                this.txtPasswordInstructor.PasswordChar = '*';
        }

        private void btnInsertNewInstructor_Click(object sender, EventArgs e)
        {
            if (AddNewInstructor())
            {
                MessageBox.Show("Monitor cadastrado com sucesso!");
                _handlerRefreshAddInstructor();
            }
        }

        private void btnClearNewInstructor_Click(object sender, EventArgs e)
        {
            _handlerRefreshAddInstructor();
        }

        private void btnAddNewActivity_Click(object sender, EventArgs e)
        {
            if (AddActivity())
            {
                MessageBox.Show("Atividade cadastrada com sucesso!");
                _handlerRefreshAddActivity();
            }
        }

        private void mnItemNewActivity_Click(object sender, EventArgs e)
        {
            _handlerTabGeral();

            tabControlGeral.TabPages.Insert(0, tabNewActivity);
            txtTitleActivity.Focus();
            mnItemNewActivity.Enabled = false;
        }

        private void btnLimparNewActivity_Click(object sender, EventArgs e)
        {
            _handlerRefreshAddActivity();
        }

        private void txtSearchStudent_KeyUp(object sender, KeyEventArgs e)
        {
            dtgListStudents.DataSource = StudentsDTO.getFilteredStudentsToDisplay(txtSearchStudents.Text);
            if (dtgListStudents.Columns.Count > 0)
            {
                dtgListStudents.Columns[0].Visible = false;
                dtgListStudents.Visible = true;
                lblListStudentsEmpty.Visible = false;
            }
            else
            {
                dtgListStudents.Visible = false;
                lblListStudentsEmpty.Text = "Não há aluno com esse critério!";
                lblListStudentsEmpty.Visible = true;
            }
        }

        private void listarMonitoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _handlerTabGeral();

            tabControlGeral.TabPages.Insert(0, tabListInstructors);
            mnItemListInstructors.Enabled = false;

            dtgListInstructors.DataSource = InstructorDTO.getAllInstructorsToDisplay();
            if (dtgListInstructors.Columns.Count > 0)
            {
                dtgListInstructors.Columns[0].Visible = false;
                dtgListInstructors.Visible = true;
                lblListInstructorsEmpty.Visible = false;
            }
            else
            {
                dtgListInstructors.Visible = false;
                lblListInstructorsEmpty.Text = "Não há monitor cadastrado!";
                lblListInstructorsEmpty.Visible = true;
            }
        }

        private void txtSearchInstructors_KeyUp(object sender, KeyEventArgs e)
        {
            dtgListInstructors.DataSource = InstructorDTO.getFilteredInstructorsToDisplay(txtSearchInstructors.Text);
            if (dtgListInstructors.Columns.Count > 0)
            {
                dtgListInstructors.Columns[0].Visible = false;
                dtgListInstructors.Visible = true;
                lblListInstructorsEmpty.Visible = false;
            }
            else
            {
                dtgListInstructors.Visible = false;
                lblListInstructorsEmpty.Text = "Não há monitor com esse critério!";
                lblListInstructorsEmpty.Visible = true;
            }
        }
    }
}
