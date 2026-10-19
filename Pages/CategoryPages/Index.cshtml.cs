using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Bran_Vladut_Lab2.Models;

namespace Bran_Vladut_Lab2.Pages.CategoryPages;

public class IndexModel : PageModel
{
    private readonly Bran_Vladut_Lab2Context _context;

    public IndexModel(Bran_Vladut_Lab2Context context)
    {
        _context = context;
    }

    public IList<Category> Category { get; set; } = default!;

    public async Task OnGetAsync()
    {
        Category = await _context.Category.ToListAsync();
    }
}
