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
            this.clName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clApp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAppType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskForLesson = new System.Windows.Forms.Button();
            this.dtgTask = new System.Windows.Forms.DataGridView();
            this.btAddLersson = new System.Windows.Forms.Button();
            this.txtLessonName = new System.Windows.Forms.TextBox();
            this.txtLessonDescription = new System.Windows.Forms.TextBox();
            this.txtLessonApp = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.rchLessonApp = new System.Windows.Forms.RichTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btAnswere = new System.Windows.Forms.Button();
            this.dtgTaskAnswere = new System.Windows.Forms.DataGridView();
            this.btReadLesson = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLesson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTaskAnswere)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Read LessonData";
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
            this.clAppType.DataPropertyName = "AppTypeData";
            this.clAppType.HeaderText = "AppTypeData";
            this.clAppType.Name = "clAppType";
            this.clAppType.ReadOnly = true;
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
            // btAnswere
            // 
            this.btAnswere.Location = new System.Drawing.Point(4, 403);
            this.btAnswere.Name = "btAnswere";
            this.btAnswere.Size = new System.Drawing.Size(95, 23);
            this.btAnswere.TabIndex = 13;
            this.btAnswere.Text = "Ответ";
            this.btAnswere.UseVisualStyleBackColor = true;
            this.btAnswere.Click += new System.EventHandler(this.btAnswere_Click);
            // 
            // dtgTaskAnswere
            // 
            this.dtgTaskAnswere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTaskAnswere.Location = new System.Drawing.Point(6, 436);
            this.dtgTaskAnswere.Name = "dtgTaskAnswere";
            this.dtgTaskAnswere.Size = new System.Drawing.Size(721, 150);
            this.dtgTaskAnswere.TabIndex = 14;
            // 
            // btReadLesson
            // 
            this.btReadLesson.Location = new System.Drawing.Point(750, 8);
            this.btReadLesson.Name = "btReadLesson";
            this.btReadLesson.Size = new System.Drawing.Size(75, 23);
            this.btReadLesson.TabIndex = 15;
            this.btReadLesson.Text = "Read lesson";
            this.btReadLesson.UseVisualStyleBackColor = true;
            this.btReadLesson.Click += new System.EventHandler(this.btReadLesson_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(753, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Task for lesson";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(753, 403);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 23);
            this.button5.TabIndex = 17;
            this.button5.Text = "Ответ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(753, 48);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 18;
            this.button6.Text = "ShowLesson";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(755, 85);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 19;
            this.button7.Text = "Add";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(759, 121);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 20;
            this.button8.Text = "Edit";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 637);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btReadLesson);
            this.Controls.Add(this.dtgTaskAnswere);
            this.Controls.Add(this.btAnswere);
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
            ((System.ComponentModel.ISupportInitialize)(this.dtgTaskAnswere)).EndInit();
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
        private System.Windows.Forms.Button btAnswere;
        private System.Windows.Forms.DataGridView dtgTaskAnswere;
        private System.Windows.Forms.Button btReadLesson;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}

