using HduIot.Models;
using Microsoft.EntityFrameworkCore;
using MqttServerTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HduIot.Services
{
    //public class DeviceContext : DbContext
    //{
    //    public DbSet<DeviceModel> Devices { get; set; }
    //    protected override void OnConfiguring(DbContextOptionsBuilder options)
    //    {
    //        options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=HduIot-DeviceDb;Trusted_Connection=True;MultipleActiveResultSets=true");
    //    }
    //}
    public class DeviceMemoryService:IDeviceService
    {
        public Task<IEnumerable<DeviceModel>> GetllAllAsync(string userName)
        {
            DeviceContext _Devicedb = new DeviceContext();
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
            DeviceContext _Devicedb = new DeviceContext();
            return Task.Run(() => _Devicedb.Devices.FirstOrDefault(x => x.Id == id));
        }

        public Task AddAsync(DeviceModel device)
        {
            DeviceContext _Devicedb = new DeviceContext();
            _Devicedb.Devices.Add(device);
            _Devicedb.SaveChanges();
            return Task.CompletedTask;
        }
        public Task DeleteAsync(int Id)
        {
            DeviceContext _Devicedb = new DeviceContext();
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
            DeviceContext _Devicedb = new DeviceContext();
            var device = _Devicedb.Devices.SingleOrDefault(x => x.Id == Id);
            device.Switch = !device.Switch;
            _Devicedb.SaveChanges();     
            return Task.CompletedTask;
        }
    }
}
