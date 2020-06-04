using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtUsr.Text == "用户名")
                txtUsr.Text = "";
            if (txtUsr.ForeColor == Color.Gray)
                txtUsr.ForeColor = Color.Black;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (txtUsr.Text == "")
            {
                txtUsr.Text = "用户名";
                txtUsr.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (txtPwd.Text == "密码")
                txtPwd.Text = "";
            if (txtPwd.ForeColor == Color.Gray)
            {
                txtPwd.ForeColor = Color.Black;
                txtPwd.PasswordChar = '*';
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (txtPwd.Text == "")
            {
                txtPwd.Text = "密码";
                txtPwd.ForeColor = Color.Gray;
                txtPwd.PasswordChar = '\0';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsr.Text == "")
            {

            }
        }
    }
}