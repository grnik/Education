namespace Educations
{
    partial class Main
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.dtgLesson = new System.Windows.Forms.DataGridView();
            this.TaskForLesson = new System.Windows.Forms.Button();
            this.dtgTask = new System.Windows.Forms.DataGridView();
            this.btAddLersson = new System.Windows.Forms.Button();
            this.txtLessonName = new System.Windows.Forms.TextBox();
            this.txtLessonDescription = new System.Windows.Forms.TextBox();
            this.txtLessonApp = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.rchLessonApp = new System.Windows.Forms.RichTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.clName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clApp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAppType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLesson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTask)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Read Lesson";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtgLesson
            // 
            this.dtgLesson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLesson.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clName,
            this.clDescription,
            this.clID,
            this.clApp,
            this.clAppType});
            this.dtgLesson.Location = new System.Drawing.Point(4, 41);
            this.dtgLesson.Name = "dtgLesson";
            this.dtgLesson.ReadOnly = true;
            this.dtgLesson.Size = new System.Drawing.Size(344, 153);
            this.dtgLesson.TabIndex = 1;
            // 
            // TaskForLesson
            // 
            this.TaskForLesson.Location = new System.Drawing.Point(3, 204);
            this.TaskForLesson.Name = "TaskForLesson";
            this.TaskForLesson.Size = new System.Drawing.Size(96, 23);
            this.TaskForLesson.TabIndex = 4;
            this.TaskForLesson.Text = "TaskForLesson";
            this.TaskForLesson.UseVisualStyleBackColor = true;
            this.TaskForLesson.Click += new System.EventHandler(this.TaskForLesson_Click);
            // 
            // dtgTask
            // 
            this.dtgTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTask.Location = new System.Drawing.Point(4, 238);
            this.dtgTask.Name = "dtgTask";
            this.dtgTask.Size = new System.Drawing.Size(723, 150);
            this.dtgTask.TabIndex = 5;
            // 
            // btAddLersson
            // 
            this.btAddLersson.Location = new System.Drawing.Point(111, 11);
            this.btAddLersson.Name = "btAddLersson";
            this.btAddLersson.Size = new System.Drawing.Size(97, 23);
            this.btAddLersson.TabIndex = 6;
            this.btAddLersson.Text = "Add lesson";
            this.btAddLersson.UseVisualStyleBackColor = true;
            this.btAddLersson.Click += new System.EventHandler(this.btAddLersson_Click);
            // 
            // txtLessonName
            // 
            this.txtLessonName.Location = new System.Drawing.Point(223, 11);
            this.txtLessonName.Name = "txtLessonName";
            this.txtLessonName.Size = new System.Drawing.Size(100, 20);
            this.txtLessonName.TabIndex = 7;
            // 
            // txtLessonDescription
            // 
            this.txtLessonDescription.Location = new System.Drawing.Point(329, 11);
            this.txtLessonDescription.Name = "txtLessonDescription";
            this.txtLessonDescription.Size = new System.Drawing.Size(100, 20);
            this.txtLessonDescription.TabIndex = 8;
            // 
            // txtLessonApp
            // 
            this.txtLessonApp.Location = new System.Drawing.Point(441, 11);
            this.txtLessonApp.Name = "txtLessonApp";
            this.txtLessonApp.Size = new System.Drawing.Size(106, 20);
            this.txtLessonApp.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(547, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(21, 20);
            this.button3.TabIndex = 10;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // rchLessonApp
            // 
            this.rchLessonApp.Location = new System.Drawing.Point(355, 41);
            this.rchLessonApp.Name = "rchLessonApp";
            this.rchLessonApp.Size = new System.Drawing.Size(378, 153);
            this.rchLessonApp.TabIndex = 11;
            this.rchLessonApp.Text = "";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(650, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "Show lesson";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // clName
            // 
            this.clName.DataPropertyName = "Name";
            this.clName.HeaderText = "Name";
            this.clName.Name = "clName";
            this.clName.ReadOnly = true;
            // 
            // clDescription
            // 
            this.clDescription.DataPropertyName = "Description";
            this.clDescription.HeaderText = "Description";
            this.clDescription.Name = "clDescription";
            this.clDescription.ReadOnly = true;
            // 
            // clID
            // 
            this.clID.DataPropertyName = "ID";
            this.clID.HeaderText = "ID";
            this.clID.Name = "clID";
            this.clID.ReadOnly = true;
            // 
            // clApp
            // 
            this.clApp.DataPropertyName = "App";
            this.clApp.HeaderText = "App";
            this.clApp.Name = "clApp";
            this.clApp.ReadOnly = true;
            // 
            // clAppType
            // 
            this.clAppType.DataPropertyName = "AppType";
            this.clAppType.HeaderText = "AppType";
            this.clAppType.Name = "clAppType";
            this.clAppType.ReadOnly = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 637);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.rchLessonApp);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtLessonApp);
            this.Controls.Add(this.txtLessonDescription);
            this.Controls.Add(this.txtLessonName);
            this.Controls.Add(this.btAddLersson);
            this.Controls.Add(this.dtgTask);
            this.Controls.Add(this.TaskForLesson);
            this.Controls.Add(this.dtgLesson);
            this.Controls.Add(this.button1);
            this.Name = "Main";
            this.Text = "Образование";
            ((System.ComponentModel.ISupportInitialize)(this.dtgLesson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTask)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button TaskForLesson;
        private System.Windows.Forms.DataGridView dtgTask;
        private System.Windows.Forms.Button btAddLersson;
        private System.Windows.Forms.TextBox txtLessonName;
        private System.Windows.Forms.TextBox txtLessonDescription;
        private System.Windows.Forms.TextBox txtLessonApp;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox rchLessonApp;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dtgLesson;
        private System.Windows.Forms.DataGridViewTextBoxColumn clName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn clID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clApp;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAppType;
    }
}

