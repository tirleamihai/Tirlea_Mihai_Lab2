using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Tirlea_Mihai_Lab2.Models;
using Tirlea_Mihai_Lab2.Data;
namespace Tirlea_Mihai_Lab2.Pages.Members;

public class IndexModel : PageModel
{
    private readonly Tirlea_Mihai_Lab2Context _context;

    public IndexModel(Tirlea_Mihai_Lab2Context context)
    {
        _context = context;
    }

    public IList<Member> Member { get; set; } = default!;

    public async Task OnGetAsync()
    {
        Member = await _context.Member.ToListAsync();
    }
}
