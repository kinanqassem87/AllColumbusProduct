using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AllColumbusProduct.BL;

namespace AllColumbusProduct.PL
{
    public partial class FRM_UpdateProduct : Form
    {
        int ProID;
        public FRM_UpdateProduct(string s)
        {
            InitializeComponent();
            ProID = int.Parse(s);
            DataTable dt = ClassManagmentReport.selectOneProID(int.Parse(s));
            txtname.Text = dt.Rows[0][1].ToString();
            txtbarcode.Text = dt.Rows[0][2].ToString();
            txtCategory.Text = dt.Rows[0][3].ToString();
            txtCountry.Text = dt.Rows[0][4].ToString();
            txtcity.Text = dt.Rows[0][5].ToString();
            txtCompany.Text = dt.Rows[0][6].ToString();
            //txtcost.Text = dt.Rows[0][7].ToString();
            //txtgroup.Text = dt.Rows[0][8].ToString();
            //txtone.Text = dt.Rows[0][9].ToString();
            rtxtdiscrp.Text = dt.Rows[0][10].ToString();
            rtxtnote.Text = dt.Rows[0][11].ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int found = 0;
            if (txtname.Text.Equals("")) { MessageBox.Show("Please insert product name ."); }
            else 
            {
                DataTable ProName = ClassProduct.selectOnePro(txtbarcode.Text);
                if (ProName.Rows.Count > 0 && !ProName.Rows[0][0].ToString().Equals(ProID.ToString())) { found = 1; MessageBox.Show("This Product or Barcode Already Exist . ."); }
            }
            if (found == 0) 
            {
                int i = ClassManagmentReport.updatePro(ProID,txtname.Text, txtbarcode.Text, txtCategory.Text, txtCountry.Text, txtcity.Text, txtCompany.Text, "0", "0", "0", rtxtdiscrp.Text, rtxtnote.Text);
                txtname.Text = txtbarcode.Text = txtCategory.Text = txtCountry.Text = txtcity.Text = txtCompany.Text =  rtxtdiscrp.Text = rtxtnote.Text = "";
                MessageBox.Show("Done. .");
            }
            this.Close();
        }
    }
}
