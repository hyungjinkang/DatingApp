namespace API.Entities
{
    public class UserLike
    {
        public AppUser SourceUser { get; set; } 
        public int SourceUserId { get; set; }

        public AppUser LikedUser { get; set; } // the other member that the user likes
        public int LikedUserId { get; set; }
    }
}