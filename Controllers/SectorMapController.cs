using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using DeeperAndDeeper.Models;
using DeeperAndDeeper.Service.SectorMapServices;

namespace DeeperAndDeeper.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SectorMapController : ControllerBase
    {
        private readonly ISectorMapService _sectorMapService;

        public SectorMapController(ISectorMapService sectorMapService)
        {
            _sectorMapService = sectorMapService;
        }

        [HttpGet]
        // [Route("[controller]/GetSectors")]
        public IActionResult GetSectors()
        {
            try
            {
                return Ok(_sectorMapService.GetSectors());
            }
            catch (System.Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet("getsector")]
        public IActionResult GetSector(int x, int y)
        {
            try
            {
                return Ok(_sectorMapService.GetSector(x, y));
            }
            catch (System.Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}