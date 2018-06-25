namespace SYS_APAE.SYS_APAE.View
{
    partial class InstructorDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstructorDetail));
            this.gpbShowInfo = new System.Windows.Forms.GroupBox();
            this.lblCreated = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblTagId = new System.Windows.Forms.Label();
            this.lblTagCreated = new System.Windows.Forms.Label();
            this.pnlGreenDetail = new System.Windows.Forms.Panel();
            this.pnlSave = new System.Windows.Forms.Panel();
            this.lblSave = new System.Windows.Forms.Label();
            this.lblCancel = new System.Windows.Forms.Label();
            this.pnlCancel = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTagEmail = new System.Windows.Forms.Label();
            this.sptStudent = new System.Windows.Forms.SplitContainer();
            this.gpbExtFields = new System.Windows.Forms.GroupBox();
            this.gpbPersonal = new System.Windows.Forms.GroupBox();
            this.txtCPF = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomMaskedTextBoxWithLabel();
            this.txtEmail = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBoxWithLabel();
            this.txtName = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBoxWithLabel();
            this.logo_if = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblCargaInstructor = new System.Windows.Forms.Label();
            this.txtCargaInstructor = new System.Windows.Forms.NumericUpDown();
            this.txtTipoInstructor = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBoxWithLabel();
            this.txtProntuarioInstructor = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomMaskedTextBoxWithLabel();
            this.lblName = new System.Windows.Forms.Label();
            this.gpbShowInfo.SuspendLayout();
            this.pnlSave.SuspendLayout();
            this.pnlCancel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sptStudent)).BeginInit();
            this.sptStudent.Panel1.SuspendLayout();
            this.sptStudent.Panel2.SuspendLayout();
            this.sptStudent.SuspendLayout();
            this.gpbExtFields.SuspendLayout();
            this.gpbPersonal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_if)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCargaInstructor)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbShowInfo
            // 
            this.gpbShowInfo.Controls.Add(this.lblCreated);
            this.gpbShowInfo.Controls.Add(this.lblId);
            this.gpbShowInfo.Controls.Add(this.lblTagId);
            this.gpbShowInfo.Controls.Add(this.lblTagCreated);
            this.gpbShowInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbShowInfo.Location = new System.Drawing.Point(3, 121);
            this.gpbShowInfo.Name = "gpbShowInfo";
            this.gpbShowInfo.Size = new System.Drawing.Size(185, 122);
            this.gpbShowInfo.TabIndex = 8;
            this.gpbShowInfo.TabStop = false;
            this.gpbShowInfo.Text = "Geral";
            // 
            // lblCreated
            // 
            this.lblCreated.AutoSize = true;
            this.lblCreated.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreated.Location = new System.Drawing.Point(20, 88);
            this.lblCreated.Name = "lblCreated";
            this.lblCreated.Size = new System.Drawing.Size(0, 15);
            this.lblCreated.TabIndex = 3;
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
            // lblTagId
            // 
            this.lblTagId.AutoSize = true;
            this.lblTagId.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTagId.Location = new System.Drawing.Point(9, 27);
            this.lblTagId.Name = "lblTagId";
            this.lblTagId.Size = new System.Drawing.Size(52, 12);
            this.lblTagId.TabIndex = 1;
            this.lblTagId.Text = "Id do aluno:";
            // 
            // lblTagCreated
            // 
            this.lblTagCreated.AutoSize = true;
            this.lblTagCreated.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTagCreated.Location = new System.Drawing.Point(9, 72);
            this.lblTagCreated.Name = "lblTagCreated";
            this.lblTagCreated.Size = new System.Drawing.Size(50, 12);
            this.lblTagCreated.TabIndex = 0;
            this.lblTagCreated.Text = "Criado em:";
            // 
            // pnlGreenDetail
            // 
            this.pnlGreenDetail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlGreenDetail.AutoSize = true;
            this.pnlGreenDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(153)))), ((int)(((byte)(54)))));
            this.pnlGreenDetail.Location = new System.Drawing.Point(0, 73);
            this.pnlGreenDetail.Name = "pnlGreenDetail";
            this.pnlGreenDetail.Size = new System.Drawing.Size(191, 10);
            this.pnlGreenDetail.TabIndex = 7;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.lblTagEmail);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 77);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contato";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(20, 43);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(0, 15);
            this.lblEmail.TabIndex = 2;
            // 
            // lblTagEmail
            // 
            this.lblTagEmail.AutoSize = true;
            this.lblTagEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTagEmail.Location = new System.Drawing.Point(9, 27);
            this.lblTagEmail.Name = "lblTagEmail";
            this.lblTagEmail.Size = new System.Drawing.Size(34, 12);
            this.lblTagEmail.TabIndex = 1;
            this.lblTagEmail.Text = "E-mail:";
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
            this.sptStudent.Panel1.Controls.Add(this.lblName);
            this.sptStudent.Panel1.Controls.Add(this.groupBox1);
            this.sptStudent.Panel1.Controls.Add(this.gpbShowInfo);
            this.sptStudent.Panel1.Controls.Add(this.pnlGreenDetail);
            this.sptStudent.Panel1.Controls.Add(this.logo_if);
            // 
            // sptStudent.Panel2
            // 
            this.sptStudent.Panel2.Controls.Add(this.pnlCancel);
            this.sptStudent.Panel2.Controls.Add(this.pnlSave);
            this.sptStudent.Panel2.Controls.Add(this.gpbExtFields);
            this.sptStudent.Panel2.Controls.Add(this.gpbPersonal);
            this.sptStudent.Size = new System.Drawing.Size(724, 511);
            this.sptStudent.SplitterDistance = 191;
            this.sptStudent.TabIndex = 1;
            // 
            // gpbExtFields
            // 
            this.gpbExtFields.Controls.Add(this.lblCargaInstructor);
            this.gpbExtFields.Controls.Add(this.txtCargaInstructor);
            this.gpbExtFields.Controls.Add(this.txtTipoInstructor);
            this.gpbExtFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbExtFields.Location = new System.Drawing.Point(3, 215);
            this.gpbExtFields.Name = "gpbExtFields";
            this.gpbExtFields.Size = new System.Drawing.Size(523, 103);
            this.gpbExtFields.TabIndex = 4;
            this.gpbExtFields.TabStop = false;
            this.gpbExtFields.Text = "Informações da Monitoria";
            // 
            // gpbPersonal
            // 
            this.gpbPersonal.Controls.Add(this.txtProntuarioInstructor);
            this.gpbPersonal.Controls.Add(this.txtCPF);
            this.gpbPersonal.Controls.Add(this.txtEmail);
            this.gpbPersonal.Controls.Add(this.txtName);
            this.gpbPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPersonal.Location = new System.Drawing.Point(3, 65);
            this.gpbPersonal.Name = "gpbPersonal";
            this.gpbPersonal.Size = new System.Drawing.Size(523, 140);
            this.gpbPersonal.TabIndex = 3;
            this.gpbPersonal.TabStop = false;
            this.gpbPersonal.Text = "Informações Pessoais";
            // 
            // txtCPF
            // 
            this.txtCPF.ErrorMessage = "";
            this.txtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF.Location = new System.Drawing.Point(269, 73);
            this.txtCPF.Mask = "000.000.000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(95, 35);
            this.txtCPF.TabIndex = 24;
            this.txtCPF.Tag = "CPF";
            // 
            // txtEmail
            // 
            this.txtEmail.ErrorMessage = "";
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(8, 73);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ReadOnly = false;
            this.txtEmail.Size = new System.Drawing.Size(248, 35);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.Tag = "Email";
            // 
            // txtName
            // 
            this.txtName.ErrorMessage = "";
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(8, 24);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ReadOnly = false;
            this.txtName.Size = new System.Drawing.Size(345, 35);
            this.txtName.TabIndex = 0;
            this.txtName.Tag = "Nome";
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
            // lblCargaInstructor
            // 
            this.lblCargaInstructor.AutoSize = true;
            this.lblCargaInstructor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargaInstructor.Location = new System.Drawing.Point(223, 24);
            this.lblCargaInstructor.Name = "lblCargaInstructor";
            this.lblCargaInstructor.Size = new System.Drawing.Size(107, 13);
            this.lblCargaInstructor.TabIndex = 27;
            this.lblCargaInstructor.Text = "Carga Horária (horas)";
            // 
            // txtCargaInstructor
            // 
            this.txtCargaInstructor.BackColor = System.Drawing.SystemColors.Control;
            this.txtCargaInstructor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCargaInstructor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargaInstructor.Location = new System.Drawing.Point(225, 42);
            this.txtCargaInstructor.Name = "txtCargaInstructor";
            this.txtCargaInstructor.Size = new System.Drawing.Size(120, 16);
            this.txtCargaInstructor.TabIndex = 28;
            // 
            // txtTipoInstructor
            // 
            this.txtTipoInstructor.ErrorMessage = "";
            this.txtTipoInstructor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoInstructor.Location = new System.Drawing.Point(14, 24);
            this.txtTipoInstructor.Name = "txtTipoInstructor";
            this.txtTipoInstructor.PasswordChar = '\0';
            this.txtTipoInstructor.ReadOnly = false;
            this.txtTipoInstructor.Size = new System.Drawing.Size(196, 35);
            this.txtTipoInstructor.TabIndex = 26;
            this.txtTipoInstructor.Tag = "Tipo";
            // 
            // txtProntuarioInstructor
            // 
            this.txtProntuarioInstructor.ErrorMessage = "";
            this.txtProntuarioInstructor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProntuarioInstructor.Location = new System.Drawing.Point(366, 24);
            this.txtProntuarioInstructor.Mask = "000000-A";
            this.txtProntuarioInstructor.Name = "txtProntuarioInstructor";
            this.txtProntuarioInstructor.Size = new System.Drawing.Size(149, 35);
            this.txtProntuarioInstructor.TabIndex = 25;
            this.txtProntuarioInstructor.Tag = "Prontuário";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(11, 94);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 15);
            this.lblName.TabIndex = 11;
            // 
            // InstructorsDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 511);
            this.Controls.Add(this.sptStudent);
            this.Name = "InstructorsDetail";
            this.Text = "InstructorsDetail";
            this.gpbShowInfo.ResumeLayout(false);
            this.gpbShowInfo.PerformLayout();
            this.pnlSave.ResumeLayout(false);
            this.pnlSave.PerformLayout();
            this.pnlCancel.ResumeLayout(false);
            this.pnlCancel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.sptStudent.Panel1.ResumeLayout(false);
            this.sptStudent.Panel1.PerformLayout();
            this.sptStudent.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sptStudent)).EndInit();
            this.sptStudent.ResumeLayout(false);
            this.gpbExtFields.ResumeLayout(false);
            this.gpbExtFields.PerformLayout();
            this.gpbPersonal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo_if)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCargaInstructor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gpbShowInfo;
        private System.Windows.Forms.Label lblCreated;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblTagId;
        private System.Windows.Forms.Label lblTagCreated;
        private System.Windows.Forms.Panel pnlGreenDetail;
        private System.Windows.Forms.Panel pnlSave;
        private System.Windows.Forms.Label lblSave;
        private System.Windows.Forms.Label lblCancel;
        private System.Windows.Forms.Panel pnlCancel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTagEmail;
        private System.Windows.Forms.PictureBox logo_if;
        private System.Windows.Forms.SplitContainer sptStudent;
        private System.Windows.Forms.GroupBox gpbExtFields;
        private System.Windows.Forms.GroupBox gpbPersonal;
        private SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomMaskedTextBoxWithLabel txtCPF;
        private SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBoxWithLabel txtEmail;
        private SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBoxWithLabel txtName;
        private System.Windows.Forms.Label lblCargaInstructor;
        private System.Windows.Forms.NumericUpDown txtCargaInstructor;
        private SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBoxWithLabel txtTipoInstructor;
        private SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomMaskedTextBoxWithLabel txtProntuarioInstructor;
        private System.Windows.Forms.Label lblName;
    }
}