using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class CreateEditProductViewModel
    {
        public Product Product { get; set; }
        public List<SelectListItem> ProductCategories { get; set; }
    }
}
