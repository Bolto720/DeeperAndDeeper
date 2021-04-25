using System;
using DeeperAndDeeper.Models;
using DeeperAndDeeper.Service.SectorServices.Requests;

namespace DeeperAndDeeper.Service.SectorServices
{
    public interface ISectorService
    {
        public Sector CreateSector(CreateSectorRequest request);
        
    }
}