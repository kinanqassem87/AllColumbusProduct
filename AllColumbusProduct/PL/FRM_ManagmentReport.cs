using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AllColumbusProduct.BL;
using System.IO;

namespace AllColumbusProduct.PL
{
    public partial class FRM_ManagmentReport : Form
    {
        DataTable dt = new DataTable();
        public FRM_ManagmentReport()
        {
            InitializeComponent();
            displayPro();
        }
        void displayPro() 
        {
            dgvProduct.DataSource = ClassManagmentReport.displayAllPro();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvProduct.DataSource = ClassManagmentReport.searchForPro(txtSearch.Text);
        }

        private void dgvProduct_DoubleClick(object sender, EventArgs e)
        {
            try 
            {
                txtID.Text = dgvProduct.CurrentRow.Cells[0].Value.ToString();
                txtName.Text = dgvProduct.CurrentRow.Cells[1].Value.ToString();
                txtBarcode.Text = dgvProduct.CurrentRow.Cells[2].Value.ToString();
            }
            catch (Exception) { }
        }

        private void btnShowIMG_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_ProductImage a = new Frm_ProductImage(txtID.Text,"Managment");
                a.ShowDialog();
            }
            catch (Exception) { MessageBox.Show("Double Cilck On Product Please."); }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                FRM_UpdateProduct a = new FRM_UpdateProduct(txtID.Text);
                a.ShowDialog();
            }
            catch (Exception) { MessageBox.Show("Double Cilck On Product Please."); }
        }

        private void FRM_ManagmentReport_Activated(object sender, EventArgs e)
        {
            txtID.Text = txtName.Text = txtBarcode.Text = "";
            displayPro();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Equals("")) { MessageBox.Show("Please Select One By Double Click. ."); }
            else 
            {
                string proDI = txtID.Text;
                DialogResult result = MessageBox.Show("Are You Sure IF You Want To Delete This Product ?", "Warnning", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes) 
                {
                    int delImg = ClassManagmentReport.deleteAllIMGProduct(int.Parse(proDI));
                    int delPro = ClassManagmentReport.deletePro(int.Parse(proDI));
                    txtID.Text = txtName.Text = txtBarcode.Text = "";
                    displayPro();
                    MessageBox.Show("Done ...");
                }
                else 
                {
                    return;
                }
            }
        }

        private void dgvProduct_Click(object sender, EventArgs e)
        {
            try
            {
                dt = ClassManagmentReport.displayAllIMGForPro(int.Parse(dgvProduct.CurrentRow.Cells[0].Value.ToString()));
                byte[] arr = (byte[])(dt.Rows[0][1]);
                MemoryStream ms = new MemoryStream(arr);
                 pic1.Image = Image.FromStream(ms);
            }
            catch (Exception) { pic1.Image =  null; }
        }
    }
}
