using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace delete_file_lesson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            StreamWriter outputFile = File.CreateText("courses.txt");

            outputFile.WriteLine("Introduction to Computer Science");
            outputFile.WriteLine("English Composition");
            outputFile.WriteLine("Calculus I");

            outputFile.Close();

            MessageBox.Show("Data saved successfully!");
        }

        private void btnRead_Click_1(object sender, EventArgs e)
        {
            if (File.Exists("courses.txt"))
            {
                listBoxItems.Items.Clear();

                byte[] data = File.ReadAllBytes("courses.txt");

                string content = Encoding.UTF8.GetString(data);

                string[] lines = content.Split(
                    new string[] { "\r\n", "\n" },
                    StringSplitOptions.None
                );

                foreach (string line in lines)
                {
                    if (line != "")
                    {
                        listBoxItems.Items.Add(line);
                    }
                }
            }
            else
            {
                MessageBox.Show("File does not exist!");
            }
        }

        private void btnAppend_Click_1(object sender, EventArgs e)
        {
            StreamWriter outputFile = File.AppendText("courses.txt");

            outputFile.WriteLine("Computer Programming");

            outputFile.Close();

            MessageBox.Show("Data appended successfully!");
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            listBoxItems.Items.Clear();
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (File.Exists("courses.txt"))
            {
                StreamWriter outputFile = File.CreateText("courses.txt");
                outputFile.Close();

                listBoxItems.Items.Clear();

                MessageBox.Show("All items deleted!");
            }
            else
            {
                MessageBox.Show("File does not exist!");
            }
        }

        private void btnDeleteFile_Click_1(object sender, EventArgs e)
        {
            if (File.Exists("courses.txt"))
            {
                File.Delete("courses.txt");

                listBoxItems.Items.Clear();

                MessageBox.Show("File deleted successfully!");
            }
            else
            {
                MessageBox.Show("File does not exist!");
            }
        }
    }
}