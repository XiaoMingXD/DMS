using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DMS.utils;

namespace DMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void txtUsr_Enter(object sender, EventArgs e)
        {
            if (txtUsr.Text == "用户名")
                txtUsr.Text = "";
            if (txtUsr.ForeColor == Color.Gray)
                txtUsr.ForeColor = Color.Black;
        }

        private void txtUsr_Leave(object sender, EventArgs e)
        {
            if (txtUsr.Text == "")
            {
                txtUsr.Text = "用户名";
                txtUsr.ForeColor = Color.Gray;
            }
        }

        private void txtPwd_Enter(object sender, EventArgs e)
        {
            if (txtPwd.Text == "密码")
                txtPwd.Text = "";
            if (txtPwd.ForeColor == Color.Gray)
            {
                txtPwd.ForeColor = Color.Black;
                txtPwd.PasswordChar = '*';
            }
        }

        private void txtPwd_Leave(object sender, EventArgs e)
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
            if (txtUsr.Text == "" || txtUsr.Text == "用户名" || txtPwd.Text == "" || txtPwd.Text == "密码")
            {
                MessageBox.Show("请完整填写用户名和密码");
                return;
            }
            int rt = DataBase.LoginCheck(txtUsr.Text, txtPwd.Text);
            if (rt == 0)
                new Main(txtUsr.Text).Show();
            if (rt == -102)
                MessageBox.Show("", "登录失败");
            if (rt == -1)
                MessageBox.Show("用户名不存在或密码错误，请检查输入。", "登录失败");
        }
    }
}