﻿using SYS_APAE.SYS_APAE.Data;
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

namespace SYS_APAE
{
    public partial class MainMenu : Form
    {
        private Dictionary<string, int> radioControl = new Dictionary<string, int>();

        public MainMenu()
        {
            InitializeComponent();

            this.radioControl.Add("dig", -1);
            this.radioControl.Add("lei", -1);
            this.radioControl.Add("rec", -1);
            this.radioControl.Add("atv", -1);
            this.radioControl.Add("int", -1);

            _handlerTabGeral();
            dtpNasc.Value = DateTime.Today;
        }

        private void _handlerTabGeral()
        {
            tabControlGeral.TabPages.Remove(tabCadastro);
            tabControlGeral.TabPages.Remove(tabParticipante);
            tabControlGeral.TabPages.Remove(tabVisuRel);
            tabControlGeral.TabPages.Remove(tabGerarRel);

            btnCadastro.Visible = true;
            btnParticipante.Visible = true;
            btnVisualizarRelatorio.Visible = true;
            btnGerarRel.Visible = true;
            btnCadastro.Enabled = true;
            btnParticipante.Enabled = true;
            btnVisualizarRelatorio.Enabled = true;
            btnGerarRel.Enabled = true;
        }

        private void _handlerRefreshAdd()
        {
            txtProntuario.ResetText();
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
                txtEmail.Text,
                txtProntuario.Text
                ));
        }

        private void btnParticipante_Click(object sender, EventArgs e)
        {
            _handlerTabGeral();

            tabControlGeral.TabPages.Insert(0, tabParticipante);
            btnParticipante.Enabled = false;
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            _handlerTabGeral();

            tabControlGeral.TabPages.Insert(0, tabCadastro);
            btnCadastro.Enabled = false;
        }

        private void btnVisualizarRelatorio_Click(object sender, EventArgs e)
        {
            _handlerTabGeral();

            tabControlGeral.TabPages.Insert(0, tabVisuRel);
            btnVisualizarRelatorio.Enabled = false;
        }

        private void btnGerarRel_Click(object sender, EventArgs e)
        {
            _handlerTabGeral();

            tabControlGeral.TabPages.Insert(0, tabGerarRel);
            btnGerarRel.Enabled = false;
        }

        private void radioAluno_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                txtProntuario.Enabled = false;
        }

        private void radioMonitor_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                txtProntuario.Enabled = true;
        }

        private void radioButton_Click(object sender, EventArgs e)
        {
            this.radioControl[((RadioButton)sender).Tag.ToString()] = Convert.ToInt32(((RadioButton)sender).Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (radioAluno.Checked)
            {
                if (AddNewStudent())
                {
                    MessageBox.Show("Aluno cadastrado com sucesso!");
                    _handlerRefreshAdd();
                }
            }
            else
            {
                if (AddNewInstructor())
                {
                    MessageBox.Show("Monitor cadastrado com sucesso!");
                    _handlerRefreshAdd();
                }
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
    }
}
