using AutoMapper;
using VehiclesApi.Entity;
using VehiclesApi.Interfaces;
using VehiclesApi.Models;

namespace VehiclesApi.Services
{
    public class VehicleService : IVehicleService
    {
        private IVehicleRepository _vehecleRepo;

        private IMapper _mapper;

        public VehicleService(IVehicleRepository vehecleRepo, IMapper mapper)
        {
            _vehecleRepo = vehecleRepo;
            _mapper = mapper;
        }

        public async Task AddVehicle(VehicleDto vehicle)
        {
            var entity = _mapper.Map<Vehicle>(vehicle);
            await _vehecleRepo.AddVehicle(entity);
        }


        public async Task DeleteVehicle(int id)
        {
            await _vehecleRepo.DeleteVehicle(id);
        }

        public async Task<List<VehicleDto>> GetAllVehicles()
        {
            var result = await _vehecleRepo.GetAllVehicles();
            return _mapper.Map<List<VehicleDto>>(result);
        }


        public async Task<VehicleDto> GetVehicleById(int id) => _mapper.Map<VehicleDto>(await _vehecleRepo.GetVehicleById(id));


        public async Task UpdateVehicle(int id, VehicleDto vehicle)
        {
            var item = await _vehecleRepo.GetVehicleById(id);
            if (item == null)
            {
                throw new Exception("Item cant found");
            }
            var updateiteam = _mapper.Map<Vehicle>(vehicle);
            await _vehecleRepo.UpdateVehicle(updateiteam);
        }

    }
}
