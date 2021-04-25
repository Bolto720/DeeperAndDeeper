using System;
using System.Collections.Generic;
using DeeperAndDeeper.Models;
using DeeperAndDeeper.Service.ResourceServices;
using DeeperAndDeeper.Service.SolarBodyServices;

namespace DeeperAndDeeper.Service.SolarBodyServices
{
    public class SolarBodyService : ISolarBodyService
    {
        IResourceService _resourceService;
        public SolarBodyService(IResourceService resourceService)
        {
            _resourceService = resourceService;
        }

        public ICollection<SolarBody> CreateSolarBodies()
        {
            List<SolarBody> solarBodies = new List<SolarBody>();
            var rand = new Random();

            for (int i = 0; i < rand.Next(2, 9); i++)
            {
                solarBodies.Add(CreateSolarBody());
            }

            return solarBodies;
        }

        public SolarBody CreateSolarBody()
        {
            var rand = new Random();

            Array sbTypes = Enum.GetValues(typeof(SolarBodyType));

            SolarBody solarBody = new SolarBody();
            solarBody.ID = rand.Next(1000);
            solarBody.Type = (SolarBodyType)sbTypes.GetValue(rand.Next(sbTypes.Length));
            solarBody.Resources = new List<Resource>();

            for (int i = 0; i < rand.Next(1, 7); i++)
            {
                solarBody.Resources.Add(_resourceService.CreateResource());
            }

            return solarBody;
        }
    }
}