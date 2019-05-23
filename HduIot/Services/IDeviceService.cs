using HduIot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HduIot.Services
{
    public interface IDeviceService
    {
        Task<IEnumerable<DeviceModel>> GetllAllAsync();
        Task<DeviceModel> GetByIdAsync(int Id);
        Task AddAsync(DeviceModel device);
        Task SwitchChange(int Id);

    }
}
