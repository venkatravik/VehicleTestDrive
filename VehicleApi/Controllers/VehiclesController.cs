using Microsoft.AspNetCore.Mvc;
using VehiclesApi.Interfaces;
//using VehiclesApi.Migrations;
using VehiclesApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VehiclesApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        private IVehicleService _vehicleService;

        public VehiclesController(IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }

        // GET: api/<VehiclesController>
        [HttpGet]
        public async Task<IEnumerable<VehicleDto>> Get()
        {
            var vehicles = await _vehicleService.GetAllVehicles();
            return vehicles;
        }

        // GET api/<VehiclesController>/5
        [HttpGet("{id}")]
        public async Task<VehicleDto> Get(int id)
        {
            return await _vehicleService.GetVehicleById(id);
        }

        // POST api/<VehiclesController>
        [HttpPost]
        public async Task Post([FromBody] VehicleDto vehicle)
        {
            await _vehicleService.AddVehicle(vehicle);  
        }

        // PUT api/<VehiclesController>/5
        [HttpPut("{id}")]
        public async Task put(int id, [FromBody] VehicleDto vehicle)
        {
            await _vehicleService.UpdateVehicle(id, vehicle);
        }

        // DELETE api/<VehiclesController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _vehicleService.DeleteVehicle(id);
        }
    }
}
