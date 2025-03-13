namespace Lesson9
{
    public partial class Form1 : Form
    {
        private List<Program.Question> _questions;
        private int _current_question;
        private int _points;

        public Form1()
        {
            InitializeComponent();
            _current_question = 0;
            _points = 0;
            _questions = new List<Program.Question>();
        }

        private void ErrorMessageOpeningFile()
        {
            MessageBox.Show("Невірний формат файлу!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            _questions.Clear();
        }

        private void SwitchQestions()
        {
            Random rnd = new Random();
            _questions = _questions.OrderBy(x => rnd.Next()).ToList();
        }

        private void load_btn_Click(object sender, EventArgs e)
        {
            _questions.Clear();
            openFileDialog1.Title = "Завантажити питання";
            openFileDialog1.Filter = "Текстовий документ|*.txt|Усі файли|*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string file_path = openFileDialog1.FileName;
                string[] data = File.ReadAllLines(file_path);
                int question_count = -1;
                foreach (string line in data)
                {
                    string text = line.Substring(2);
                    if (line.StartsWith("q:"))
                    {
                        _questions.Add(new Program.Question(text));
                        question_count++;
                    }
                    if (line.StartsWith("-:"))
                    {
                        _questions[question_count].AddAnswer(text);
                    }
                    if (line.StartsWith("+:"))
                    {
                        _questions[question_count].AddAnswer(text, true);
                    }
                }

                if (_questions.Count > 0)
                {
                    _current_question = 0;
                    _points = 0;
                    MessageBox.Show("Питання завантажено!");
                    SwitchQestions();
                    display_question();
                }
                else
                {
                    ErrorMessageOpeningFile();
                }
            }
        }

        private void check_answer_Click(object sender, EventArgs e)
        {

            foreach (RadioButton answer in answer_options_group.Controls)
            {
                if (answer.Checked && _questions[_current_question].CheckAnswer(answer.Text))
                {
                    _points++;
                    question_label.Text = "Відповідь вірна!";
                    question_label.ForeColor = Color.Green;
                    Update();
                    Thread.Sleep(500);
                    question_label.ForeColor = Color.Black;
                    break;
                }
            }

            if (_current_question < _questions.Count)
                _current_question++;
            display_question();
        }

        private void display_question()
        {
            if (_questions.Count == 0)
                return;
            if (_current_question >= _questions.Count)
            {
                string end_game_text = "Ви відповіли на всі питання!\nКількість правильних відповідей: " + _points.ToString() + "/" + _questions.Count;
                question_label.Text = end_game_text;
                MessageBox.Show(end_game_text, "інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            question_label.Text = _questions[_current_question].Text;
            answer_options_group.Controls.Clear();
            int i = 0;
            foreach (string answer_text in _questions[_current_question].Answers)
            {
                RadioButton tmp_answer = new RadioButton();
                tmp_answer.Text = answer_text;
                tmp_answer.Location = new Point(6, 19 + i * 20);
                answer_options_group.Controls.Add(tmp_answer);
                i++;
            }
        }
    }
}
