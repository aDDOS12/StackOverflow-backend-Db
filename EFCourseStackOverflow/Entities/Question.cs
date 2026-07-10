namespace EFCourseStackOverflow.Entities
{
    public class Question
    {
        public int QuestionID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Score { get; set; }
        public string Author { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
