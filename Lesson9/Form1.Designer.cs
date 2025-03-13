namespace Lesson9
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
            openFileDialog1 = new OpenFileDialog();
            load_btn = new Button();
            answer_options_group = new GroupBox();
            check_answer = new Button();
            question_label = new Label();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // load_btn
            // 
            load_btn.Location = new Point(12, 409);
            load_btn.Name = "load_btn";
            load_btn.Size = new Size(461, 29);
            load_btn.TabIndex = 0;
            load_btn.Text = "Завантажити вікторину";
            load_btn.UseVisualStyleBackColor = true;
            load_btn.Click += load_btn_Click;
            // 
            // answer_options_group
            // 
            answer_options_group.Location = new Point(12, 90);
            answer_options_group.Name = "answer_options_group";
            answer_options_group.Size = new Size(461, 232);
            answer_options_group.TabIndex = 1;
            answer_options_group.TabStop = false;
            answer_options_group.Text = "Відповіді";
            // 
            // check_answer
            // 
            check_answer.Location = new Point(12, 343);
            check_answer.Name = "check_answer";
            check_answer.Size = new Size(461, 29);
            check_answer.TabIndex = 2;
            check_answer.Text = "Відповісти";
            check_answer.UseVisualStyleBackColor = true;
            check_answer.Click += check_answer_Click;
            // 
            // question_label
            // 
            question_label.AutoSize = true;
            question_label.Font = new Font("Segoe UI", 12F);
            question_label.Location = new Point(12, 18);
            question_label.Name = "question_label";
            question_label.Size = new Size(423, 28);
            question_label.TabIndex = 3;
            question_label.Text = "Натисніть кнопку, щоб завантажити питання";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 450);
            Controls.Add(question_label);
            Controls.Add(check_answer);
            Controls.Add(answer_options_group);
            Controls.Add(load_btn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private Button load_btn;
        private GroupBox answer_options_group;
        private Button check_answer;
        private Label question_label;
    }
}
