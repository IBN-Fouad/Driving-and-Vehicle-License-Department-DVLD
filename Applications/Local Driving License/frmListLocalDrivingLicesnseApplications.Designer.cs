namespace DVLD_MySolution.Applications.Local_Driving_License
{
    partial class frmListLocalDrivingLicenseApplications
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new Guna.UI.WinForms.GunaLabel();
            this.label2 = new Guna.UI.WinForms.GunaLabel();
            this.lblRecordsCount = new Guna.UI.WinForms.GunaLabel();
            this.dgvLocalDrivingLicenseApplications = new Guna.UI.WinForms.GunaDataGridView();
            this.cmsApplications = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.DeleteApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.CancelApplicaitonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ScheduleTestsMenue = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleVisionTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.scheduleWrittenTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.scheduleStreetTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.issueDrivingLicenseFirstTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbFilterBy = new Guna.UI.WinForms.GunaComboBox();
            this.txtFilterValue = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.btnControlClose = new Guna.UI.WinForms.GunaControlBox();
            this.btnAddNewApplication = new Guna.UI.WinForms.GunaButton();
            this.btnClose = new Guna.UI.WinForms.GunaButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbPersonImage = new Guna.UI.WinForms.GunaPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalDrivingLicenseApplications)).BeginInit();
            this.cmsApplications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTitle.Location = new System.Drawing.Point(389, 219);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(668, 56);
            this.lblTitle.TabIndex = 132;
            this.lblTitle.Text = "Local Driving License Applications";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12.5F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(32, 717);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 30);
            this.label2.TabIndex = 133;
            this.label2.Text = "# Records:";
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Comic Sans MS", 12.5F, System.Drawing.FontStyle.Bold);
            this.lblRecordsCount.Location = new System.Drawing.Point(153, 717);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(37, 30);
            this.lblRecordsCount.TabIndex = 134;
            this.lblRecordsCount.Text = "??";
            // 
            // dgvLocalDrivingLicenseApplications
            // 
            this.dgvLocalDrivingLicenseApplications.AllowUserToAddRows = false;
            this.dgvLocalDrivingLicenseApplications.AllowUserToDeleteRows = false;
            this.dgvLocalDrivingLicenseApplications.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvLocalDrivingLicenseApplications.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLocalDrivingLicenseApplications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLocalDrivingLicenseApplications.BackgroundColor = System.Drawing.Color.White;
            this.dgvLocalDrivingLicenseApplications.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvLocalDrivingLicenseApplications.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLocalDrivingLicenseApplications.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvLocalDrivingLicenseApplications.ColumnHeadersHeight = 32;
            this.dgvLocalDrivingLicenseApplications.ContextMenuStrip = this.cmsApplications;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLocalDrivingLicenseApplications.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvLocalDrivingLicenseApplications.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvLocalDrivingLicenseApplications.EnableHeadersVisualStyles = false;
            this.dgvLocalDrivingLicenseApplications.Location = new System.Drawing.Point(37, 347);
            this.dgvLocalDrivingLicenseApplications.Margin = new System.Windows.Forms.Padding(0);
            this.dgvLocalDrivingLicenseApplications.MultiSelect = false;
            this.dgvLocalDrivingLicenseApplications.Name = "dgvLocalDrivingLicenseApplications";
            this.dgvLocalDrivingLicenseApplications.ReadOnly = true;
            this.dgvLocalDrivingLicenseApplications.RowHeadersVisible = false;
            this.dgvLocalDrivingLicenseApplications.RowHeadersWidth = 51;
            this.dgvLocalDrivingLicenseApplications.RowTemplate.Height = 40;
            this.dgvLocalDrivingLicenseApplications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLocalDrivingLicenseApplications.Size = new System.Drawing.Size(1386, 353);
            this.dgvLocalDrivingLicenseApplications.TabIndex = 139;
            this.dgvLocalDrivingLicenseApplications.TabStop = false;
            this.dgvLocalDrivingLicenseApplications.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvLocalDrivingLicenseApplications.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLocalDrivingLicenseApplications.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvLocalDrivingLicenseApplications.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvLocalDrivingLicenseApplications.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvLocalDrivingLicenseApplications.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvLocalDrivingLicenseApplications.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvLocalDrivingLicenseApplications.ThemeStyle.GridColor = System.Drawing.SystemColors.ControlDark;
            this.dgvLocalDrivingLicenseApplications.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvLocalDrivingLicenseApplications.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.dgvLocalDrivingLicenseApplications.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvLocalDrivingLicenseApplications.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvLocalDrivingLicenseApplications.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvLocalDrivingLicenseApplications.ThemeStyle.HeaderStyle.Height = 32;
            this.dgvLocalDrivingLicenseApplications.ThemeStyle.ReadOnly = true;
            this.dgvLocalDrivingLicenseApplications.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLocalDrivingLicenseApplications.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLocalDrivingLicenseApplications.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvLocalDrivingLicenseApplications.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvLocalDrivingLicenseApplications.ThemeStyle.RowsStyle.Height = 40;
            this.dgvLocalDrivingLicenseApplications.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLocalDrivingLicenseApplications.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvLocalDrivingLicenseApplications.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLocalDrivingLicenseApplications_CellContentDoubleClick);
            // 
            // cmsApplications
            // 
            this.cmsApplications.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cmsApplications.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsApplications.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.toolStripSeparator1,
            this.editToolStripMenuItem,
            this.toolStripSeparator2,
            this.DeleteApplicationToolStripMenuItem,
            this.toolStripSeparator3,
            this.CancelApplicaitonToolStripMenuItem,
            this.toolStripSeparator4,
            this.ScheduleTestsMenue,
            this.toolStripSeparator5,
            this.issueDrivingLicenseFirstTimeToolStripMenuItem,
            this.toolStripSeparator6,
            this.showLicenseToolStripMenuItem,
            this.toolStripSeparator7,
            this.showPersonLicenseHistoryToolStripMenuItem});
            this.cmsApplications.Name = "cmsApplications";
            this.cmsApplications.Size = new System.Drawing.Size(343, 350);
            this.cmsApplications.Opening += new System.ComponentModel.CancelEventHandler(this.cmsApplications_Opening);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.showDetailsToolStripMenuItem.Image = global::DVLD_MySolution.Properties.Resources.PersonDetails_32;
            this.showDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(342, 38);
            this.showDetailsToolStripMenuItem.Text = "&Show Application Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(339, 6);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.editToolStripMenuItem.Image = global::DVLD_MySolution.Properties.Resources.edit_32;
            this.editToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(342, 38);
            this.editToolStripMenuItem.Text = "&Edit Application";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(339, 6);
            // 
            // DeleteApplicationToolStripMenuItem
            // 
            this.DeleteApplicationToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.DeleteApplicationToolStripMenuItem.Image = global::DVLD_MySolution.Properties.Resources.Delete_32_2;
            this.DeleteApplicationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DeleteApplicationToolStripMenuItem.Name = "DeleteApplicationToolStripMenuItem";
            this.DeleteApplicationToolStripMenuItem.Size = new System.Drawing.Size(342, 38);
            this.DeleteApplicationToolStripMenuItem.Text = "&Delete Application";
            this.DeleteApplicationToolStripMenuItem.Click += new System.EventHandler(this.DeleteApplicationToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(339, 6);
            // 
            // CancelApplicaitonToolStripMenuItem
            // 
            this.CancelApplicaitonToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.CancelApplicaitonToolStripMenuItem.Image = global::DVLD_MySolution.Properties.Resources.Delete_32;
            this.CancelApplicaitonToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CancelApplicaitonToolStripMenuItem.Name = "CancelApplicaitonToolStripMenuItem";
            this.CancelApplicaitonToolStripMenuItem.Size = new System.Drawing.Size(342, 38);
            this.CancelApplicaitonToolStripMenuItem.Text = "&Cancel Application";
            this.CancelApplicaitonToolStripMenuItem.Click += new System.EventHandler(this.CancelApplicaitonToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(339, 6);
            // 
            // ScheduleTestsMenue
            // 
            this.ScheduleTestsMenue.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scheduleVisionTestToolStripMenuItem,
            this.toolStripSeparator8,
            this.scheduleWrittenTestToolStripMenuItem,
            this.toolStripSeparator9,
            this.scheduleStreetTestToolStripMenuItem});
            this.ScheduleTestsMenue.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ScheduleTestsMenue.Image = global::DVLD_MySolution.Properties.Resources.Schedule_Test_32;
            this.ScheduleTestsMenue.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ScheduleTestsMenue.Name = "ScheduleTestsMenue";
            this.ScheduleTestsMenue.Size = new System.Drawing.Size(342, 38);
            this.ScheduleTestsMenue.Text = "Sechdule &Tests";
            // 
            // scheduleVisionTestToolStripMenuItem
            // 
            this.scheduleVisionTestToolStripMenuItem.Image = global::DVLD_MySolution.Properties.Resources.Vision_Test_32;
            this.scheduleVisionTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.scheduleVisionTestToolStripMenuItem.Name = "scheduleVisionTestToolStripMenuItem";
            this.scheduleVisionTestToolStripMenuItem.Size = new System.Drawing.Size(273, 38);
            this.scheduleVisionTestToolStripMenuItem.Text = "Schedule Vision Test";
            this.scheduleVisionTestToolStripMenuItem.Click += new System.EventHandler(this.scheduleVisionTestToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(270, 6);
            // 
            // scheduleWrittenTestToolStripMenuItem
            // 
            this.scheduleWrittenTestToolStripMenuItem.Image = global::DVLD_MySolution.Properties.Resources.Written_Test_32;
            this.scheduleWrittenTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.scheduleWrittenTestToolStripMenuItem.Name = "scheduleWrittenTestToolStripMenuItem";
            this.scheduleWrittenTestToolStripMenuItem.Size = new System.Drawing.Size(273, 38);
            this.scheduleWrittenTestToolStripMenuItem.Text = "Schedule Written Test";
            this.scheduleWrittenTestToolStripMenuItem.Click += new System.EventHandler(this.scheduleWrittenTestToolStripMenuItem_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(270, 6);
            // 
            // scheduleStreetTestToolStripMenuItem
            // 
            this.scheduleStreetTestToolStripMenuItem.Image = global::DVLD_MySolution.Properties.Resources.Street_Test_32;
            this.scheduleStreetTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.scheduleStreetTestToolStripMenuItem.Name = "scheduleStreetTestToolStripMenuItem";
            this.scheduleStreetTestToolStripMenuItem.Size = new System.Drawing.Size(273, 38);
            this.scheduleStreetTestToolStripMenuItem.Text = "Schedule Street Test";
            this.scheduleStreetTestToolStripMenuItem.Click += new System.EventHandler(this.scheduleStreetTestToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(339, 6);
            // 
            // issueDrivingLicenseFirstTimeToolStripMenuItem
            // 
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Image = global::DVLD_MySolution.Properties.Resources.IssueDrivingLicense_32;
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Name = "issueDrivingLicenseFirstTimeToolStripMenuItem";
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Size = new System.Drawing.Size(342, 38);
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Text = "&Issue Driving License (First Time)";
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Click += new System.EventHandler(this.issueDrivingLicenseFirstTimeToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(339, 6);
            // 
            // showLicenseToolStripMenuItem
            // 
            this.showLicenseToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.showLicenseToolStripMenuItem.Image = global::DVLD_MySolution.Properties.Resources.License_View_32;
            this.showLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            this.showLicenseToolStripMenuItem.Size = new System.Drawing.Size(342, 38);
            this.showLicenseToolStripMenuItem.Text = "Show &License";
            this.showLicenseToolStripMenuItem.Click += new System.EventHandler(this.showLicenseToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(339, 6);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.showPersonLicenseHistoryToolStripMenuItem.Image = global::DVLD_MySolution.Properties.Resources.PersonLicenseHistory_32;
            this.showPersonLicenseHistoryToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(342, 38);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License &History";
            this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.BackColor = System.Drawing.Color.Transparent;
            this.cbFilterBy.BaseColor = System.Drawing.Color.White;
            this.cbFilterBy.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cbFilterBy.BorderSize = 3;
            this.cbFilterBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.FocusedColor = System.Drawing.Color.Empty;
            this.cbFilterBy.Font = new System.Drawing.Font("Comic Sans MS", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterBy.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "L.D.L.AppID",
            "National No.",
            "Full Name",
            "Status"});
            this.cbFilterBy.Location = new System.Drawing.Point(116, 287);
            this.cbFilterBy.Margin = new System.Windows.Forms.Padding(0);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbFilterBy.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbFilterBy.Radius = 10;
            this.cbFilterBy.Size = new System.Drawing.Size(210, 39);
            this.cbFilterBy.TabIndex = 136;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.BackColor = System.Drawing.Color.Transparent;
            this.txtFilterValue.BaseColor = System.Drawing.Color.White;
            this.txtFilterValue.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtFilterValue.BorderSize = 3;
            this.txtFilterValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilterValue.FocusedBaseColor = System.Drawing.Color.White;
            this.txtFilterValue.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtFilterValue.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtFilterValue.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.txtFilterValue.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtFilterValue.Location = new System.Drawing.Point(329, 286);
            this.txtFilterValue.Margin = new System.Windows.Forms.Padding(0);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.PasswordChar = '\0';
            this.txtFilterValue.Radius = 10;
            this.txtFilterValue.SelectedText = "";
            this.txtFilterValue.Size = new System.Drawing.Size(256, 41);
            this.txtFilterValue.TabIndex = 137;
            this.txtFilterValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFilterValue.Visible = false;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12.5F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(32, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 30);
            this.label1.TabIndex = 135;
            this.label1.Text = "Find By:";
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this;
            // 
            // btnControlClose
            // 
            this.btnControlClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnControlClose.AnimationHoverSpeed = 0.07F;
            this.btnControlClose.AnimationSpeed = 0.03F;
            this.btnControlClose.ControlBoxTheme = Guna.UI.WinForms.FormControlBoxTheme.Custom;
            this.btnControlClose.IconColor = System.Drawing.Color.Gray;
            this.btnControlClose.IconSize = 15F;
            this.btnControlClose.Location = new System.Drawing.Point(1397, 0);
            this.btnControlClose.Name = "btnControlClose";
            this.btnControlClose.OnHoverBackColor = System.Drawing.Color.Tomato;
            this.btnControlClose.OnHoverIconColor = System.Drawing.Color.White;
            this.btnControlClose.OnPressedColor = System.Drawing.Color.Black;
            this.btnControlClose.Size = new System.Drawing.Size(52, 36);
            this.btnControlClose.TabIndex = 142;
            // 
            // btnAddNewApplication
            // 
            this.btnAddNewApplication.Animated = true;
            this.btnAddNewApplication.AnimationHoverSpeed = 0.07F;
            this.btnAddNewApplication.AnimationSpeed = 0.03F;
            this.btnAddNewApplication.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewApplication.BaseColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAddNewApplication.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAddNewApplication.BorderSize = 3;
            this.btnAddNewApplication.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAddNewApplication.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddNewApplication.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewApplication.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnAddNewApplication.Image = global::DVLD_MySolution.Properties.Resources.New_Application_64;
            this.btnAddNewApplication.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddNewApplication.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAddNewApplication.Location = new System.Drawing.Point(1332, 255);
            this.btnAddNewApplication.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddNewApplication.Name = "btnAddNewApplication";
            this.btnAddNewApplication.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnAddNewApplication.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddNewApplication.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddNewApplication.OnHoverImage = null;
            this.btnAddNewApplication.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddNewApplication.Radius = 10;
            this.btnAddNewApplication.Size = new System.Drawing.Size(91, 80);
            this.btnAddNewApplication.TabIndex = 138;
            this.btnAddNewApplication.Click += new System.EventHandler(this.btnAddNewApplication_Click);
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
            this.btnClose.Image = global::DVLD_MySolution.Properties.Resources.Close_321;
            this.btnClose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnClose.ImageSize = new System.Drawing.Size(40, 40);
            this.btnClose.Location = new System.Drawing.Point(1273, 717);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnClose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClose.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClose.OnHoverImage = null;
            this.btnClose.OnPressedColor = System.Drawing.Color.Black;
            this.btnClose.Radius = 10;
            this.btnClose.Size = new System.Drawing.Size(150, 60);
            this.btnClose.TabIndex = 140;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::DVLD_MySolution.Properties.Resources.Local_321;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(784, 96);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 131;
            this.pictureBox1.TabStop = false;
            // 
            // pbPersonImage
            // 
            this.pbPersonImage.BackColor = System.Drawing.Color.Transparent;
            this.pbPersonImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPersonImage.BaseColor = System.Drawing.Color.Transparent;
            this.pbPersonImage.Image = global::DVLD_MySolution.Properties.Resources.Applications;
            this.pbPersonImage.InitialImage = null;
            this.pbPersonImage.Location = new System.Drawing.Point(614, 30);
            this.pbPersonImage.Margin = new System.Windows.Forms.Padding(0);
            this.pbPersonImage.Name = "pbPersonImage";
            this.pbPersonImage.Radius = 30;
            this.pbPersonImage.Size = new System.Drawing.Size(220, 189);
            this.pbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersonImage.TabIndex = 3;
            this.pbPersonImage.TabStop = false;
            // 
            // frmListLocalDrivingLicenseApplications
            // 
            this.AcceptButton = this.btnAddNewApplication;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1449, 796);
            this.Controls.Add(this.btnControlClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvLocalDrivingLicenseApplications);
            this.Controls.Add(this.btnAddNewApplication);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbPersonImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListLocalDrivingLicenseApplications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Local Driving License Applications";
            this.Load += new System.EventHandler(this.frmListLocalDrivingLicenseApplications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalDrivingLicenseApplications)).EndInit();
            this.cmsApplications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPictureBox pbPersonImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaLabel lblTitle;
        private Guna.UI.WinForms.GunaLabel label2;
        private Guna.UI.WinForms.GunaLabel lblRecordsCount;
        private Guna.UI.WinForms.GunaButton btnClose;
        private Guna.UI.WinForms.GunaDataGridView dgvLocalDrivingLicenseApplications;
        private Guna.UI.WinForms.GunaButton btnAddNewApplication;
        private Guna.UI.WinForms.GunaComboBox cbFilterBy;
        private Guna.UI.WinForms.GunaTextBox txtFilterValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip cmsApplications;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem DeleteApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem CancelApplicaitonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ScheduleTestsMenue;
        private System.Windows.Forms.ToolStripMenuItem issueDrivingLicenseFirstTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaControlBox btnControlClose;
        private System.Windows.Forms.ToolStripMenuItem scheduleVisionTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleWrittenTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleStreetTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
    }
}