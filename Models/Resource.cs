using System;

namespace DeeperAndDeeper.Models
{
    public class Resource
    {
        public Guid ResourceID { get; set; }
        public ResourceType Type { get; set; }
        public string ResourceType { get { return Type.ToString(); } }
        public int Amount { get; set; }
        public Guid SolarBodyID { get; set; }
    }

    public enum ResourceType
    {
        Water,
        Gold,
        Silver,
        Titanium,
        Platinum,
        Iron,
        Cobalt,
        Urainium,
        Tungsten,
        Hydrogen
    }
}