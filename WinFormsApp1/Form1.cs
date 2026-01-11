using ClassLibrary2;
using System.Windows.Forms;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Class2 ds = new Class2();
        int[,] matr;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBoxStartPosKInput.Text) > Convert.ToInt32(textBoxEndPosLInput.Text))
                {
                    MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                matr = new int[Convert.ToInt32(textBoxRowsNInput.Text), Convert.ToInt32(textBoxColumnsMInput.Text)];

                int[,] resmatr = ds.GetMatrix(matr, Convert.ToInt32(textBoxRandNum_n1_Input.Text), Convert.ToInt32(textBoxRandNum_n2_Input.Text));

                int res = ds.result(resmatr, Convert.ToInt32(textBoxRowRInput.Text), Convert.ToInt32(textBoxStartPosKInput.Text), Convert.ToInt32(textBoxEndPosLInput.Text));



                int row = resmatr.GetUpperBound(0) + 1;
                int col = resmatr.Length / row;

                dataGridViewOutPut.RowCount = row;
                dataGridViewOutPut.ColumnCount = col;

                for (int i = 0; i < col; i++)
                {
                    dataGridViewOutPut.Columns[i].Width = 50;
                    dataGridViewOutPut.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                    dataGridViewOutPut.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                for (int i = 0; i < row; i++)
                {
                    // Настраиваем высоту строки
                    if (i < dataGridViewOutPut.Rows.Count)
                    {
                        dataGridViewOutPut.Rows[i].Height = 50;
                    }

                    for (int j = 0; j < col; j++)
                    {
                        dataGridViewOutPut.Rows[i].Cells[j].Value = Convert.ToString(resmatr[i, j]);
                        dataGridViewOutPut.Rows[i].Cells[j].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    }
                }

                textBoxAnswOutPut.Text = Convert.ToString(res);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxBetweenNumXTip_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewOutPut_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ConfigureDataGridView()
        {

            dataGridViewOutPut.AllowUserToResizeRows = false;
            dataGridViewOutPut.AllowUserToResizeColumns = false;
        }

    }
}
