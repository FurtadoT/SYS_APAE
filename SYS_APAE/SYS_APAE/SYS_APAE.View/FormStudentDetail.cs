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

namespace SYS_APAE
{
    public partial class FormStudentDetail : Form
    {
        private string studentId;

        public FormStudentDetail(String studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
        }

        public void FetchData()
        {
            Student student = StudentsDTO.getStudentById(this.studentId);

            MessageBox.Show(student.ToString());
        }

        private void FormStudentDetail_Load(object sender, EventArgs e)
        {
            FetchData();
        }
    }
}
