namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            panel = new Panel();
            textBox1 = new TextBox();
            Start = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            button3 = new Button();
            listBox1 = new ListBox();
            fileSystemWatcher1 = new FileSystemWatcher();
            button4 = new Button();
            panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 32);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "문제";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(676, 65);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 1;
            label2.Text = "시간";
            // 
            // button1
            // 
            button1.Location = new Point(33, 264);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "이전";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(537, 264);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "다음";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel
            // 
            panel.Controls.Add(textBox1);
            panel.Controls.Add(label1);
            panel.Controls.Add(button1);
            panel.Controls.Add(Start);
            panel.Controls.Add(button2);
            panel.Location = new Point(36, 21);
            panel.Name = "panel";
            panel.Size = new Size(644, 404);
            panel.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(155, 170);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(152, 23);
            textBox1.TabIndex = 4;
            // 
            // Start
            // 
            Start.Location = new Point(456, 88);
            Start.Name = "Start";
            Start.Size = new Size(75, 23);
            Start.TabIndex = 5;
            Start.Text = "시작";
            Start.UseVisualStyleBackColor = true;
            Start.Click += Start_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // button3
            // 
            button3.Location = new Point(722, 191);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 6;
            button3.Text = "정답 확인";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(36, 444);
            listBox1.Name = "listBox1";
            listBox1.ScrollAlwaysVisible = true;
            listBox1.Size = new Size(922, 379);
            listBox1.TabIndex = 7;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            fileSystemWatcher1.Changed += fileSystemWatcher1_Changed;
            // 
            // button4
            // 
            button4.Location = new Point(907, 82);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 8;
            button4.Text = "파일 ";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 860);
            Controls.Add(button4);
            Controls.Add(listBox1);
            Controls.Add(button3);
            Controls.Add(panel);
            Controls.Add(label2);
            MaximizeBox = false;
            Name = "Form1";
            Text = "웹프 문제 테스트기";
            Load += Form1_Load;
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Panel panel;
        private TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private Button Start;
        private Button button3;
        private ListBox listBox1;
        private FileSystemWatcher fileSystemWatcher1;
        private Button button4;
    }
}
