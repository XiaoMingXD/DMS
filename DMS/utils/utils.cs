using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace DMS.utils
{
    public class Utils
    {
        //配置文件读取
        /// <summary>
        /// 修改INI配置文件
        /// </summary>
        /// <param name="section">段落</param>
        /// <param name="key">关键字</param>
        /// <param name="val">新值</param>
        /// <param name="filepath">文件完整路径</param>
        /// <returns>void</returns>
        [DllImport("kernel32")]
        public static extern long WritePrivateProfileString(string section, string key, string val, string filepath);

        /// <summary>
        /// 读INI配置文件
        /// </summary>
        /// <param name="section">段落</param>
        /// <param name="key">关键字</param>
        /// <param name="def">缺省值</param>
        /// <param name="filePath">文件完整路径</param>
        /// <returns>string</returns>
        public static string GetPrivateProfileString(string section, string key, string def, string filePath)
        {
            StringBuilder strbdr = new StringBuilder();
            GetPrivateProfileString(section, key, def, strbdr, 255, filePath);
            return strbdr.ToString();
        }

        /// <summary>
        /// 读INI配置文件
        /// </summary>
        /// <param name="section">段落</param>
        /// <param name="key">关键字</param>
        /// <param name="def">缺省值</param>
        /// <param name="retval">读取至</param>
        /// <param name="size">指定装载到lpReturnedString缓冲区的最大字符数量</param>
        /// <param name="filePath">文件完整路径</param>
        /// <returns>void</returns>
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retval, int size, string filePath);

        /// <summary>
        /// 创建默认数据库信息
        /// </summary>
        public static bool WriteDefDbConf()
        {
            try
            {
                WritePrivateProfileString("Server", "IP", ".", @".\config.ini");
                WritePrivateProfileString("Server", "Port", "1433", @".\config.ini");
                WritePrivateProfileString("Server", "DB", "Dorm", @".\config.ini");
                WritePrivateProfileString("Server", "UsrN", "Dorm", @".\config.ini");
                WritePrivateProfileString("Server", "Pwd", "12345679", @".\config.ini");
            }
            catch { return false; }
            return true;
        }
        public static bool WriteDbConf(string ip, string port, string name, string usrN, string pwd)
        {
            try
            {
                WritePrivateProfileString("Server", "IP", ip, @".\config.ini");
                WritePrivateProfileString("Server", "Port", port, @".\config.ini");
                WritePrivateProfileString("Server", "DB", name, @".\config.ini");
                WritePrivateProfileString("Server", "UsrN", usrN, @".\config.ini");
                WritePrivateProfileString("Server", "Pwd", pwd, @".\config.ini");
            }
            catch { return false; }
            return true;
        }
        public static string GetConnStr()
        {
            string dbIP = GetPrivateProfileString("Server", "IP", ".", @".\config.ini");
            string dbPort = GetPrivateProfileString("Server", "Port", "1433", @".\config.ini");
            string dbName = GetPrivateProfileString("Server", "DB", "Dorm", @".\config.ini");
            string dbUsr = GetPrivateProfileString("Server", "UsrN", "sa", @".\config.ini");
            string dbPwd = GetPrivateProfileString("Server", "Pwd", "123456", @".\config.ini");
            return "Data Source=" + dbIP + "," + dbPort + ";DataBase=" + dbName + ";uid=" + dbUsr + ";pwd=" + dbPwd;
        }
    }
}
