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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!LoginDTO.verifyLogin(txtUser.Text, txtPassword.Text))
            {
                MessageBox.Show("Usuário não encontrado!");

                return;
            }

            MainMenu mainMenu = new MainMenu();
            this.Hide();
            mainMenu.ShowDialog();
            Application.Exit();
        }
    }
}
