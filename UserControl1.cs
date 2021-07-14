using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeChatRobot
{
    public partial class UserControl1 : UserControl
    {
        public Form1.WindowInfo p;
        public Thread G;//工作线程
        public wxinfo W=new wxinfo();
        //public gb2312 = Encoding.GetEncoding("gb2312");
        [DllImport("user32", EntryPoint = "GetWindowThreadProcessId")]
        private static extern int GetWindowThreadProcessId(IntPtr hwnd, out int pid);
        public UserControl1()
        {
            InitializeComponent();
            
           
        }
        public void Init() {

            GetWindowThreadProcessId(p.hWnd,out p.pid);
           label4.Text = p.hWnd.ToString();

            //读取微信号：
            W.wxhao= System.Text.Encoding.UTF8.GetString(ReadByte(ReadPointerValue("WeChatWin.dll", new int[] { 0x1DDF534 }), 20));
            W.wxid = System.Text.Encoding.UTF8.GetString(ReadByte(ReadPointerValue("WeChatWin.dll", new int[] { 0x01DE250C, 0x0 }), 19));
            W.nick = System.Text.Encoding.UTF8.GetString(ReadByte(ReadPointerValue("WeChatWin.dll", new int[] { 0x1DDF938 }), 32));
           
            textBox_wxid.Text = W.wxhao;
            textBox_nick.Text = W.nick;
            textBox1.Text = W.wxid;


            string imgurl = System.Text.Encoding.UTF8.GetString(ReadByte(ReadPointerValue("WeChatWin.dll", new int[] { 0x01DDF7FC, 0x0 }),260));

            pictureBox_image.ImageLocation = imgurl.Trim();

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
           // textBox_log.Text += p.hWnd.ToString();
        }
        /// <summary>
        /// 从内存读取字节数据
        /// </summary>
        /// <param name="baseAddress">指针</param>
        /// <param name="len">长度</param>
        /// <returns></returns>
        public byte[] ReadByte(int baseAddress, int len = 4) {
            IntPtr addr = ReadMemoryValue(baseAddress, len);
            // Marshal.ReadInt32();
            byte[] c = new byte[len];
            for (var i = 0; i < len; i++)
            {
               // Console.WriteLine(Convert.ToInt32(Marshal.ReadByte(addr, i)).ToString("X2"));
                if (Convert.ToInt32(Marshal.ReadByte(addr, i))== 0) {
                    byte[] e = new byte[i];
                    Array.Copy(c,e,i);
                    //e = c;
                    Console.WriteLine("提前返回："+i.ToString());
                    return e;
                }
                c[i] = Marshal.ReadByte(addr, i);
            }
            return c;
        }
        //读取指针内存中的值
        public int ReadPointerValue(string name,int[] baseAdd)
        {
            IntPtr WeChatWin_dll = GetModAddr(name);
            int address = (int)WeChatWin_dll;
            address = address + baseAdd[0];
          //  textBox_log.Text += "\r\n读取 "+name+"("+WeChatWin_dll.ToString("X8")+ " + " +baseAdd[0].ToString("X8")+") =指针：" + address.ToString("X8");
            for (int i = 1; i < baseAdd.Length; i++)
            {
                //读取对方指针处数据到我方 返回我方缓冲区指针 读取我方缓冲区指针内容=对方指针内容

                address = Marshal.ReadInt32(ReadMemoryValue(address));
                address = address + baseAdd[i];
               
            }
            
            return address;
        }

        /// <summary>
        /// 读取内存 返回数据指针
        /// </summary>
        /// <param name="baseAddress">内存地址</param>
        /// <param name="len">读取长度 byte</param>
        /// <returns></returns>
        public IntPtr ReadMemoryValue(int baseAddress,int len=4)
        {
            try
            {
                
                byte[] buffer = new byte[len];
                IntPtr byteAddress = Marshal.UnsafeAddrOfPinnedArrayElement(buffer, 0); //获取缓冲区地址
                
                IntPtr hProcess = OpenProcess(0x1F0FFF, false,p.pid);
                ReadProcessMemory(hProcess, (IntPtr)baseAddress, byteAddress, len, IntPtr.Zero); //将制定内存中的值读入缓冲区
                CloseHandle(hProcess);
                return byteAddress;
            }
            catch
            {
                return (IntPtr)0;
            }
        }

        [DllImportAttribute("kernel32.dll", EntryPoint = "ReadProcessMemory")]
        public static extern bool ReadProcessMemory
       (
           IntPtr hProcess,
           IntPtr lpBaseAddress,
           IntPtr lpBuffer,
           int nSize,
           IntPtr lpNumberOfBytesRead
       );

        [DllImportAttribute("kernel32.dll", EntryPoint = "OpenProcess")]
        public static extern IntPtr OpenProcess
            (
                int dwDesiredAccess,
                bool bInheritHandle,
                int dwProcessId
            );

        [DllImport("kernel32.dll")]
        private static extern void CloseHandle
            (
                IntPtr hObject
            );

        public IntPtr GetModAddr(string name) {
            // IntPtr hProcess = OpenProcess(0x1F0FFF, false, p.pid);
            Process pp = Process.GetProcessById(p.pid);
            IntPtr ret=new IntPtr();
            foreach (ProcessModule m in pp.Modules)
            {
                if (m.ModuleName == name){
                    
                    ret= m.BaseAddress;
                    break;
                     }
            }
            return ret;
        }
    }

    

    //微信信息
    public class wxinfo {
        public string wxid;
        public string wxhao;
        public string nick;
        public string wxname;
    }
}
