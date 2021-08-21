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
    }
}