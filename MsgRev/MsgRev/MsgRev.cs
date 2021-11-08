using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Interop;

namespace MsgRev
{
    public partial class MsgRev : Form
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

        public MsgRev()
        {
            InitializeComponent();
        }

        protected override void DefWndProc(ref Message m)
        {
            switch (m.Msg)
            {
                //接收自定义消息
                case WM_COPYDATA:
                    try
                    {
                        COPYDATASTRUCT rev = new COPYDATASTRUCT();
                        Type type = rev.GetType();
                        rev = (COPYDATASTRUCT)m.GetLParam(type);
                        string str = rev.lpData;
                        uitbxRev.Text = str;
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        break;
                    }

                default:
                    base.DefWndProc(ref m);
                    break;
            }
        }

        private void uibtnClr_Click(object sender, EventArgs e)
        {
            uitbxRev.Clear();
        }
    }
}
