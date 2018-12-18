using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveToExcel
{
    public partial class frmSaveToExcel : Form
    {
        public frmSaveToExcel()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            User objUser;
            objUser = new User();

            objUser.Name = txtName.Text;
            objUser.Company = txtCompany.Text;
            objUser.Mobile = Convert.ToInt32(txtMobile.Text);

            MyExcel.WriteToExcel(objUser);
            MessageBox.Show("User details have been saved to Excel");

        }

        private void frmSaveToExcel_Load(object sender, EventArgs e)
        {
            MyExcel.InitializeExcel();
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            clearAllFields();
        }

        public void clearAllFields()
        {
            txtName.Text = "";
            txtCompany.Text = "";
            txtMobile.Text = "";
        }
    }
}
