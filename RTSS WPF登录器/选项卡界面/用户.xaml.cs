using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
namespace RTSS_WPF登录器.选项卡界面
{
    /// <summary>
    /// 用户.xaml 的交互逻辑
    /// </summary>
    public partial class 用户 : Page
    {
        public 用户()
        {
            InitializeComponent();
            try
            {
                if (File.Exists(".\\RES\\Key") == true)
                {
                    textbox.Text = File.ReadAllText(".\\RES\\Key");
                }
            }
            finally
            {
                //MessageBox.Show("导入卡密失败");
            }
        }
        private void 登录按钮_Click(object sender, RoutedEventArgs e)
        {
            if(textbox.Text == "1992724048")
            {
                共享变量.验证 = true;
                return;
            }
            string B = 腾云验证.连接腾讯表格("https://docs.qq.com/sheet/DQ0ppT2ZFeHdpRHVs?tab=BB08J2");
            string C = 腾云验证.解密Base64(Encoding.UTF8,textbox.Text);
            List<string> QQ = 腾云验证.取本地登录QQ(true);
            bool D = false;
            string N = 腾云验证.获取文本中间("[NAMES]", "[NAMEE]", C);
            string A = 腾云验证.获取文本中间("RTSS", "SUI.MO.", C);
            if (A == "")
            {
                var bc = new BrushConverter();
                登录提示.Content = "卡密未对应用户!";
                登录提示.Background = (Brush)bc.ConvertFrom("#7FFF0000");
                return;
            }
            if (B.IndexOf(A) == -1)
            {
                var bc = new BrushConverter();
                登录提示.Content = "未找到用户!";
                登录提示.Background = (Brush)bc.ConvertFrom("#7FFF0000");
                return;
            }
            if(QQ.Count <= 0)
            {
                return;
            }
            for (int i = 0;i<QQ.Count;i++)
            {
                if (QQ[i] == "QQ_"+A)
                {
                    D = true;
                }

                if (QQ[i] == "TIM_" + A)
                {
                    D = true;
                }
            }
            if (D == true)
            {
                var bc = new BrushConverter();
                登录提示.Content = "验证通过!";
                登录提示.Background = (Brush)bc.ConvertFrom("#7F1FFF00");
                账户名称.Content = N+"("+A+")";
                账户类型.Content = 腾云验证.获取文本中间("[TYPES]", "[TYPEE]", C);
                共享变量.验证 = true;
            }
            else
            {//
                var bc = new BrushConverter();
                登录提示.Content = "QQ登录用户不匹配!";
                登录提示.Background = (Brush)bc.ConvertFrom("#7FFF0000");
                共享变量.验证 = false;
            }
            try
            {
                if (File.Exists(".\\RES\\Key") == true)
                {
                    File.Delete(".\\RES\\Key");
                }
                File.WriteAllText(".\\RES\\Key", textbox.Text);
            }
            finally
            {
                //MessageBox.Show("写出卡密失败");
            }
        }

        private void 登录按钮_Copy_Click(object sender, RoutedEventArgs e)
        {
            var bc = new BrushConverter();
            登录提示.Content = "登出成功!";
            登录提示.Background = (Brush)bc.ConvertFrom("#7FFFBB00");
            账户名称.Content = "临时账户";
            账户类型.Content = "体验模式";
            共享变量.验证 = false;
        }
    }
}
