namespace DVLD_MySolution.People
{
    partial class frmShowPersonInfo
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI.WinForms.GunaButton();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.ctrlPersonCard1 = new DVLD_MySolution.People.Controls.ctrlPersonCard();
            this.btnControlClose = new Guna.UI.WinForms.GunaControlBox();
            this.gunaDragControl2 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTitle.Location = new System.Drawing.Point(304, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(308, 55);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Person Details";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnClose.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnClose.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnClose.Image = global::DVLD_MySolution.Properties.Resources.Close_321;
            this.btnClose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnClose.ImageSize = new System.Drawing.Size(40, 40);
            this.btnClose.Location = new System.Drawing.Point(696, 398);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnClose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClose.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClose.OnHoverImage = null;
            this.btnClose.OnPressedColor = System.Drawing.Color.Black;
            this.btnClose.Radius = 10;
            this.btnClose.Size = new System.Drawing.Size(150, 60);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this;
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlPersonCard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ctrlPersonCard1.Location = new System.Drawing.Point(13, 70);
            this.ctrlPersonCard1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(841, 308);
            this.ctrlPersonCard1.TabIndex = 0;
            // 
            // btnControlClose
            // 
            this.btnControlClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnControlClose.AnimationHoverSpeed = 0.07F;
            this.btnControlClose.AnimationSpeed = 0.03F;
            this.btnControlClose.ControlBoxTheme = Guna.UI.WinForms.FormControlBoxTheme.Custom;
            this.btnControlClose.IconColor = System.Drawing.Color.Gray;
            this.btnControlClose.IconSize = 15F;
            this.btnControlClose.Location = new System.Drawing.Point(812, 3);
            this.btnControlClose.Name = "btnControlClose";
            this.btnControlClose.OnHoverBackColor = System.Drawing.Color.Tomato;
            this.btnControlClose.OnHoverIconColor = System.Drawing.Color.White;
            this.btnControlClose.OnPressedColor = System.Drawing.Color.Black;
            this.btnControlClose.Size = new System.Drawing.Size(52, 36);
            this.btnControlClose.TabIndex = 2;
            // 
            // gunaDragControl2
            // 
            this.gunaDragControl2.TargetControl = this.lblTitle;
            // 
            // frmShowPersonInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(867, 474);
            this.Controls.Add(this.btnControlClose);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.ctrlPersonCard1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmShowPersonInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Person Details";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ctrlPersonCard ctrlPersonCard1;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI.WinForms.GunaButton btnClose;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaControlBox btnControlClose;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl2;
    }
}