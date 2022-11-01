using System;
using System.IO;
using System.Windows.Forms;
//using Logging;


namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            OpenBtn.Click += OpenBtn_Click;
            SaveBtn.Click += SaveBtn_Click;

            openFileDialog1.Filter = "Text-file(*.txt)|*.txt|SQL-file(*.sql)|*.sql|XML-file(*.xml)|*.xml|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text-file(*.txt)|*.txt|SQL-file(*.sql)|*.sql|XML-file(*.xml)|*.xml|All files(*.*)|*.*";
        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                string filename = openFileDialog1.FileName;
                string fileText = System.IO.File.ReadAllText(filename);
                textBox1.Text = fileText;
                toolStripStatusLabel4.Text = ("Файл: " + openFileDialog1.FileName+ " открыт ");
                Logging.Log.Log_Open(filename);
                //string pathToFile = "/log.txt";
                //File.AppendAllText(pathToFile, Environment.NewLine);
                //File.AppendAllText(pathToFile, "Открыт файл: " + openFileDialog1.FileName + " Дата: " + DateTime.Now.ToString("HH:mm:ss ") + DateTime.Now.ToString("dd MMMM yyyy"));
            }
            catch {
                ///обработка предусмотренна фреймворком
                //MessageBox.Show("Some text", "Some title",
                //MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
                string filename = saveFileDialog1.FileName;
                System.IO.File.WriteAllText(filename, textBox1.Text);
                MessageBox.Show("Файл сохранен");
                toolStripStatusLabel4.Text = ("Файл: "+saveFileDialog1.FileName+" сохранён");
                Logging.Log.Log_Save(filename);
                }
            catch {
                ///обработка предусмотренна фреймворком
                //MessageBox.Show("Some text", "Some title",
                //MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void выходToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void выходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout frmAbout = new frmAbout();
            frmAbout.Show();
        }

        private void нашаКомандаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTeam frmTeam = new frmTeam();
            frmTeam.Show();
        }


    }
}
