using HduIot.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HduIot.Services
{
    public class DeviceContext : DbContext
    {
        public DbSet<DeviceModel> Devices { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=HduIot-DeviceDb;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
    public class DeviceMemoryService:IDeviceService
    {
        DeviceContext _Devicedb = new DeviceContext();

        public Task<IEnumerable<DeviceModel>> GetllAllAsync(string userName)
        {
            List<DeviceModel> devices = new List<DeviceModel>();
            foreach (DeviceModel device in _Devicedb.Devices)
            {
                if (device.User == userName)
                {
                    devices.Add(device);
                }
            }
            return Task.Run(() => devices.AsEnumerable());
            //return Task.Run(() => _Devicedb.Devices.AsEnumerable());
        }

        public Task<DeviceModel> GetByIdAsync(int id)
        {
            return Task.Run(() => _Devicedb.Devices.FirstOrDefault(x => x.Id == id));
        }

        public Task AddAsync(DeviceModel device)
        {
            _Devicedb.Devices.Add(device);
            _Devicedb.SaveChanges();
            return Task.CompletedTask;
        }
        public Task DeleteAsync(int Id)
        {
            var device = _Devicedb.Devices.SingleOrDefault(x => x.Id == Id);
            if (device != null)
            {
                _Devicedb.Devices.Remove(device);
            }
            _Devicedb.SaveChanges();
            return Task.CompletedTask;
        }
        public Task SwitchChange(int Id)
        {
            var device = _Devicedb.Devices.SingleOrDefault(x => x.Id == Id);
            device.Switch = !device.Switch;
            _Devicedb.SaveChanges();
           
            return Task.CompletedTask;
        }
    }
}
