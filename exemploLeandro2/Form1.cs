using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exemploLeandro2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControlGeral.TabPages.Remove(tabCadastro);
            tabControlGeral.TabPages.Remove(tabParticipante);
            tabControlGeral.TabPages.Remove(tabVisuRel);
            tabControlGeral.TabPages.Remove(tabGerarRel);

            btnCadastro.Visible = true;
            btnParticipante.Visible = true;
            btnvisualizar.Visible = true;
            btnGerarRel.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControlGeral.TabPages.Remove(tabCadastro);
            tabControlGeral.TabPages.Remove(tabParticipante);
            tabControlGeral.TabPages.Remove(tabVisuRel);
            tabControlGeral.TabPages.Remove(tabGerarRel);
            tabControlGeral.TabPages.Insert(0, tabParticipante);

            btnCadastro.Visible = true;
            btnParticipante.Visible = true;
            btnvisualizar.Visible = true;
            btnCadastro.Enabled = true;
            btnParticipante.Enabled = false;
            btnvisualizar.Enabled = true;
            btnGerarRel.Enabled = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControlGeral.TabPages.Remove(tabCadastro);
            tabControlGeral.TabPages.Remove(tabParticipante);
            tabControlGeral.TabPages.Remove(tabVisuRel);
            tabControlGeral.TabPages.Remove(tabGerarRel);
            tabControlGeral.TabPages.Insert(0, tabCadastro);
            btnCadastro.Visible = true;
            btnParticipante.Visible = true;
            btnvisualizar.Visible = true;
            btnCadastro.Enabled = false;
            btnParticipante.Enabled = true;
            btnvisualizar.Enabled = true;
            btnGerarRel.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void button3_Click(object sender, EventArgs e) {

            tabControlGeral.TabPages.Remove(tabCadastro);
            tabControlGeral.TabPages.Remove(tabParticipante);
            tabControlGeral.TabPages.Remove(tabVisuRel);
            tabControlGeral.TabPages.Remove(tabGerarRel);
            tabControlGeral.TabPages.Insert(0, tabVisuRel);
            btnCadastro.Visible = true;
            btnParticipante.Visible = true;
            btnvisualizar.Visible = true;
            btnCadastro.Enabled = true;
            btnParticipante.Enabled = true;
            btnvisualizar.Enabled = false;
            btnGerarRel.Enabled = true;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) {

            txtProntuario.Enabled = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) {

            txtProntuario.Enabled = true;
        }

        private void label12_Click(object sender, EventArgs e) {

        }

        private void textBox7_TextChanged(object sender, EventArgs e) {

        }

        private void label18_Click(object sender, EventArgs e) {

        }

        private void button4_Click(object sender, EventArgs e) {

            tabControlGeral.TabPages.Remove(tabCadastro);
            tabControlGeral.TabPages.Remove(tabParticipante);
            tabControlGeral.TabPages.Remove(tabVisuRel);
            tabControlGeral.TabPages.Remove(tabGerarRel);
            tabControlGeral.TabPages.Insert(0, tabGerarRel);
            btnCadastro.Visible = true;
            btnParticipante.Visible = true;
            btnvisualizar.Visible = true;
            btnGerarRel.Visible = true;
            btnCadastro.Enabled = true;
            btnParticipante.Enabled = true;
            btnvisualizar.Enabled = true;
            btnGerarRel.Enabled = false;


        }

        private void trackBar1_Scroll(object sender, EventArgs e) {

        }
    }
}
