namespace QuestionsMaker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            group_answers = new GroupBox();
            answer3_radiobtn = new RadioButton();
            answer3_textbox = new TextBox();
            answer2_radiobtn = new RadioButton();
            answer2_textbox = new TextBox();
            answer1_textbox = new TextBox();
            answer1_radiobtn = new RadioButton();
            question_title_textbox = new TextBox();
            label_question = new Label();
            new_file_btn = new Button();
            save_question_btn = new Button();
            saveFileDialog1 = new SaveFileDialog();
            group_answers.SuspendLayout();
            SuspendLayout();
            // 
            // group_answers
            // 
            group_answers.Controls.Add(answer3_radiobtn);
            group_answers.Controls.Add(answer3_textbox);
            group_answers.Controls.Add(answer2_radiobtn);
            group_answers.Controls.Add(answer2_textbox);
            group_answers.Controls.Add(answer1_textbox);
            group_answers.Controls.Add(answer1_radiobtn);
            group_answers.Location = new Point(13, 102);
            group_answers.Name = "group_answers";
            group_answers.Size = new Size(439, 211);
            group_answers.TabIndex = 0;
            group_answers.TabStop = false;
            group_answers.Text = "відповіді";
            // 
            // answer3_radiobtn
            // 
            answer3_radiobtn.AutoSize = true;
            answer3_radiobtn.Font = new Font("Segoe UI", 15F);
            answer3_radiobtn.Location = new Point(264, 148);
            answer3_radiobtn.Name = "answer3_radiobtn";
            answer3_radiobtn.Size = new Size(159, 39);
            answer3_radiobtn.TabIndex = 6;
            answer3_radiobtn.TabStop = true;
            answer3_radiobtn.Text = "правильне";
            answer3_radiobtn.UseVisualStyleBackColor = true;
            // 
            // answer3_textbox
            // 
            answer3_textbox.Font = new Font("Segoe UI", 15F);
            answer3_textbox.Location = new Point(2, 146);
            answer3_textbox.Name = "answer3_textbox";
            answer3_textbox.PlaceholderText = "текст відповіді";
            answer3_textbox.Size = new Size(256, 41);
            answer3_textbox.TabIndex = 5;
            // 
            // answer2_radiobtn
            // 
            answer2_radiobtn.AutoSize = true;
            answer2_radiobtn.Font = new Font("Segoe UI", 15F);
            answer2_radiobtn.Location = new Point(264, 89);
            answer2_radiobtn.Name = "answer2_radiobtn";
            answer2_radiobtn.Size = new Size(159, 39);
            answer2_radiobtn.TabIndex = 4;
            answer2_radiobtn.TabStop = true;
            answer2_radiobtn.Text = "правильне";
            answer2_radiobtn.UseVisualStyleBackColor = true;
            // 
            // answer2_textbox
            // 
            answer2_textbox.Font = new Font("Segoe UI", 15F);
            answer2_textbox.Location = new Point(2, 87);
            answer2_textbox.Name = "answer2_textbox";
            answer2_textbox.PlaceholderText = "текст відповіді";
            answer2_textbox.Size = new Size(256, 41);
            answer2_textbox.TabIndex = 3;
            // 
            // answer1_textbox
            // 
            answer1_textbox.Font = new Font("Segoe UI", 15F);
            answer1_textbox.Location = new Point(2, 34);
            answer1_textbox.Name = "answer1_textbox";
            answer1_textbox.PlaceholderText = "текст відповіді";
            answer1_textbox.Size = new Size(256, 41);
            answer1_textbox.TabIndex = 1;
            // 
            // answer1_radiobtn
            // 
            answer1_radiobtn.AutoSize = true;
            answer1_radiobtn.Font = new Font("Segoe UI", 15F);
            answer1_radiobtn.Location = new Point(264, 36);
            answer1_radiobtn.Name = "answer1_radiobtn";
            answer1_radiobtn.Size = new Size(159, 39);
            answer1_radiobtn.TabIndex = 0;
            answer1_radiobtn.TabStop = true;
            answer1_radiobtn.Text = "правильне";
            answer1_radiobtn.UseVisualStyleBackColor = true;
            // 
            // question_title_textbox
            // 
            question_title_textbox.Font = new Font("Segoe UI", 15F);
            question_title_textbox.Location = new Point(13, 55);
            question_title_textbox.Name = "question_title_textbox";
            question_title_textbox.PlaceholderText = "Текст питання";
            question_title_textbox.Size = new Size(439, 41);
            question_title_textbox.TabIndex = 1;
            // 
            // label_question
            // 
            label_question.AutoSize = true;
            label_question.Font = new Font("Segoe UI", 13F);
            label_question.Location = new Point(13, 9);
            label_question.Name = "label_question";
            label_question.Size = new Size(99, 30);
            label_question.TabIndex = 2;
            label_question.Text = "Питання";
            // 
            // new_file_btn
            // 
            new_file_btn.Location = new Point(12, 319);
            new_file_btn.Name = "new_file_btn";
            new_file_btn.Size = new Size(208, 40);
            new_file_btn.TabIndex = 3;
            new_file_btn.Text = "нова вікторина";
            new_file_btn.UseVisualStyleBackColor = true;
            new_file_btn.Click += new_file_btn_Click;
            // 
            // save_question_btn
            // 
            save_question_btn.Location = new Point(247, 319);
            save_question_btn.Name = "save_question_btn";
            save_question_btn.Size = new Size(205, 40);
            save_question_btn.TabIndex = 4;
            save_question_btn.Text = "зберегти питання";
            save_question_btn.UseVisualStyleBackColor = true;
            save_question_btn.Click += save_question_btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 375);
            Controls.Add(save_question_btn);
            Controls.Add(new_file_btn);
            Controls.Add(label_question);
            Controls.Add(question_title_textbox);
            Controls.Add(group_answers);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            group_answers.ResumeLayout(false);
            group_answers.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox group_answers;
        private TextBox answer1_textbox;
        private RadioButton answer1_radiobtn;
        private TextBox question_title_textbox;
        private Label label_question;
        private RadioButton answer3_radiobtn;
        private TextBox answer3_textbox;
        private RadioButton answer2_radiobtn;
        private TextBox answer2_textbox;
        private Button new_file_btn;
        private Button save_question_btn;
        private SaveFileDialog saveFileDialog1;
    }
}
