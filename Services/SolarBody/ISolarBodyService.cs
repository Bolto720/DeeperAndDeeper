using System.Collections.Generic;
using DeeperAndDeeper.Models;

namespace DeeperAndDeeper.Service.SolarBodyServices
{
    public interface ISolarBodyService
    {
        public SolarBody CreateSolarBody();
        public ICollection<SolarBody> CreateSolarBodies();
    }
}