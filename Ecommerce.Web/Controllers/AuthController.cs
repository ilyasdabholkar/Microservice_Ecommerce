﻿using Ecommerce.Web.Models.Dto;
using Ecommerce.Web.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Web.Controllers
{
    public class AuthController : Controller
    {

        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService= authService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            LoginRequestDto loginRequestDto = new();
            return View(loginRequestDto);
        }

        [HttpGet]
        public IActionResult Register()
        {
            
            return View();
        }


        public IActionResult Logout()
        {

            return View();
        }
    }
}
