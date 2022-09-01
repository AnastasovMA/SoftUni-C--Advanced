using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace P03_FootballBetting.Data.Models
{
    public class Color
    {
        //Винаги когато имаме колекции правим hashset
        public Color()
        {
            //HashSet-a усигурява бързодействие на сета
            this.PrimaryKitTeams = new HashSet<Team>();
            this.SecondaryKitTeams = new HashSet<Team>();
        }
        [Key]
        public int ColorId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        //Щом има "МНОГО" означава ICollection<Entity> => Many
        //One to many връзка 
        [InverseProperty("PrimaryKitColor")] // По този начин свързваме двамата primary key-a 
        public virtual ICollection<Team> PrimaryKitTeams { get; set; }
        [InverseProperty("SecondaryKitColor")]

        public virtual ICollection<Team> SecondaryKitTeams { get; set; }
    }
}
