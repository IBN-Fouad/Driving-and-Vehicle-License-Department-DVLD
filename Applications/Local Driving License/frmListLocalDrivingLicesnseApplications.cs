using DevExpress.Utils.Extensions;
using DVLD_Business;
using DVLD_MySolution.Applications.NewFolder1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_MySolution.Applications.Local_Driving_License
{
    public partial class frmListLocalDrivingLicenseApplications : Form
    {
        private DataTable _dtLocalDrivingLicenseApplications;

        public frmListLocalDrivingLicenseApplications()
        {
            InitializeComponent();
        }

        private void frmListLocalDrivingLicenseApplications_Load(object sender, EventArgs e)
        {
            _dtLocalDrivingLicenseApplications = clsLocalDrivingLicenseApplication.GetAllLocalDrivingLicenseApplications();
            dgvLocalDrivingLicenseApplications.DataSource = _dtLocalDrivingLicenseApplications;
            lblRecordsCount.Text = dgvLocalDrivingLicenseApplications.Rows.Count.ToString();
            cbFilterBy.SelectedIndex = 0;

            if(dgvLocalDrivingLicenseApplications.Rows.Count > 0)
            {
                dgvLocalDrivingLicenseApplications.Columns[0].HeaderText = "L.D.L.AppID";
                dgvLocalDrivingLicenseApplications.Columns[0].Width = 110;

                dgvLocalDrivingLicenseApplications.Columns[1].HeaderText = "Driving Class";
                dgvLocalDrivingLicenseApplications.Columns[1].Width = 300;

                dgvLocalDrivingLicenseApplications.Columns[2].HeaderText = "National No";
                dgvLocalDrivingLicenseApplications.Columns[2].Width = 130;

                dgvLocalDrivingLicenseApplications.Columns[3].HeaderText = "Full Name";
                dgvLocalDrivingLicenseApplications.Columns[3].Width = 350;

                dgvLocalDrivingLicenseApplications.Columns[4].HeaderText = "Application Date";
                dgvLocalDrivingLicenseApplications.Columns[4].Width = 170;

                dgvLocalDrivingLicenseApplications.Columns[5].HeaderText = "Passed Tests";
                dgvLocalDrivingLicenseApplications.Columns[5].Width = 120;

                dgvLocalDrivingLicenseApplications.Columns[6].HeaderText = "Status";
                dgvLocalDrivingLicenseApplications.Columns[6].Width = 100;
            }
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilterBy.Text != "None");

            if (txtFilterValue.Visible)
            {
                txtFilterValue.Text = string.Empty;
                txtFilterValue.Focus();
            }
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = string.Empty;

            // Map Selected filter to real column name

            switch (cbFilterBy.Text)
            {
                case "L.D.L.AppID":
                    FilterColumn = "LocalDrivingLicenseApplicationID";
                    break;
                case "National No.":
                    FilterColumn = "NationalNo";
                    break;
                case "None":
                    FilterColumn = "None";
                    break;
                case "Full Name":
                    FilterColumn = "FullName";
                    break;
                case "Status":
                    FilterColumn = "Status";
                    break;
                default:
                    FilterColumn = "None";
                    break;
            }

            // Reset the filters in case bothing selected or filter value conains nothing.
            if(txtFilterValue.Text.Trim() == string.Empty || FilterColumn == "None")
            {
                _dtLocalDrivingLicenseApplications.DefaultView.RowFilter = string.Empty;
                lblRecordsCount.Text = dgvLocalDrivingLicenseApplications.Rows.Count.ToString();
                return;
            }

            if(FilterColumn == "LocalDrivingLicenseApplicationID")
                _dtLocalDrivingLicenseApplications.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
            else
                _dtLocalDrivingLicenseApplications.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());

            lblRecordsCount.Text = dgvLocalDrivingLicenseApplications.Rows.Count.ToString();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*frmLocalDrivingLicesnseApplicationInfo frm
                = new frmLocalDrivingLicesnseApplicationInfo((int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmListLocalDrivingLicenseApplications_Load(null, null);*/

            MessageBox.Show("Is not Implemented");
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateLocalDrivingLicesnseApplication frm
                = new frmAddUpdateLocalDrivingLicesnseApplication((int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmListLocalDrivingLicenseApplications_Load(null, null);
        }

        private void DeleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to delete application", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)  == DialogResult.Cancel)
                return;

            clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingLicenseApplicationID((int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value);

            if(LocalDrivingLicenseApplication != null)
            {
                if (LocalDrivingLicenseApplication.Delete())
                {
                    MessageBox.Show("Application Deleted Successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    frmListLocalDrivingLicenseApplications_Load(null, null);
                }
                else
                    MessageBox.Show("Could not delete application, other.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelApplicaitonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cansel application", "Confirm Cansel", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;

            clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingLicenseApplicationID((int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value);

            if (LocalDrivingLicenseApplication != null)
            {
                if (LocalDrivingLicenseApplication.Cancel())
                {
                    MessageBox.Show("Application Canselled Successfully.", "Canselled", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    frmListLocalDrivingLicenseApplications_Load(null, null);
                }
                else
                    MessageBox.Show("Could not cansel application, other.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void issueDrivingLicenseFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void scheduleVisionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void scheduleWrittenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void scheduleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "L.D.L.AppID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cmsApplications_Opening(object sender, CancelEventArgs e)
        {
            clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication
                = clsLocalDrivingLicenseApplication.FindByLocalDrivingLicenseApplicationID
                ((int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value);

            int TotalPassedTests = (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[5].Value;
            bool LicenseExists = LocalDrivingLicenseApplication.IsLicenseIssued();

            // Enabled only if person passed all tests and Does not have license
            issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = (TotalPassedTests == 3) && !LicenseExists;
            showLicenseToolStripMenuItem.Enabled = LicenseExists;
            editToolStripMenuItem.Enabled = !LicenseExists && (LocalDrivingLicenseApplication.ApplicationStatus == clsApplication.enApplicationStatus.New);
            ScheduleTestsMenue.Enabled = !LicenseExists;

            CancelApplicaitonToolStripMenuItem.Enabled = (LocalDrivingLicenseApplication.ApplicationStatus == clsApplication.enApplicationStatus.New);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvLocalDrivingLicenseApplications_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Is not Implemented");
        }

        private void btnAddNewApplication_Click(object sender, EventArgs e)
        {
            frmAddUpdateLocalDrivingLicesnseApplication frm = new frmAddUpdateLocalDrivingLicesnseApplication();
            frm.ShowDialog();
            frmListLocalDrivingLicenseApplications_Load(null, null);
        }
    }
}