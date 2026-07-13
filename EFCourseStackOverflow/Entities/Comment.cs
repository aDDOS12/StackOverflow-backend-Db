using EFCourseStackOverflow.Interfaces;

namespace EFCourseStackOverflow.Entities
{
    public class Comment : IVoteable
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int Score { get; set; }
        public User User { get; set; }
        public Guid UserId { get; set; }
        public Question Question { get; set; }
        public int QuestionId { get; set; }
        public Answer Answer { get; set; }
        public int AnswerId { get; set; }
        public List<CommentVote> CommentVotes { get; set; } = new List<CommentVote>();
    }
}
