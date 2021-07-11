using CoffeeShopApi.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShopApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenusController : ControllerBase
    {
        ExpressoDbContext _expressoDbContext;

        public MenusController(ExpressoDbContext expressoDbContext)
        {
            _expressoDbContext = expressoDbContext;
        }

        [HttpGet]
        public IActionResult GetMenus()
        {
            // used eager loading - search for it
            var menus = _expressoDbContext.Menus.Include("SubMenus");
            return Ok(menus);
        }
    }
}
