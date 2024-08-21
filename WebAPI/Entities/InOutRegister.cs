namespace WebAPI.Entities
{
    public class InOutRegister
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public bool IsEntry { get; set; }
        public virtual Club Club { get; set; }
        public string ClubId { get; set; } = string.Empty;
        public virtual Player Member { get; set; }
        public string MemberId { get; set; } = string.Empty;
    }
}
