namespace WebAPI.Entities
{
    public class TrophyRegister
    {
        public int Id { get; set; }
        public int Trohpies { get; set; }
        public DateTime DateTime { get; set; }
        public Player Member { get; set; } = new();
        public string MemberId { get; set; } = string.Empty;
    }
}
