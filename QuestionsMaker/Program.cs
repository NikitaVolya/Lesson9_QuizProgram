namespace QuestionsMaker
{
    internal static class Program
    {
        public class Question
        {
            private string _text;
            private List<string> _answers;
            private int _correct_answer_index;
            public string Text { get => _text; }
            public string[] Answers { get => _answers.ToArray(); }
            public int CorrectAnswerIndex
            {
                get => _correct_answer_index;
            }
            public void AddAnswer(string text, bool correct_answer = false)
            {
                if (_correct_answer_index != -1 && correct_answer)
                    throw new InvalidOperationException("Correct answer already set");
                if (correct_answer)
                    _correct_answer_index = _answers.Count;
                _answers.Add(text);
            }
            public bool CheckAnswer(string text) => _answers.IndexOf(text) == _correct_answer_index;

            public Question(string text)
            {
                _text = text;
                _answers = new List<string>();
                _correct_answer_index = -1;
            }

            public override string ToString()
            {
                string rep = $"q:{_text}";
                for (int i = 0; i < _answers.Count; i++)
                    rep += $"\n{(i == _correct_answer_index ? '+' : '-')}:{_answers[i]}";
                return rep;
            }
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}