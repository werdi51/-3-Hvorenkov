
namespace Коллекции_3__ArrayLisdt
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
            textBox2 = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            label2 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            button2 = new System.Windows.Forms.Button();
            listBox1 = new System.Windows.Forms.ListBox();
            button3 = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(142, 214);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(168, 23);
            textBox2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(123, 36);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(213, 15);
            label1.TabIndex = 1;
            label1.Text = "«Одномерный массив целых чисел».";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new System.Drawing.Point(22, 111);
            numericUpDown1.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new System.Drawing.Size(146, 23);
            numericUpDown1.TabIndex = 2;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(18, 68);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(174, 15);
            label2.TabIndex = 3;
            label2.Text = "какого размера будет массив?";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(380, 12);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "проверка";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(159, 184);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(137, 15);
            label3.TabIndex = 5;
            label3.Text = "Что добавить в массив?";
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(179, 252);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(90, 40);
            button2.TabIndex = 6;
            button2.Text = "Внести";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new System.Drawing.Point(62, 364);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(353, 199);
            listBox1.TabIndex = 7;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(221, 10);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(164, 33);
            button3.TabIndex = 8;
            button3.Text = "умножить на число";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button3);
            panel1.Location = new System.Drawing.Point(37, 584);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(402, 50);
            panel1.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(14, 16);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "выберите на какое число умножить";
            textBox1.Size = new System.Drawing.Size(158, 23);
            textBox1.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(481, 658);
            Controls.Add(panel1);
            Controls.Add(listBox1);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(numericUpDown1);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

