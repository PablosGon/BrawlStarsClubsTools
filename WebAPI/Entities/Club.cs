namespace WebAPI.Entities
{
    public class Club
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public virtual ClubFamily Family { get; set; }
        public int FamilyId { get; set; }
        public virtual ICollection<Player> Members { get; set; } = [];
        public virtual ICollection<InOutRegister> InOuts { get; set; } = [];
    }
}
