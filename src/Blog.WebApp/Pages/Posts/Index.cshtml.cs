using Blog.WebApp.Data;
using Blog.WebApp.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Blog.WebApp.Pages.Posts;

public class IndexModel : PageModel
{
    private readonly ApplicationDbContext _context;

    public IndexModel(ApplicationDbContext context)
    {
        _context = context;
    }

    public IList<Post> Posts { get; set; } = new List<Post>();

    public async Task OnGetAsync()
    {
        Posts = await _context.Posts
            .Include(p => p.ApplicationUser)
            .ToListAsync();
    }
}