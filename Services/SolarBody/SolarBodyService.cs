using System;
using System.Collections.Generic;
using DeeperAndDeeper.Models;
using DeeperAndDeeper.Service.SolarBodyServices;

namespace DeeperAndDeeper.Service.SolarBodyServices
{
    public class SolarBodyService : ISolarBodyService
    {        
        public ICollection<SolarBody> CreateSolarBodies()
        {
            List<SolarBody> solarBodies = new List<SolarBody>();
            var rand = new Random();

            for (int i = 0; i < rand.Next(2,9); i++)
            {
                solarBodies.Add(CreateSolarBody());
            }

            return solarBodies;
        }

        public SolarBody CreateSolarBody()
        {
            SolarBody solarBody = new SolarBody();
            solarBody.ID = 0;
            solarBody.Type = SolarBodyType.Asteroid;

            return solarBody;
        }
    }
}