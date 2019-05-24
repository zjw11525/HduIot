using HduIot.Models;
using HduIot.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HduIot.Controllers
{
    public class DeviceController:Controller
    {
        private readonly IDeviceService _deviceService;
        public DeviceController(IDeviceService deviceService)
        {
            _deviceService = deviceService;
        }

        public IActionResult Add()
        {
            ViewBag.Title = "添加设备";

            return View(new DeviceModel
            {
                Message = "暂无"
            });
        }

        [HttpPost]
        public async Task<IActionResult> Add(DeviceModel device)
        {
            if (ModelState.IsValid)
            {
                await _deviceService.AddAsync(device);
            }

            return RedirectToAction("Console");
        }
        public async Task<IActionResult> Console()
        {
            ViewBag.Title = "所有设备";

            return View(await _deviceService.GetllAllAsync());
        }
        public IActionResult ChangeSwitch(int Id)
        {
            _deviceService.SwitchChange(Id);
            return RedirectToAction("Console");
        }
    }
}
