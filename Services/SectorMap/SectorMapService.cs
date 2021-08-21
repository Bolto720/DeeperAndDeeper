using System.Collections.Generic;
using System.Linq;
using DeeperAndDeeper.Data;
using DeeperAndDeeper.Models;
using DeeperAndDeeper.Service.SectorServices;

namespace DeeperAndDeeper.Service.SectorMapServices
{
    public class SectorMapService : ISectorMapService
    {
        private readonly DeeperAndDeeperContext _context;
        private readonly ISectorService _sectorService;

        public SectorMapService(DeeperAndDeeperContext context, ISectorService sectorService)
        {
            _context = context;
            _sectorService = sectorService;
        }

        public Sector GetSector(int x, int y)
        {
            return _context.Sector.FirstOrDefault(l => l.X == x && l.Y == y);
        }

        public ICollection<Sector> GetSectors()
        {
            return _context.Sector.ToList();
        }
    }
}