using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeeperAndDeeper.Models
{
    public class Sector
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid ID { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public virtual ICollection<SolarBody> SolarBodies { get; set; }
    }
}