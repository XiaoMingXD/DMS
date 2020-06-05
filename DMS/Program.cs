,using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using DMS.utils;

namespace DMS
{
    static class Program
    {
        public static string connStr;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //如果配置不存在 则生成默认配置文件
            if (File.Exists("config.ini") == false)
                //如无法创建配置文件，则报错并退出程序
                if (Utils.WriteDefDbConf() == false)
                {
                    MessageBox.Show("无法创建配置文件，请检查程序是否被放置于需特殊权限位置。\n程序即将退出。", "无法创建配置文件");
                    Environment.Exit(-1);
                }
            //如无法连接到配置文件内所写的数据库，则提示填写新的数据库连接信息
            if(DataBase.SqlTest(Utils.GetConnStr())!=0)
            //显示需填写信息，如未正确填写 则退出程序
                if (NewConf() == false)
                    Environment.Exit(-1);
            //从配置文件获取连接字符串
            connStr = Utils.GetConnStr();
            Application.Run(new Login());
        }

        private static bool NewConf()
        {
            if (DialogResult.No == MessageBox.Show("无法连接到数据库，可能因为本机网络不畅或数据库不在线。\n是否填写新数据库信息？", "无法连接到数据库", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1))
                return false;
            NewDb nDb = new NewDb();
            nDb.ShowDialog();
            if (nDb.Status == false)
                return false;
            return true;
        }
    }
}
