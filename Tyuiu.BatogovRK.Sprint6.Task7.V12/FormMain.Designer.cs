namespace Tyuiu.BatogovRK.Sprint6.Task7.V12
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewIn = new DataGridView();
            dataGridViewOut = new DataGridView();
            openFileDialog = new OpenFileDialog();
            textBoxInPut = new TextBox();
            textBoxOutPut = new TextBox();
            buttonClick = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewIn
            // 
            dataGridViewIn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn.Location = new Point(17, 43);
            dataGridViewIn.Margin = new Padding(4, 5, 4, 5);
            dataGridViewIn.Name = "dataGridViewIn";
            dataGridViewIn.RowHeadersWidth = 62;
            dataGridViewIn.Size = new Size(311, 662);
            dataGridViewIn.TabIndex = 0;
            // 
            // dataGridViewOut
            // 
            dataGridViewOut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut.Location = new Point(353, 43);
            dataGridViewOut.Margin = new Padding(4, 5, 4, 5);
            dataGridViewOut.Name = "dataGridViewOut";
            dataGridViewOut.RowHeadersWidth = 62;
            dataGridViewOut.Size = new Size(301, 662);
            dataGridViewOut.TabIndex = 1;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            openFileDialog.FileOk += openFileDialog1_FileOk;
            // 
            // textBoxInPut
            // 
            textBoxInPut.Location = new Point(749, 102);
            textBoxInPut.Margin = new Padding(4, 5, 4, 5);
            textBoxInPut.Name = "textBoxInPut";
            textBoxInPut.Size = new Size(288, 31);
            textBoxInPut.TabIndex = 2;
            // 
            // textBoxOutPut
            // 
            textBoxOutPut.Location = new Point(749, 185);
            textBoxOutPut.Margin = new Padding(4, 5, 4, 5);
            textBoxOutPut.Name = "textBoxOutPut";
            textBoxOutPut.Size = new Size(288, 31);
            textBoxOutPut.TabIndex = 3;
            // 
            // buttonClick
            // 
            buttonClick.Location = new Point(749, 385);
            buttonClick.Margin = new Padding(4, 5, 4, 5);
            buttonClick.Name = "buttonClick";
            buttonClick.Size = new Size(290, 77);
            buttonClick.TabIndex = 4;
            buttonClick.Text = "Открыть файл";
            buttonClick.UseVisualStyleBackColor = true;
            buttonClick.Click += button1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(749, 523);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(290, 77);
            button1.TabIndex = 5;
            button1.Text = "Обработать файл";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(button1);
            Controls.Add(buttonClick);
            Controls.Add(textBoxOutPut);
            Controls.Add(textBoxInPut);
            Controls.Add(dataGridViewOut);
            Controls.Add(dataGridViewIn);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 7 | Вариант 12 | Батогов Р.К.";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewIn;
        private DataGridView dataGridViewOut;
        private OpenFileDialog openFileDialog;
        private TextBox textBoxInPut;
        private TextBox textBoxOutPut;
        private Button buttonClick;
        private Button button1;
    }
}
