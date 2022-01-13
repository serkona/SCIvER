namespace System
{
    partial class Insert_Tasks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioButton_SText = new System.Windows.Forms.RadioButton();
            this.radioButton_SImage = new System.Windows.Forms.RadioButton();
            this.label_ChooseType = new System.Windows.Forms.Label();
            this.richTextBox_TextS = new System.Windows.Forms.RichTextBox();
            this.button_Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_TaskTypes = new System.Windows.Forms.ComboBox();
            this.textBox_Answer = new System.Windows.Forms.TextBox();
            this.pictureBox_Task = new System.Windows.Forms.PictureBox();
            this.button_ChooseIMG = new System.Windows.Forms.Button();
            this.pictureBox_Confirm = new System.Windows.Forms.PictureBox();
            this.Back_button = new System.Windows.Forms.Button();
            this.label_forAnswer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Task)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Confirm)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton_SText
            // 
            this.radioButton_SText.AutoSize = true;
            this.radioButton_SText.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_SText.Checked = true;
            this.radioButton_SText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_SText.Location = new System.Drawing.Point(17, 217);
            this.radioButton_SText.Name = "radioButton_SText";
            this.radioButton_SText.Size = new System.Drawing.Size(97, 33);
            this.radioButton_SText.TabIndex = 0;
            this.radioButton_SText.TabStop = true;
            this.radioButton_SText.Text = "Текст";
            this.radioButton_SText.UseVisualStyleBackColor = false;
            this.radioButton_SText.CheckedChanged += new System.EventHandler(this.radioButton_SText_CheckedChanged);
            this.radioButton_SText.Click += new System.EventHandler(this.radioButton_SText_Click);
            // 
            // radioButton_SImage
            // 
            this.radioButton_SImage.AutoSize = true;
            this.radioButton_SImage.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_SImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_SImage.Location = new System.Drawing.Point(120, 217);
            this.radioButton_SImage.Name = "radioButton_SImage";
            this.radioButton_SImage.Size = new System.Drawing.Size(274, 33);
            this.radioButton_SImage.TabIndex = 1;
            this.radioButton_SImage.Text = "Изображение ( .png )";
            this.radioButton_SImage.UseVisualStyleBackColor = false;
            this.radioButton_SImage.CheckedChanged += new System.EventHandler(this.radioButton_SImage_CheckedChanged);
            this.radioButton_SImage.Click += new System.EventHandler(this.radioButton_SImage_Click);
            // 
            // label_ChooseType
            // 
            this.label_ChooseType.AutoSize = true;
            this.label_ChooseType.BackColor = System.Drawing.Color.Transparent;
            this.label_ChooseType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ChooseType.Location = new System.Drawing.Point(12, 176);
            this.label_ChooseType.Name = "label_ChooseType";
            this.label_ChooseType.Size = new System.Drawing.Size(415, 25);
            this.label_ChooseType.TabIndex = 2;
            this.label_ChooseType.Text = "Выберите формат загружаемой задачи:";
            // 
            // richTextBox_TextS
            // 
            this.richTextBox_TextS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox_TextS.Location = new System.Drawing.Point(17, 264);
            this.richTextBox_TextS.Name = "richTextBox_TextS";
            this.richTextBox_TextS.Size = new System.Drawing.Size(673, 369);
            this.richTextBox_TextS.TabIndex = 3;
            this.richTextBox_TextS.Text = "";
            this.richTextBox_TextS.TextChanged += new System.EventHandler(this.richTextBox_TextS_TextChanged);
            // 
            // button_Save
            // 
            this.button_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Save.Location = new System.Drawing.Point(770, 210);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(186, 77);
            this.button_Save.TabIndex = 4;
            this.button_Save.Text = "Сохранить";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Выберите номер задачи:";
            // 
            // comboBox_TaskTypes
            // 
            this.comboBox_TaskTypes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_TaskTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TaskTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_TaskTypes.FormattingEnabled = true;
            this.comboBox_TaskTypes.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.comboBox_TaskTypes.Location = new System.Drawing.Point(280, 119);
            this.comboBox_TaskTypes.Name = "comboBox_TaskTypes";
            this.comboBox_TaskTypes.Size = new System.Drawing.Size(253, 28);
            this.comboBox_TaskTypes.TabIndex = 6;
            this.comboBox_TaskTypes.SelectedIndexChanged += new System.EventHandler(this.comboBox_TaskTypes_SelectedIndexChanged);
            // 
            // textBox_Answer
            // 
            this.textBox_Answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Answer.Location = new System.Drawing.Point(746, 115);
            this.textBox_Answer.Name = "textBox_Answer";
            this.textBox_Answer.Size = new System.Drawing.Size(226, 31);
            this.textBox_Answer.TabIndex = 7;
            this.textBox_Answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_Answer.TextChanged += new System.EventHandler(this.textBox_Answer_TextChanged);
            // 
            // pictureBox_Task
            // 
            this.pictureBox_Task.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Task.Location = new System.Drawing.Point(17, 264);
            this.pictureBox_Task.Name = "pictureBox_Task";
            this.pictureBox_Task.Size = new System.Drawing.Size(673, 369);
            this.pictureBox_Task.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_Task.TabIndex = 8;
            this.pictureBox_Task.TabStop = false;
            this.pictureBox_Task.Visible = false;
            // 
            // button_ChooseIMG
            // 
            this.button_ChooseIMG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ChooseIMG.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_ChooseIMG.Location = new System.Drawing.Point(400, 210);
            this.button_ChooseIMG.Name = "button_ChooseIMG";
            this.button_ChooseIMG.Size = new System.Drawing.Size(204, 48);
            this.button_ChooseIMG.TabIndex = 9;
            this.button_ChooseIMG.Text = "Выбрать файл";
            this.button_ChooseIMG.UseVisualStyleBackColor = true;
            this.button_ChooseIMG.Visible = false;
            this.button_ChooseIMG.Click += new System.EventHandler(this.button_ChooseIMG_Click);
            // 
            // pictureBox_Confirm
            // 
            this.pictureBox_Confirm.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Confirm.Location = new System.Drawing.Point(573, 75);
            this.pictureBox_Confirm.Name = "pictureBox_Confirm";
            this.pictureBox_Confirm.Size = new System.Drawing.Size(133, 116);
            this.pictureBox_Confirm.TabIndex = 52;
            this.pictureBox_Confirm.TabStop = false;
            // 
            // Back_button
            // 
            this.Back_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back_button.Location = new System.Drawing.Point(2, 26);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(158, 36);
            this.Back_button.TabIndex = 53;
            this.Back_button.Text = "Назад";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // label_forAnswer
            // 
            this.label_forAnswer.AutoSize = true;
            this.label_forAnswer.BackColor = System.Drawing.Color.Transparent;
            this.label_forAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_forAnswer.Location = new System.Drawing.Point(822, 80);
            this.label_forAnswer.Name = "label_forAnswer";
            this.label_forAnswer.Size = new System.Drawing.Size(71, 25);
            this.label_forAnswer.TabIndex = 54;
            this.label_forAnswer.Text = "Ответ";
            // 
            // Insert_Tasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1017, 726);
            this.Controls.Add(this.label_forAnswer);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.pictureBox_Confirm);
            this.Controls.Add(this.button_ChooseIMG);
            this.Controls.Add(this.pictureBox_Task);
            this.Controls.Add(this.textBox_Answer);
            this.Controls.Add(this.comboBox_TaskTypes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.richTextBox_TextS);
            this.Controls.Add(this.label_ChooseType);
            this.Controls.Add(this.radioButton_SImage);
            this.Controls.Add(this.radioButton_SText);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Insert_Tasks";
            this.Text = "                                                                                 " +
    "                        Insert_Tasks";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Insert_Tasks_FormClosed);
            this.Load += new System.EventHandler(this.Insert_Tasks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Task)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Confirm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Windows.Forms.RadioButton radioButton_SText;
        private Windows.Forms.RadioButton radioButton_SImage;
        private Windows.Forms.Label label_ChooseType;
        private Windows.Forms.RichTextBox richTextBox_TextS;
        private Windows.Forms.Button button_Save;
        private Windows.Forms.Label label1;
        private Windows.Forms.ComboBox comboBox_TaskTypes;
        private Windows.Forms.TextBox textBox_Answer;
        private Windows.Forms.PictureBox pictureBox_Task;
        private Windows.Forms.Button button_ChooseIMG;
        private Windows.Forms.PictureBox pictureBox_Confirm;
        private Windows.Forms.Button Back_button;
        private Windows.Forms.Label label_forAnswer;
    }
}