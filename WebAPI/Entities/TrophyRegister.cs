namespace WebAPI.Entities
{
    public class TrophyRegister
    {
        public int Id { get; set; }
        public int Trophies { get; set; }
        public DateTime DateTime { get; set; }
        public virtual Player Member { get; set; }
        public string MemberId { get; set; } = string.Empty;
    }
}
