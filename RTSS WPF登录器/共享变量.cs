using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RTSS_WPF登录器
{
    public static class 共享变量
    {
        private static bool 是否通过 = false;
        public static bool 验证
        {
            get { return 是否通过; }
            set { 是否通过 = value; }
        }
    }
}
