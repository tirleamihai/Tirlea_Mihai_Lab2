using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Tirlea_Mihai_Lab2.Models;
using Tirlea_Mihai_Lab2.Models.ViewModels;
using Tirlea_Mihai_Lab2.Data;
namespace Tirlea_Mihai_Lab2.Pages.CategoryPages;

public class IndexModel : PageModel
{
    private readonly Tirlea_Mihai_Lab2Context _context;

    public IndexModel(Tirlea_Mihai_Lab2Context context)
    {
        _context = context;
    }

    public IList<Category> Category { get; set; } = default!;

    public CategoryIndexData BookCategoryData { get; set; }
   // public CategoryIndexData CategoryData { get; set; }
    //public int BookCategoryID { get; set; }
    public int CategoryID { get; set; }
    //public int BookID { get; set; }
    public async Task OnGetAsync(int? id, int? bookID)
    {
        BookCategoryData = new CategoryIndexData();
        BookCategoryData.Categories= await _context.Category
        .Include(i => i.BookCategories)
        .ThenInclude(c => c.Book)
        .ThenInclude(b => b.Author)
        .ToListAsync();
        if (id != null)
        {
            CategoryID = id.Value;
            Category bookcategory = BookCategoryData.Categories
            .Where(i => i.ID == id.Value).Single();
            BookCategoryData.Books = bookcategory.BookCategories.Select(bc => bc.Book).ToList();
        }
    }
}
