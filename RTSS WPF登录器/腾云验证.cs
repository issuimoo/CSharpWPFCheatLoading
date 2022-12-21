using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Media.Media3D;
using System.Runtime.InteropServices;

namespace RTSS_WPF登录器
{
    internal static class 腾云验证
    {
        public static string 连接腾讯表格(string url)
        {
            string strHTML;
            WebClient myWebClient = new WebClient();
            Stream myStream = myWebClient.OpenRead(url);
            StreamReader sr = new StreamReader(myStream, System.Text.Encoding.GetEncoding("utf-8"));
            strHTML = sr.ReadToEnd();
            myStream.Close();
        }
            return strHTML;
        public static string 获取文本中间(string left, string right,string 文本)
        {
            if (string.IsNullOrEmpty(left))
                return "";
            if (string.IsNullOrEmpty(right))
                return "";
            if (string.IsNullOrEmpty(文本))
                return "";
            int Lindex = 文本.IndexOf(left);

            if (Lindex == -1)
            {
                return "";
            }
            Lindex = Lindex + left.Length;
            int Rindex = 文本.IndexOf(right, Lindex);
            if (Rindex == -1)
            {
                return "";
            }
            return 文本.Substring(Lindex, Rindex - Lindex);
        }
        [DllImport("User32.dll", EntryPoint = "FindWindow", CharSet = CharSet.Auto)]
        private extern static IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("User32.dll", EntryPoint = "GetWindowText", CharSet = CharSet.Auto)]
        private static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int nMaxCount);
        [DllImport("User32.dll", EntryPoint = "GetWindow", CharSet = CharSet.Auto)]
        private static extern IntPtr GetWindow(IntPtr hwnd, int GW_HWNDNEXT);
        public static List<string> 取本地登录QQ(bool type = false)
        {
            IntPtr fw;
            if (type)
            {
                fw = FindWindow(null, "QQ");
            }
            else
            {
                fw = FindWindow("CTXOPConntion_Class", null);
            }
            if (fw != IntPtr.Zero)
            {
                List<string> ret = new List<string>();
                StringBuilder sb = new StringBuilder(512);
                string qq; int len;
                do
                {
                    len = GetWindowText(fw, sb, 512);
                    if (len > 0)
                    {
                        qq = Convert.ToString(sb);

                        // Console.WriteLine(qq);

                        if (qq.Contains("OP_") || qq.Contains("_32856F50-AA9A-4388-A3C1-AE5C00A61C43"))
                        {
                            ret.Add(qq.Replace("_32856F50-AA9A-4388-A3C1-AE5C00A61C43", string.Empty));
                        }
                    }
                    fw = GetWindow(fw, 2);
                    sb.Clear();
                } while (fw != IntPtr.Zero);
                if (ret.Count > 0)
                {
                    return ret;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
        public static string 解密Base64(Encoding encode, string result)
        {
            string decode = "";
            byte[] bytes = Convert.FromBase64String(result);
            try
            {
                decode = encode.GetString(bytes);
            }
            catch
            {
                decode = result;
            }
            return decode;
        }
    }
}
