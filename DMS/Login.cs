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
            if (textBox1.Text == "用户名")
                textBox1.Text = "";
            if (textBox1.ForeColor == Color.Gray)
                textBox1.ForeColor = Color.Black;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "用户名";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "密码")
                textBox2.Text = "";
            if (textBox2.ForeColor == Color.Gray)
            {
                textBox2.ForeColor = Color.Black;
                textBox2.PasswordChar = '*';
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "密码";
                textBox2.ForeColor = Color.Gray;
                textBox2.PasswordChar = '\0';
            }
        }
        private void Login_Load(object sender, EventArgs e)
        {
            btnLogin.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }


    }
}