namespace WebAPI.Entities
{
    public class Club
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public ClubFamily Family { get; set; }
        public int FamilyId { get; set; }
        public ICollection<Player> Members { get; set; } = [];
        public ICollection<InOutRegister> InOuts { get; set; } = [];
    }
}
