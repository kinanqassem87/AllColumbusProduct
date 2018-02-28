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
    public partial class FRM_SignIN : Form
    {
        string stateEnter = "";
        public FRM_SignIN()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            DataTable dt = ClassUsers.sp_SelectAllUser();
            if (txtUserName.Text.Equals("") || txtPassword.Text.Equals(""))
            {
                MessageBox.Show("الرجاء تعبئة كل الحقول");
            }
            else
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i][1].Equals(txtUserName.Text))
                    {
                        if (dt.Rows[i][2].Equals(txtPassword.Text))
                        {
                            Close();
                            stateEnter = "1";
                            FRM_Main.FullName = dt.Rows[i][3].ToString();
                            FRM_Main.UserName = dt.Rows[i][1].ToString();
                            FRM_Main.U_Password = dt.Rows[i][2].ToString();
                            FRM_Main.u_id = dt.Rows[i][0].ToString();

                            if (dt.Rows[i][4].Equals("admin"))
                            {
                                FRM_Main.Per = "admin";

                            }
                            if (dt.Rows[i][4].Equals("user"))
                            {
                                FRM_Main.Per = "user";
                            }
                        }

                    }
                }
                if (!stateEnter.Equals("1"))
                {
                    MessageBox.Show("اسم المستخدم أو كلمة السر غير صحيحة");
                    txtUserName.Text = txtPassword.Text = "";
                }

            }
        }
    }
}
