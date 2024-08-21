using Microsoft.EntityFrameworkCore;
using WebAPI.Enums;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
using WebAPI.Entities;

namespace WebAPI.Entities
{
    public class Player
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public int Trophies { get; set; }
        public virtual Club Club { get; set; }
        public string ClubId { get; set; } = string.Empty;
        public virtual ICollection<TrophyRegister> Registers { get; set; } = [];
        public virtual ICollection<InOutRegister> InOuts { get; set; } = [];

    }
}