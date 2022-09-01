using P03_FootballBetting.Data.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P03_FootballBetting.Data
{
    //Model layers - Където седят entity класовете
    public class Team
    {
        public Team()
        {
            this.HomeGames = new HashSet<Game>();
            this.AwayGames = new HashSet<Game>();

            this.Players = new HashSet<Player>();
        }
        [Key]
        public int TeamId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(2048)]
        public string LogoUrl { get; set; }

        [Required]
        [MaxLength(4)]
        public string Initials { get; set; }
        //Required само за типовете, които са nullable => int,double,decimal etc required by default .... int? може да приема стойности null
        public decimal Budget { get; set; }
        [ForeignKey(nameof(PrimaryKitColor))]
        public int PrimaryKitColorId { get; set; }
        //Това е навигационното пропърти на PrimaryKitColor
        //Добре е да направим навигационните пропъртите "virtual"
        public virtual Color PrimaryKitColor { get; set; }
        [ForeignKey(nameof(SecondaryKitColor))]

        public int SecondaryKitColorId { get; set; }
        public virtual Color SecondaryKitColor { get; set; }

        [ForeignKey(nameof(Town))] //Името на това навигационно пропърти е town
        public int TownId { get; set; }
        public virtual Town Town { get; set; }

        [InverseProperty("HomeTeam")]
        public ICollection<Game> HomeGames { get; set; }

        [InverseProperty("AwayTeam")] // За да знае с кое пропърти ги навързва 

        public ICollection<Game> AwayGames { get; set; }
        public virtual ICollection<Player> Players { get; set; }
    }
}
