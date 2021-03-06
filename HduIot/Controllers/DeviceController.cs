﻿using HduIot.Models;
using HduIot.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MqttServerTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HduIot.Controllers
{
    public class DeviceController:Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IDeviceService _deviceService;
        public DeviceController(IDeviceService deviceService,UserManager<IdentityUser> userManager)
        {
            _deviceService = deviceService;
            _userManager = userManager;
        }

        public async Task<IActionResult> Add()
        {
            ViewBag.Title = "添加设备";
            IdentityUser user = await _userManager.GetUserAsync(HttpContext.User);

            return View(new DeviceModel
            {
                Message = "暂无",
                User = user.UserName
            });
        }

        [HttpPost]
        public async Task<IActionResult> Add(DeviceModel device)
        {
            DeviceContext devices = new DeviceContext();
            string DeviceKey;
            int count = 0;
            do
            {
                DeviceKey = System.Guid.NewGuid().ToString();
                var dbset = devices.Devices.Where(t => t.DeviceKey == DeviceKey);
                count = dbset.Count();
            } while (count != 0);//密码在数据库中不存在

            device.DeviceKey = DeviceKey;

            if (ModelState.IsValid)
            {
                await _deviceService.AddAsync(device);
            }

            return RedirectToAction("Console");
        }
        public async Task<IActionResult> Delete(int Id)
        {
            await _deviceService.DeleteAsync(Id);

            return RedirectToAction("Console");
        }

        public async Task<IActionResult> Console()
        {
            ViewBag.Title = "所有设备";

            IdentityUser user = await _userManager.GetUserAsync(HttpContext.User);
            if (user == null)
            {
                ViewBag.IsLogin = false;
                return View();
            }
            else
            {
                ViewBag.IsLogin = true;
                return View(await _deviceService.GetllAllAsync(user.UserName));
            }
        }
        public async Task<IActionResult> Protocol()
        {
            return View();
        }
        public IActionResult ChangeSwitch(int Id)
        {
            _deviceService.SwitchChange(Id);
            return RedirectToAction("Console");
        }
    }
}
