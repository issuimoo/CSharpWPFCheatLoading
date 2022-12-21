using System;
using System.Collections.Generic;
using System.Linq;
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

namespace RTSS_WPF登录器.选项卡界面
{
    /// <summary>
    /// 关于.xaml 的交互逻辑
    /// </summary>
    public partial class 关于 : Page
    {
        public 关于()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://opensource.org/licenses/gpl-2.0.php");
        }

        private void Git_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://github.com/issuimoo/Sausage-Man-Cheat");
        }
    }
}
