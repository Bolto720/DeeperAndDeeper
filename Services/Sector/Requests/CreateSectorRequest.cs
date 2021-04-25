using DeeperAndDeeper.Models;

namespace DeeperAndDeeper.Service.SectorServices.Requests
{
    public class CreateSectorRequest
    {
        public long ID { get; set; }
        public Position Pos { get; set; }
    }
}