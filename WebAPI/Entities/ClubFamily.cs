namespace WebAPI.Entities
{
    public class ClubFamily
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public virtual ICollection<Club> Clubs { get; set; } = [];
    }
}
