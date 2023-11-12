﻿namespace CleanAppFilesGenerator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitter1 = new Splitter();
            splitter2 = new Splitter();
            textBox1 = new TextBox();
            FolderLocation = new TextBox();
            Domain_Model_Dll_Path = new TextBox();
            button1 = new Button();
            button2 = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            richTextBox1 = new RichTextBox();
            tabPage2 = new TabPage();
            richTextBox2 = new RichTextBox();
            tabPage3 = new TabPage();
            richTextBox3 = new RichTextBox();
            tabPage4 = new TabPage();
            richTextBox4 = new RichTextBox();
            tabPage5 = new TabPage();
            richTextBox5 = new RichTextBox();
            tabPage6 = new TabPage();
            richTextBox6 = new RichTextBox();
            listBox1 = new ListBox();
            openFileDialog1 = new OpenFileDialog();
            Library_Name_Space = new TextBox();
            tabPage7 = new TabPage();
            richTextBox7 = new RichTextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            tabPage6.SuspendLayout();
            tabPage7.SuspendLayout();
            SuspendLayout();
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 797);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // splitter2
            // 
            splitter2.Location = new Point(4, 0);
            splitter2.Name = "splitter2";
            splitter2.Size = new Size(559, 797);
            splitter2.TabIndex = 1;
            splitter2.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(33, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(254, 27);
            textBox1.TabIndex = 2;
            // 
            // FolderLocation
            // 
            FolderLocation.Location = new Point(33, 90);
            FolderLocation.Name = "FolderLocation";
            FolderLocation.Size = new Size(254, 27);
            FolderLocation.TabIndex = 3;
            // 
            // Domain_Model_Dll_Path
            // 
            Domain_Model_Dll_Path.Location = new Point(33, 157);
            Domain_Model_Dll_Path.Name = "Domain_Model_Dll_Path";
            Domain_Model_Dll_Path.Size = new Size(254, 27);
            Domain_Model_Dll_Path.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(333, 27);
            button1.Name = "button1";
            button1.Size = new Size(161, 29);
            button1.TabIndex = 5;
            button1.Text = "&Browse";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(333, 62);
            button2.Name = "button2";
            button2.Size = new Size(161, 190);
            button2.TabIndex = 6;
            button2.Text = "&Generate";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Controls.Add(tabPage7);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(563, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1615, 797);
            tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(richTextBox1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 3, 3, 3);
            tabPage1.Size = new Size(1607, 764);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Entities";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(3, 3);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1601, 758);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(richTextBox2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 3, 3, 3);
            tabPage2.Size = new Size(879, 764);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Interfaces";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            richTextBox2.Dock = DockStyle.Fill;
            richTextBox2.Location = new Point(3, 3);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(873, 758);
            richTextBox2.TabIndex = 0;
            richTextBox2.Text = "";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(richTextBox3);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 3, 3, 3);
            tabPage3.Size = new Size(879, 764);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Infrastructure Models";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // richTextBox3
            // 
            richTextBox3.Dock = DockStyle.Fill;
            richTextBox3.Location = new Point(3, 3);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(873, 758);
            richTextBox3.TabIndex = 0;
            richTextBox3.Text = "";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(richTextBox4);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3, 3, 3, 3);
            tabPage4.Size = new Size(879, 764);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "CQRS Command";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // richTextBox4
            // 
            richTextBox4.Dock = DockStyle.Fill;
            richTextBox4.Location = new Point(3, 3);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.Size = new Size(873, 758);
            richTextBox4.TabIndex = 0;
            richTextBox4.Text = "";
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(richTextBox5);
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3, 3, 3, 3);
            tabPage5.Size = new Size(879, 764);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "CQRS Handler";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // richTextBox5
            // 
            richTextBox5.Dock = DockStyle.Fill;
            richTextBox5.Location = new Point(3, 3);
            richTextBox5.Name = "richTextBox5";
            richTextBox5.Size = new Size(873, 758);
            richTextBox5.TabIndex = 0;
            richTextBox5.Text = "";
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(richTextBox6);
            tabPage6.Location = new Point(4, 29);
            tabPage6.Margin = new Padding(1, 1, 1, 1);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(1, 1, 1, 1);
            tabPage6.Size = new Size(879, 764);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "CQRS Query";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // richTextBox6
            // 
            richTextBox6.Dock = DockStyle.Fill;
            richTextBox6.Location = new Point(1, 1);
            richTextBox6.Margin = new Padding(1, 1, 1, 1);
            richTextBox6.Name = "richTextBox6";
            richTextBox6.Size = new Size(877, 762);
            richTextBox6.TabIndex = 0;
            richTextBox6.Text = "";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(24, 270);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(470, 464);
            listBox1.TabIndex = 8;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Library_Name_Space
            // 
            Library_Name_Space.Location = new Point(33, 204);
            Library_Name_Space.Name = "Library_Name_Space";
            Library_Name_Space.Size = new Size(254, 27);
            Library_Name_Space.TabIndex = 9;
            // 
            // tabPage7
            // 
            tabPage7.Controls.Add(richTextBox7);
            tabPage7.Location = new Point(4, 29);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new Padding(3);
            tabPage7.Size = new Size(1607, 764);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "IUNITOFWORK";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // richTextBox7
            // 
            richTextBox7.Dock = DockStyle.Fill;
            richTextBox7.Location = new Point(3, 3);
            richTextBox7.Name = "richTextBox7";
            richTextBox7.Size = new Size(1601, 758);
            richTextBox7.TabIndex = 0;
            richTextBox7.Text = "";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2178, 797);
            Controls.Add(Library_Name_Space);
            Controls.Add(listBox1);
            Controls.Add(tabControl1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Domain_Model_Dll_Path);
            Controls.Add(FolderLocation);
            Controls.Add(textBox1);
            Controls.Add(splitter2);
            Controls.Add(splitter1);
            Name = "MainForm";
            Text = "MainForm";
            WindowState = FormWindowState.Maximized;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            tabPage6.ResumeLayout(false);
            tabPage7.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Splitter splitter1;
        private Splitter splitter2;
        private TextBox textBox1;
        private TextBox FolderLocation;
        private TextBox Domain_Model_Dll_Path;
        private Button button1;
        private Button button2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private RichTextBox richTextBox1;
        private TabPage tabPage2;
        private ListBox listBox1;
        private OpenFileDialog openFileDialog1;
        private TextBox Library_Name_Space;
        private RichTextBox richTextBox2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private RichTextBox richTextBox3;
        private RichTextBox richTextBox4;
        private TabPage tabPage5;
        private RichTextBox richTextBox5;
        private TabPage tabPage6;
        private RichTextBox richTextBox6;
        private TabPage tabPage7;
        private RichTextBox richTextBox7;
    }
}