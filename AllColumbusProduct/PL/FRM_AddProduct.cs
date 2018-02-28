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
    public partial class FRM_AddProduct : Form
    {
        int NumOfImage = 0;
        List<byte[]> images = new List<byte[]>();
        public FRM_AddProduct()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                PictureBox img = new PictureBox();
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Please Select Images";
                // ofd.Multiselect = true;
                ofd.Filter = "JPG|*.jpg|JPEG|*.jpeg|GIF|*.gif|PNG|*.png";
                DialogResult dr = ofd.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    string[] files = ofd.FileNames;
                    foreach (string fileName in files)
                    {
                        img.Image = Image.FromFile(ofd.FileName);

                        MemoryStream ms = new MemoryStream();
                        img.Image.Save(ms, img.Image.RawFormat);
                        byte[] arr = ms.ToArray();
                        images.Add(arr);

                        NumOfImage++;
                    }
                }
                lbNumIMG.Text = NumOfImage.ToString();
            }
            catch (Exception) { MessageBox.Show("Wrong with Selected Image..\n Image Not Selected"); }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            int found = 0;
            if (txtname.Text.Equals(""))
            {
                MessageBox.Show("Please Insert Product Name ! ");
            }
            else 
            {
                DataTable ProName = ClassProduct.selectOnePro(txtbarcode.Text);
                if (ProName.Rows.Count > 0) { found = 1; MessageBox.Show("This Product or Barcode Already Exist . ."); }
                if (found == 0) 
                {
                    int product = ClassProduct.insertPro(txtname.Text, txtbarcode.Text, txtCategory.Text, txtCountry.Text, txtcity.Text, txtCompany.Text, "0", "0", "0", rtxtdiscrp.Text, rtxtnote.Text);
                    if (NumOfImage > 0)
                    {
                        DataTable LastOne = ClassProduct.LastPro();
                        for (int i = 0; i < images.Count; i++)
                        {
                            int AddImg = ClassProduct.insertIMG(images[i], int.Parse(LastOne.Rows[0][0].ToString()));
                        }
                    }
                    txtname.Text = txtbarcode.Text = txtCategory.Text = txtCountry.Text = txtcity.Text = txtCompany.Text = rtxtdiscrp.Text = rtxtnote.Text = "";
                    lbNumIMG.Text = "0";
                    NumOfImage = 0;
                    images.Clear();
                    MessageBox.Show("Done. .");
                }
            }
            btnSave.Enabled = true;
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            lbNumIMG.Text = "0";
            NumOfImage = 0;
            images.Clear();
        }

        
    }
}
