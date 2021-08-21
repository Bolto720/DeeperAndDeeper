using System;
using System.Collections.Generic;
using DeeperAndDeeper.Models;

namespace DeeperAndDeeper.Data.DataSeed
{
    public class DatabaseSeed
    {
        private readonly DeeperAndDeeperContext _context;

        public DatabaseSeed(DeeperAndDeeperContext context)
        {
            _context = context;
        }

        public void SeedDatabase()
        {
            var sectors = AddSectors();
            var solarBodies = AddSolarBodies(sectors);
            AddResources(solarBodies);
        }

        List<Sector> AddSectors()
        {
            List<Sector> sectors = new List<Sector>();

            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    Sector sector = new Sector();
                    // sector.ID = Guid.NewGuid();
                    sector.X = x;
                    sector.Y = y;

                    sectors.Add(sector);
                }
            }

            _context.Sector.AddRange(sectors);
            _context.SaveChanges();

            return sectors;
        }

        List<SolarBody> AddSolarBodies(List<Sector> sectors)
        {
            var rand = new Random();

            Array sbTypes = Enum.GetValues(typeof(SolarBodyType));

            List<SolarBody> solarBodies = new List<SolarBody>();

            foreach (var sector in sectors)
            {
                sector.SolarBodies = new List<SolarBody>();
                int count = rand.Next(2, 9);

                for (int i = 0; i < count; i++)
                {
                    SolarBody solarBody = new SolarBody();
                    solarBody.ID = Guid.NewGuid();
                    solarBody.Type = (SolarBodyType)sbTypes.GetValue(rand.Next(sbTypes.Length));
                    solarBody.SectorID = sector.ID;

                    solarBodies.Add(solarBody);
                    sector.SolarBodies.Add(solarBody);
                }
            }

            _context.SolarBody.AddRange(solarBodies);
            _context.SaveChanges();

            return solarBodies;
        }

        void AddResources(List<SolarBody> solarBodies)
        {
            Random rand = new Random();

            Array resourceTypes = Enum.GetValues(typeof(ResourceType));

            List<Resource> resources = new List<Resource>();

            foreach (var solarBody in solarBodies)
            {
                solarBody.Resources = new List<Resource>();
                int count = rand.Next(2, 9);

                for (int i = 0; i < count; i++)
                {
                    Resource resource = new Resource();
                    resource.ResourceID = Guid.NewGuid();
                    resource.Type = (ResourceType)resourceTypes.GetValue(rand.Next(resourceTypes.Length));
                    resource.Amount = rand.Next(100, 1000);
                    resource.SolarBodyID = solarBody.ID;

                    solarBody.Resources.Add(resource);
                    resources.Add(resource);
                }

            }

            _context.Resource.AddRange(resources);
            _context.SaveChanges();
        }
    }
}