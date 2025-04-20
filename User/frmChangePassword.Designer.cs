namespace DVLD_MySolution.User
{
    partial class frmChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePassword));
            this.btnControlClose = new Guna.UI.WinForms.GunaControlBox();
            this.btnClose = new Guna.UI.WinForms.GunaButton();
            this.btnSave = new Guna.UI.WinForms.GunaButton();
            this.ctrlUserCard1 = new DVLD_MySolution.User.ctrlUserCard();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtNewPassword = new Guna.UI.WinForms.GunaTextBox();
            this.txtCurrentPassword = new Guna.UI.WinForms.GunaTextBox();
            this.gunaPictureBox3 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPictureBox4 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtConfirmPassword = new Guna.UI.WinForms.GunaTextBox();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.lblTitle = new Guna.UI.WinForms.GunaLabel();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnControlClose
            // 
            this.btnControlClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnControlClose.AnimationHoverSpeed = 0.07F;
            this.btnControlClose.AnimationSpeed = 0.03F;
            this.btnControlClose.ControlBoxTheme = Guna.UI.WinForms.FormControlBoxTheme.Custom;
            this.btnControlClose.IconColor = System.Drawing.Color.Gray;
            this.btnControlClose.IconSize = 15F;
            this.btnControlClose.Location = new System.Drawing.Point(977, 0);
            this.btnControlClose.Name = "btnControlClose";
            this.btnControlClose.OnHoverBackColor = System.Drawing.Color.Tomato;
            this.btnControlClose.OnHoverIconColor = System.Drawing.Color.White;
            this.btnControlClose.OnPressedColor = System.Drawing.Color.Black;
            this.btnControlClose.Size = new System.Drawing.Size(52, 36);
            this.btnControlClose.TabIndex = 0;
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
            this.btnClose.Location = new System.Drawing.Point(674, 696);
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
            this.btnSave.Location = new System.Drawing.Point(855, 696);
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
            // ctrlUserCard1
            // 
            this.ctrlUserCard1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlUserCard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ctrlUserCard1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ctrlUserCard1.Location = new System.Drawing.Point(16, 44);
            this.ctrlUserCard1.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlUserCard1.Name = "ctrlUserCard1";
            this.ctrlUserCard1.Size = new System.Drawing.Size(989, 511);
            this.ctrlUserCard1.TabIndex = 21;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtNewPassword.BaseColor = System.Drawing.Color.White;
            this.txtNewPassword.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtNewPassword.BorderSize = 3;
            this.txtNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPassword.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNewPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtNewPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNewPassword.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.txtNewPassword.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtNewPassword.Location = new System.Drawing.Point(257, 613);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtNewPassword.MaxLength = 50;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '\0';
            this.txtNewPassword.Radius = 10;
            this.txtNewPassword.SelectedText = "";
            this.txtNewPassword.Size = new System.Drawing.Size(167, 41);
            this.txtNewPassword.TabIndex = 27;
            this.txtNewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNewPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtNewPassword_Validating);
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtCurrentPassword.BaseColor = System.Drawing.Color.White;
            this.txtCurrentPassword.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtCurrentPassword.BorderSize = 3;
            this.txtCurrentPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCurrentPassword.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCurrentPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtCurrentPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCurrentPassword.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.txtCurrentPassword.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtCurrentPassword.Location = new System.Drawing.Point(257, 560);
            this.txtCurrentPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtCurrentPassword.MaxLength = 50;
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.PasswordChar = '\0';
            this.txtCurrentPassword.Radius = 10;
            this.txtCurrentPassword.SelectedText = "";
            this.txtCurrentPassword.Size = new System.Drawing.Size(167, 41);
            this.txtCurrentPassword.TabIndex = 24;
            this.txtCurrentPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCurrentPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtCurrentPassword_Validating);
            // 
            // gunaPictureBox3
            // 
            this.gunaPictureBox3.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox3.Image")));
            this.gunaPictureBox3.Location = new System.Drawing.Point(210, 617);
            this.gunaPictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.gunaPictureBox3.Name = "gunaPictureBox3";
            this.gunaPictureBox3.Size = new System.Drawing.Size(40, 33);
            this.gunaPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox3.TabIndex = 25;
            this.gunaPictureBox3.TabStop = false;
            // 
            // gunaPictureBox4
            // 
            this.gunaPictureBox4.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox4.Image")));
            this.gunaPictureBox4.Location = new System.Drawing.Point(210, 564);
            this.gunaPictureBox4.Margin = new System.Windows.Forms.Padding(0);
            this.gunaPictureBox4.Name = "gunaPictureBox4";
            this.gunaPictureBox4.Size = new System.Drawing.Size(40, 33);
            this.gunaPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox4.TabIndex = 26;
            this.gunaPictureBox4.TabStop = false;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Comic Sans MS", 12.5F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.Location = new System.Drawing.Point(61, 618);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(164, 30);
            this.gunaLabel1.TabIndex = 22;
            this.gunaLabel1.Text = "New Password:";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel2.Font = new System.Drawing.Font("Comic Sans MS", 12.5F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.Location = new System.Drawing.Point(27, 565);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(198, 30);
            this.gunaLabel2.TabIndex = 23;
            this.gunaLabel2.Text = "Current Password:";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtConfirmPassword.BaseColor = System.Drawing.Color.White;
            this.txtConfirmPassword.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtConfirmPassword.BorderSize = 3;
            this.txtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmPassword.FocusedBaseColor = System.Drawing.Color.White;
            this.txtConfirmPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtConfirmPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.txtConfirmPassword.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtConfirmPassword.Location = new System.Drawing.Point(257, 666);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtConfirmPassword.MaxLength = 50;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '\0';
            this.txtConfirmPassword.Radius = 10;
            this.txtConfirmPassword.SelectedText = "";
            this.txtConfirmPassword.Size = new System.Drawing.Size(167, 41);
            this.txtConfirmPassword.TabIndex = 30;
            this.txtConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmPassword_Validating);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(210, 670);
            this.gunaPictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(40, 33);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 29;
            this.gunaPictureBox1.TabStop = false;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel3.Font = new System.Drawing.Font("Comic Sans MS", 12.5F, System.Drawing.FontStyle.Bold);
            this.gunaLabel3.Location = new System.Drawing.Point(26, 671);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(199, 30);
            this.gunaLabel3.TabIndex = 28;
            this.gunaLabel3.Text = "Confirm Password:";
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTitle.Location = new System.Drawing.Point(28, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(177, 23);
            this.lblTitle.TabIndex = 31;
            this.lblTitle.Text = "Change Password";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this;
            // 
            // frmChangePassword
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1029, 777);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtCurrentPassword);
            this.Controls.Add(this.gunaPictureBox3);
            this.Controls.Add(this.gunaPictureBox4);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.ctrlUserCard1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnControlClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChangePassword";
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.frmChangePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaControlBox btnControlClose;
        private Guna.UI.WinForms.GunaButton btnClose;
        private Guna.UI.WinForms.GunaButton btnSave;
        private ctrlUserCard ctrlUserCard1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI.WinForms.GunaTextBox txtNewPassword;
        private Guna.UI.WinForms.GunaTextBox txtCurrentPassword;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox3;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox4;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox txtConfirmPassword;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel lblTitle;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
    }
}