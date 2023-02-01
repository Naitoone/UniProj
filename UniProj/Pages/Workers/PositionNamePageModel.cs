using UniProj.Data;
using UniProj.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace UniProj.Pages.Workers
{
    public class PositionNamePageModel : PageModel
    {
        public SelectList PositionNameSL { get; set; }

        public void PositionDropDownList(WebShopContext _context, 
            object selectedPosition = null)
        {
            var positionQuery = from d in _context.Positions orderby d.Name select d;

            PositionNameSL = new SelectList(positionQuery.AsNoTracking(),
                nameof(Position.Id),
                nameof(Position.Name),
                selectedPosition);

        }
    }
}
