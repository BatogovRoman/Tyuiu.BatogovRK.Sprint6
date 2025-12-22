using System.Windows.Forms;
using Tyuiu.BatogovRK.Sprint6.Task5.V24.Lib;

namespace Tyuiu.BatogovRK.Sprint6.Task5.V24
{
    public partial class FormMain : Form
    {
        private DataService ds;
        private double[] zeros = Array.Empty<double>();

        public FormMain()
        {
            InitializeComponent();
            ds = new DataService();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            try
            {

                string path = $@"C:\Users\{Environment.UserName}\source\repos\ТИУ с 1 спринта\Tyuiu.BatogovRK.Sprint6\files\InPutFileTask5V24.txt";



                double[] allNumbers = ds.LoadFromDataFile(path);


                dataGridViewAll.Rows.Clear();
                dataGridViewZeros.Rows.Clear();

                if (allNumbers.Length == 0)
                {
                    MessageBox.Show("Файл пустой.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                foreach (double val in allNumbers)
                {
                    dataGridViewAll.Rows.Add(Math.Round(val, 3));
                }

                zeros = allNumbers.Where(val => Math.Abs(val) < 1e-10).ToArray();

                foreach (double val in zeros)
                {
                    dataGridViewZeros.Rows.Add(Math.Round(val, 3));
                }

                if (zeros.Length == 0)
                {
                    MessageBox.Show("В файле нет чисел равных 0.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                pictureBoxChart.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void pictureBoxChart_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);

            int x = 20, y = 20;

            if (zeros.Length == 0)
            {
                g.DrawString("Нет нулевых элементов для отображения",
                            new Font("Arial", 12, FontStyle.Bold),
                            Brushes.Red, x, y);
                return;
            }

            int barHeight = 20;
            int maxWidth = pictureBoxChart.Width - 100;

            g.DrawString($"Количество нулевых элементов: {zeros.Length}",
                        new Font("Arial", 10, FontStyle.Bold),
                        Brushes.Black, x, y);
            y += 30;


            for (int i = 0; i < zeros.Length; i++)
            {
                int barWidth = 50; 
                g.FillRectangle(Brushes.LightBlue, x, y, barWidth, barHeight);
                g.DrawRectangle(Pens.Black, x, y, barWidth, barHeight);
                g.DrawString($"0 (элемент {i + 1})", this.Font, Brushes.Black, x + barWidth + 5, y);
                y += barHeight + 5;
            }
        }




        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск выполнил студент группы АСОиУб-25-1 Батогов Роман", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}