using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MsgRevWPF
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        //定义常量消息值
        public const int WM_COPYDATA = 0x004A;

        //定义结构体
        public struct COPYDATASTRUCT
        {
            public IntPtr dwData;
            public int cbData;
            [MarshalAs(UnmanagedType.LPStr)]
            public string lpData;
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MsgRevWPF_Loaded(object sender, RoutedEventArgs e)
        {
            HwndSource hWndSource;
            WindowInteropHelper wih = new WindowInteropHelper(this);
            hWndSource = HwndSource.FromHwnd(wih.Handle);

            //添加处理程序
            hWndSource.AddHook(MainWindowProc);
        }

        //钩子函数，处理所收到的消息
        private IntPtr MainWindowProc(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handled)
        {
            switch (msg)
            {
                case WM_COPYDATA:
                    try
                    {
                        COPYDATASTRUCT rev = new COPYDATASTRUCT();
                        Type type = rev.GetType();
                        rev = (COPYDATASTRUCT)Marshal.PtrToStructure(lParam, type);
                        string str = rev.lpData;
                        tbxRev.Text = str;
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        break;
                    }

                default:
                    break;
            }
            return hwnd;
        }

        private void btnClr_Click(object sender, RoutedEventArgs e)
        {
            tbxRev.Clear();
        }
    }
}
