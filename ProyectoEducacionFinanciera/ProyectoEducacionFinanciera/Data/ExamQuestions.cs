namespace ProyectoEducacionFinanciera.Data
{
    public class ExamQuestions
    {
        public int QuestionID { get; set; }
        public string QuestionText { get; set; } = string.Empty;
        public int IdLeccion { get; set; }
        public Lecciones Lecciones { get; set; } = new Lecciones();
        public virtual ICollection<ExamOptions> ExamOptions { get; set; } = new List<ExamOptions>();


    }
}
