using System.Collections.Generic;
using System.Linq;
using DeeperAndDeeper.Models;
using DeeperAndDeeper.Service.SectorServices;

namespace DeeperAndDeeper.Service.SectorMapServices
{
    public class SectorMapService : ISectorMapService
    {
        private readonly SectorMap _sectorMap = new SectorMap();
        private readonly ISectorService _sectorService;

        public SectorMapService(ISectorService sectorService)
        {
            _sectorService = sectorService;

            _sectorMap.Sectors = new List<Sector>();

            for (int x = 0; x < 15; x++)
            {
                for (int y = 0; y < 15; y++)
                {
                    _sectorMap.Sectors.Add(_sectorService.CreateSector(new SectorServices.Requests.CreateSectorRequest()
                    {
                        ID = x + y,
                        Pos = new Position() { X = x, Y = y }
                    }));
                }
            }
        }

        public Sector GetSector(Position position)
        {
            return _sectorMap.Sectors.FirstOrDefault(x => x.Pos == position);
        }

        public ICollection<Sector> GetSectors()
        {
            return _sectorMap.Sectors;
        }
    }
}