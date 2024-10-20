using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Tudose_Nicholas_Lab2.Data;
using Tudose_Nicholas_Lab2.Models;

namespace Tudose_Nicholas_Lab2.Pages.Authors
{
    public class IndexModel : PageModel
    {
        private readonly Tudose_Nicholas_Lab2.Data.Tudose_Nicholas_Lab2Context _context;

        public IndexModel(Tudose_Nicholas_Lab2.Data.Tudose_Nicholas_Lab2Context context)
        {
            _context = context;
        }

        public IList<Author> Author { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Author = await _context.Author.ToListAsync();

        }
    }
}
