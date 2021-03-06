﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataAccess;
using System.IO;
using Providers;

namespace Educations
{
    public partial class Main : Form
    {
        private AppTypeHelper appTypeHelper = new AppTypeHelper();
        CourseHelper courseHelper = new CourseHelper();
        LessonHelper lessonHelper = new LessonHelper();
        TaskAnswereHelper taskAnswereHelper = new TaskAnswereHelper();
        TaskHelper taskHelper = new TaskHelper();

        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataAccess.LessonData lessonData = new LessonData();

            dtgLesson.DataSource = lessonData.GetAll();
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
            DataAccess.LessonData lessonData = new LessonData();

            lessonData.AddRow(txtLessonName.Text, txtLessonDescription.Text, DBData.FileToByte(txtLessonApp.Text), AppTypeData.AppTypeDataText.ID, new Guid("a0a43c41-3314-402a-af82-2f4a021128a8"), 10);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataAccess.LessonData lessonData = new LessonData();

            string id = dtgLesson.CurrentRow.Cells["clID"].Value.ToString();
            DataRow row = lessonData.GetByID(new Guid(id));

            byte[] text = (byte[])row["App"];
            rchLessonApp.Text = DBData.ByteToString(text);
        }

        private void TaskForLesson_Click(object sender, EventArgs e)
        {
            DataAccess.TaskData taskData = new TaskData();

            Guid uid = new Guid(dtgLesson.CurrentRow.Cells["clID"].Value.ToString());
            dtgTask.DataSource = taskData.GetByLesson(uid);
        }

        private void btAnswere_Click(object sender, EventArgs e)
        {
            DataAccess.TaskAnswereData taskAnswereData = new TaskAnswereData();

            Guid uid = new Guid(dtgTask.CurrentRow.Cells[0].Value.ToString());
            dtgTaskAnswere.DataSource = taskAnswereData.GetByTask(uid);
        }

        private void btReadLesson_Click(object sender, EventArgs e)
        {
            List<Lesson> lessons = lessonHelper.GetAll();

            dtgLesson.DataSource = lessons;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Guid uid = new Guid(dtgLesson.CurrentRow.Cells["clID"].Value.ToString());
            Lesson lesson = lessonHelper.GetById(uid);
            dtgTask.DataSource = taskHelper.GetByLesson(lesson);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Guid uid = new Guid(dtgTask.CurrentRow.Cells[0].Value.ToString());
            dtgTaskAnswere.DataSource = taskAnswereHelper.GetByTask(taskHelper.GetById(uid));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Guid uid = new Guid(dtgLesson.CurrentRow.Cells["clID"].Value.ToString());
            Lesson lesson = lessonHelper.GetById(uid);
            if (lesson.App != null)
            {
                rchLessonApp.Text = DBData.ByteToString(lesson.App);
            }
            else
            {
                rchLessonApp.Clear();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Lesson lesson = new Lesson();

            lesson.ID = Guid.Empty;
            lesson.Name = txtLessonName.Text;
            lesson.Description = txtLessonDescription.Text;
            lesson.App = DBData.FileToByte(txtLessonApp.Text);
            lesson.AppType = appTypeHelper.GetById(AppTypeData.AppTypeDataText.ID);
            lesson.Order = 10;
            lesson.Course = new Course() { ID = new Guid("a0a43c41-3314-402a-af82-2f4a021128a8"), Name = "Первый курс" };

            lessonHelper.Save(lesson);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Lesson lesson = lessonHelper.GetById(new Guid(dtgLesson.CurrentRow.Cells["clID"].Value.ToString()));

            lesson.Name = txtLessonName.Text;
            lesson.Description = txtLessonDescription.Text;
            lesson.App = DBData.FileToByte(txtLessonApp.Text);
            lesson.AppType = appTypeHelper.GetById(AppTypeData.AppTypeDataText.ID);
            lesson.Order = 10;
            lesson.Course = new Course() { ID = new Guid("a0a43c41-3314-402a-af82-2f4a021128a8"), Name = "Первый курс" };

            lessonHelper.Save(lesson);
        }
    }
}
