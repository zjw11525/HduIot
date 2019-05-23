using HduIot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HduIot.Services
{
    public class DeviceMemoryService:IDeviceService
    {
        private readonly List<DeviceModel> _devices = new List<DeviceModel>();
        public DeviceMemoryService()
        {
            _devices.Add(new DeviceModel
            {
                Id = 1,
                Name = "人脸识别门禁",
                Switch = false,
                Message = "Hello",
                DeviceKey = "123456"
            });
            _devices.Add(new DeviceModel
            {
                Id = 2,
                Name = "人脸识别门禁",
                Switch = false,
                Message = "用户开锁",
                DeviceKey = "111111"
            });
        }
        public Task<IEnumerable<DeviceModel>> GetllAllAsync()
        {
            return Task.Run(() => _devices.AsEnumerable());
        }

        public Task<DeviceModel> GetByIdAsync(int id)
        {
            return Task.Run(() => _devices.FirstOrDefault(x => x.Id == id));
        }

        public Task AddAsync(DeviceModel device)
        {
            var maxId = _devices.Max(x => x.Id);
            device.Id = maxId + 1;
            _devices.Add(device);
            return Task.CompletedTask;
        }
        public Task SwitchChange(int Id)
        {
            if (Id >= 1)
            {
                Id--;
                _devices[Id].Switch = !_devices[Id].Switch;
            }
            return Task.CompletedTask;
        }
    }
}
