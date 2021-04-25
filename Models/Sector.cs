using System.Collections.Generic;

namespace DeeperAndDeeper.Models
{
    public class Sector 
    {
        public long ID { get; set; }
        public Position Pos { get; set; }
        public ICollection<SolarBody> SolarBodies { get; set; }
    }
}