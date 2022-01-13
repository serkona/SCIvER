namespace System
{
    partial class Programm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Questions_Button = new System.Windows.Forms.Button();
            this.Test_Button = new System.Windows.Forms.Button();
            this.InsertTasks_Button = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.label_EGE1 = new System.Windows.Forms.Label();
            this.label_EGE2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Questions_Button
            // 
            this.Questions_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Questions_Button.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Questions_Button.Location = new System.Drawing.Point(160, 136);
            this.Questions_Button.Name = "Questions_Button";
            this.Questions_Button.Size = new System.Drawing.Size(250, 100);
            this.Questions_Button.TabIndex = 0;
            this.Questions_Button.Text = "Задачи";
            this.Questions_Button.UseVisualStyleBackColor = true;
            this.Questions_Button.Click += new System.EventHandler(this.Questions_Button_Click);
            // 
            // Test_Button
            // 
            this.Test_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Test_Button.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Test_Button.Location = new System.Drawing.Point(490, 136);
            this.Test_Button.Name = "Test_Button";
            this.Test_Button.Size = new System.Drawing.Size(250, 100);
            this.Test_Button.TabIndex = 1;
            this.Test_Button.Text = "Тест";
            this.Test_Button.UseVisualStyleBackColor = true;
            this.Test_Button.Click += new System.EventHandler(this.Test_Button_Click_1);
            // 
            // InsertTasks_Button
            // 
            this.InsertTasks_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InsertTasks_Button.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertTasks_Button.Location = new System.Drawing.Point(325, 280);
            this.InsertTasks_Button.Name = "InsertTasks_Button";
            this.InsertTasks_Button.Size = new System.Drawing.Size(250, 100);
            this.InsertTasks_Button.TabIndex = 3;
            this.InsertTasks_Button.Text = "Добавление задач ";
            this.InsertTasks_Button.UseVisualStyleBackColor = true;
            this.InsertTasks_Button.Click += new System.EventHandler(this.InsertTasks_Button_Click);
            // 
            // button_Close
            // 
            this.button_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Close.Location = new System.Drawing.Point(12, 427);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(168, 61);
            this.button_Close.TabIndex = 4;
            this.button_Close.Text = "Выход";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // label_EGE1
            // 
            this.label_EGE1.AutoSize = true;
            this.label_EGE1.BackColor = System.Drawing.Color.Transparent;
            this.label_EGE1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_EGE1.Location = new System.Drawing.Point(421, 440);
            this.label_EGE1.Name = "label_EGE1";
            this.label_EGE1.Size = new System.Drawing.Size(478, 26);
            this.label_EGE1.TabIndex = 6;
            this.label_EGE1.Text = "Все задачи, используемые в системе, взяты с сайта  ";
            // 
            // label_EGE2
            // 
            this.label_EGE2.AutoSize = true;
            this.label_EGE2.BackColor = System.Drawing.Color.Transparent;
            this.label_EGE2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_EGE2.Location = new System.Drawing.Point(300, 466);
            this.label_EGE2.Name = "label_EGE2";
            this.label_EGE2.Size = new System.Drawing.Size(599, 26);
            this.label_EGE2.TabIndex = 7;
            this.label_EGE2.Text = "https://ege.sdamgia.ru  в целях демонстрации работы программы ";
            // 
            // Programm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.label_EGE2);
            this.Controls.Add(this.label_EGE1);
            this.Controls.Add(this.InsertTasks_Button);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.Questions_Button);
            this.Controls.Add(this.Test_Button);
            this.Name = "Programm";
            this.Text = "                                                                                 " +
    "                   SCIʌER";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Programm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Windows.Forms.Button Questions_Button;
        private Windows.Forms.Button Test_Button;
        private Windows.Forms.Button InsertTasks_Button;
        private Windows.Forms.Button button_Close;
        private Windows.Forms.Label label_EGE1;
        private Windows.Forms.Label label_EGE2;
    }
}

