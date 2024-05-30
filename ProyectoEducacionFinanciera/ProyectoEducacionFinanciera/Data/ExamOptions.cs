namespace ProyectoEducacionFinanciera.Data
{
    public class ExamOptions
    {
        public int OptionID { get; set; }
        public int QuestionID { get; set; }
        public string OptionText { get; set; } = string.Empty;
        public bool IsAnswer { get; set; }
        public ExamQuestions ExamQuestions { get; set; } = new ExamQuestions();
    }
}
