namespace API.Entities
{
    public class UserLike
    {
        public int SourceUserId { get; set; }
        public int LikedUserId { get; set; }

        //Navigation Properties
        public AppUser LikedUser { get; set; }
        public AppUser SourceUser { get; set; }
    }
}