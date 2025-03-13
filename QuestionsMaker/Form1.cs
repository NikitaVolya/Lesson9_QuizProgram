namespace QuestionsMaker
{
    public partial class Form1 : Form
    {
        private string _file_patch;
        private List<Program.Question> _questions;

        public Form1()
        {
            InitializeComponent();

            _file_patch = null;
            _questions = new List<Program.Question>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void new_file_btn_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _file_patch = saveFileDialog1.FileName;
                _questions.Clear();
            }
        }

        private void save_file(object sender, EventArgs e)
        {
            string data = "";
            foreach (Program.Question question in _questions)
                data += question.ToString() + "\n";
            File.WriteAllText(_file_patch, data);
        }

        private bool check_textboxes()
        {
            if (question_title_textbox.Text.Length == 0)
                return false;
            if (answer1_textbox.Text.Length == 0)
                return false;
            if (answer2_textbox.Text.Length == 0)
                return false;
            if (answer3_textbox.Text.Length == 0)
                return false;
            return true;
        }

        private void save_question_btn_Click(object sender, EventArgs e)
        {
            if (_file_patch == null){
                MessageBox.Show("спочатку треба створити нову вікторину", "помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!check_textboxes()){
                MessageBox.Show("усі поля повинні бути заповнені", "помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Program.Question new_question = new Program.Question(question_title_textbox.Text);

            new_question.AddAnswer(answer1_textbox.Text, answer1_radiobtn.Checked);
            new_question.AddAnswer(answer2_textbox.Text, answer2_radiobtn.Checked);
            new_question.AddAnswer(answer3_textbox.Text, answer3_radiobtn.Checked);
            _questions.Add(new_question);

            question_title_textbox.Text = "";
            answer1_textbox.Text = "";
            answer2_textbox.Text = "";
            answer3_textbox.Text = "";

            save_file(sender, e);
        }
    }
}
