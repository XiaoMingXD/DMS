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
    public partial class NewDb : Form
    {
        public NewDb()
        {
            InitializeComponent();
        }
        bool status = false;
        public bool Status {
            get {
                return status;
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            string connstr;
            if (dbIP.Text == "" || dbName.Text == "" || dbUsr.Text == "" || dbPwd.Text == "")
            {
                MessageBox.Show("请确认信息填写是否完整，所有项均为必填项", "请输入完整的数据库连接信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //默认链接字符串
            connstr = "Data Source=" + dbIP.Text + "," + dbPort.Text + ";DataBase=" + dbName.Text + ";uid=" + dbUsr.Text + ";pwd=" + dbPwd.Text;
            //如果端口为初始的1433 则不需要指定端口号
            if (dbPort.Value == 1433)
                connstr = "Data Source=" + dbIP.Text + ";DataBase=" + dbName.Text + ";uid=" + dbUsr.Text + ";pwd=" + dbPwd.Text;
            //测试数据库是否能连通
            int sqlStatus = DataBase.SqlTest(connstr);
            if (sqlStatus == 1)
            {
                MessageBox.Show("无法打开数据库连接, 数据库错误", "数据库连接失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (sqlStatus == -1)
            {
                MessageBox.Show("无法打开数据库连接, 未知错误", "数据库连接失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Utils.WriteDbConf(dbIP.Text, dbPort.Text, dbName.Text, dbUsr.Text, dbPwd.Text);
            status = true;
            this.Dispose();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("未填写有效数据库信息，程序即将退出", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();
        }
    }
}
