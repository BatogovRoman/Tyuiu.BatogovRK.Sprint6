namespace Tyuiu.BatogovRK.Sprint6.Task0.V13
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
            buttonDone_BRK = new Button();
            textBoxResult_BRK = new TextBox();
            textBoxValueX_BRK = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonHelp_BRK = new Button();
            formula = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)formula).BeginInit();
            SuspendLayout();
            // 
            // buttonDone_BRK
            // 
            buttonDone_BRK.Location = new Point(1019, 692);
            buttonDone_BRK.Margin = new Padding(4, 5, 4, 5);
            buttonDone_BRK.Name = "buttonDone_BRK";
            buttonDone_BRK.Size = new Size(107, 38);
            buttonDone_BRK.TabIndex = 0;
            buttonDone_BRK.Text = "Выполнить";
            buttonDone_BRK.UseVisualStyleBackColor = true;
            buttonDone_BRK.Click += buttonDone_BRK_Click;
            // 
            // textBoxResult_BRK
            // 
            textBoxResult_BRK.Location = new Point(983, 643);
            textBoxResult_BRK.Margin = new Padding(4, 5, 4, 5);
            textBoxResult_BRK.Multiline = true;
            textBoxResult_BRK.Name = "textBoxResult_BRK";
            textBoxResult_BRK.Size = new Size(141, 36);
            textBoxResult_BRK.TabIndex = 2;
            textBoxResult_BRK.TextChanged += textBoxResult_BRK_TextChanged;
            // 
            // textBoxValueX_BRK
            // 
            textBoxValueX_BRK.Location = new Point(61, 643);
            textBoxValueX_BRK.Margin = new Padding(4, 5, 4, 5);
            textBoxValueX_BRK.Multiline = true;
            textBoxValueX_BRK.Name = "textBoxValueX_BRK";
            textBoxValueX_BRK.Size = new Size(141, 36);
            textBoxValueX_BRK.TabIndex = 3;
            textBoxValueX_BRK.TextChanged += textBoxValueX_BRK_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 568);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(130, 50);
            label1.TabIndex = 4;
            label1.Text = "Ввод данных: \r\nПеременная X";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 15);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(79, 25);
            label2.TabIndex = 5;
            label2.Text = "Условие";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 57);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(302, 50);
            label3.TabIndex = 6;
            label3.Text = "Вычислить выражения по формуле\r\n\r\n";
            label3.Click += label3_Click;
            // 
            // buttonHelp_BRK
            // 
            buttonHelp_BRK.Location = new Point(983, 692);
            buttonHelp_BRK.Margin = new Padding(4, 5, 4, 5);
            buttonHelp_BRK.Name = "buttonHelp_BRK";
            buttonHelp_BRK.Size = new Size(27, 38);
            buttonHelp_BRK.TabIndex = 7;
            buttonHelp_BRK.Text = "?";
            buttonHelp_BRK.UseVisualStyleBackColor = true;
            buttonHelp_BRK.Click += buttonHelp_BRK_Click;
            // 
            // formula
            // 
            formula.Image = Properties.Resources.form1;
            formula.Location = new Point(953, 57);
            formula.Margin = new Padding(4, 5, 4, 5);
            formula.Name = "formula";
            formula.Size = new Size(173, 98);
            formula.TabIndex = 8;
            formula.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 747);
            Controls.Add(formula);
            Controls.Add(buttonHelp_BRK);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxValueX_BRK);
            Controls.Add(textBoxResult_BRK);
            Controls.Add(buttonDone_BRK);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormMain";
            Text = "Спринт 6| Таск0 | Вариант 13| Батогов Р.К. ";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)formula).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDone_BRK;
        private TextBox textBoxResult_BRK;
        private TextBox textBoxValueX_BRK;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonHelp_BRK;
        private PictureBox formula;
    }
}
