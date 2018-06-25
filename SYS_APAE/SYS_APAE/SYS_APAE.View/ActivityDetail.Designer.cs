namespace SYS_APAE.SYS_APAE.View
{
    partial class ActivityDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivityDetail));
            this.btnSave = new System.Windows.Forms.Button();
            this.logo_if = new System.Windows.Forms.PictureBox();
            this.sptStudent = new System.Windows.Forms.SplitContainer();
            this.gpbShowInfo = new System.Windows.Forms.GroupBox();
            this.lblTagInstructor = new System.Windows.Forms.Label();
            this.pnlGreenDetail = new System.Windows.Forms.Panel();
            this.pnlCancel = new System.Windows.Forms.Panel();
            this.lblCancel = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlSave = new System.Windows.Forms.Panel();
            this.lblSave = new System.Windows.Forms.Label();
            this.gpbPersonal = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblTagStudent = new System.Windows.Forms.Label();
            this.lblCreated = new System.Windows.Forms.Label();
            this.lblDescriptionActivity = new System.Windows.Forms.Label();
            this.txtDescriptionActivity = new System.Windows.Forms.TextBox();
            this.txtTitleActivity = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBoxWithLabel();
            ((System.ComponentModel.ISupportInitialize)(this.logo_if)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sptStudent)).BeginInit();
            this.sptStudent.Panel1.SuspendLayout();
            this.sptStudent.Panel2.SuspendLayout();
            this.sptStudent.SuspendLayout();
            this.gpbShowInfo.SuspendLayout();
            this.pnlCancel.SuspendLayout();
            this.pnlSave.SuspendLayout();
            this.gpbPersonal.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::SYS_APAE.Properties.Resources._checked;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Location = new System.Drawing.Point(0, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(23, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseEnter += new System.EventHandler(this.btnSave_MouseEnter);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            // 
            // logo_if
            // 
            this.logo_if.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo_if.BackgroundImage")));
            this.logo_if.Location = new System.Drawing.Point(3, 3);
            this.logo_if.Name = "logo_if";
            this.logo_if.Size = new System.Drawing.Size(48, 61);
            this.logo_if.TabIndex = 6;
            this.logo_if.TabStop = false;
            // 
            // sptStudent
            // 
            this.sptStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sptStudent.Location = new System.Drawing.Point(0, 0);
            this.sptStudent.Name = "sptStudent";
            // 
            // sptStudent.Panel1
            // 
            this.sptStudent.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.sptStudent.Panel1.Controls.Add(this.gpbShowInfo);
            this.sptStudent.Panel1.Controls.Add(this.pnlGreenDetail);
            this.sptStudent.Panel1.Controls.Add(this.logo_if);
            // 
            // sptStudent.Panel2
            // 
            this.sptStudent.Panel2.Controls.Add(this.pnlCancel);
            this.sptStudent.Panel2.Controls.Add(this.pnlSave);
            this.sptStudent.Panel2.Controls.Add(this.gpbPersonal);
            this.sptStudent.Size = new System.Drawing.Size(724, 511);
            this.sptStudent.SplitterDistance = 191;
            this.sptStudent.TabIndex = 3;
            // 
            // gpbShowInfo
            // 
            this.gpbShowInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbShowInfo.Controls.Add(this.lblCreated);
            this.gpbShowInfo.Controls.Add(this.lblTagStudent);
            this.gpbShowInfo.Controls.Add(this.lblId);
            this.gpbShowInfo.Controls.Add(this.lblTagInstructor);
            this.gpbShowInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbShowInfo.Location = new System.Drawing.Point(3, 89);
            this.gpbShowInfo.Name = "gpbShowInfo";
            this.gpbShowInfo.Size = new System.Drawing.Size(185, 115);
            this.gpbShowInfo.TabIndex = 8;
            this.gpbShowInfo.TabStop = false;
            this.gpbShowInfo.Text = "Geral";
            // 
            // lblTagInstructor
            // 
            this.lblTagInstructor.AutoSize = true;
            this.lblTagInstructor.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTagInstructor.Location = new System.Drawing.Point(9, 27);
            this.lblTagInstructor.Name = "lblTagInstructor";
            this.lblTagInstructor.Size = new System.Drawing.Size(70, 12);
            this.lblTagInstructor.TabIndex = 1;
            this.lblTagInstructor.Text = "Id da Atividade:";
            // 
            // pnlGreenDetail
            // 
            this.pnlGreenDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGreenDetail.AutoSize = true;
            this.pnlGreenDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(153)))), ((int)(((byte)(54)))));
            this.pnlGreenDetail.Location = new System.Drawing.Point(0, 73);
            this.pnlGreenDetail.Name = "pnlGreenDetail";
            this.pnlGreenDetail.Size = new System.Drawing.Size(191, 10);
            this.pnlGreenDetail.TabIndex = 7;
            // 
            // pnlCancel
            // 
            this.pnlCancel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCancel.Controls.Add(this.lblCancel);
            this.pnlCancel.Controls.Add(this.btnCancel);
            this.pnlCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlCancel.Location = new System.Drawing.Point(16, 29);
            this.pnlCancel.Name = "pnlCancel";
            this.pnlCancel.Size = new System.Drawing.Size(81, 25);
            this.pnlCancel.TabIndex = 10;
            this.pnlCancel.Click += new System.EventHandler(this.pnlCancel_Click);
            this.pnlCancel.MouseEnter += new System.EventHandler(this.pnlCancel_MouseEnter);
            this.pnlCancel.MouseLeave += new System.EventHandler(this.pnlCancel_MouseLeave);
            // 
            // lblCancel
            // 
            this.lblCancel.AutoSize = true;
            this.lblCancel.Location = new System.Drawing.Point(29, 5);
            this.lblCancel.Name = "lblCancel";
            this.lblCancel.Size = new System.Drawing.Size(49, 13);
            this.lblCancel.TabIndex = 10;
            this.lblCancel.Text = "Cancelar";
            this.lblCancel.Click += new System.EventHandler(this.lblCancel_Click);
            this.lblCancel.MouseEnter += new System.EventHandler(this.lblCancel_MouseEnter);
            this.lblCancel.MouseLeave += new System.EventHandler(this.lblCancel_MouseLeave);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(0, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.btnCancel.Size = new System.Drawing.Size(23, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "X";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.MouseEnter += new System.EventHandler(this.btnCancel_MouseEnter);
            this.btnCancel.MouseLeave += new System.EventHandler(this.btnCancel_MouseLeave);
            // 
            // pnlSave
            // 
            this.pnlSave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSave.Controls.Add(this.btnSave);
            this.pnlSave.Controls.Add(this.lblSave);
            this.pnlSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlSave.Location = new System.Drawing.Point(123, 29);
            this.pnlSave.Name = "pnlSave";
            this.pnlSave.Size = new System.Drawing.Size(73, 25);
            this.pnlSave.TabIndex = 9;
            this.pnlSave.Click += new System.EventHandler(this.pnlSave_Click);
            this.pnlSave.MouseEnter += new System.EventHandler(this.pnlSave_MouseEnter);
            this.pnlSave.MouseLeave += new System.EventHandler(this.pnlSave_MouseLeave);
            // 
            // lblSave
            // 
            this.lblSave.AutoSize = true;
            this.lblSave.Location = new System.Drawing.Point(29, 5);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(37, 13);
            this.lblSave.TabIndex = 8;
            this.lblSave.Text = "Salvar";
            this.lblSave.Click += new System.EventHandler(this.lblSave_Click);
            this.lblSave.MouseEnter += new System.EventHandler(this.lblSave_MouseEnter);
            this.lblSave.MouseLeave += new System.EventHandler(this.lblSave_MouseLeave);
            // 
            // gpbPersonal
            // 
            this.gpbPersonal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbPersonal.Controls.Add(this.lblDescriptionActivity);
            this.gpbPersonal.Controls.Add(this.txtDescriptionActivity);
            this.gpbPersonal.Controls.Add(this.txtTitleActivity);
            this.gpbPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPersonal.Location = new System.Drawing.Point(3, 65);
            this.gpbPersonal.Name = "gpbPersonal";
            this.gpbPersonal.Size = new System.Drawing.Size(523, 346);
            this.gpbPersonal.TabIndex = 3;
            this.gpbPersonal.TabStop = false;
            this.gpbPersonal.Text = "Dados da aula";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(20, 43);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 15);
            this.lblId.TabIndex = 2;
            // 
            // lblTagStudent
            // 
            this.lblTagStudent.AutoSize = true;
            this.lblTagStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTagStudent.Location = new System.Drawing.Point(9, 65);
            this.lblTagStudent.Name = "lblTagStudent";
            this.lblTagStudent.Size = new System.Drawing.Size(50, 12);
            this.lblTagStudent.TabIndex = 4;
            this.lblTagStudent.Text = "Criado em:";
            // 
            // lblCreated
            // 
            this.lblCreated.AutoSize = true;
            this.lblCreated.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreated.Location = new System.Drawing.Point(20, 81);
            this.lblCreated.Name = "lblCreated";
            this.lblCreated.Size = new System.Drawing.Size(0, 15);
            this.lblCreated.TabIndex = 5;
            // 
            // lblDescriptionActivity
            // 
            this.lblDescriptionActivity.AutoSize = true;
            this.lblDescriptionActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriptionActivity.Location = new System.Drawing.Point(13, 86);
            this.lblDescriptionActivity.Name = "lblDescriptionActivity";
            this.lblDescriptionActivity.Size = new System.Drawing.Size(47, 12);
            this.lblDescriptionActivity.TabIndex = 6;
            this.lblDescriptionActivity.Text = "Descrição";
            // 
            // txtDescriptionActivity
            // 
            this.txtDescriptionActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescriptionActivity.Location = new System.Drawing.Point(14, 102);
            this.txtDescriptionActivity.Multiline = true;
            this.txtDescriptionActivity.Name = "txtDescriptionActivity";
            this.txtDescriptionActivity.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescriptionActivity.Size = new System.Drawing.Size(500, 232);
            this.txtDescriptionActivity.TabIndex = 5;
            // 
            // txtTitleActivity
            // 
            this.txtTitleActivity.ErrorMessage = "";
            this.txtTitleActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitleActivity.Location = new System.Drawing.Point(14, 29);
            this.txtTitleActivity.Name = "txtTitleActivity";
            this.txtTitleActivity.PasswordChar = '\0';
            this.txtTitleActivity.ReadOnly = false;
            this.txtTitleActivity.Size = new System.Drawing.Size(437, 35);
            this.txtTitleActivity.TabIndex = 4;
            this.txtTitleActivity.Tag = "Título";
            // 
            // ActivityDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 511);
            this.Controls.Add(this.sptStudent);
            this.Name = "ActivityDetail";
            this.Text = "ActivityDetail";
            ((System.ComponentModel.ISupportInitialize)(this.logo_if)).EndInit();
            this.sptStudent.Panel1.ResumeLayout(false);
            this.sptStudent.Panel1.PerformLayout();
            this.sptStudent.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sptStudent)).EndInit();
            this.sptStudent.ResumeLayout(false);
            this.gpbShowInfo.ResumeLayout(false);
            this.gpbShowInfo.PerformLayout();
            this.pnlCancel.ResumeLayout(false);
            this.pnlCancel.PerformLayout();
            this.pnlSave.ResumeLayout(false);
            this.pnlSave.PerformLayout();
            this.gpbPersonal.ResumeLayout(false);
            this.gpbPersonal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox logo_if;
        private System.Windows.Forms.SplitContainer sptStudent;
        private System.Windows.Forms.GroupBox gpbShowInfo;
        private System.Windows.Forms.Label lblCreated;
        private System.Windows.Forms.Label lblTagStudent;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblTagInstructor;
        private System.Windows.Forms.Panel pnlGreenDetail;
        private System.Windows.Forms.Panel pnlCancel;
        private System.Windows.Forms.Label lblCancel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlSave;
        private System.Windows.Forms.Label lblSave;
        private System.Windows.Forms.GroupBox gpbPersonal;
        private System.Windows.Forms.Label lblDescriptionActivity;
        private System.Windows.Forms.TextBox txtDescriptionActivity;
        private SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBoxWithLabel txtTitleActivity;
    }
}