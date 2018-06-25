using SYS_APAE.SYS_APAE.Data;
using SYS_APAE.SYS_APAE.Models;
using SYS_APAE.SYS_APAE.View;
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

        private void listAllStudent()
        {
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

        private void listStudentWithSearchField()
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

        private void listAllInstructor()
        {
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

        private void listInstructorWithSearchField()
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

        private bool _validateStudentFields()
        {
            if (txtNome.Text == String.Empty)
                txtNome.ErrorMessage = "*requerido";

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


            return (txtNome.Text != String.Empty && (txtCPF.Text != String.Empty && txtCPF.MaskCompleted) &&
                (txtRG.Text != String.Empty && txtRG.MaskCompleted) && txtOrgExp.Text != String.Empty &&
                txtNaturalidade.Text != String.Empty && txtPai.Text != String.Empty && txtMae.Text != String.Empty &&
                txtEnd.Text != String.Empty && txtCidade.Text != String.Empty && txtEstado.Text != String.Empty &&
                txtBairro.Text != String.Empty && (txtCep.Text != String.Empty && txtCep.MaskCompleted) &&
                (txtTel.Text != String.Empty && txtTel.MaskCompleted) && (txtCelular.Text != String.Empty &&
                txtCelular.MaskCompleted) && txtEmail.Text != String.Empty);
        }

        private bool _validateInstructorsFields()
        {
            if (txtNameInstructor.Text == String.Empty)
                txtNameInstructor.ErrorMessage = "*requerido";

            if (txtEmailInstructor.Text == String.Empty)
                txtEmailInstructor.ErrorMessage = "*requerido";

            if (txtProntuarioInstructor.Text == String.Empty || !txtProntuarioInstructor.MaskCompleted)
                txtProntuarioInstructor.ErrorMessage = "*requerido";

            if (txtCpfInstructor.Text == String.Empty || !txtCpfInstructor.MaskCompleted)
                txtCpfInstructor.ErrorMessage = "*requerido";

            if (txtPasswordInstructor.Text == String.Empty)
                txtPasswordInstructor.ErrorMessage = "*requerido";

            if (txtTipoInstructor.Text == String.Empty)
                txtTipoInstructor.ErrorMessage = "*requerido";

            return (txtNameInstructor.Text != String.Empty && txtEmailInstructor.Text != String.Empty &&
                (txtProntuarioInstructor.Text != String.Empty && txtProntuarioInstructor.MaskCompleted) &&
                (txtCpfInstructor.Text != String.Empty && txtCpfInstructor.MaskCompleted) &&
                txtPasswordInstructor.Text != String.Empty && txtTipoInstructor.Text != String.Empty);
        }
        
        private bool _validateActivitiesFields()
        {
            if (txtTitleActivity.Text == String.Empty)
                txtTitleActivity.ErrorMessage = "*requerido";

            return (txtTitleActivity.Text != String.Empty);
        }

        private bool _validateClassFields()
        {
            if (cmbNomeAluno.SelectedValue.ToString() == "-1")
                lblNomeAluno.ForeColor = System.Drawing.Color.Red;

            if (cmbActivities.SelectedValue.ToString() == "-1")
                lblTitulo.ForeColor = System.Drawing.Color.Red;

            if (cmbNomeMonitor.SelectedValue.ToString() == "-1")
                gpbInstructorReport.ForeColor = System.Drawing.Color.Red;

            if (radioControl["dig"] == -1)
                lblDigitacao.ForeColor = System.Drawing.Color.Red;

            if (radioControl["lei"] == -1)
                lblLeitura.ForeColor = System.Drawing.Color.Red;

            if (radioControl["rec"] == -1)
                lblReconhecer.ForeColor = System.Drawing.Color.Red;

            if (radioControl["atv"] == -1)
                lblAtividade.ForeColor = System.Drawing.Color.Red;

            if (radioControl["int"] == -1)
                lblInteressante.ForeColor = System.Drawing.Color.Red;

            return (cmbNomeAluno.SelectedValue.ToString() != "-1" && cmbActivities.SelectedValue.ToString() != "-1" &&
                cmbNomeMonitor.SelectedValue.ToString() != "-1" && radioControl["dig"] != -1 && radioControl["lei"] != -1 &&
                radioControl["rec"] != -1 && radioControl["atv"] != -1 && radioControl["int"] != -1);
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
                Convert.ToInt32(txtCargaInstructor.Value),
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
            return ClassDTO.AddNewClass(new Class(
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
            if (((RadioButton)sender).Tag.ToString() == "dig")
                lblDigitacao.ForeColor = System.Drawing.Color.Black;
            else if (((RadioButton)sender).Tag.ToString() == "lei")
                lblLeitura.ForeColor = System.Drawing.Color.Black;
            else if (((RadioButton)sender).Tag.ToString() == "rec")
                lblReconhecer.ForeColor = System.Drawing.Color.Black;
            else if (((RadioButton)sender).Tag.ToString() == "atv")
                lblAtividade.ForeColor = System.Drawing.Color.Black;
            else if (((RadioButton)sender).Tag.ToString() == "int")
                lblInteressante.ForeColor = System.Drawing.Color.Black;
  
            this.radioControl[((RadioButton)sender).Tag.ToString()] = Convert.ToInt32(((RadioButton)sender).Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (_validateStudentFields() && AddNewStudent())
            {
                MessageBox.Show("Aluno cadastrado com sucesso!");
                _handlerRefreshAddStudent();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            _handlerRefreshAddStudent();
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
            if (_validateClassFields() && AddRelatorio())
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

            listAllStudent();
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

            dtgReports.DataSource = ClassDTO.getAllClassToDisplay();
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
            if (_validateInstructorsFields() && AddNewInstructor())
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
            if (_validateActivitiesFields() && AddActivity())
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
            listStudentWithSearchField();
        }

        private void listarMonitoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _handlerTabGeral();

            tabControlGeral.TabPages.Insert(0, tabListInstructors);
            mnItemListInstructors.Enabled = false;

            listAllInstructor();
        }

        private void txtSearchInstructors_KeyUp(object sender, KeyEventArgs e)
        {
            listInstructorWithSearchField();
        }

        private void mnItemListActivities_Click(object sender, EventArgs e)
        {
            _handlerTabGeral();

            tabControlGeral.TabPages.Insert(0, tabListActivity);
            mnItemListActivities.Enabled = false;

            dtgListActivities.DataSource = ActivityDTO.getAllActivitiesToDisplay();
            if (dtgListActivities.Columns.Count > 0)
            {
                dtgListActivities.Columns[0].Visible = false;
                dtgListActivities.Visible = true;
                lblListActivitiesEmpty.Visible = false;
            }
            else
            {
                dtgListActivities.Visible = false;
                lblListActivitiesEmpty.Text = "Não há atividade cadastrada!";
                lblListActivitiesEmpty.Visible = true;
            }
        }

        private void txtSearchActivity_KeyUp(object sender, KeyEventArgs e)
        {
            dtgListActivities.DataSource = ActivityDTO.getFilteredActivitiesToDisplay(txtSearchActivities.Text);
            if (dtgListActivities.Columns.Count > 0)
            {
                dtgListActivities.Columns[0].Visible = false;
                dtgListActivities.Visible = true;
                lblListActivitiesEmpty.Visible = false;
            }
            else
            {
                dtgListActivities.Visible = false;
                lblListActivitiesEmpty.Text = "Não há atividade com esse critério!";
                lblListActivitiesEmpty.Visible = true;
            }
        }

        private void cmbNomeAluno_SelectedValueChanged(object sender, EventArgs e)
        {
            lblNomeAluno.ForeColor = System.Drawing.Color.Black;
        }

        private void cmbActivities_SelectedValueChanged(object sender, EventArgs e)
        {
            lblTitulo.ForeColor = System.Drawing.Color.Black;
        }

        private void cmbNomeMonitor_SelectedValueChanged(object sender, EventArgs e)
        {
            gpbInstructorReport.ForeColor = System.Drawing.Color.Black;
        }

        private void dtgListStudents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            StudentDetail formDetail = new StudentDetail(dtgListStudents.Rows[e.RowIndex].Cells["id"].Value.ToString());
            formDetail.ShowDialog();
            if (txtSearchStudents.Text != String.Empty)
                listStudentWithSearchField();
            else
                listAllStudent();
        }

        private void dtgListInstructors_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            InstructorsDetail formDetail = new InstructorsDetail(dtgListInstructors.Rows[e.RowIndex].Cells["id"].Value.ToString());
            formDetail.ShowDialog();
            if (txtSearchInstructors.Text != String.Empty)
                listInstructorWithSearchField();
            else
                listAllInstructor();
        }
    }
}
