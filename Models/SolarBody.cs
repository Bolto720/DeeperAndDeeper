namespace DeeperAndDeeper.Models
{
    public class SolarBody
    {
        public long ID { get; set; }
        public SolarBodyType Type { get; set; }
        public string TypeName { get; set; }
    }

    public enum SolarBodyType
    {
        Asteroid,
        Planet,
        Nebula,
    }
}