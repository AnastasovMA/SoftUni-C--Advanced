using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace P03_FootballBetting.Data.Models
{
    public class PlayerStatistic
    {
        //todo: Create composite primary key using Fluent API
        [ForeignKey(nameof(Game))]
        public int GameId { get; set; }
        //2:30:45 - Един играч играе в много игри
        public virtual Game Game { get; set; }
        [ForeignKey(nameof(Player))]
        public int PlayerId { get; set; }
        public virtual Player Player { get; set; }
        //По-малко от 256, затова използваме byte
        public byte ScoredGoals { get; set; }
        public byte Assists { get; set; }
        public byte MinutesPlayed { get; set; }
    }
}
