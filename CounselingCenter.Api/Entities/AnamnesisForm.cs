namespace CounselingCenter.Api.Entities
{
    public class AnamnesisForm
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Opinion { get; set; }
        public AppUser User { get; set; }
    }
}