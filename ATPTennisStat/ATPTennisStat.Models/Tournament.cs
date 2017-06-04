﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ATPTennisStat.Models
{
    public class Tournament
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(40)]
        public string Name { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime StartDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime EndDate { get; set; }

        [Column(TypeName = "money")]
        public decimal PrizeMoney { get; set; }

        public virtual Surface Type { get; set; }

        public virtual TournamentCategory Category { get; set; }

        public virtual City City { get; set; } // One City - many Tournaments
    }
}
