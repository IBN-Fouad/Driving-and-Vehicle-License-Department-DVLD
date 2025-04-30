using System;
using System.Text;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;
using DevExpress.Xpo.DB.Helpers;

namespace DVLD_MySolution.People
{
    public partial class frmFindPerson : Form
    {
        //Declare a delegate
        public delegate void DataBackEventHandler(object sender, int PersonID);

        //Declare an event using the delegate
        public event DataBackEventHandler DataBack;

        public frmFindPerson()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Trigger the event to send data back to the caller form.
            DataBack?.Invoke(this, ctrlPersonCardWithFilter1.PersonID);
            
            this.Close();
        }

        private void frmFindPerson_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Trigger the event to send data back to the caller form.
            DataBack?.Invoke(this, ctrlPersonCardWithFilter1.PersonID);
        }
    }
}
