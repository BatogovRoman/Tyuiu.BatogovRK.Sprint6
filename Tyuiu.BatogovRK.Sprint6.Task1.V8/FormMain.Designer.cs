namespace Tyuiu.BatogovRK.Sprint6.Task1.V8
{
    partial class FormMain
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
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            textBox5 = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox2 = new GroupBox();
            textBoxResult = new TextBox();
            groupBox3 = new GroupBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            TextBoxStop = new TextBox();
            TextBoxStart = new TextBox();
            buttonINF = new Button();
            buttonResult = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox5);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(516, 222);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.AliceBlue;
            textBox5.Enabled = false;
            textBox5.Location = new Point(4, 24);
            textBox5.Margin = new Padding(2);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(472, 84);
            textBox5.TabIndex = 0;
            textBox5.Text = "Протабулировать функцию на заданном диапазоне. Результат вывести в виде таблицы.";
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxResult);
            groupBox2.Location = new Point(543, 7);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(286, 324);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вывод данных";
            // 
            // textBoxResult
            // 
            textBoxResult.AccessibleName = "textBoxResult";
            textBoxResult.Font = new Font("Consolas", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult.Location = new Point(4, 31);
            textBoxResult.Margin = new Padding(2);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(285, 291);
            textBoxResult.TabIndex = 0;
            textBoxResult.TextChanged += textBoxResult_TextChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox4);
            groupBox3.Controls.Add(textBox3);
            groupBox3.Controls.Add(TextBoxStop);
            groupBox3.Controls.Add(TextBoxStart);
            groupBox3.Location = new Point(7, 240);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(302, 110);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ввод данных";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.AliceBlue;
            textBox4.Location = new Point(152, 42);
            textBox4.Margin = new Padding(2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 3;
            textBox4.Text = "Конец шага";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.AliceBlue;
            textBox3.Location = new Point(4, 42);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 2;
            textBox3.Text = "Старт шага";
            // 
            // TextBoxStop
            // 
            TextBoxStop.BackColor = Color.AliceBlue;
            TextBoxStop.Location = new Point(152, 62);
            TextBoxStop.Margin = new Padding(2);
            TextBoxStop.Multiline = true;
            TextBoxStop.Name = "TextBoxStop";
            TextBoxStop.Size = new Size(128, 41);
            TextBoxStop.TabIndex = 1;
            TextBoxStop.TextChanged += TextBoxStop_TextChanged;
            // 
            // TextBoxStart
            // 
            TextBoxStart.AccessibleName = "textBoxStart";
            TextBoxStart.BackColor = Color.AliceBlue;
            TextBoxStart.Location = new Point(4, 62);
            TextBoxStart.Margin = new Padding(2);
            TextBoxStart.Multiline = true;
            TextBoxStart.Name = "TextBoxStart";
            TextBoxStart.Size = new Size(125, 41);
            TextBoxStart.TabIndex = 0;
            TextBoxStart.TextChanged += TextBoxStart_TextChanged;
            // 
            // buttonINF
            // 
            buttonINF.BackColor = Color.Crimson;
            buttonINF.Location = new Point(314, 282);
            buttonINF.Margin = new Padding(2);
            buttonINF.Name = "buttonINF";
            buttonINF.Size = new Size(79, 59);
            buttonINF.TabIndex = 0;
            buttonINF.Text = "Справка";
            buttonINF.UseVisualStyleBackColor = false;
            buttonINF.Click += buttonINF_Click;
            // 
            // buttonResult
            // 
            buttonResult.BackColor = Color.CornflowerBlue;
            buttonResult.ForeColor = SystemColors.ActiveCaptionText;
            buttonResult.Location = new Point(407, 282);
            buttonResult.Margin = new Padding(2);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new Size(126, 59);
            buttonResult.TabIndex = 1;
            buttonResult.Text = "Выполнить";
            buttonResult.UseVisualStyleBackColor = false;
            buttonResult.Click += buttonResult_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 356);
            Controls.Add(buttonResult);
            Controls.Add(buttonINF);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(2);
            Name = "FormMain";
            Text = "Спринт 6| Таск 1| Вариант 8| Батогов Р.К.";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        private GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button buttonINF;
        private Button buttonResult;
        private TextBox textBoxResult;
        private TextBox TextBoxStop;
        private TextBox TextBoxStart;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox5;
    }
}
