using System.Windows.Forms;
using Tyuiu.BatogovRK.Sprint6.Task6.V8.Lib;

namespace Tyuiu.BatogovRK.Sprint6.Task6.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        Class1 ds = new Class1();
        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void textBoxRes_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonINF_Click(object sender, EventArgs e)
        {
            FormAbout form = new FormAbout();
            form.ShowDialog();
        }

        private void buttonRes_Click(object sender, EventArgs e)
        {
            string str = "";
            textBoxRes.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFilePath = openFileDialog1.FileName;
            textBoxVV.Text = File.ReadAllText(openFilePath);

            buttonRes.Enabled = true;
        }

        private void textBoxVV_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
