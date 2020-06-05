using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
namespace DMS.utils
{
    public class DataBase
    {
        //连接数据库
        //读取配置信息
        readonly static SqlConnection con = new SqlConnection(Program.connStr);

        /// <summary>
        /// 测试数据库连接是否有效
        /// 连接有效 返回 0
        /// 连接无效 返回 1
        /// 未知错误 返回 -1
        /// </summary>
        /// <param name="connString">连接字符串</param>
        /// <returns>int</returns>
        public static int SqlTest(string connString)
        {
            SqlConnection con = new SqlConnection(connString);
            try { con.Open(); }
            catch (SqlException) { return 1; }
            catch { return -1; }
            finally { con.Close(); }
            return 0;
        }

        /// <summary>
        /// 单条语句且只返回一个值的简单数据库连接
        /// 如出错 Gen.flag会置 真 且返回"#Error" + 报错
        /// </summary>
        /// <param name="cmdText">要执行的语句</param>
        /// <returns>string</returns>
        public static string SqlSigRt(string cmdText)
        {
            //定义要执行的命令
            SqlCommand cmd = new SqlCommand(cmdText, con);
            //尝试执行
            try
            {
                con.Open();
                //执行命令 并将返回值写入 rt 变量
                string rt = cmd.ExecuteScalar().ToString();
                //返回执行结果
                return rt;
            }
            catch (Exception Ex)
            {
                //如发生错误返回报错
                return "#Error" + Ex;
            }
            finally{con.Close();}
        }
        public static int LoginCheck(string Usn, string Pwd)
        {
            string cmd = "SELECT Pwd FROM User WHERE ID='" + Usn + "'";
            string rt = SqlSigRt(cmd);
            if (rt.StartsWith("#Error") == true)
                return -102;
            if (Pwd == rt)
                return 0;
            return -1;
        }
    }
}
