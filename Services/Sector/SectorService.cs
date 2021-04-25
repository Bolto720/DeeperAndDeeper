using System.Collections.Generic;
using DeeperAndDeeper.Models;
using DeeperAndDeeper.Service.SectorServices.Requests;
using DeeperAndDeeper.Service.SolarBodyServices;

namespace DeeperAndDeeper.Service.SectorServices
{
    public class SectorService : ISectorService
    {
        private readonly ISolarBodyService _solarBodyService;

        public SectorService(ISolarBodyService solarBodyService)
        {
            _solarBodyService = solarBodyService;
        }

        public Sector CreateSector(CreateSectorRequest request)
        {
            Sector sector = new Sector();
            sector.ID = 0;
            sector.Pos = request.Pos;
            sector.SolarBodies = _solarBodyService.CreateSolarBodies();

            return sector;

        }
    }
}