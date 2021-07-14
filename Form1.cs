using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace WeChatRobot
{
    public partial class Form1 : Form
    {
        public int WechatNum;
        public int WechatNum2;
        public Form1()
        {
            InitializeComponent();
        }


        //获得设置信息 （只读）
        private readonly Properties.Settings Config = Properties.Settings.Default;


        private delegate bool WNDENUMPROC(IntPtr hWnd, int lParam);

        //用来遍历所有窗口 
        [DllImport("user32.dll")]
        private static extern bool EnumWindows(WNDENUMPROC lpEnumFunc, int lParam);

        //获取窗口Text 
        [DllImport("user32.dll")]
        private static extern int GetWindowTextW(IntPtr hWnd, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpString, int nMaxCount);

        //获取窗口类名 
        [DllImport("user32.dll")]
        private static extern int GetClassNameW(IntPtr hWnd, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpString, int nMaxCount);


        public WindowInfo[] WindowList;
        public struct WindowInfo
        {
            public IntPtr hWnd;
            public int pid;
            public string szWindowName;
            public string szClassName;
            public int Index;//索引
        }

        public WindowInfo[] GetAllDesktopWindows()
        {
            //用来保存窗口对象 列表
            List<WindowInfo> wndList = new List<WindowInfo>();

            //enum all desktop windows 
            EnumWindows(delegate (IntPtr hWnd, int lParam)
            {
                WindowInfo wnd = new WindowInfo();
                StringBuilder sb = new StringBuilder(256);

                //get hwnd 
                wnd.hWnd = hWnd;

                //get window name  
                GetWindowTextW(hWnd, sb, sb.Capacity);
                wnd.szWindowName = sb.ToString();

                //get window class 
                GetClassNameW(hWnd, sb, sb.Capacity);
                wnd.szClassName = sb.ToString();

                //add it into list 
                wndList.Add(wnd);
                return true;
            }, 0);

            return wndList.ToArray();
        }

        //检查微信窗口对象
        private void CheckWechatWindow() {
            GetWindowList();

            
        }

        public List<WindowInfo> WL = new List<WindowInfo>();
        private void GetWindowList()
        {
            try
            {
                WL.Clear();
                //myPanel1.Controls.Clear();
                //flowLayoutPanel1.Controls.Clear();
                foreach (WindowInfo p in GetAllDesktopWindows())
                {
                    // Console.WriteLine(p.szWindowName);
                    if (p.szWindowName.IndexOf("微信") > -1 && p.szClassName.IndexOf("WeChatMainWndForPC") >-1)  //第一个字符匹配的话为0，这与VB不同
                    {
                        WL.Add(p);
                        UserControl1 a = new UserControl1();
                        a.p = p;
                        bool cki=false;//是否存在
                        for (var i=0;i< flowLayoutPanel1.Controls.Count;i++)
                        {

                            //if (flowLayoutPanel1.Controls[0].Contains(a)=false) {
                            UserControl1 b = (UserControl1)flowLayoutPanel1.Controls[i];
                            if (b.p.hWnd==p.hWnd) {
                                cki = true;
                                break;
                            }
                        }
                        if (cki == false) {
                            a.Init();
                            flowLayoutPanel1.Controls.Add(a);

                        }
                        
                    }
                }
                // WindowCount = WL.Count;
                WechatNum = WL.Count;
                // toolStripStatusLabel1.Text = $"窗口{WindowCount}个";
                // toolStripStatusLabel2.Text = $"布局{textBox_Num_X.Text}x{textBox_Num_Y.Text}={(int.Parse(textBox_Num_X.Text) * int.Parse(textBox_Num_Y.Text)).ToString()}个";
                ;
                //  textBox_info.Text = $"已找到{WindowCount.ToString()}个窗口\r\n桌面尺寸：{ScreenW}x{ScreenH}\r\n单窗口分辨率：160x90";
            }
            catch
            {

            }
        }
        //更新信息显示
        private void UpdateTextShow() {
            toolStripStatusLabel_num.Text = $"{WechatNum2}/{WechatNum}";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //没有找到窗口时 加快寻找速度
            if (WechatNum == 0)
            {
                timer1.Interval = 100;
            }
            else {
                timer1.Interval = 500;
            }

            CheckWechatWindow();
            UpdateTextShow();
        }

        private void button_OpenWeChat_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < numericUpDown1.Value; i++) {
                Process pr = new Process();//声明一个进程类对象
                pr.StartInfo.FileName =textBox_wxpath.Text;
                pr.Start();
            }
        }
    }
}
