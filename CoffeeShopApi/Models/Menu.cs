using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShopApi.Models
{
    public class Menu
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Image { get; set; }

        //used for one-to-many relationship navigation between Menu and SubMenu classes
        public ICollection<SubMenu> SubMenus { get; set; }
    }
}
