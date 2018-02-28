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
    public partial class FRM_NormalReport : Form
    {
        DataTable dt = new DataTable();
        public FRM_NormalReport()
        {
            InitializeComponent();
            display();
        }
        void display() 
        {
            dgvProduct.DataSource = ClassManagmentReport.displayNormalPro();
        }

        private void dgvProduct_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Frm_ProductImage a = new Frm_ProductImage(dgvProduct.CurrentRow.Cells[0].Value.ToString(), "Normal");
                a.ShowDialog();
            }
            catch (Exception) { }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvProduct.DataSource = ClassManagmentReport.searchForNormalPro(txtSearch.Text);
        }

        private void dgvProduct_Click(object sender, EventArgs e)
        {
            try
            {
                dt = ClassManagmentReport.displayAllIMGForPro(int.Parse(dgvProduct.CurrentRow.Cells[0].Value.ToString()));
                byte[] arr = (byte[])(dt.Rows[0][1]);
                MemoryStream ms = new MemoryStream(arr);
                pic2.Image = pic1.Image = Image.FromStream(ms);
            }
            catch (Exception) { pic1.Image = pic2.Image = null; }
        }
    }
}
