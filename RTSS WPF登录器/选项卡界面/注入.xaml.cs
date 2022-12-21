using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using RTSS_WPF登录器;

namespace RTSS_WPF登录器.选项卡界面
{
    /// <summary>
    /// 注入.xaml 的交互逻辑
    /// </summary>
    
    public partial class 注入 : Page
    {
        public 注入()
        {
            InitializeComponent();
        }
        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (共享变量.验证 == true)
            {
                if (File.Exists(".\\EXE\\svchost.exe") == true)
                {
                    File.Delete(".\\settings.xml");
                    File.Delete(".\\EXE\\RTSSHooks_Scrambled.dll");
                    File.Copy(".\\RES\\settings.xml", ".\\settings.xml");
                    Process.Start(".\\EXE\\svchost.exe");
                }
                else
                {
                    MessageBox.Show("注入器文件丢失");
                }
            }
            else
            {
                MessageBox.Show("请先登录");
            }
        }

        private void Label_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            if (共享变量.验证 == true)
            {
                MessageBox.Show("敬请期待...");
            }
            else
            {
                MessageBox.Show("请先登录");
            }
        }
    }
}
