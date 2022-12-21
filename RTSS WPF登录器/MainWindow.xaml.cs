using RTSS_WPF登录器.选项卡界面;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
namespace RTSS_WPF登录器
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            选择列表.Margin = new Thickness(0, 50, 597, 0);
            ContentControl.Content = new Frame()
            {
                Content = 主页界面
            };
        }
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                this.DragMove();
        }
        private void 用户_鼠标进入(object sender, MouseEventArgs e)
        {
            用户.Width = 50;
        }
        private void 用户_鼠标离开(object sender, MouseEventArgs e)
        {
            用户.Width = 40;
        }
        private void 主页_鼠标进入(object sender, MouseEventArgs e)
        {
            主页.Width = 50;
        }
        private void 主页_鼠标离开(object sender, MouseEventArgs e)
        {
            主页.Width = 40;
        }
        private void 注入_鼠标进入(object sender, MouseEventArgs e)
        {
            注入.Width = 50;
        }
        private void 注入_鼠标离开(object sender, MouseEventArgs e)
        {
            注入.Width = 40;
        }
        private void 关于_鼠标进入(object sender, MouseEventArgs e)
        {
            关于.Width = 50;
        }
        private void 关于_鼠标离开(object sender, MouseEventArgs e)
        {
            关于.Width = 40;
        }
        private void 退出_鼠标进入(object sender, MouseEventArgs e)
        {
            退出.Width = 50;
        }
        private void 退出_鼠标离开(object sender, MouseEventArgs e)
        {
            退出.Width = 40;
        }
        private void 退出_鼠标按下(object sender, MouseButtonEventArgs e)
        {
            if (MessageBox.Show("是否退出?","提示",MessageBoxButton.YesNo,MessageBoxImage.Information)==MessageBoxResult.Yes)
            {
                this.Close();
            }
        }
        private readonly 用户 用户界面 = new();
        private readonly 主页 主页界面 = new();
        private readonly 注入 注入界面 = new();
        private readonly 关于 关于界面 = new();
        private readonly 空白 空白界面 = new();
        private void 用户_MouseDown(object sender, MouseButtonEventArgs e)
        {
            选择列表.Margin = new Thickness(0, 0, 597, 0);
            ContentControl.Content = new Frame()
            {
                Content = 用户界面
            };
        }
        private void 主页_MouseDown(object sender, MouseButtonEventArgs e)
        {
            选择列表.Margin = new Thickness(0, 50, 597, 0);
            ContentControl.Content = new Frame()
            {
                Content = 主页界面
            };
        }

        private void 注入_MouseDown(object sender, MouseButtonEventArgs e)
        {
            选择列表.Margin = new Thickness(0, 100, 597, 0);
            ContentControl.Content = new Frame()
            {
                Content = 注入界面
            };
        }

        private void 关于_MouseDown(object sender, MouseButtonEventArgs e)
        {
            选择列表.Margin = new Thickness(0, 150, 597, 0);
            ContentControl.Content = new Frame()
            {
                Content = 关于界面
            };
        }

        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {
            空白.Width = 50;
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            选择列表.Margin = new Thickness(0, 250, 597, 0);
            ContentControl.Content = new Frame()
            {
                Content = 空白界面
            };
        }

        private void Image_MouseLeave(object sender, MouseEventArgs e)
        {
            空白.Width = 40;
        }
    }
}
