using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Data;

namespace WebApplication.Services
{
    public class ProductCategoryService
    {
        private readonly ApplicationDbContext _context;

        public ProductCategoryService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<SelectListItem> GetSelectList(int selectedProductCategoryId = -1)
        {
            return _context.ProductCategory
                .Select(x => new SelectListItem
                {
                    Text = x.Name,
                    Value = x.ProductCategoryId.ToString(),
                    Selected = selectedProductCategoryId == x.ProductCategoryId
                })
                .ToList();
        }
    }
}
