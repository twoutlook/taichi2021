using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContosoUniversity.Data;
using ContosoUniversity.Models;

namespace ContosoUniversity.Pages.Moves
{
    public class ShowModel : PageModel
    {
        private readonly ContosoUniversity.Data.SchoolContext _context;

        public ShowModel(ContosoUniversity.Data.SchoolContext context)
        {
            _context = context;
        }

        public IList<Move> Move { get; set; }
        public IList<Combo> Combo { get; set; }

        public async Task OnGetAsync()
        {
            Move = await _context.Moves
                .Include(m => m.Combo).OrderBy(x=>x.Combo).ThenBy(x=>x.Seq).ToListAsync();

            Combo = await _context.Combos.OrderBy(x => x.Name).ToListAsync();

        }
    }
}
