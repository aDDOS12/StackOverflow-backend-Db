namespace EFCourseStackOverflow.Entities
{
    public class Answer
    {
        public int AnswerID { get; set; }
        public string Content { get; set; }
        public int Score { get; set; }
        public string Author { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool IsAccepted { get; set; }
    }
}
