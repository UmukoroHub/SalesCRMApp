﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace SalesCRMApp.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AppRolesController : Controller
    {
       

        private readonly RoleManager<IdentityRole> _roleManager;
        public AppRolesController(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

        //Lists All The Roles Created By Users
        public IActionResult Index()
        {
            var roles = _roleManager.Roles.ToList(); 
            return View(roles);
        }

        [HttpGet]

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Create(IdentityRole model)
        {
            //To avoid duplicate roles
            if (!_roleManager.RoleExistsAsync(model.Name).GetAwaiter().GetResult())
            {
                _roleManager.CreateAsync(new IdentityRole(model.Name)).GetAwaiter().GetResult();
                
            }
            return RedirectToAction("Index");
        }


    }
}
