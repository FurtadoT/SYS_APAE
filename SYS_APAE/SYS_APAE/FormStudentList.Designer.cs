namespace SYS_APAE
{
    partial class FormStudentList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dtGridStudents = new System.Windows.Forms.DataGridView();
            this.bdSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridStudents
            // 
            this.dtGridStudents.AllowUserToAddRows = false;
            this.dtGridStudents.AllowUserToDeleteRows = false;
            this.dtGridStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGridStudents.Location = new System.Drawing.Point(0, 0);
            this.dtGridStudents.Name = "dtGridStudents";
            this.dtGridStudents.ReadOnly = true;
            this.dtGridStudents.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtGridStudents.Size = new System.Drawing.Size(1008, 729);
            this.dtGridStudents.TabIndex = 0;
            this.dtGridStudents.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridStudents_CellDoubleClick);
            // 
            // FormStudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.dtGridStudents);
            this.Name = "FormStudentList";
            this.Text = "SYS APAE";
            this.Load += new System.EventHandler(this.FormStudentList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridStudents;
        private System.Windows.Forms.BindingSource bdSource;
    }
}

