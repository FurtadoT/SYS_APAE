namespace SYS_APAE.SYS_APAE.View
{
    partial class StudentDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentDetail));
            this.sptStudent = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTagEmail = new System.Windows.Forms.Label();
            this.gpbShowInfo = new System.Windows.Forms.GroupBox();
            this.lblCreated = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblTagId = new System.Windows.Forms.Label();
            this.lblTagCreated = new System.Windows.Forms.Label();
            this.pnlGreenDetail = new System.Windows.Forms.Panel();
            this.logo_if = new System.Windows.Forms.PictureBox();
            this.pnlCancel = new System.Windows.Forms.Panel();
            this.lblCancel = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlSave = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblSave = new System.Windows.Forms.Label();
            this.gpbAddress = new System.Windows.Forms.GroupBox();
            this.txtEnd = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBoxWithLabel();
            this.txtCep = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomMaskedTextBoxWithLabel();
            this.txtCidade = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBoxWithLabel();
            this.txtCelular = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomMaskedTextBoxWithLabel();
            this.txtEstado = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBoxWithLabel();
            this.txtTel = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomMaskedTextBoxWithLabel();
            this.txtBairro = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBoxWithLabel();
            this.gpbPersonal = new System.Windows.Forms.GroupBox();
            this.txtNaturalidade = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBoxWithLabel();
            this.txtMae = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBoxWithLabel();
            this.lblDtExp = new System.Windows.Forms.Label();
            this.txtPai = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBoxWithLabel();
            this.txtCPF = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomMaskedTextBoxWithLabel();
            this.dtpExp = new System.Windows.Forms.DateTimePicker();
            this.txtRG = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomMaskedTextBoxWithLabel();
            this.txtOrgExp = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBoxWithLabel();
            this.dtpNasc = new System.Windows.Forms.DateTimePicker();
            this.lblNasc = new System.Windows.Forms.Label();
            this.txtEmail = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBoxWithLabel();
            this.txtName = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBoxWithLabel();
            this.lblTagPhone = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblCel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sptStudent)).BeginInit();
            this.sptStudent.Panel1.SuspendLayout();
            this.sptStudent.Panel2.SuspendLayout();
            this.sptStudent.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gpbShowInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_if)).BeginInit();
            this.pnlCancel.SuspendLayout();
            this.pnlSave.SuspendLayout();
            this.gpbAddress.SuspendLayout();
            this.gpbPersonal.SuspendLayout();
            this.SuspendLayout();
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
            this.sptStudent.Panel1.Controls.Add(this.groupBox1);
            this.sptStudent.Panel1.Controls.Add(this.gpbShowInfo);
            this.sptStudent.Panel1.Controls.Add(this.pnlGreenDetail);
            this.sptStudent.Panel1.Controls.Add(this.logo_if);
            // 
            // sptStudent.Panel2
            // 
            this.sptStudent.Panel2.Controls.Add(this.pnlCancel);
            this.sptStudent.Panel2.Controls.Add(this.pnlSave);
            this.sptStudent.Panel2.Controls.Add(this.gpbAddress);
            this.sptStudent.Panel2.Controls.Add(this.gpbPersonal);
            this.sptStudent.Size = new System.Drawing.Size(724, 511);
            this.sptStudent.SplitterDistance = 191;
            this.sptStudent.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCel);
            this.groupBox1.Controls.Add(this.lblPhone);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.lblTagEmail);
            this.groupBox1.Controls.Add(this.lblTagPhone);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 131);
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
            // gpbShowInfo
            // 
            this.gpbShowInfo.Controls.Add(this.lblCreated);
            this.gpbShowInfo.Controls.Add(this.lblId);
            this.gpbShowInfo.Controls.Add(this.lblTagId);
            this.gpbShowInfo.Controls.Add(this.lblTagCreated);
            this.gpbShowInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbShowInfo.Location = new System.Drawing.Point(3, 90);
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
            // logo_if
            // 
            this.logo_if.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo_if.BackgroundImage")));
            this.logo_if.Location = new System.Drawing.Point(3, 3);
            this.logo_if.Name = "logo_if";
            this.logo_if.Size = new System.Drawing.Size(48, 61);
            this.logo_if.TabIndex = 6;
            this.logo_if.TabStop = false;
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
            // gpbAddress
            // 
            this.gpbAddress.Controls.Add(this.txtEnd);
            this.gpbAddress.Controls.Add(this.txtCep);
            this.gpbAddress.Controls.Add(this.txtCidade);
            this.gpbAddress.Controls.Add(this.txtCelular);
            this.gpbAddress.Controls.Add(this.txtEstado);
            this.gpbAddress.Controls.Add(this.txtTel);
            this.gpbAddress.Controls.Add(this.txtBairro);
            this.gpbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbAddress.Location = new System.Drawing.Point(3, 337);
            this.gpbAddress.Name = "gpbAddress";
            this.gpbAddress.Size = new System.Drawing.Size(523, 168);
            this.gpbAddress.TabIndex = 4;
            this.gpbAddress.TabStop = false;
            this.gpbAddress.Text = "Informações de Contato";
            // 
            // txtEnd
            // 
            this.txtEnd.ErrorMessage = "";
            this.txtEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnd.Location = new System.Drawing.Point(106, 22);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.PasswordChar = '\0';
            this.txtEnd.ReadOnly = false;
            this.txtEnd.Size = new System.Drawing.Size(292, 35);
            this.txtEnd.TabIndex = 2;
            this.txtEnd.Tag = "Endereço";
            // 
            // txtCep
            // 
            this.txtCep.ErrorMessage = "";
            this.txtCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCep.Location = new System.Drawing.Point(13, 22);
            this.txtCep.Mask = "00.000-000";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(80, 35);
            this.txtCep.TabIndex = 1;
            this.txtCep.Tag = "CEP";
            // 
            // txtCidade
            // 
            this.txtCidade.ErrorMessage = "";
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(296, 71);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.PasswordChar = '\0';
            this.txtCidade.ReadOnly = false;
            this.txtCidade.Size = new System.Drawing.Size(209, 35);
            this.txtCidade.TabIndex = 5;
            this.txtCidade.Tag = "Cidade";
            // 
            // txtCelular
            // 
            this.txtCelular.ErrorMessage = "";
            this.txtCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.Location = new System.Drawing.Point(13, 120);
            this.txtCelular.Mask = "(00) 00000-000#";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(164, 35);
            this.txtCelular.TabIndex = 6;
            this.txtCelular.Tag = "Celular";
            // 
            // txtEstado
            // 
            this.txtEstado.ErrorMessage = "";
            this.txtEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(411, 22);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.PasswordChar = '\0';
            this.txtEstado.ReadOnly = false;
            this.txtEstado.Size = new System.Drawing.Size(94, 35);
            this.txtEstado.TabIndex = 4;
            this.txtEstado.Tag = "Estado";
            // 
            // txtTel
            // 
            this.txtTel.ErrorMessage = "";
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(190, 120);
            this.txtTel.Mask = "(00) 0000-0000";
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(164, 35);
            this.txtTel.TabIndex = 7;
            this.txtTel.Tag = "Telefone";
            // 
            // txtBairro
            // 
            this.txtBairro.ErrorMessage = "";
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(13, 71);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.PasswordChar = '\0';
            this.txtBairro.ReadOnly = false;
            this.txtBairro.Size = new System.Drawing.Size(270, 35);
            this.txtBairro.TabIndex = 3;
            this.txtBairro.Tag = "Bairro";
            // 
            // gpbPersonal
            // 
            this.gpbPersonal.Controls.Add(this.txtNaturalidade);
            this.gpbPersonal.Controls.Add(this.txtMae);
            this.gpbPersonal.Controls.Add(this.lblDtExp);
            this.gpbPersonal.Controls.Add(this.txtPai);
            this.gpbPersonal.Controls.Add(this.txtCPF);
            this.gpbPersonal.Controls.Add(this.dtpExp);
            this.gpbPersonal.Controls.Add(this.txtRG);
            this.gpbPersonal.Controls.Add(this.txtOrgExp);
            this.gpbPersonal.Controls.Add(this.dtpNasc);
            this.gpbPersonal.Controls.Add(this.lblNasc);
            this.gpbPersonal.Controls.Add(this.txtEmail);
            this.gpbPersonal.Controls.Add(this.txtName);
            this.gpbPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPersonal.Location = new System.Drawing.Point(3, 65);
            this.gpbPersonal.Name = "gpbPersonal";
            this.gpbPersonal.Size = new System.Drawing.Size(523, 270);
            this.gpbPersonal.TabIndex = 3;
            this.gpbPersonal.TabStop = false;
            this.gpbPersonal.Text = "Informações Pessoais";
            // 
            // txtNaturalidade
            // 
            this.txtNaturalidade.ErrorMessage = "";
            this.txtNaturalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaturalidade.Location = new System.Drawing.Point(373, 22);
            this.txtNaturalidade.Name = "txtNaturalidade";
            this.txtNaturalidade.PasswordChar = '\0';
            this.txtNaturalidade.ReadOnly = false;
            this.txtNaturalidade.Size = new System.Drawing.Size(132, 35);
            this.txtNaturalidade.TabIndex = 30;
            this.txtNaturalidade.Tag = "Naturalidade";
            // 
            // txtMae
            // 
            this.txtMae.ErrorMessage = "";
            this.txtMae.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMae.Location = new System.Drawing.Point(13, 174);
            this.txtMae.Name = "txtMae";
            this.txtMae.PasswordChar = '\0';
            this.txtMae.ReadOnly = false;
            this.txtMae.Size = new System.Drawing.Size(345, 35);
            this.txtMae.TabIndex = 29;
            this.txtMae.Tag = "Nome da mãe";
            // 
            // lblDtExp
            // 
            this.lblDtExp.AutoSize = true;
            this.lblDtExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtExp.Location = new System.Drawing.Point(276, 123);
            this.lblDtExp.Name = "lblDtExp";
            this.lblDtExp.Size = new System.Drawing.Size(98, 13);
            this.lblDtExp.TabIndex = 28;
            this.lblDtExp.Text = "Data de Expedição";
            // 
            // txtPai
            // 
            this.txtPai.ErrorMessage = "";
            this.txtPai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPai.Location = new System.Drawing.Point(13, 221);
            this.txtPai.Name = "txtPai";
            this.txtPai.PasswordChar = '\0';
            this.txtPai.ReadOnly = false;
            this.txtPai.Size = new System.Drawing.Size(345, 35);
            this.txtPai.TabIndex = 31;
            this.txtPai.Tag = "Nome do pai";
            // 
            // txtCPF
            // 
            this.txtCPF.ErrorMessage = "";
            this.txtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF.Location = new System.Drawing.Point(13, 123);
            this.txtCPF.Mask = "000.000.000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(95, 35);
            this.txtCPF.TabIndex = 24;
            this.txtCPF.Tag = "CPF";
            // 
            // dtpExp
            // 
            this.dtpExp.CustomFormat = "\"dd-MM-yyyy\"";
            this.dtpExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpExp.Location = new System.Drawing.Point(276, 138);
            this.dtpExp.Name = "dtpExp";
            this.dtpExp.Size = new System.Drawing.Size(229, 20);
            this.dtpExp.TabIndex = 27;
            this.dtpExp.Value = new System.DateTime(2018, 5, 13, 0, 19, 44, 0);
            // 
            // txtRG
            // 
            this.txtRG.ErrorMessage = "";
            this.txtRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRG.Location = new System.Drawing.Point(120, 123);
            this.txtRG.Mask = "00.000.000-A";
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(75, 35);
            this.txtRG.TabIndex = 25;
            this.txtRG.Tag = "RG";
            // 
            // txtOrgExp
            // 
            this.txtOrgExp.ErrorMessage = "";
            this.txtOrgExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrgExp.Location = new System.Drawing.Point(203, 123);
            this.txtOrgExp.Name = "txtOrgExp";
            this.txtOrgExp.PasswordChar = '\0';
            this.txtOrgExp.ReadOnly = false;
            this.txtOrgExp.Size = new System.Drawing.Size(60, 35);
            this.txtOrgExp.TabIndex = 26;
            this.txtOrgExp.Tag = "Orgão Exp.";
            // 
            // dtpNasc
            // 
            this.dtpNasc.CustomFormat = "\"dd-MM-yyyy\"";
            this.dtpNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNasc.Location = new System.Drawing.Point(277, 86);
            this.dtpNasc.Name = "dtpNasc";
            this.dtpNasc.Size = new System.Drawing.Size(228, 20);
            this.dtpNasc.TabIndex = 21;
            this.dtpNasc.Value = new System.DateTime(2018, 5, 13, 0, 19, 44, 0);
            // 
            // lblNasc
            // 
            this.lblNasc.AutoSize = true;
            this.lblNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNasc.Location = new System.Drawing.Point(276, 71);
            this.lblNasc.Name = "lblNasc";
            this.lblNasc.Size = new System.Drawing.Size(104, 13);
            this.lblNasc.TabIndex = 22;
            this.lblNasc.Text = "Data de Nascimento\r\n";
            // 
            // txtEmail
            // 
            this.txtEmail.ErrorMessage = "";
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(13, 71);
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
            this.txtName.Location = new System.Drawing.Point(13, 22);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ReadOnly = false;
            this.txtName.Size = new System.Drawing.Size(345, 35);
            this.txtName.TabIndex = 0;
            this.txtName.Tag = "Nome";
            // 
            // lblTagPhone
            // 
            this.lblTagPhone.AutoSize = true;
            this.lblTagPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTagPhone.Location = new System.Drawing.Point(9, 72);
            this.lblTagPhone.Name = "lblTagPhone";
            this.lblTagPhone.Size = new System.Drawing.Size(48, 12);
            this.lblTagPhone.TabIndex = 0;
            this.lblTagPhone.Text = "Telefones:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(20, 88);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(0, 15);
            this.lblPhone.TabIndex = 3;
            // 
            // lblCel
            // 
            this.lblCel.AutoSize = true;
            this.lblCel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCel.Location = new System.Drawing.Point(20, 107);
            this.lblCel.Name = "lblCel";
            this.lblCel.Size = new System.Drawing.Size(0, 15);
            this.lblCel.TabIndex = 4;
            // 
            // StudentDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 511);
            this.Controls.Add(this.sptStudent);
            this.Name = "StudentDetail";
            this.Text = "StudentDetail";
            this.sptStudent.Panel1.ResumeLayout(false);
            this.sptStudent.Panel1.PerformLayout();
            this.sptStudent.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sptStudent)).EndInit();
            this.sptStudent.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpbShowInfo.ResumeLayout(false);
            this.gpbShowInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_if)).EndInit();
            this.pnlCancel.ResumeLayout(false);
            this.pnlCancel.PerformLayout();
            this.pnlSave.ResumeLayout(false);
            this.pnlSave.PerformLayout();
            this.gpbAddress.ResumeLayout(false);
            this.gpbPersonal.ResumeLayout(false);
            this.gpbPersonal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer sptStudent;
        private SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBoxWithLabel txtName;
        private System.Windows.Forms.GroupBox gpbPersonal;
        private SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBoxWithLabel txtEmail;
        private System.Windows.Forms.DateTimePicker dtpNasc;
        private System.Windows.Forms.Label lblNasc;
        private System.Windows.Forms.Label lblDtExp;
        private SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomMaskedTextBoxWithLabel txtCPF;
        private System.Windows.Forms.DateTimePicker dtpExp;
        private SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomMaskedTextBoxWithLabel txtRG;
        private SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBoxWithLabel txtOrgExp;
        private SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBoxWithLabel txtNaturalidade;
        private SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBoxWithLabel txtMae;
        private SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBoxWithLabel txtPai;
        private System.Windows.Forms.GroupBox gpbAddress;
        private SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBoxWithLabel txtEnd;
        private SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomMaskedTextBoxWithLabel txtCep;
        private SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBoxWithLabel txtCidade;
        private SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomMaskedTextBoxWithLabel txtCelular;
        private SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBoxWithLabel txtEstado;
        private SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomMaskedTextBoxWithLabel txtTel;
        private SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBoxWithLabel txtBairro;
        private System.Windows.Forms.Label lblSave;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox logo_if;
        private System.Windows.Forms.GroupBox gpbShowInfo;
        private System.Windows.Forms.Panel pnlGreenDetail;
        private System.Windows.Forms.Panel pnlSave;
        private System.Windows.Forms.Panel pnlCancel;
        private System.Windows.Forms.Label lblCancel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblCreated;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblTagId;
        private System.Windows.Forms.Label lblTagCreated;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTagEmail;
        private System.Windows.Forms.Label lblCel;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblTagPhone;
    }
}