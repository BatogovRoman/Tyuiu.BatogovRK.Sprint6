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
            textBoxRowsNTip = new TextBox();
            groupBoxInput = new GroupBox();
            buttonDone = new Button();
            groupBoxFind = new GroupBox();
            textBoxRowRInput = new TextBox();
            textBoxRowRTip = new TextBox();
            textBoxEndPosLInput = new TextBox();
            textBoxStartPosKInput = new TextBox();
            textBoxEndPosLTip = new TextBox();
            textBoxStartPosKTip = new TextBox();
            textBoxRandNum_n2_Input = new TextBox();
            textBoxRandNum_n1_Input = new TextBox();
            textBoxRandNum_n2_Tip = new TextBox();
            textBoxRandNum_n1_Tip = new TextBox();
            textBoxRandNumsTip = new TextBox();
            textBoxColumnsMInput = new TextBox();
            textBoxRowsNInput = new TextBox();
            textBoxColumnsMTip = new TextBox();
            dataGridViewOutPut = new DataGridView();
            textBoxAnswTip = new TextBox();
            textBoxAnswOutPut = new TextBox();
            groupBoxOutPut = new GroupBox();
            groupBoxInput.SuspendLayout();
            groupBoxFind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutPut).BeginInit();
            groupBoxOutPut.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxRowsNTip
            // 
            textBoxRowsNTip.BorderStyle = BorderStyle.None;
            textBoxRowsNTip.Location = new Point(37, 75);
            textBoxRowsNTip.Margin = new Padding(4, 5, 4, 5);
            textBoxRowsNTip.Name = "textBoxRowsNTip";
            textBoxRowsNTip.ReadOnly = true;
            textBoxRowsNTip.Size = new Size(179, 24);
            textBoxRowsNTip.TabIndex = 0;
            textBoxRowsNTip.Text = "Количество строк N:";
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(buttonDone);
            groupBoxInput.Controls.Add(groupBoxFind);
            groupBoxInput.Controls.Add(textBoxRandNum_n2_Input);
            groupBoxInput.Controls.Add(textBoxRandNum_n1_Input);
            groupBoxInput.Controls.Add(textBoxRandNum_n2_Tip);
            groupBoxInput.Controls.Add(textBoxRandNum_n1_Tip);
            groupBoxInput.Controls.Add(textBoxRandNumsTip);
            groupBoxInput.Controls.Add(textBoxColumnsMInput);
            groupBoxInput.Controls.Add(textBoxRowsNInput);
            groupBoxInput.Controls.Add(textBoxColumnsMTip);
            groupBoxInput.Controls.Add(textBoxRowsNTip);
            groupBoxInput.Location = new Point(81, 62);
            groupBoxInput.Margin = new Padding(4, 5, 4, 5);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Padding = new Padding(4, 5, 4, 5);
            groupBoxInput.Size = new Size(561, 795);
            groupBoxInput.TabIndex = 1;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Условие";
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(37, 678);
            buttonDone.Margin = new Padding(4, 5, 4, 5);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(491, 87);
            buttonDone.TabIndex = 12;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // groupBoxFind
            // 
            groupBoxFind.Controls.Add(textBoxRowRInput);
            groupBoxFind.Controls.Add(textBoxRowRTip);
            groupBoxFind.Controls.Add(textBoxEndPosLInput);
            groupBoxFind.Controls.Add(textBoxStartPosKInput);
            groupBoxFind.Controls.Add(textBoxEndPosLTip);
            groupBoxFind.Controls.Add(textBoxStartPosKTip);
            groupBoxFind.Location = new Point(0, 365);
            groupBoxFind.Margin = new Padding(4, 5, 4, 5);
            groupBoxFind.Name = "groupBoxFind";
            groupBoxFind.Padding = new Padding(4, 5, 4, 5);
            groupBoxFind.Size = new Size(557, 293);
            groupBoxFind.TabIndex = 11;
            groupBoxFind.TabStop = false;
            groupBoxFind.Text = "Найти";
            // 
            // textBoxRowRInput
            // 
            textBoxRowRInput.Location = new Point(227, 70);
            textBoxRowRInput.Margin = new Padding(4, 5, 4, 5);
            textBoxRowRInput.Name = "textBoxRowRInput";
            textBoxRowRInput.Size = new Size(177, 31);
            textBoxRowRInput.TabIndex = 5;
            // 
            // textBoxRowRTip
            // 
            textBoxRowRTip.BorderStyle = BorderStyle.None;
            textBoxRowRTip.Location = new Point(126, 75);
            textBoxRowRTip.Margin = new Padding(4, 5, 4, 5);
            textBoxRowRTip.Name = "textBoxRowRTip";
            textBoxRowRTip.ReadOnly = true;
            textBoxRowRTip.Size = new Size(93, 24);
            textBoxRowRTip.TabIndex = 4;
            textBoxRowRTip.Text = "Столбец С:";
            // 
            // textBoxEndPosLInput
            // 
            textBoxEndPosLInput.Location = new Point(324, 202);
            textBoxEndPosLInput.Margin = new Padding(4, 5, 4, 5);
            textBoxEndPosLInput.Name = "textBoxEndPosLInput";
            textBoxEndPosLInput.Size = new Size(203, 31);
            textBoxEndPosLInput.TabIndex = 3;
            // 
            // textBoxStartPosKInput
            // 
            textBoxStartPosKInput.Location = new Point(37, 202);
            textBoxStartPosKInput.Margin = new Padding(4, 5, 4, 5);
            textBoxStartPosKInput.Name = "textBoxStartPosKInput";
            textBoxStartPosKInput.Size = new Size(177, 31);
            textBoxStartPosKInput.TabIndex = 2;
            // 
            // textBoxEndPosLTip
            // 
            textBoxEndPosLTip.BorderStyle = BorderStyle.None;
            textBoxEndPosLTip.Location = new Point(324, 165);
            textBoxEndPosLTip.Margin = new Padding(4, 5, 4, 5);
            textBoxEndPosLTip.Name = "textBoxEndPosLTip";
            textBoxEndPosLTip.ReadOnly = true;
            textBoxEndPosLTip.Size = new Size(204, 24);
            textBoxEndPosLTip.TabIndex = 1;
            textBoxEndPosLTip.Text = "До элемента L:";
            // 
            // textBoxStartPosKTip
            // 
            textBoxStartPosKTip.BorderStyle = BorderStyle.None;
            textBoxStartPosKTip.Location = new Point(37, 165);
            textBoxStartPosKTip.Margin = new Padding(4, 5, 4, 5);
            textBoxStartPosKTip.Name = "textBoxStartPosKTip";
            textBoxStartPosKTip.ReadOnly = true;
            textBoxStartPosKTip.Size = new Size(179, 24);
            textBoxStartPosKTip.TabIndex = 0;
            textBoxStartPosKTip.Text = "От элемента K:";
            // 
            // textBoxRandNum_n2_Input
            // 
            textBoxRandNum_n2_Input.Location = new Point(324, 308);
            textBoxRandNum_n2_Input.Margin = new Padding(4, 5, 4, 5);
            textBoxRandNum_n2_Input.Name = "textBoxRandNum_n2_Input";
            textBoxRandNum_n2_Input.Size = new Size(148, 31);
            textBoxRandNum_n2_Input.TabIndex = 8;
            // 
            // textBoxRandNum_n1_Input
            // 
            textBoxRandNum_n1_Input.Location = new Point(37, 308);
            textBoxRandNum_n1_Input.Margin = new Padding(4, 5, 4, 5);
            textBoxRandNum_n1_Input.Name = "textBoxRandNum_n1_Input";
            textBoxRandNum_n1_Input.Size = new Size(148, 31);
            textBoxRandNum_n1_Input.TabIndex = 7;
            // 
            // textBoxRandNum_n2_Tip
            // 
            textBoxRandNum_n2_Tip.BorderStyle = BorderStyle.None;
            textBoxRandNum_n2_Tip.Location = new Point(324, 272);
            textBoxRandNum_n2_Tip.Margin = new Padding(4, 5, 4, 5);
            textBoxRandNum_n2_Tip.Name = "textBoxRandNum_n2_Tip";
            textBoxRandNum_n2_Tip.ReadOnly = true;
            textBoxRandNum_n2_Tip.Size = new Size(110, 24);
            textBoxRandNum_n2_Tip.TabIndex = 6;
            textBoxRandNum_n2_Tip.Text = "До n2:";
            // 
            // textBoxRandNum_n1_Tip
            // 
            textBoxRandNum_n1_Tip.BorderStyle = BorderStyle.None;
            textBoxRandNum_n1_Tip.Location = new Point(37, 272);
            textBoxRandNum_n1_Tip.Margin = new Padding(4, 5, 4, 5);
            textBoxRandNum_n1_Tip.Name = "textBoxRandNum_n1_Tip";
            textBoxRandNum_n1_Tip.ReadOnly = true;
            textBoxRandNum_n1_Tip.Size = new Size(110, 24);
            textBoxRandNum_n1_Tip.TabIndex = 5;
            textBoxRandNum_n1_Tip.Text = "От n1:";
            // 
            // textBoxRandNumsTip
            // 
            textBoxRandNumsTip.BorderStyle = BorderStyle.None;
            textBoxRandNumsTip.Location = new Point(126, 206);
            textBoxRandNumsTip.Margin = new Padding(4, 5, 4, 5);
            textBoxRandNumsTip.Multiline = true;
            textBoxRandNumsTip.Name = "textBoxRandNumsTip";
            textBoxRandNumsTip.ReadOnly = true;
            textBoxRandNumsTip.Size = new Size(248, 26);
            textBoxRandNumsTip.TabIndex = 4;
            textBoxRandNumsTip.Text = "Диапазон случайных чисел:";
            // 
            // textBoxColumnsMInput
            // 
            textBoxColumnsMInput.Location = new Point(324, 112);
            textBoxColumnsMInput.Margin = new Padding(4, 5, 4, 5);
            textBoxColumnsMInput.Name = "textBoxColumnsMInput";
            textBoxColumnsMInput.Size = new Size(203, 31);
            textBoxColumnsMInput.TabIndex = 3;
            // 
            // textBoxRowsNInput
            // 
            textBoxRowsNInput.Location = new Point(37, 112);
            textBoxRowsNInput.Margin = new Padding(4, 5, 4, 5);
            textBoxRowsNInput.Name = "textBoxRowsNInput";
            textBoxRowsNInput.Size = new Size(177, 31);
            textBoxRowsNInput.TabIndex = 2;
            // 
            // textBoxColumnsMTip
            // 
            textBoxColumnsMTip.BorderStyle = BorderStyle.None;
            textBoxColumnsMTip.Location = new Point(324, 75);
            textBoxColumnsMTip.Margin = new Padding(4, 5, 4, 5);
            textBoxColumnsMTip.Name = "textBoxColumnsMTip";
            textBoxColumnsMTip.ReadOnly = true;
            textBoxColumnsMTip.Size = new Size(204, 24);
            textBoxColumnsMTip.TabIndex = 1;
            textBoxColumnsMTip.Text = "Количество столбцов M:";
            textBoxColumnsMTip.TextChanged += textBox2_TextChanged;
            // 
            // dataGridViewOutPut
            // 
            dataGridViewOutPut.AllowUserToAddRows = false;
            dataGridViewOutPut.AllowUserToDeleteRows = false;
            dataGridViewOutPut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutPut.Location = new Point(794, 62);
            dataGridViewOutPut.Margin = new Padding(4, 5, 4, 5);
            dataGridViewOutPut.Name = "dataGridViewOutPut";
            dataGridViewOutPut.ReadOnly = true;
            dataGridViewOutPut.RowHeadersWidth = 62;
            dataGridViewOutPut.Size = new Size(790, 430);
            dataGridViewOutPut.TabIndex = 2;
            dataGridViewOutPut.CellContentClick += dataGridViewOutPut_CellContentClick;
            // 
            // textBoxAnswTip
            // 
            textBoxAnswTip.BorderStyle = BorderStyle.None;
            textBoxAnswTip.Location = new Point(29, 60);
            textBoxAnswTip.Margin = new Padding(4, 5, 4, 5);
            textBoxAnswTip.Name = "textBoxAnswTip";
            textBoxAnswTip.ReadOnly = true;
            textBoxAnswTip.Size = new Size(250, 24);
            textBoxAnswTip.TabIndex = 13;
            textBoxAnswTip.Text = "Сумма положительных элементов:";
            // 
            // textBoxAnswOutPut
            // 
            textBoxAnswOutPut.Location = new Point(287, 55);
            textBoxAnswOutPut.Margin = new Padding(4, 5, 4, 5);
            textBoxAnswOutPut.Name = "textBoxAnswOutPut";
            textBoxAnswOutPut.ReadOnly = true;
            textBoxAnswOutPut.Size = new Size(203, 31);
            textBoxAnswOutPut.TabIndex = 6;
            // 
            // groupBoxOutPut
            // 
            groupBoxOutPut.Controls.Add(textBoxAnswTip);
            groupBoxOutPut.Controls.Add(textBoxAnswOutPut);
            groupBoxOutPut.Location = new Point(903, 707);
            groupBoxOutPut.Margin = new Padding(4, 5, 4, 5);
            groupBoxOutPut.Name = "groupBoxOutPut";
            groupBoxOutPut.Padding = new Padding(4, 5, 4, 5);
            groupBoxOutPut.Size = new Size(557, 150);
            groupBoxOutPut.TabIndex = 12;
            groupBoxOutPut.TabStop = false;
            groupBoxOutPut.Text = "Результат";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1668, 881);
            Controls.Add(groupBoxOutPut);
            Controls.Add(dataGridViewOutPut);
            Controls.Add(groupBoxInput);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Task Review | Вариант 8 | Батогов Р.К.";
            Load += Form1_Load;
            groupBoxInput.ResumeLayout(false);
            groupBoxInput.PerformLayout();
            groupBoxFind.ResumeLayout(false);
            groupBoxFind.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutPut).EndInit();
            groupBoxOutPut.ResumeLayout(false);
            groupBoxOutPut.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxRowsNTip;
        private GroupBox groupBoxInput;
        private TextBox textBoxRowsNInput;
        private TextBox textBoxColumnsMTip;
        private TextBox textBoxColumnsMInput;
        private TextBox textBoxRandNum_n2_Input;
        private TextBox textBoxRandNum_n1_Input;
        private TextBox textBoxRandNum_n2_Tip;
        private TextBox textBoxRandNum_n1_Tip;
        private TextBox textBoxRandNumsTip;
        private GroupBox groupBoxFind;
        private TextBox textBoxEndPosLInput;
        private TextBox textBoxStartPosKInput;
        private TextBox textBoxEndPosLTip;
        private TextBox textBoxStartPosKTip;
        private TextBox textBoxRowRInput;
        private TextBox textBoxRowRTip;
        private DataGridView dataGridViewOutPut;
        private Button buttonDone;
        private TextBox textBoxAnswTip;
        private TextBox textBoxAnswOutPut;
        private GroupBox groupBoxOutPut;
    }
}
