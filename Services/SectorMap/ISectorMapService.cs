using System.Collections.Generic;
using DeeperAndDeeper.Models;

namespace DeeperAndDeeper.Service.SectorMapServices
{
    public interface ISectorMapService
    {
        public ICollection<Sector> GetSectors();
        public Sector GetSector(Position position);
    }
}