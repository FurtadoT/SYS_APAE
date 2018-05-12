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
    public partial class FormStudentList : Form
    {
        public FormStudentList()
        {
            InitializeComponent();
        }

        public void FetchData()
        {
            dtGridStudents.DataSource = StudentsDTO.getAllStudentsUsingView();
            dtGridStudents.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        private void FormStudentList_Load(object sender, EventArgs e)
        {
            FetchData();
        }

        private void dtGridStudents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormStudentDetail FormDetails = new FormStudentDetail(dtGridStudents.Rows[e.RowIndex].Cells["id"].Value.ToString());
            FormDetails.ShowDialog();
        }
    }
}
