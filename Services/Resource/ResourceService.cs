using System;
using DeeperAndDeeper.Models;

namespace DeeperAndDeeper.Service.ResourceServices
{
    public class ResourceService : IResourceService
    {
        public Resource CreateResource()
        {
            Random rand = new Random();

            Array resourceTypes = Enum.GetValues(typeof(ResourceType));

            Resource resource = new Resource();
            resource.Type =  (ResourceType)resourceTypes.GetValue(rand.Next(resourceTypes.Length));
            resource.Amount = rand.Next(100, 1000);

            return resource;
        }
    }
}