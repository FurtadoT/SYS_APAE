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
            tabControl1.TabPages.Remove(tabPage1);
            tabControl1.TabPages.Remove(tabPage2);
            tabControl1.TabPages.Remove(tabPage3);

            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPage1);
            tabControl1.TabPages.Remove(tabPage2);
            tabControl1.TabPages.Remove(tabPage3);
            tabControl1.TabPages.Insert(0, tabPage2);

            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = true;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPage1);
            tabControl1.TabPages.Remove(tabPage2);
            tabControl1.TabPages.Remove(tabPage3);
            tabControl1.TabPages.Insert(0, tabPage1);
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void button3_Click(object sender, EventArgs e) {

            tabControl1.TabPages.Remove(tabPage1);
            tabControl1.TabPages.Remove(tabPage2);
            tabControl1.TabPages.Remove(tabPage3);
            tabControl1.TabPages.Insert(0, tabPage3);
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = false;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) {

            textBox1.Enabled = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) {

            textBox1.Enabled = true;
        }
    }
}
