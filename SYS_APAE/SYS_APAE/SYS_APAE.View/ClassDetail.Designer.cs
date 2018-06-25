namespace SYS_APAE.SYS_APAE.View
{
    partial class ClassDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassDetail));
            this.gpbPersonal = new System.Windows.Forms.GroupBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.logo_if = new System.Windows.Forms.PictureBox();
            this.sptStudent = new System.Windows.Forms.SplitContainer();
            this.gpbShowInfo = new System.Windows.Forms.GroupBox();
            this.lblStudent = new System.Windows.Forms.Label();
            this.lblTagStudent = new System.Windows.Forms.Label();
            this.lblCreated = new System.Windows.Forms.Label();
            this.lblInstructor = new System.Windows.Forms.Label();
            this.lblTagInstructor = new System.Windows.Forms.Label();
            this.lblTagCreated = new System.Windows.Forms.Label();
            this.pnlGreenDetail = new System.Windows.Forms.Panel();
            this.pnlCancel = new System.Windows.Forms.Panel();
            this.lblCancel = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlSave = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblSave = new System.Windows.Forms.Label();
            this.gpBoxDigitacao = new System.Windows.Forms.GroupBox();
            this.lblDigitacao = new System.Windows.Forms.Label();
            this.radioDig0 = new System.Windows.Forms.RadioButton();
            this.radioDig5 = new System.Windows.Forms.RadioButton();
            this.radioDig3 = new System.Windows.Forms.RadioButton();
            this.radioDig4 = new System.Windows.Forms.RadioButton();
            this.radioDig2 = new System.Windows.Forms.RadioButton();
            this.radioDig1 = new System.Windows.Forms.RadioButton();
            this.gpBoxLeitura = new System.Windows.Forms.GroupBox();
            this.lblLeitura = new System.Windows.Forms.Label();
            this.radioLeitura0 = new System.Windows.Forms.RadioButton();
            this.radioLeitura5 = new System.Windows.Forms.RadioButton();
            this.radioLeitura3 = new System.Windows.Forms.RadioButton();
            this.radioLeitura4 = new System.Windows.Forms.RadioButton();
            this.radioLeitura2 = new System.Windows.Forms.RadioButton();
            this.radioLeitura1 = new System.Windows.Forms.RadioButton();
            this.gpBoxRecLetras = new System.Windows.Forms.GroupBox();
            this.lblReconhecer = new System.Windows.Forms.Label();
            this.radioReconhecer0 = new System.Windows.Forms.RadioButton();
            this.radioReconhecer5 = new System.Windows.Forms.RadioButton();
            this.radioReconhecer3 = new System.Windows.Forms.RadioButton();
            this.radioReconhecer4 = new System.Windows.Forms.RadioButton();
            this.radioReconhecer2 = new System.Windows.Forms.RadioButton();
            this.radioReconhecer1 = new System.Windows.Forms.RadioButton();
            this.gpBoxAtividade = new System.Windows.Forms.GroupBox();
            this.txtObs = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBoxWithLabel();
            this.radioAtividade0 = new System.Windows.Forms.RadioButton();
            this.lblAtividade = new System.Windows.Forms.Label();
            this.radioAtividade5 = new System.Windows.Forms.RadioButton();
            this.radioAtividade3 = new System.Windows.Forms.RadioButton();
            this.radioAtividade4 = new System.Windows.Forms.RadioButton();
            this.radioAtividade2 = new System.Windows.Forms.RadioButton();
            this.radioAtividade1 = new System.Windows.Forms.RadioButton();
            this.gpBoxInteressante = new System.Windows.Forms.GroupBox();
            this.lblInteressante = new System.Windows.Forms.Label();
            this.radioInteressante0 = new System.Windows.Forms.RadioButton();
            this.radioInteressante5 = new System.Windows.Forms.RadioButton();
            this.radioInteressante3 = new System.Windows.Forms.RadioButton();
            this.radioInteressante4 = new System.Windows.Forms.RadioButton();
            this.radioInteressante2 = new System.Windows.Forms.RadioButton();
            this.radioInteressante1 = new System.Windows.Forms.RadioButton();
            this.txtObsInteressante = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBoxWithLabel();
            this.gpbPersonal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_if)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sptStudent)).BeginInit();
            this.sptStudent.Panel1.SuspendLayout();
            this.sptStudent.Panel2.SuspendLayout();
            this.sptStudent.SuspendLayout();
            this.gpbShowInfo.SuspendLayout();
            this.pnlCancel.SuspendLayout();
            this.pnlSave.SuspendLayout();
            this.gpBoxDigitacao.SuspendLayout();
            this.gpBoxLeitura.SuspendLayout();
            this.gpBoxRecLetras.SuspendLayout();
            this.gpBoxAtividade.SuspendLayout();
            this.gpBoxInteressante.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbPersonal
            // 
            this.gpbPersonal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbPersonal.Controls.Add(this.gpBoxInteressante);
            this.gpbPersonal.Controls.Add(this.gpBoxAtividade);
            this.gpbPersonal.Controls.Add(this.gpBoxRecLetras);
            this.gpbPersonal.Controls.Add(this.gpBoxLeitura);
            this.gpbPersonal.Controls.Add(this.gpBoxDigitacao);
            this.gpbPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPersonal.Location = new System.Drawing.Point(3, 65);
            this.gpbPersonal.Name = "gpbPersonal";
            this.gpbPersonal.Size = new System.Drawing.Size(523, 443);
            this.gpbPersonal.TabIndex = 3;
            this.gpbPersonal.TabStop = false;
            this.gpbPersonal.Text = "Dados da aula";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(11, 94);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 15);
            this.lblTitle.TabIndex = 11;
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
            this.sptStudent.Panel1.Controls.Add(this.lblTitle);
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
            this.sptStudent.TabIndex = 2;
            // 
            // gpbShowInfo
            // 
            this.gpbShowInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbShowInfo.Controls.Add(this.lblStudent);
            this.gpbShowInfo.Controls.Add(this.lblTagStudent);
            this.gpbShowInfo.Controls.Add(this.lblCreated);
            this.gpbShowInfo.Controls.Add(this.lblInstructor);
            this.gpbShowInfo.Controls.Add(this.lblTagInstructor);
            this.gpbShowInfo.Controls.Add(this.lblTagCreated);
            this.gpbShowInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbShowInfo.Location = new System.Drawing.Point(3, 121);
            this.gpbShowInfo.Name = "gpbShowInfo";
            this.gpbShowInfo.Size = new System.Drawing.Size(185, 153);
            this.gpbShowInfo.TabIndex = 8;
            this.gpbShowInfo.TabStop = false;
            this.gpbShowInfo.Text = "Geral";
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudent.Location = new System.Drawing.Point(20, 81);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(0, 15);
            this.lblStudent.TabIndex = 5;
            // 
            // lblTagStudent
            // 
            this.lblTagStudent.AutoSize = true;
            this.lblTagStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTagStudent.Location = new System.Drawing.Point(9, 65);
            this.lblTagStudent.Name = "lblTagStudent";
            this.lblTagStudent.Size = new System.Drawing.Size(32, 12);
            this.lblTagStudent.TabIndex = 4;
            this.lblTagStudent.Text = "Aluno:";
            // 
            // lblCreated
            // 
            this.lblCreated.AutoSize = true;
            this.lblCreated.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreated.Location = new System.Drawing.Point(20, 119);
            this.lblCreated.Name = "lblCreated";
            this.lblCreated.Size = new System.Drawing.Size(0, 15);
            this.lblCreated.TabIndex = 3;
            // 
            // lblInstructor
            // 
            this.lblInstructor.AutoSize = true;
            this.lblInstructor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructor.Location = new System.Drawing.Point(20, 43);
            this.lblInstructor.Name = "lblInstructor";
            this.lblInstructor.Size = new System.Drawing.Size(0, 15);
            this.lblInstructor.TabIndex = 2;
            // 
            // lblTagInstructor
            // 
            this.lblTagInstructor.AutoSize = true;
            this.lblTagInstructor.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTagInstructor.Location = new System.Drawing.Point(9, 27);
            this.lblTagInstructor.Name = "lblTagInstructor";
            this.lblTagInstructor.Size = new System.Drawing.Size(40, 12);
            this.lblTagInstructor.TabIndex = 1;
            this.lblTagInstructor.Text = "Monitor:";
            // 
            // lblTagCreated
            // 
            this.lblTagCreated.AutoSize = true;
            this.lblTagCreated.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTagCreated.Location = new System.Drawing.Point(9, 103);
            this.lblTagCreated.Name = "lblTagCreated";
            this.lblTagCreated.Size = new System.Drawing.Size(64, 12);
            this.lblTagCreated.TabIndex = 0;
            this.lblTagCreated.Text = "Aula dada em:";
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
            // gpBoxDigitacao
            // 
            this.gpBoxDigitacao.Controls.Add(this.lblDigitacao);
            this.gpBoxDigitacao.Controls.Add(this.radioDig0);
            this.gpBoxDigitacao.Controls.Add(this.radioDig5);
            this.gpBoxDigitacao.Controls.Add(this.radioDig3);
            this.gpBoxDigitacao.Controls.Add(this.radioDig4);
            this.gpBoxDigitacao.Controls.Add(this.radioDig2);
            this.gpBoxDigitacao.Controls.Add(this.radioDig1);
            this.gpBoxDigitacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpBoxDigitacao.Location = new System.Drawing.Point(6, 19);
            this.gpBoxDigitacao.Name = "gpBoxDigitacao";
            this.gpBoxDigitacao.Size = new System.Drawing.Size(255, 76);
            this.gpBoxDigitacao.TabIndex = 55;
            this.gpBoxDigitacao.TabStop = false;
            // 
            // lblDigitacao
            // 
            this.lblDigitacao.AutoSize = true;
            this.lblDigitacao.Location = new System.Drawing.Point(24, 16);
            this.lblDigitacao.Name = "lblDigitacao";
            this.lblDigitacao.Size = new System.Drawing.Size(207, 13);
            this.lblDigitacao.TabIndex = 12;
            this.lblDigitacao.Text = "O Aluno teve dificuldade com a digitação?";
            // 
            // radioDig0
            // 
            this.radioDig0.AutoSize = true;
            this.radioDig0.Location = new System.Drawing.Point(13, 42);
            this.radioDig0.Name = "radioDig0";
            this.radioDig0.Size = new System.Drawing.Size(31, 17);
            this.radioDig0.TabIndex = 9;
            this.radioDig0.TabStop = true;
            this.radioDig0.Tag = "dig";
            this.radioDig0.Text = "0";
            this.radioDig0.UseVisualStyleBackColor = true;
            this.radioDig0.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioDig5
            // 
            this.radioDig5.AutoSize = true;
            this.radioDig5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.radioDig5.Location = new System.Drawing.Point(212, 42);
            this.radioDig5.Margin = new System.Windows.Forms.Padding(10);
            this.radioDig5.Name = "radioDig5";
            this.radioDig5.Size = new System.Drawing.Size(31, 17);
            this.radioDig5.TabIndex = 13;
            this.radioDig5.TabStop = true;
            this.radioDig5.Tag = "dig";
            this.radioDig5.Text = "5";
            this.radioDig5.UseVisualStyleBackColor = true;
            this.radioDig5.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioDig3
            // 
            this.radioDig3.AutoSize = true;
            this.radioDig3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.radioDig3.Location = new System.Drawing.Point(133, 42);
            this.radioDig3.Name = "radioDig3";
            this.radioDig3.Size = new System.Drawing.Size(31, 17);
            this.radioDig3.TabIndex = 14;
            this.radioDig3.TabStop = true;
            this.radioDig3.Tag = "dig";
            this.radioDig3.Text = "3";
            this.radioDig3.UseVisualStyleBackColor = true;
            this.radioDig3.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioDig4
            // 
            this.radioDig4.AutoSize = true;
            this.radioDig4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.radioDig4.Location = new System.Drawing.Point(172, 42);
            this.radioDig4.Name = "radioDig4";
            this.radioDig4.Size = new System.Drawing.Size(31, 17);
            this.radioDig4.TabIndex = 15;
            this.radioDig4.TabStop = true;
            this.radioDig4.Tag = "dig";
            this.radioDig4.Text = "4";
            this.radioDig4.UseVisualStyleBackColor = true;
            this.radioDig4.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioDig2
            // 
            this.radioDig2.AutoSize = true;
            this.radioDig2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.radioDig2.Location = new System.Drawing.Point(93, 42);
            this.radioDig2.Name = "radioDig2";
            this.radioDig2.Size = new System.Drawing.Size(31, 17);
            this.radioDig2.TabIndex = 16;
            this.radioDig2.TabStop = true;
            this.radioDig2.Tag = "dig";
            this.radioDig2.Text = "2";
            this.radioDig2.UseVisualStyleBackColor = true;
            this.radioDig2.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioDig1
            // 
            this.radioDig1.AutoSize = true;
            this.radioDig1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.radioDig1.Location = new System.Drawing.Point(53, 42);
            this.radioDig1.Name = "radioDig1";
            this.radioDig1.Size = new System.Drawing.Size(31, 17);
            this.radioDig1.TabIndex = 17;
            this.radioDig1.TabStop = true;
            this.radioDig1.Tag = "dig";
            this.radioDig1.Text = "1";
            this.radioDig1.UseVisualStyleBackColor = true;
            this.radioDig1.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // gpBoxLeitura
            // 
            this.gpBoxLeitura.Controls.Add(this.lblLeitura);
            this.gpBoxLeitura.Controls.Add(this.radioLeitura0);
            this.gpBoxLeitura.Controls.Add(this.radioLeitura5);
            this.gpBoxLeitura.Controls.Add(this.radioLeitura3);
            this.gpBoxLeitura.Controls.Add(this.radioLeitura4);
            this.gpBoxLeitura.Controls.Add(this.radioLeitura2);
            this.gpBoxLeitura.Controls.Add(this.radioLeitura1);
            this.gpBoxLeitura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpBoxLeitura.Location = new System.Drawing.Point(269, 19);
            this.gpBoxLeitura.Name = "gpBoxLeitura";
            this.gpBoxLeitura.Size = new System.Drawing.Size(250, 76);
            this.gpBoxLeitura.TabIndex = 56;
            this.gpBoxLeitura.TabStop = false;
            // 
            // lblLeitura
            // 
            this.lblLeitura.AutoSize = true;
            this.lblLeitura.Location = new System.Drawing.Point(30, 16);
            this.lblLeitura.Name = "lblLeitura";
            this.lblLeitura.Size = new System.Drawing.Size(192, 13);
            this.lblLeitura.TabIndex = 19;
            this.lblLeitura.Text = "O Aluno teve dificuldade com a leitura?";
            // 
            // radioLeitura0
            // 
            this.radioLeitura0.AutoSize = true;
            this.radioLeitura0.Location = new System.Drawing.Point(13, 42);
            this.radioLeitura0.Name = "radioLeitura0";
            this.radioLeitura0.Size = new System.Drawing.Size(31, 17);
            this.radioLeitura0.TabIndex = 18;
            this.radioLeitura0.TabStop = true;
            this.radioLeitura0.Tag = "lei";
            this.radioLeitura0.Text = "0";
            this.radioLeitura0.UseVisualStyleBackColor = true;
            this.radioLeitura0.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioLeitura5
            // 
            this.radioLeitura5.AutoSize = true;
            this.radioLeitura5.Location = new System.Drawing.Point(208, 42);
            this.radioLeitura5.Margin = new System.Windows.Forms.Padding(10);
            this.radioLeitura5.Name = "radioLeitura5";
            this.radioLeitura5.Size = new System.Drawing.Size(31, 17);
            this.radioLeitura5.TabIndex = 20;
            this.radioLeitura5.TabStop = true;
            this.radioLeitura5.Tag = "lei";
            this.radioLeitura5.Text = "5";
            this.radioLeitura5.UseVisualStyleBackColor = true;
            this.radioLeitura5.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioLeitura3
            // 
            this.radioLeitura3.AutoSize = true;
            this.radioLeitura3.Location = new System.Drawing.Point(130, 42);
            this.radioLeitura3.Name = "radioLeitura3";
            this.radioLeitura3.Size = new System.Drawing.Size(31, 17);
            this.radioLeitura3.TabIndex = 21;
            this.radioLeitura3.TabStop = true;
            this.radioLeitura3.Tag = "lei";
            this.radioLeitura3.Text = "3";
            this.radioLeitura3.UseVisualStyleBackColor = true;
            this.radioLeitura3.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioLeitura4
            // 
            this.radioLeitura4.AutoSize = true;
            this.radioLeitura4.Location = new System.Drawing.Point(169, 42);
            this.radioLeitura4.Name = "radioLeitura4";
            this.radioLeitura4.Size = new System.Drawing.Size(31, 17);
            this.radioLeitura4.TabIndex = 22;
            this.radioLeitura4.TabStop = true;
            this.radioLeitura4.Tag = "lei";
            this.radioLeitura4.Text = "4";
            this.radioLeitura4.UseVisualStyleBackColor = true;
            this.radioLeitura4.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioLeitura2
            // 
            this.radioLeitura2.AutoSize = true;
            this.radioLeitura2.Location = new System.Drawing.Point(91, 42);
            this.radioLeitura2.Name = "radioLeitura2";
            this.radioLeitura2.Size = new System.Drawing.Size(31, 17);
            this.radioLeitura2.TabIndex = 23;
            this.radioLeitura2.TabStop = true;
            this.radioLeitura2.Tag = "lei";
            this.radioLeitura2.Text = "2";
            this.radioLeitura2.UseVisualStyleBackColor = true;
            this.radioLeitura2.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioLeitura1
            // 
            this.radioLeitura1.AutoSize = true;
            this.radioLeitura1.Location = new System.Drawing.Point(52, 42);
            this.radioLeitura1.Name = "radioLeitura1";
            this.radioLeitura1.Size = new System.Drawing.Size(31, 17);
            this.radioLeitura1.TabIndex = 24;
            this.radioLeitura1.TabStop = true;
            this.radioLeitura1.Tag = "lei";
            this.radioLeitura1.Text = "1";
            this.radioLeitura1.UseVisualStyleBackColor = true;
            this.radioLeitura1.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // gpBoxRecLetras
            // 
            this.gpBoxRecLetras.Controls.Add(this.lblReconhecer);
            this.gpBoxRecLetras.Controls.Add(this.radioReconhecer0);
            this.gpBoxRecLetras.Controls.Add(this.radioReconhecer5);
            this.gpBoxRecLetras.Controls.Add(this.radioReconhecer3);
            this.gpBoxRecLetras.Controls.Add(this.radioReconhecer4);
            this.gpBoxRecLetras.Controls.Add(this.radioReconhecer2);
            this.gpBoxRecLetras.Controls.Add(this.radioReconhecer1);
            this.gpBoxRecLetras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpBoxRecLetras.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gpBoxRecLetras.Location = new System.Drawing.Point(99, 101);
            this.gpBoxRecLetras.Name = "gpBoxRecLetras";
            this.gpBoxRecLetras.Size = new System.Drawing.Size(291, 74);
            this.gpBoxRecLetras.TabIndex = 57;
            this.gpBoxRecLetras.TabStop = false;
            // 
            // lblReconhecer
            // 
            this.lblReconhecer.AutoSize = true;
            this.lblReconhecer.Location = new System.Drawing.Point(23, 17);
            this.lblReconhecer.Name = "lblReconhecer";
            this.lblReconhecer.Size = new System.Drawing.Size(245, 13);
            this.lblReconhecer.TabIndex = 26;
            this.lblReconhecer.Text = "O Aluno teve dificuldade em reconhecer as letras?";
            // 
            // radioReconhecer0
            // 
            this.radioReconhecer0.AutoSize = true;
            this.radioReconhecer0.Location = new System.Drawing.Point(30, 43);
            this.radioReconhecer0.Name = "radioReconhecer0";
            this.radioReconhecer0.Size = new System.Drawing.Size(31, 17);
            this.radioReconhecer0.TabIndex = 25;
            this.radioReconhecer0.TabStop = true;
            this.radioReconhecer0.Tag = "rec";
            this.radioReconhecer0.Text = "0";
            this.radioReconhecer0.UseVisualStyleBackColor = true;
            this.radioReconhecer0.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioReconhecer5
            // 
            this.radioReconhecer5.AutoSize = true;
            this.radioReconhecer5.Location = new System.Drawing.Point(230, 43);
            this.radioReconhecer5.Margin = new System.Windows.Forms.Padding(10);
            this.radioReconhecer5.Name = "radioReconhecer5";
            this.radioReconhecer5.Size = new System.Drawing.Size(31, 17);
            this.radioReconhecer5.TabIndex = 27;
            this.radioReconhecer5.TabStop = true;
            this.radioReconhecer5.Tag = "rec";
            this.radioReconhecer5.Text = "5";
            this.radioReconhecer5.UseVisualStyleBackColor = true;
            this.radioReconhecer5.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioReconhecer3
            // 
            this.radioReconhecer3.AutoSize = true;
            this.radioReconhecer3.Location = new System.Drawing.Point(150, 43);
            this.radioReconhecer3.Name = "radioReconhecer3";
            this.radioReconhecer3.Size = new System.Drawing.Size(31, 17);
            this.radioReconhecer3.TabIndex = 28;
            this.radioReconhecer3.TabStop = true;
            this.radioReconhecer3.Tag = "rec";
            this.radioReconhecer3.Text = "3";
            this.radioReconhecer3.UseVisualStyleBackColor = true;
            this.radioReconhecer3.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioReconhecer4
            // 
            this.radioReconhecer4.AutoSize = true;
            this.radioReconhecer4.Location = new System.Drawing.Point(190, 43);
            this.radioReconhecer4.Name = "radioReconhecer4";
            this.radioReconhecer4.Size = new System.Drawing.Size(31, 17);
            this.radioReconhecer4.TabIndex = 29;
            this.radioReconhecer4.TabStop = true;
            this.radioReconhecer4.Tag = "rec";
            this.radioReconhecer4.Text = "4";
            this.radioReconhecer4.UseVisualStyleBackColor = true;
            this.radioReconhecer4.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioReconhecer2
            // 
            this.radioReconhecer2.AutoSize = true;
            this.radioReconhecer2.Location = new System.Drawing.Point(110, 43);
            this.radioReconhecer2.Name = "radioReconhecer2";
            this.radioReconhecer2.Size = new System.Drawing.Size(31, 17);
            this.radioReconhecer2.TabIndex = 30;
            this.radioReconhecer2.TabStop = true;
            this.radioReconhecer2.Tag = "rec";
            this.radioReconhecer2.Text = "2";
            this.radioReconhecer2.UseVisualStyleBackColor = true;
            this.radioReconhecer2.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioReconhecer1
            // 
            this.radioReconhecer1.AutoSize = true;
            this.radioReconhecer1.Location = new System.Drawing.Point(70, 43);
            this.radioReconhecer1.Name = "radioReconhecer1";
            this.radioReconhecer1.Size = new System.Drawing.Size(31, 17);
            this.radioReconhecer1.TabIndex = 31;
            this.radioReconhecer1.TabStop = true;
            this.radioReconhecer1.Tag = "rec";
            this.radioReconhecer1.Text = "1";
            this.radioReconhecer1.UseVisualStyleBackColor = true;
            this.radioReconhecer1.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // gpBoxAtividade
            // 
            this.gpBoxAtividade.Controls.Add(this.txtObs);
            this.gpBoxAtividade.Controls.Add(this.radioAtividade0);
            this.gpBoxAtividade.Controls.Add(this.lblAtividade);
            this.gpBoxAtividade.Controls.Add(this.radioAtividade5);
            this.gpBoxAtividade.Controls.Add(this.radioAtividade3);
            this.gpBoxAtividade.Controls.Add(this.radioAtividade4);
            this.gpBoxAtividade.Controls.Add(this.radioAtividade2);
            this.gpBoxAtividade.Controls.Add(this.radioAtividade1);
            this.gpBoxAtividade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpBoxAtividade.Location = new System.Drawing.Point(14, 181);
            this.gpBoxAtividade.Name = "gpBoxAtividade";
            this.gpBoxAtividade.Size = new System.Drawing.Size(494, 127);
            this.gpBoxAtividade.TabIndex = 58;
            this.gpBoxAtividade.TabStop = false;
            // 
            // txtObs
            // 
            this.txtObs.ErrorMessage = "";
            this.txtObs.Location = new System.Drawing.Point(12, 79);
            this.txtObs.Name = "txtObs";
            this.txtObs.PasswordChar = '\0';
            this.txtObs.ReadOnly = false;
            this.txtObs.Size = new System.Drawing.Size(473, 35);
            this.txtObs.TabIndex = 39;
            this.txtObs.Tag = "Observação";
            // 
            // radioAtividade0
            // 
            this.radioAtividade0.AutoSize = true;
            this.radioAtividade0.Location = new System.Drawing.Point(73, 46);
            this.radioAtividade0.Name = "radioAtividade0";
            this.radioAtividade0.Size = new System.Drawing.Size(31, 17);
            this.radioAtividade0.TabIndex = 32;
            this.radioAtividade0.TabStop = true;
            this.radioAtividade0.Tag = "atv";
            this.radioAtividade0.Text = "0";
            this.radioAtividade0.UseVisualStyleBackColor = true;
            this.radioAtividade0.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // lblAtividade
            // 
            this.lblAtividade.AutoSize = true;
            this.lblAtividade.Location = new System.Drawing.Point(152, 19);
            this.lblAtividade.Name = "lblAtividade";
            this.lblAtividade.Size = new System.Drawing.Size(207, 13);
            this.lblAtividade.TabIndex = 33;
            this.lblAtividade.Text = "O Aluno teve dificuldade com a atividade?";
            // 
            // radioAtividade5
            // 
            this.radioAtividade5.AutoSize = true;
            this.radioAtividade5.Location = new System.Drawing.Point(379, 46);
            this.radioAtividade5.Margin = new System.Windows.Forms.Padding(10);
            this.radioAtividade5.Name = "radioAtividade5";
            this.radioAtividade5.Size = new System.Drawing.Size(31, 17);
            this.radioAtividade5.TabIndex = 34;
            this.radioAtividade5.TabStop = true;
            this.radioAtividade5.Tag = "atv";
            this.radioAtividade5.Text = "5";
            this.radioAtividade5.UseVisualStyleBackColor = true;
            this.radioAtividade5.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioAtividade3
            // 
            this.radioAtividade3.AutoSize = true;
            this.radioAtividade3.Location = new System.Drawing.Point(250, 46);
            this.radioAtividade3.Name = "radioAtividade3";
            this.radioAtividade3.Size = new System.Drawing.Size(31, 17);
            this.radioAtividade3.TabIndex = 35;
            this.radioAtividade3.TabStop = true;
            this.radioAtividade3.Tag = "atv";
            this.radioAtividade3.Text = "3";
            this.radioAtividade3.UseVisualStyleBackColor = true;
            this.radioAtividade3.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioAtividade4
            // 
            this.radioAtividade4.AutoSize = true;
            this.radioAtividade4.Location = new System.Drawing.Point(313, 46);
            this.radioAtividade4.Name = "radioAtividade4";
            this.radioAtividade4.Size = new System.Drawing.Size(31, 17);
            this.radioAtividade4.TabIndex = 36;
            this.radioAtividade4.TabStop = true;
            this.radioAtividade4.Tag = "atv";
            this.radioAtividade4.Text = "4";
            this.radioAtividade4.UseVisualStyleBackColor = true;
            this.radioAtividade4.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioAtividade2
            // 
            this.radioAtividade2.AutoSize = true;
            this.radioAtividade2.Location = new System.Drawing.Point(187, 46);
            this.radioAtividade2.Name = "radioAtividade2";
            this.radioAtividade2.Size = new System.Drawing.Size(31, 17);
            this.radioAtividade2.TabIndex = 37;
            this.radioAtividade2.TabStop = true;
            this.radioAtividade2.Tag = "atv";
            this.radioAtividade2.Text = "2";
            this.radioAtividade2.UseVisualStyleBackColor = true;
            this.radioAtividade2.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioAtividade1
            // 
            this.radioAtividade1.AutoSize = true;
            this.radioAtividade1.Location = new System.Drawing.Point(127, 46);
            this.radioAtividade1.Name = "radioAtividade1";
            this.radioAtividade1.Size = new System.Drawing.Size(31, 17);
            this.radioAtividade1.TabIndex = 38;
            this.radioAtividade1.TabStop = true;
            this.radioAtividade1.Tag = "atv";
            this.radioAtividade1.Text = "1";
            this.radioAtividade1.UseVisualStyleBackColor = true;
            this.radioAtividade1.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // gpBoxInteressante
            // 
            this.gpBoxInteressante.Controls.Add(this.lblInteressante);
            this.gpBoxInteressante.Controls.Add(this.radioInteressante0);
            this.gpBoxInteressante.Controls.Add(this.radioInteressante5);
            this.gpBoxInteressante.Controls.Add(this.radioInteressante3);
            this.gpBoxInteressante.Controls.Add(this.radioInteressante4);
            this.gpBoxInteressante.Controls.Add(this.radioInteressante2);
            this.gpBoxInteressante.Controls.Add(this.radioInteressante1);
            this.gpBoxInteressante.Controls.Add(this.txtObsInteressante);
            this.gpBoxInteressante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpBoxInteressante.Location = new System.Drawing.Point(14, 313);
            this.gpBoxInteressante.Name = "gpBoxInteressante";
            this.gpBoxInteressante.Size = new System.Drawing.Size(493, 124);
            this.gpBoxInteressante.TabIndex = 59;
            this.gpBoxInteressante.TabStop = false;
            // 
            // lblInteressante
            // 
            this.lblInteressante.AutoSize = true;
            this.lblInteressante.Location = new System.Drawing.Point(153, 16);
            this.lblInteressante.Name = "lblInteressante";
            this.lblInteressante.Size = new System.Drawing.Size(199, 13);
            this.lblInteressante.TabIndex = 41;
            this.lblInteressante.Text = "O Aluno achou a atividade interessante?";
            // 
            // radioInteressante0
            // 
            this.radioInteressante0.AutoSize = true;
            this.radioInteressante0.Location = new System.Drawing.Point(66, 47);
            this.radioInteressante0.Name = "radioInteressante0";
            this.radioInteressante0.Size = new System.Drawing.Size(31, 17);
            this.radioInteressante0.TabIndex = 40;
            this.radioInteressante0.TabStop = true;
            this.radioInteressante0.Tag = "int";
            this.radioInteressante0.Text = "0";
            this.radioInteressante0.UseVisualStyleBackColor = true;
            this.radioInteressante0.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioInteressante5
            // 
            this.radioInteressante5.AutoSize = true;
            this.radioInteressante5.Location = new System.Drawing.Point(372, 47);
            this.radioInteressante5.Margin = new System.Windows.Forms.Padding(10);
            this.radioInteressante5.Name = "radioInteressante5";
            this.radioInteressante5.Size = new System.Drawing.Size(31, 17);
            this.radioInteressante5.TabIndex = 42;
            this.radioInteressante5.TabStop = true;
            this.radioInteressante5.Tag = "int";
            this.radioInteressante5.Text = "5";
            this.radioInteressante5.UseVisualStyleBackColor = true;
            this.radioInteressante5.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioInteressante3
            // 
            this.radioInteressante3.AutoSize = true;
            this.radioInteressante3.Location = new System.Drawing.Point(243, 47);
            this.radioInteressante3.Name = "radioInteressante3";
            this.radioInteressante3.Size = new System.Drawing.Size(31, 17);
            this.radioInteressante3.TabIndex = 43;
            this.radioInteressante3.TabStop = true;
            this.radioInteressante3.Tag = "int";
            this.radioInteressante3.Text = "3";
            this.radioInteressante3.UseVisualStyleBackColor = true;
            this.radioInteressante3.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioInteressante4
            // 
            this.radioInteressante4.AutoSize = true;
            this.radioInteressante4.Location = new System.Drawing.Point(306, 47);
            this.radioInteressante4.Name = "radioInteressante4";
            this.radioInteressante4.Size = new System.Drawing.Size(31, 17);
            this.radioInteressante4.TabIndex = 44;
            this.radioInteressante4.TabStop = true;
            this.radioInteressante4.Tag = "int";
            this.radioInteressante4.Text = "4";
            this.radioInteressante4.UseVisualStyleBackColor = true;
            this.radioInteressante4.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioInteressante2
            // 
            this.radioInteressante2.AutoSize = true;
            this.radioInteressante2.Location = new System.Drawing.Point(180, 47);
            this.radioInteressante2.Name = "radioInteressante2";
            this.radioInteressante2.Size = new System.Drawing.Size(31, 17);
            this.radioInteressante2.TabIndex = 45;
            this.radioInteressante2.TabStop = true;
            this.radioInteressante2.Tag = "int";
            this.radioInteressante2.Text = "2";
            this.radioInteressante2.UseVisualStyleBackColor = true;
            this.radioInteressante2.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioInteressante1
            // 
            this.radioInteressante1.AutoSize = true;
            this.radioInteressante1.Location = new System.Drawing.Point(120, 47);
            this.radioInteressante1.Name = "radioInteressante1";
            this.radioInteressante1.Size = new System.Drawing.Size(31, 17);
            this.radioInteressante1.TabIndex = 46;
            this.radioInteressante1.TabStop = true;
            this.radioInteressante1.Tag = "int";
            this.radioInteressante1.Text = "1";
            this.radioInteressante1.UseVisualStyleBackColor = true;
            this.radioInteressante1.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // txtObsInteressante
            // 
            this.txtObsInteressante.ErrorMessage = "";
            this.txtObsInteressante.Location = new System.Drawing.Point(12, 82);
            this.txtObsInteressante.Name = "txtObsInteressante";
            this.txtObsInteressante.PasswordChar = '\0';
            this.txtObsInteressante.ReadOnly = false;
            this.txtObsInteressante.Size = new System.Drawing.Size(473, 35);
            this.txtObsInteressante.TabIndex = 48;
            this.txtObsInteressante.Tag = "Observação";
            // 
            // ClassDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 511);
            this.Controls.Add(this.sptStudent);
            this.Name = "ClassDetail";
            this.Text = "ClassDetail";
            this.gpbPersonal.ResumeLayout(false);
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
            this.gpBoxDigitacao.ResumeLayout(false);
            this.gpBoxDigitacao.PerformLayout();
            this.gpBoxLeitura.ResumeLayout(false);
            this.gpBoxLeitura.PerformLayout();
            this.gpBoxRecLetras.ResumeLayout(false);
            this.gpBoxRecLetras.PerformLayout();
            this.gpBoxAtividade.ResumeLayout(false);
            this.gpBoxAtividade.PerformLayout();
            this.gpBoxInteressante.ResumeLayout(false);
            this.gpBoxInteressante.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbPersonal;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox logo_if;
        private System.Windows.Forms.SplitContainer sptStudent;
        private System.Windows.Forms.GroupBox gpbShowInfo;
        private System.Windows.Forms.Label lblCreated;
        private System.Windows.Forms.Label lblInstructor;
        private System.Windows.Forms.Label lblTagInstructor;
        private System.Windows.Forms.Label lblTagCreated;
        private System.Windows.Forms.Panel pnlGreenDetail;
        private System.Windows.Forms.Panel pnlCancel;
        private System.Windows.Forms.Label lblCancel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlSave;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblSave;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Label lblTagStudent;
        private System.Windows.Forms.GroupBox gpBoxDigitacao;
        private System.Windows.Forms.Label lblDigitacao;
        private System.Windows.Forms.RadioButton radioDig0;
        private System.Windows.Forms.RadioButton radioDig5;
        private System.Windows.Forms.RadioButton radioDig3;
        private System.Windows.Forms.RadioButton radioDig4;
        private System.Windows.Forms.RadioButton radioDig2;
        private System.Windows.Forms.RadioButton radioDig1;
        private System.Windows.Forms.GroupBox gpBoxLeitura;
        private System.Windows.Forms.Label lblLeitura;
        private System.Windows.Forms.RadioButton radioLeitura0;
        private System.Windows.Forms.RadioButton radioLeitura5;
        private System.Windows.Forms.RadioButton radioLeitura3;
        private System.Windows.Forms.RadioButton radioLeitura4;
        private System.Windows.Forms.RadioButton radioLeitura2;
        private System.Windows.Forms.RadioButton radioLeitura1;
        private System.Windows.Forms.GroupBox gpBoxRecLetras;
        private System.Windows.Forms.Label lblReconhecer;
        private System.Windows.Forms.RadioButton radioReconhecer0;
        private System.Windows.Forms.RadioButton radioReconhecer5;
        private System.Windows.Forms.RadioButton radioReconhecer3;
        private System.Windows.Forms.RadioButton radioReconhecer4;
        private System.Windows.Forms.RadioButton radioReconhecer2;
        private System.Windows.Forms.RadioButton radioReconhecer1;
        private System.Windows.Forms.GroupBox gpBoxAtividade;
        private SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBoxWithLabel txtObs;
        private System.Windows.Forms.RadioButton radioAtividade0;
        private System.Windows.Forms.Label lblAtividade;
        private System.Windows.Forms.RadioButton radioAtividade5;
        private System.Windows.Forms.RadioButton radioAtividade3;
        private System.Windows.Forms.RadioButton radioAtividade4;
        private System.Windows.Forms.RadioButton radioAtividade2;
        private System.Windows.Forms.RadioButton radioAtividade1;
        private System.Windows.Forms.GroupBox gpBoxInteressante;
        private System.Windows.Forms.Label lblInteressante;
        private System.Windows.Forms.RadioButton radioInteressante0;
        private System.Windows.Forms.RadioButton radioInteressante5;
        private System.Windows.Forms.RadioButton radioInteressante3;
        private System.Windows.Forms.RadioButton radioInteressante4;
        private System.Windows.Forms.RadioButton radioInteressante2;
        private System.Windows.Forms.RadioButton radioInteressante1;
        private SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBoxWithLabel txtObsInteressante;
    }
}