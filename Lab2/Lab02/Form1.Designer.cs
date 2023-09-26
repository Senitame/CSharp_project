using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab02
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
            menuStrip1 = new MenuStrip();
            ToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            richTextBoxResult = new RichTextBox();
            groupBox1 = new GroupBox();
            buttonTask1 = new Button();
            tbLastName1 = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            buttonTask2 = new Button();
            tbLastName2 = new TextBox();
            label2 = new Label();
            groupBox3 = new GroupBox();
            buttonTask3 = new Button();
            tbTeacherLastName = new TextBox();
            label3 = new Label();
            groupBox4 = new GroupBox();
            buttonTask4 = new Button();
            tbNumBus = new TextBox();
            label4 = new Label();
            groupBox5 = new GroupBox();
            buttonTask5 = new Button();
            tbGrade = new TextBox();
            label5 = new Label();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(906, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem
            // 
            ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loadToolStripMenuItem });
            ToolStripMenuItem.Name = "ToolStripMenuItem";
            ToolStripMenuItem.Size = new Size(59, 24);
            ToolStripMenuItem.Text = "Файл";
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            loadToolStripMenuItem.Size = new Size(212, 26);
            loadToolStripMenuItem.Text = "Загрузить";
            loadToolStripMenuItem.Click += loadToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 703);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(906, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(85, 20);
            toolStripStatusLabel1.Text = "Count lines:";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(60, 20);
            toolStripStatusLabel2.Text = "number";
            // 
            // richTextBoxResult
            // 
            richTextBoxResult.Dock = DockStyle.Right;
            richTextBoxResult.Location = new Point(423, 28);
            richTextBoxResult.Name = "richTextBoxResult";
            richTextBoxResult.Size = new Size(483, 675);
            richTextBoxResult.TabIndex = 2;
            richTextBoxResult.Text = "Hello, world!";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonTask1);
            groupBox1.Controls.Add(tbLastName1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(388, 124);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "№1";
            // 
            // buttonTask1
            // 
            buttonTask1.Location = new Point(209, 69);
            buttonTask1.Name = "buttonTask1";
            buttonTask1.Size = new Size(124, 32);
            buttonTask1.TabIndex = 2;
            buttonTask1.Text = "Найти";
            buttonTask1.UseVisualStyleBackColor = true;
            buttonTask1.Click += button1_Click;
            // 
            // tbLastName1
            // 
            tbLastName1.Cursor = Cursors.IBeam;
            tbLastName1.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            tbLastName1.ForeColor = Color.Black;
            tbLastName1.Location = new Point(27, 74);
            tbLastName1.Name = "tbLastName1";
            tbLastName1.PlaceholderText = "Фамилия студента";
            tbLastName1.Size = new Size(150, 25);
            tbLastName1.TabIndex = 1;
            tbLastName1.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 35);
            label1.Name = "label1";
            label1.Size = new Size(306, 20);
            label1.TabIndex = 0;
            label1.Text = "Найти класс студента и его преподавателя";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonTask2);
            groupBox2.Controls.Add(tbLastName2);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(12, 161);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(388, 124);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "№2";
            // 
            // buttonTask2
            // 
            buttonTask2.Location = new Point(209, 79);
            buttonTask2.Name = "buttonTask2";
            buttonTask2.Size = new Size(124, 29);
            buttonTask2.TabIndex = 2;
            buttonTask2.Text = "Найти";
            buttonTask2.UseVisualStyleBackColor = true;
            buttonTask2.Click += buttonTask2_Click;
            // 
            // tbLastName2
            // 
            tbLastName2.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            tbLastName2.Location = new Point(27, 81);
            tbLastName2.Name = "tbLastName2";
            tbLastName2.PlaceholderText = "Фамилия студента";
            tbLastName2.Size = new Size(150, 25);
            tbLastName2.TabIndex = 1;
            tbLastName2.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 44);
            label2.Name = "label2";
            label2.Size = new Size(268, 20);
            label2.TabIndex = 0;
            label2.Text = "Найти автобусный маршрут студента";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(buttonTask3);
            groupBox3.Controls.Add(tbTeacherLastName);
            groupBox3.Controls.Add(label3);
            groupBox3.Location = new Point(12, 295);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(388, 132);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "№3";
            // 
            // buttonTask3
            // 
            buttonTask3.Location = new Point(208, 76);
            buttonTask3.Name = "buttonTask3";
            buttonTask3.Size = new Size(124, 29);
            buttonTask3.TabIndex = 2;
            buttonTask3.Text = "Найти";
            buttonTask3.UseVisualStyleBackColor = true;
            buttonTask3.Click += buttonTask3_Click;
            // 
            // tbTeacherLastName
            // 
            tbTeacherLastName.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            tbTeacherLastName.Location = new Point(26, 80);
            tbTeacherLastName.Name = "tbTeacherLastName";
            tbTeacherLastName.PlaceholderText = "Фамилия преподавателя";
            tbTeacherLastName.Size = new Size(150, 25);
            tbTeacherLastName.TabIndex = 1;
            tbTeacherLastName.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 44);
            label3.Name = "label3";
            label3.Size = new Size(260, 20);
            label3.TabIndex = 0;
            label3.Text = "Найти студентов по преподавателю";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(buttonTask4);
            groupBox4.Controls.Add(tbNumBus);
            groupBox4.Controls.Add(label4);
            groupBox4.Location = new Point(15, 436);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(384, 125);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "№4";
            // 
            // buttonTask4
            // 
            buttonTask4.Location = new Point(205, 77);
            buttonTask4.Name = "buttonTask4";
            buttonTask4.Size = new Size(124, 29);
            buttonTask4.TabIndex = 2;
            buttonTask4.Text = "Найти";
            buttonTask4.UseVisualStyleBackColor = true;
            buttonTask4.Click += buttonTask4_Click;
            // 
            // tbNumBus
            // 
            tbNumBus.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            tbNumBus.Location = new Point(23, 77);
            tbNumBus.Name = "tbNumBus";
            tbNumBus.PlaceholderText = "Номер маршрута";
            tbNumBus.Size = new Size(150, 25);
            tbNumBus.TabIndex = 1;
            tbNumBus.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 35);
            label4.Name = "label4";
            label4.Size = new Size(313, 20);
            label4.TabIndex = 0;
            label4.Text = "Найти студентов по автобусному маршруту";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(buttonTask5);
            groupBox5.Controls.Add(tbGrade);
            groupBox5.Controls.Add(label5);
            groupBox5.Location = new Point(15, 578);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(384, 125);
            groupBox5.TabIndex = 7;
            groupBox5.TabStop = false;
            groupBox5.Text = "№5";
            // 
            // buttonTask5
            // 
            buttonTask5.Location = new Point(206, 70);
            buttonTask5.Name = "buttonTask5";
            buttonTask5.Size = new Size(124, 29);
            buttonTask5.TabIndex = 2;
            buttonTask5.Text = "Найти";
            buttonTask5.UseVisualStyleBackColor = true;
            buttonTask5.Click += buttonTask5_Click;
            // 
            // tbGrade
            // 
            tbGrade.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            tbGrade.Location = new Point(24, 70);
            tbGrade.Name = "tbGrade";
            tbGrade.PlaceholderText = "Оценка";
            tbGrade.Size = new Size(149, 25);
            tbGrade.TabIndex = 1;
            tbGrade.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 37);
            label5.Name = "label5";
            label5.Size = new Size(220, 20);
            label5.TabIndex = 0;
            label5.Text = "Найти студентов по их оценке";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 729);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(richTextBoxResult);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void buttonTask5_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void buttonTask4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void buttonTask3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void buttonTask2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private RichTextBox richTextBoxResult;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox tbLastName1;
        private Button buttonTask1;
        private GroupBox groupBox2;
        private Label label2;
        private TextBox tbLastName2;
        private Button buttonTask2;
        private GroupBox groupBox3;
        private Label label3;
        private TextBox tbTeacherLastName;
        private Button buttonTask3;
        private GroupBox groupBox4;
        private Label label4;
        private TextBox tbNumBus;
        private Button buttonTask4;
        private GroupBox groupBox5;
        private Label label5;
        private TextBox tbGrade;
        private Button buttonTask5;
    }
}