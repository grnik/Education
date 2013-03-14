using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Provider;

namespace Educations
{
    using System.IO;

    using Provider.Education;

    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Provider.Education.Lesson lesson = new Lesson();

            dtgLesson.DataSource = lesson.GetAll();
        }

        private void TaskForLesson_Click(object sender, EventArgs e)
        {
            Provider.Education.Task task = new Task();

            Guid uid = new Guid(dtgLesson.CurrentRow.Cells["clID"].Value.ToString());
            dtgTask.DataSource = task.GetByLesson(uid);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.FileName = txtLessonApp.Text;
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtLessonApp.Text = openFileDialog1.FileName;
                //try
                //{
                //    if ((myStream = openFileDialog1.OpenFile()) != null)
                //    {
                //        using (myStream)
                //        {
                //            // Insert code to read the stream here.
                //        }
                //    }
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                //}
            }
        }

        private void btAddLersson_Click(object sender, EventArgs e)
        {
            Provider.Education.Lesson lesson = new Lesson();

            lesson.AddRow(txtLessonName.Text, txtLessonDescription.Text, txtLessonApp.Text, AppType.AppTypeText);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Provider.Education.Lesson lesson = new Lesson();

            string id = dtgLesson.CurrentRow.Cells["clID"].Value.ToString();
            DataRow row = lesson.GetRow(new Guid(id));

            byte[] text = (byte[])row["App"];

            Encoding encoding = Encoding.Default;
            string strText = encoding.GetString(text);

            rchLessonApp.Text = strText;
        }
    }
}
