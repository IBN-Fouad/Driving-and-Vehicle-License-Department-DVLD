namespace DVLD_MySolution.Applications.NewFolder1
{
    partial class frmAddUpdateLocalDrivingLicesnseApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdateLocalDrivingLicesnseApplication));
            this.lblTitle = new Guna.UI.WinForms.GunaLabel();
            this.tcApplicationInfo = new System.Windows.Forms.TabControl();
            this.tpPersonalInfo = new System.Windows.Forms.TabPage();
            this.ctrlPersonCardWithFilter1 = new DVLD_MySolution.People.Controls.ctrlPersonCardWithFilter();
            this.btnApplicationInfoNext = new Guna.UI.WinForms.GunaButton();
            this.tpApplicationInfo = new System.Windows.Forms.TabPage();
            this.cbLicenseClass = new Guna.UI.WinForms.GunaComboBox();
            this.lblApplicationDate = new System.Windows.Forms.Label();
            this.lblCreatedByUser = new System.Windows.Forms.Label();
            this.lblFees = new System.Windows.Forms.Label();
            this.lblLocalDrivingLicebseApplicationID = new System.Windows.Forms.Label();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel10 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPictureBox5 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPictureBox4 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPictureBox3 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.btnClose = new Guna.UI.WinForms.GunaButton();
            this.btnSave = new Guna.UI.WinForms.GunaButton();
            this.btnControlClose = new Guna.UI.WinForms.GunaControlBox();
            this.tcApplicationInfo.SuspendLayout();
            this.tpPersonalInfo.SuspendLayout();
            this.tpApplicationInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTitle.Location = new System.Drawing.Point(191, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(649, 56);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Local Driving License Application";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tcApplicationInfo
            // 
            this.tcApplicationInfo.Controls.Add(this.tpPersonalInfo);
            this.tcApplicationInfo.Controls.Add(this.tpApplicationInfo);
            this.tcApplicationInfo.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcApplicationInfo.Location = new System.Drawing.Point(14, 102);
            this.tcApplicationInfo.Name = "tcApplicationInfo";
            this.tcApplicationInfo.SelectedIndex = 0;
            this.tcApplicationInfo.Size = new System.Drawing.Size(1002, 645);
            this.tcApplicationInfo.TabIndex = 1;
            // 
            // tpPersonalInfo
            // 
            this.tpPersonalInfo.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.tpPersonalInfo.Controls.Add(this.btnApplicationInfoNext);
            this.tpPersonalInfo.Location = new System.Drawing.Point(4, 38);
            this.tpPersonalInfo.Name = "tpPersonalInfo";
            this.tpPersonalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersonalInfo.Size = new System.Drawing.Size(994, 603);
            this.tpPersonalInfo.TabIndex = 0;
            this.tpPersonalInfo.Text = "Personal Info";
            this.tpPersonalInfo.UseVisualStyleBackColor = true;
            // 
            // ctrlPersonCardWithFilter1
            // 
            this.ctrlPersonCardWithFilter1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ctrlPersonCardWithFilter1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlPersonCardWithFilter1.FilterEnabled = true;
            this.ctrlPersonCardWithFilter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(7, 8);
            this.ctrlPersonCardWithFilter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.ShowAddPerson = true;
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(978, 508);
            this.ctrlPersonCardWithFilter1.TabIndex = 0;
            this.ctrlPersonCardWithFilter1.OnPersonSelected += new System.Action<int>(this.ctrlPersonCardWithFilter1_OnPersonSelected);
            // 
            // btnApplicationInfoNext
            // 
            this.btnApplicationInfoNext.Animated = true;
            this.btnApplicationInfoNext.AnimationHoverSpeed = 0.07F;
            this.btnApplicationInfoNext.AnimationSpeed = 0.03F;
            this.btnApplicationInfoNext.BackColor = System.Drawing.Color.Transparent;
            this.btnApplicationInfoNext.BaseColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnApplicationInfoNext.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnApplicationInfoNext.BorderSize = 3;
            this.btnApplicationInfoNext.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnApplicationInfoNext.FocusedColor = System.Drawing.Color.Empty;
            this.btnApplicationInfoNext.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplicationInfoNext.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnApplicationInfoNext.Image = ((System.Drawing.Image)(resources.GetObject("btnApplicationInfoNext.Image")));
            this.btnApplicationInfoNext.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnApplicationInfoNext.ImageSize = new System.Drawing.Size(45, 45);
            this.btnApplicationInfoNext.Location = new System.Drawing.Point(817, 533);
            this.btnApplicationInfoNext.Margin = new System.Windows.Forms.Padding(0);
            this.btnApplicationInfoNext.Name = "btnApplicationInfoNext";
            this.btnApplicationInfoNext.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnApplicationInfoNext.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnApplicationInfoNext.OnHoverForeColor = System.Drawing.Color.White;
            this.btnApplicationInfoNext.OnHoverImage = null;
            this.btnApplicationInfoNext.OnPressedColor = System.Drawing.Color.Black;
            this.btnApplicationInfoNext.Radius = 10;
            this.btnApplicationInfoNext.Size = new System.Drawing.Size(160, 55);
            this.btnApplicationInfoNext.TabIndex = 18;
            this.btnApplicationInfoNext.Text = "Next";
            this.btnApplicationInfoNext.Click += new System.EventHandler(this.btnApplicationInfoNext_Click);
            // 
            // tpApplicationInfo
            // 
            this.tpApplicationInfo.Controls.Add(this.cbLicenseClass);
            this.tpApplicationInfo.Controls.Add(this.lblApplicationDate);
            this.tpApplicationInfo.Controls.Add(this.lblCreatedByUser);
            this.tpApplicationInfo.Controls.Add(this.lblFees);
            this.tpApplicationInfo.Controls.Add(this.lblLocalDrivingLicebseApplicationID);
            this.tpApplicationInfo.Controls.Add(this.gunaLabel2);
            this.tpApplicationInfo.Controls.Add(this.gunaLabel4);
            this.tpApplicationInfo.Controls.Add(this.gunaLabel3);
            this.tpApplicationInfo.Controls.Add(this.gunaLabel1);
            this.tpApplicationInfo.Controls.Add(this.gunaLabel10);
            this.tpApplicationInfo.Controls.Add(this.gunaPictureBox5);
            this.tpApplicationInfo.Controls.Add(this.gunaPictureBox4);
            this.tpApplicationInfo.Controls.Add(this.gunaPictureBox3);
            this.tpApplicationInfo.Controls.Add(this.gunaPictureBox2);
            this.tpApplicationInfo.Controls.Add(this.gunaPictureBox1);
            this.tpApplicationInfo.Location = new System.Drawing.Point(4, 38);
            this.tpApplicationInfo.Name = "tpApplicationInfo";
            this.tpApplicationInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpApplicationInfo.Size = new System.Drawing.Size(994, 603);
            this.tpApplicationInfo.TabIndex = 1;
            this.tpApplicationInfo.Text = "Application Info.";
            this.tpApplicationInfo.UseVisualStyleBackColor = true;
            // 
            // cbLicenseClass
            // 
            this.cbLicenseClass.BackColor = System.Drawing.Color.Transparent;
            this.cbLicenseClass.BaseColor = System.Drawing.Color.White;
            this.cbLicenseClass.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cbLicenseClass.BorderSize = 3;
            this.cbLicenseClass.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLicenseClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLicenseClass.FocusedColor = System.Drawing.Color.Empty;
            this.cbLicenseClass.Font = new System.Drawing.Font("Comic Sans MS", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLicenseClass.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cbLicenseClass.FormattingEnabled = true;
            this.cbLicenseClass.Items.AddRange(new object[] {
            "National No.",
            "Person ID"});
            this.cbLicenseClass.Location = new System.Drawing.Point(330, 191);
            this.cbLicenseClass.Margin = new System.Windows.Forms.Padding(0);
            this.cbLicenseClass.Name = "cbLicenseClass";
            this.cbLicenseClass.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbLicenseClass.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbLicenseClass.Radius = 10;
            this.cbLicenseClass.Size = new System.Drawing.Size(270, 39);
            this.cbLicenseClass.TabIndex = 13;
            // 
            // lblApplicationDate
            // 
            this.lblApplicationDate.AutoSize = true;
            this.lblApplicationDate.BackColor = System.Drawing.Color.Transparent;
            this.lblApplicationDate.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationDate.Location = new System.Drawing.Point(326, 137);
            this.lblApplicationDate.Margin = new System.Windows.Forms.Padding(0);
            this.lblApplicationDate.Name = "lblApplicationDate";
            this.lblApplicationDate.Size = new System.Drawing.Size(171, 35);
            this.lblApplicationDate.TabIndex = 0;
            this.lblApplicationDate.Text = "{??/??/????}";
            // 
            // lblCreatedByUser
            // 
            this.lblCreatedByUser.AutoSize = true;
            this.lblCreatedByUser.BackColor = System.Drawing.Color.Transparent;
            this.lblCreatedByUser.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedByUser.Location = new System.Drawing.Point(326, 303);
            this.lblCreatedByUser.Margin = new System.Windows.Forms.Padding(0);
            this.lblCreatedByUser.Name = "lblCreatedByUser";
            this.lblCreatedByUser.Size = new System.Drawing.Size(89, 35);
            this.lblCreatedByUser.TabIndex = 0;
            this.lblCreatedByUser.Text = "{????}";
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.BackColor = System.Drawing.Color.Transparent;
            this.lblFees.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFees.Location = new System.Drawing.Point(326, 249);
            this.lblFees.Margin = new System.Windows.Forms.Padding(0);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(101, 35);
            this.lblFees.TabIndex = 0;
            this.lblFees.Text = "{$$$$}";
            // 
            // lblLocalDrivingLicebseApplicationID
            // 
            this.lblLocalDrivingLicebseApplicationID.AutoSize = true;
            this.lblLocalDrivingLicebseApplicationID.BackColor = System.Drawing.Color.Transparent;
            this.lblLocalDrivingLicebseApplicationID.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalDrivingLicebseApplicationID.Location = new System.Drawing.Point(326, 83);
            this.lblLocalDrivingLicebseApplicationID.Margin = new System.Windows.Forms.Padding(0);
            this.lblLocalDrivingLicebseApplicationID.Name = "lblLocalDrivingLicebseApplicationID";
            this.lblLocalDrivingLicebseApplicationID.Size = new System.Drawing.Size(89, 35);
            this.lblLocalDrivingLicebseApplicationID.TabIndex = 0;
            this.lblLocalDrivingLicebseApplicationID.Text = "{????}";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel2.Font = new System.Drawing.Font("Comic Sans MS", 12.5F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.Location = new System.Drawing.Point(99, 194);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(156, 30);
            this.gunaLabel2.TabIndex = 7;
            this.gunaLabel2.Text = "License Class:";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel4.Font = new System.Drawing.Font("Comic Sans MS", 12.5F, System.Drawing.FontStyle.Bold);
            this.gunaLabel4.Location = new System.Drawing.Point(99, 303);
            this.gunaLabel4.Margin = new System.Windows.Forms.Padding(0);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(137, 30);
            this.gunaLabel4.TabIndex = 7;
            this.gunaLabel4.Text = "Created By:";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel3.Font = new System.Drawing.Font("Comic Sans MS", 12.5F, System.Drawing.FontStyle.Bold);
            this.gunaLabel3.Location = new System.Drawing.Point(99, 250);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(188, 30);
            this.gunaLabel3.TabIndex = 7;
            this.gunaLabel3.Text = "Application Fees:";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Comic Sans MS", 12.5F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.Location = new System.Drawing.Point(99, 142);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(190, 30);
            this.gunaLabel1.TabIndex = 7;
            this.gunaLabel1.Text = "Application Date:";
            // 
            // gunaLabel10
            // 
            this.gunaLabel10.AutoSize = true;
            this.gunaLabel10.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel10.Font = new System.Drawing.Font("Comic Sans MS", 12.5F, System.Drawing.FontStyle.Bold);
            this.gunaLabel10.Location = new System.Drawing.Point(99, 89);
            this.gunaLabel10.Margin = new System.Windows.Forms.Padding(0);
            this.gunaLabel10.Name = "gunaLabel10";
            this.gunaLabel10.Size = new System.Drawing.Size(212, 30);
            this.gunaLabel10.TabIndex = 7;
            this.gunaLabel10.Text = "D.L.Application ID:";
            // 
            // gunaPictureBox5
            // 
            this.gunaPictureBox5.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox5.Image")));
            this.gunaPictureBox5.Location = new System.Drawing.Point(283, 303);
            this.gunaPictureBox5.Margin = new System.Windows.Forms.Padding(0);
            this.gunaPictureBox5.Name = "gunaPictureBox5";
            this.gunaPictureBox5.Size = new System.Drawing.Size(40, 33);
            this.gunaPictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox5.TabIndex = 10;
            this.gunaPictureBox5.TabStop = false;
            // 
            // gunaPictureBox4
            // 
            this.gunaPictureBox4.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox4.Image")));
            this.gunaPictureBox4.Location = new System.Drawing.Point(283, 251);
            this.gunaPictureBox4.Margin = new System.Windows.Forms.Padding(0);
            this.gunaPictureBox4.Name = "gunaPictureBox4";
            this.gunaPictureBox4.Size = new System.Drawing.Size(40, 33);
            this.gunaPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox4.TabIndex = 10;
            this.gunaPictureBox4.TabStop = false;
            // 
            // gunaPictureBox3
            // 
            this.gunaPictureBox3.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox3.Image")));
            this.gunaPictureBox3.Location = new System.Drawing.Point(283, 194);
            this.gunaPictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.gunaPictureBox3.Name = "gunaPictureBox3";
            this.gunaPictureBox3.Size = new System.Drawing.Size(40, 33);
            this.gunaPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox3.TabIndex = 10;
            this.gunaPictureBox3.TabStop = false;
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox2.Image")));
            this.gunaPictureBox2.Location = new System.Drawing.Point(283, 139);
            this.gunaPictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Size = new System.Drawing.Size(40, 33);
            this.gunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox2.TabIndex = 10;
            this.gunaPictureBox2.TabStop = false;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(283, 86);
            this.gunaPictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(40, 33);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 10;
            this.gunaPictureBox1.TabStop = false;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this;
            // 
            // btnClose
            // 
            this.btnClose.Animated = true;
            this.btnClose.AnimationHoverSpeed = 0.07F;
            this.btnClose.AnimationSpeed = 0.03F;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BaseColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnClose.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnClose.BorderSize = 3;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FocusedColor = System.Drawing.Color.Empty;
            this.btnClose.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnClose.ImageSize = new System.Drawing.Size(40, 40);
            this.btnClose.Location = new System.Drawing.Point(350, 770);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnClose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClose.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClose.OnHoverImage = null;
            this.btnClose.OnPressedColor = System.Drawing.Color.Black;
            this.btnClose.Radius = 10;
            this.btnClose.Size = new System.Drawing.Size(150, 60);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Animated = true;
            this.btnSave.AnimationHoverSpeed = 0.07F;
            this.btnSave.AnimationSpeed = 0.03F;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BaseColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSave.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSave.BorderSize = 3;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSave.FocusedColor = System.Drawing.Color.Empty;
            this.btnSave.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnSave.ImageSize = new System.Drawing.Size(40, 40);
            this.btnSave.Location = new System.Drawing.Point(531, 770);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSave.OnHoverImage = null;
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.Radius = 10;
            this.btnSave.Size = new System.Drawing.Size(150, 60);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnControlClose
            // 
            this.btnControlClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnControlClose.AnimationHoverSpeed = 0.07F;
            this.btnControlClose.AnimationSpeed = 0.03F;
            this.btnControlClose.ControlBoxTheme = Guna.UI.WinForms.FormControlBoxTheme.Custom;
            this.btnControlClose.IconColor = System.Drawing.Color.Gray;
            this.btnControlClose.IconSize = 15F;
            this.btnControlClose.Location = new System.Drawing.Point(978, 1);
            this.btnControlClose.Name = "btnControlClose";
            this.btnControlClose.OnHoverBackColor = System.Drawing.Color.Tomato;
            this.btnControlClose.OnHoverIconColor = System.Drawing.Color.White;
            this.btnControlClose.OnPressedColor = System.Drawing.Color.Black;
            this.btnControlClose.Size = new System.Drawing.Size(52, 36);
            this.btnControlClose.TabIndex = 19;
            // 
            // frmAddUpdateLocalDrivingLicesnseApplication
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1031, 854);
            this.Controls.Add(this.btnControlClose);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tcApplicationInfo);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddUpdateLocalDrivingLicesnseApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Update Local Driving Licesnse Application";
            this.Activated += new System.EventHandler(this.frmAddUpdateLocalDrivingLicesnseApplication_Activated);
            this.Load += new System.EventHandler(this.frmAddUpdateLocalDrivingLicesnseApplication_Load);
            this.tcApplicationInfo.ResumeLayout(false);
            this.tpPersonalInfo.ResumeLayout(false);
            this.tpApplicationInfo.ResumeLayout(false);
            this.tpApplicationInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel lblTitle;
        private Guna.UI2.WinForms.Guna2DataGridViewStyler guna2DataGridViewStyler1;
        private System.Windows.Forms.TabControl tcApplicationInfo;
        private System.Windows.Forms.TabPage tpPersonalInfo;
        private People.Controls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private Guna.UI.WinForms.GunaButton btnApplicationInfoNext;
        private System.Windows.Forms.TabPage tpApplicationInfo;
        private System.Windows.Forms.Label lblLocalDrivingLicebseApplicationID;
        private Guna.UI.WinForms.GunaLabel gunaLabel10;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaButton btnClose;
        private Guna.UI.WinForms.GunaButton btnSave;
        private Guna.UI.WinForms.GunaControlBox btnControlClose;
        private System.Windows.Forms.Label lblApplicationDate;
        private Guna.UI.WinForms.GunaComboBox cbLicenseClass;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.Label lblCreatedByUser;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox5;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox4;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}