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
    public partial class Frm_ProductImage : Form
    {
        string ProID;
        int numOfImag = 0;
        int counter = 1;
        DataTable dt = new DataTable();
        byte[] arr;
        public Frm_ProductImage(string s,string rep)
        {
            InitializeComponent();
            ProID = s;
            if (rep.Equals("Normal")) { btnExport.Visible = btnSave.Visible = btnSelectOne.Visible = btnDelete.Visible = false; }
            dt = ClassManagmentReport.displayAllIMGForPro(int.Parse(s));
            numOfImag = dt.Rows.Count;
            try
            {
                txtIMGid.Text = dt.Rows[0][0].ToString();
                byte[] arr = (byte[])(dt.Rows[0][1]);
                MemoryStream ms = new MemoryStream(arr);
                picImage.Image = Image.FromStream(ms);
            }
            catch (Exception) { MessageBox.Show("No Image Found !!!"); }
        }

        private void btnNextIMG_Click(object sender, EventArgs e)
        {
            if (numOfImag > 0)
            {
                try
                {
                    txtIMGid.Text = dt.Rows[counter][0].ToString();
                    byte[] arr = (byte[])(dt.Rows[counter][1]);
                    MemoryStream ms = new MemoryStream(arr);
                    picImage.Image = Image.FromStream(ms);
                    counter++;
                }
                catch (Exception)
                {
                    txtIMGid.Text = dt.Rows[0][0].ToString();
                    byte[] arr = (byte[])(dt.Rows[0][1]);
                    MemoryStream ms = new MemoryStream(arr);
                    picImage.Image = Image.FromStream(ms);
                    counter = 1;
                }
            }
        }

        private void btnFirstIMG_Click(object sender, EventArgs e)
        {
            if (numOfImag > 0)
            {
                txtIMGid.Text = dt.Rows[0][0].ToString();
                byte[] arr = (byte[])(dt.Rows[0][1]);
                MemoryStream ms = new MemoryStream(arr);
                picImage.Image = Image.FromStream(ms);
                counter = 1;
            }
        }

        private void btnSelectOne_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Please Select Images";
                ofd.Filter = "JPG|*.jpg|JPEG|*.jpeg|GIF|*.gif|PNG|*.png";
                DialogResult dr = ofd.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    picImage.Image = Image.FromFile(ofd.FileName);

                    MemoryStream ms = new MemoryStream();
                    picImage.Image.Save(ms, picImage.Image.RawFormat);
                    arr = ms.ToArray();

                    txtIMGid.Text = "";

                }

            }
            catch (Exception) { MessageBox.Show("Wrong with Selected Image..\n Image Not Selected"); }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIMGid.Text.Equals("") && picImage.Image != null)
                {
                    int addIMG = ClassProduct.insertIMG(arr, int.Parse(ProID));
                    dt = ClassManagmentReport.displayAllIMGForPro(int.Parse(ProID));

                    MessageBox.Show("Done . .");
                    numOfImag = dt.Rows.Count;
                    btnFirstIMG_Click(null, null);
                }

            }
            catch (Exception) { }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtIMGid.Text.Equals(""))
            {
                picImage.Image = null;
            }
            else
            {
                int delImage = ClassManagmentReport.deleteIMG(int.Parse(txtIMGid.Text));
                dt = ClassManagmentReport.displayAllIMGForPro(int.Parse(ProID));

                MessageBox.Show("Done . .");
                txtIMGid.Text = "";
                picImage.Image = null;
            }
            numOfImag = dt.Rows.Count;
            btnFirstIMG_Click(null, null);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (picImage.Image == null) { MessageBox.Show("No Image Selected !!."); }
            else
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                // saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif"; 
                saveFileDialog1.Filter = "JPG|*.jpg|JPEG|*.jpeg|GIF|*.gif|PNG|*.png";
                saveFileDialog1.Title = "Save an Image File";
                saveFileDialog1.ShowDialog();

                if (saveFileDialog1.FileName != "")
                {
                    // Saves the Image via a FileStream created by the OpenFile method.  

                    System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
                    picImage.Image.Save(fs, picImage.Image.RawFormat);
                    
                }

            }
        }
    }
}
