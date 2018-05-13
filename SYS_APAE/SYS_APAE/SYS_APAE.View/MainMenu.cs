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
    }
}
