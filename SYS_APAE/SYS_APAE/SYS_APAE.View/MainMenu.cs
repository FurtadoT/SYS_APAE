﻿using SYS_APAE.SYS_APAE.Data;
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
            dtpRelCreated.Value = DateTime.Today;
            lblWUser.Text = "Bem vindo, " + LoginDTO.getUser().Name + "!";
        }

        private void _handlerTabGeral()
        {
            tabControlGeral.TabPages.Remove(tabCadastro);
            tabControlGeral.TabPages.Remove(tabParticipante);
            tabControlGeral.TabPages.Remove(tabVisuRel);
            tabControlGeral.TabPages.Remove(tabGerarRel);

            mnItemNewStudents.Visible = true;
            mnItemShowStudents.Visible = true;
            mnItemShowReports.Visible = true;
            mnItemNewReports.Visible = true;

            mnItemNewStudents.Enabled = true;
            mnItemShowStudents.Enabled = true;
            mnItemShowReports.Enabled = true;
            mnItemNewReports.Enabled = true;

            if (LoginDTO.getUser().AccessLevel < 6)
            {
                mnItemShowStudents.Enabled = false;
                mnItemShowReports.Enabled = false;
            }
        }

        private void _handlerRefreshAdd()
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
            txtDDDTel.ResetText();
            txtTel.ResetText();
            txtDDD.ResetText();
            txtCelular.ResetText();
            txtEmail.ResetText();
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
            dtpRelCreated.ResetText();
            txtTitulo.ResetText();
            txtObs.ResetText();
            txtObsInteressante.ResetText();
        }

        private void _handlerRelatoriosCMBox()
        {
            setCMBoxValues(StudentsDTO.getAllStudentsName(), cmbNomeAluno);
            setCMBoxValues(InstructorDTO.getAllInstructorsName(), cmbNomeMonitor);
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
            return StudentsDTO.addNewStudent(new Student(
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
                txtDDDTel.Text + txtTel.Text,
                txtDDD.Text + txtCelular.Text,
                txtEmail.Text
                ));
        }

        private bool AddNewInstructor()
        {
            return InstructorDTO.addNewInstructor(new Instructor(
                0,
                txtNome.Text,
                txtCPF.Text,
                txtEmail.Text,
                "170141-X",
                "Bolsista",
                20
                ));
        }

        private bool AddRelatorio()
        {
            return ReportsDTO.addNewReport(new Report(
                0,
                this.radioControl["dig"],
                this.radioControl["lei"],
                this.radioControl["rec"],
                this.radioControl["atv"],
                this.radioControl["int"],
                StudentsDTO.getStudentById(cmbNomeAluno.SelectedValue.ToString()),
                InstructorDTO.getInstructorById(cmbNomeMonitor.SelectedValue.ToString()),
                dtpRelCreated.Value.Date,
                txtTitulo.Text,
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
                _handlerRefreshAdd();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            _handlerRefreshAdd();
        }

        private void dtpNasc_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("%{DOWN}");
        }

        private void dtpExp_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("%{DOWN}");
        }

        private void radioListMonitor_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                dtgParticipantes.DataSource = InstructorDTO.getAllInstructorsUsingView();
                dtgParticipantes.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
        }

        private void radioListAluno_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                dtgParticipantes.DataSource = StudentsDTO.getAllStudentsUsingView();
                dtgParticipantes.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
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

            tabControlGeral.TabPages.Insert(0, tabCadastro);
            mnItemNewStudents.Enabled = false;
        }

        private void mnItemShowStudents_Click(object sender, EventArgs e)
        {
            _handlerTabGeral();

            tabControlGeral.TabPages.Insert(0, tabParticipante);
            mnItemShowStudents.Enabled = false;
        }

        private void mnItemNewReports_Click(object sender, EventArgs e)
        {
            _handlerTabGeral();
            _handlerRelatoriosCMBox();

            tabControlGeral.TabPages.Insert(0, tabGerarRel);
            mnItemNewReports.Enabled = false;
        }

        private void mnItemShowReports_Click(object sender, EventArgs e)
        {
            _handlerTabGeral();

            tabControlGeral.TabPages.Insert(0, tabVisuRel);
            mnItemShowReports.Enabled = false;

            dtgReports.DataSource = ReportsDTO.getAllReportsUsingView();
            dtgReports.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }
    }
}
