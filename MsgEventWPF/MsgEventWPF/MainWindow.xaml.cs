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
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MsgEventWPF
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        //定义事件对象类型
        public delegate void MyEventHandler(object sender, MyEventArgs e);

        //定义事件对象
        public event MyEventHandler MyEvent;

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

        //动态链接库引入
        [DllImport("User32.dll", EntryPoint = "SendMessage")]
        private static extern int SendMessage(
        IntPtr hWnd,               //目标窗口句柄
        int Msg,                   //消息值
        int wParam,                //第一个消息参数
        ref COPYDATASTRUCT lParam  //第二个消息参数
        );

        [DllImport("User32.dll", EntryPoint = "FindWindow")]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        public MainWindow()
        {
            InitializeComponent();

            //添加事件到事件队列中
            MyEvent += new MyEventHandler(DoSomething);
        }

        public void DoSomething(object sender, MyEventArgs e)
        {
            MessageBox.Show(this, e.Str, "事件内容");
        }

        public void DoEvent(string str)
        {
            MyEventArgs myArgs = new MyEventArgs();
            myArgs.Str = str;

            //触发对象事件
            MyEvent(this, myArgs);
        }

        private void ToSendMessage(string msg)
        {
            //通过查找窗口，封装数据，发送消息的方式来异步更新控件
            //通过FindWindow API的方式找到目标进程句柄，然后发送消息
            IntPtr WINDOW_HANDLER = FindWindow(null, "MsgRevWPF");

            if (WINDOW_HANDLER != IntPtr.Zero)
            {
                COPYDATASTRUCT mystr = new COPYDATASTRUCT();
                mystr.dwData = WINDOW_HANDLER;
                byte[] sarr = System.Text.Encoding.Unicode.GetBytes(msg);
                mystr.cbData = sarr.Length;
                mystr.lpData = msg;
                SendMessage(WINDOW_HANDLER, WM_COPYDATA, 0, ref mystr);
            }
        }

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            string str = tbxSend.Text;

            if (str.Equals(""))
            {
                MessageBox.Show("请输入消息内容！");
                return;
            }

            ToSendMessage(str);
        }

        private void btnEvent_Click(object sender, RoutedEventArgs e)
        {
            string str = tbxSend.Text;

            if (str.Equals(""))
            {
                MessageBox.Show("请输入事件内容！");
                return;
            }

            DoEvent(str);
        }
    }

    //定义事件参数自定义类
    public class MyEventArgs : EventArgs
    {
        public string Str { get; set; }
    }
}
