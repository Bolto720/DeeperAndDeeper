using System;
using System.Collections.Generic;

namespace DeeperAndDeeper.Models
{
    public class SolarBody
    {
        public Guid ID { get; set; }
        public SolarBodyType Type { get; set; }
        public string TypeName { get { return Type.ToString(); } }
        public Guid SectorID { get; set; }
        public virtual ICollection<Resource> Resources { get; set; }
    }

    public enum SolarBodyType
    {
        Asteroid,
        Planet,
        Nebula,
    }
}