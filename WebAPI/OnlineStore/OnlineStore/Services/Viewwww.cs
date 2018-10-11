using Microsoft.AspNetCore.Mvc.Rendering;
using OnlineStore.Data;
using System.Collections.Generic;

namespace OnlineStore.Services
{
    public class Viewwww
    {
        private readonly ApplicationDbContext _context;
            public Viewwww(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<SelectListItem> GetSelectListItemsForCategories()
        {
            var listan = new List<SelectListItem>();
            foreach (var item in _context.Categories)
            {
                listan.Add(new SelectListItem { Text = item.Name, Value = item.Id.ToString() });
            }
            return listan;

        }

    }

}
