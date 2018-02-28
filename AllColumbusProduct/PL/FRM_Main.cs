using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using AllColumbusProduct.BL;

namespace AllColumbusProduct.PL
{
    public partial class FRM_Main : Form
    {
        public static string FullName = "";
        public static string UserName = "";
        public static string U_Password = "";
        public static string u_id = "";
        public static string Per = "";
        public FRM_Main()
        {
            InitializeComponent();
        }

        private void tsSignIn_Click(object sender, EventArgs e)
        {
            FRM_SignIN a = new FRM_SignIN();
            a.ShowDialog();
        }

        private void FRM_Main_Activated(object sender, EventArgs e)
        {
            if (Per.Equals("admin"))
            {
                tsSignOut.Enabled = tsChangePassword.Enabled =tsBackUp.Enabled=tsAllProduct.Enabled=tsManagWithRep.Enabled=tsNormalRep.Enabled=tsAddProduct.Enabled= true;
                tsSignIn.Enabled = false;
            }
            if (Per.Equals("user"))
            {

                tsSignOut.Enabled = tsChangePassword.Enabled = tsAllProduct.Enabled = tsNormalRep.Enabled = true;
                tsSignIn.Enabled = false;
            }
        }

        private void tsSignOut_Click(object sender, EventArgs e)
        {
            Per = "out";
            tsSignOut.Enabled = tsChangePassword.Enabled = tsBackUp.Enabled = tsAllProduct.Enabled = tsManagWithRep.Enabled = tsNormalRep.Enabled =tsAddProduct.Enabled= false;
            tsSignIn.Enabled = true;
            FRM_SignIN s = new FRM_SignIN();
            s.ShowDialog();
        }

        private void tsChangePassword_Click(object sender, EventArgs e)
        {
            FRM_ChangPassword a = new FRM_ChangPassword();
            a.ShowDialog();
        }

        private void tsBackUp_Click(object sender, EventArgs e)
        {
            FRM_BackUp a = new FRM_BackUp();
            a.ShowDialog();
        }

        private void tsAddProduct_Click(object sender, EventArgs e)
        {
            FRM_AddProduct a = new FRM_AddProduct();
            a.ShowDialog();
        }

        private void tsManagWithRep_Click(object sender, EventArgs e)
        {
            FRM_ManagmentReport a = new FRM_ManagmentReport();
            a.ShowDialog();
        }

        private void tsNormalRep_Click(object sender, EventArgs e)
        {
            FRM_NormalReport a = new FRM_NormalReport();
            a.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string SheetName = "Sheet1";
                string fileName = "final";

                String constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                                "C:\\Users\\User\\Desktop\\" + fileName + ".xlsx" +
                                ";Extended Properties='Excel 12.0 XML;HDR=YES;';";

                OleDbConnection con = new OleDbConnection(constr);
                OleDbCommand oconn = new OleDbCommand("Select * From [" + SheetName + "$]", con);
                con.Open();

                OleDbDataAdapter sda = new OleDbDataAdapter(oconn);
                DataTable data = new DataTable();
                sda.Fill(data);
                dataGridView1.DataSource = data;
            }
            catch (Exception) { MessageBox.Show("الملف غير موجود او التسمية غير صحيحة"); }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            btnInsert.Enabled = false;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                //  int add=ClassProduct.insertPro(dataGridView1.Rows[i].Cells[1].Value.ToString(),dataGridView1.Rows[i].Cells[0].Value.ToString(),"","","","",dataGridView1.Rows[i].Cells[2].Value.ToString(),"",dataGridView1.Rows[i].Cells[3].Value.ToString(),"","");
            }

            MessageBox.Show("Done. .");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_About a = new FRM_About();
            a.ShowDialog();
        }

        //private void btnImport_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        string SheetName = "Sheet1";
        //        string fileName = "121111";

        //        String constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
        //                        "C:\\Users\\User\\Desktop\\" + fileName + ".xlsx" +
        //                        ";Extended Properties='Excel 12.0 XML;HDR=YES;';";

        //        OleDbConnection con = new OleDbConnection(constr);
        //        OleDbCommand oconn = new OleDbCommand("Select * From [" + SheetName + "$]", con);
        //        con.Open();

        //        OleDbDataAdapter sda = new OleDbDataAdapter(oconn);
        //        DataTable data = new DataTable();
        //        sda.Fill(data);
        //        dataGridView1.DataSource = data;
        //    }
        //    catch (Exception) { MessageBox.Show("الملف غير موجود او التسمية غير صحيحة"); }
        //}

        //private void btnInsert_Click(object sender, EventArgs e)
        //{
        //    btnInsert.Enabled = false;
        //    for (int i = 0; i < dataGridView1.Rows.Count; i++)
        //    {
        //        //  int add=ClassProduct.insertPro(dataGridView1.Rows[i].Cells[1].Value.ToString(),dataGridView1.Rows[i].Cells[0].Value.ToString(),"","","","",dataGridView1.Rows[i].Cells[2].Value.ToString(),"",dataGridView1.Rows[i].Cells[3].Value.ToString(),"","");
        //    }

        //    MessageBox.Show("Done. .");
        //}
    }
}
