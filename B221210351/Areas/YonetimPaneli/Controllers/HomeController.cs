﻿using B221210351.Areas.YonetimPaneli.Models.ViewModels;
using B221210351.EFContext;
using B221210351.Models;
using B221210351.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace B221210351.Areas.YonetimPaneli.Controllers
{
    [Authorize(Roles ="Admin")]
    [Area("yonetimPaneli")]
    public class HomeController : Controller
    {
        private readonly HastaneDbContext context;
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;
        private readonly RoleManager<AppRole> roleManager;

        public HomeController(HastaneDbContext context, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<AppRole> roleManager)
        {
            this.context = context;
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.signInManager = signInManager;
        }

        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(LoginAdminVM model)
        {
            if (ModelState.IsValid)
            {
                AppUser user = await userManager.FindByEmailAsync(model.Email);
                if (user != null)
                {
                    await signInManager.SignOutAsync();
                    Microsoft.AspNetCore.Identity.SignInResult result = await signInManager.PasswordSignInAsync(user, model.Password, model.Persistent, model.Lock);

                    if (result.Succeeded)
                        return RedirectToAction("Dashboard");
                }
                else
                {
                    ModelState.AddModelError("NotUser", "Böyle bir kullanıcı bulunmamaktadır.");
                    ModelState.AddModelError("NotUser2", "E-posta veya şifre yanlış.");
                }
            }
            return View(model);
        }
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }

        public IActionResult Dashboard()
        {
            List<AppUser> patients = context.Users.ToList();
            List<Doctor> doctors = context.Doctors.ToList();
            List<Policlinic> policlinics = context.Policlinics.ToList();
            List<Department> departments = context.Departments.ToList();

            AppDatasForAdminVM appData = new()
            {
                Patients = patients,
                Doctors = doctors,
                Departments = departments,
                Policlinics = policlinics
            };
            return View(appData);
        }
    }
}
