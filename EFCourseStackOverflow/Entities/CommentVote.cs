namespace EFCourseStackOverflow.Entities
{
    public class CommentVote : Vote
    {
        //foreign key
        public int CommentId { get; set; }
        //navigation property
        public Comment Comment { get; set; }
        public Guid UserId { get; set; }
    }
}
