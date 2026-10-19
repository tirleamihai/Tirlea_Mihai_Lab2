using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Tirlea_Mihai_Lab2.Models;

namespace Tirlea_Mihai_Lab2.Pages.Authors;

public class IndexModel : PageModel
{
    private readonly Tirlea_Mihai_Lab2Context _context;

    public IndexModel(Tirlea_Mihai_Lab2Context context)
    {
        _context = context;
    }

    public IList<Author> Author { get; set; } = default!;

    public async Task OnGetAsync()
    {
        Author = await _context.Author.ToListAsync();
    }
}
