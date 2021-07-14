
namespace WeChatRobot
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_TaskList = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage_Option = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_num = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_wxpath = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button_OpenWeChat = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage_TaskList.SuspendLayout();
            this.tabPage_Option.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_TaskList);
            this.tabControl1.Controls.Add(this.tabPage_Option);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_TaskList
            // 
            this.tabPage_TaskList.Controls.Add(this.flowLayoutPanel1);
            this.tabPage_TaskList.Location = new System.Drawing.Point(4, 22);
            this.tabPage_TaskList.Name = "tabPage_TaskList";
            this.tabPage_TaskList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_TaskList.Size = new System.Drawing.Size(792, 424);
            this.tabPage_TaskList.TabIndex = 0;
            this.tabPage_TaskList.Text = "TaskList";
            this.tabPage_TaskList.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(786, 418);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tabPage_Option
            // 
            this.tabPage_Option.Controls.Add(this.groupBox1);
            this.tabPage_Option.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Option.Name = "tabPage_Option";
            this.tabPage_Option.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Option.Size = new System.Drawing.Size(792, 424);
            this.tabPage_Option.TabIndex = 1;
            this.tabPage_Option.Text = "Option";
            this.tabPage_Option.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel_num});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(199, 17);
            this.toolStripStatusLabel1.Text = "Effective / Number of processes:";
            // 
            // toolStripStatusLabel_num
            // 
            this.toolStripStatusLabel_num.Name = "toolStripStatusLabel_num";
            this.toolStripStatusLabel_num.Size = new System.Drawing.Size(27, 17);
            this.toolStripStatusLabel_num.Text = "0/0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_OpenWeChat);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.textBox_wxpath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 56);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OpenWeChat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "WeChat Path:";
            // 
            // textBox_wxpath
            // 
            this.textBox_wxpath.Location = new System.Drawing.Point(91, 20);
            this.textBox_wxpath.Name = "textBox_wxpath";
            this.textBox_wxpath.Size = new System.Drawing.Size(515, 21);
            this.textBox_wxpath.TabIndex = 1;
            this.textBox_wxpath.Text = "D:\\Program Files (x86)\\Tencent\\WeChat\\WeChat.exe";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(612, 20);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(45, 21);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // button_OpenWeChat
            // 
            this.button_OpenWeChat.Location = new System.Drawing.Point(663, 20);
            this.button_OpenWeChat.Name = "button_OpenWeChat";
            this.button_OpenWeChat.Size = new System.Drawing.Size(107, 23);
            this.button_OpenWeChat.TabIndex = 3;
            this.button_OpenWeChat.Text = "Open The WeChat";
            this.button_OpenWeChat.UseVisualStyleBackColor = true;
            this.button_OpenWeChat.Click += new System.EventHandler(this.button_OpenWeChat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "WeChatRobot V1.0 (beta) [yeahoh@foxmail.com] Updated:2021-07-12";
            this.tabControl1.ResumeLayout(false);
            this.tabPage_TaskList.ResumeLayout(false);
            this.tabPage_Option.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_TaskList;
        private System.Windows.Forms.TabPage tabPage_Option;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_num;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_wxpath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_OpenWeChat;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

