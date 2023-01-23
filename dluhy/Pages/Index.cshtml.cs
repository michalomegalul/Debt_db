using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using dluhy.Module;
using Microsoft.EntityFrameworkCore;

namespace dluhy.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ApplicationDbContext _context;
        public IndexModel(ILogger<IndexModel> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;

        }
        


        public void OnGet()
        {
        }
        public void OnPost()
        {
            string userinput = Request.Form["userinput"];
            var input = new ApplicationDbContext.Input {Id = 1, input= userinput };
            _context.input.Add(input);
            _context.SaveChanges();
            


        }



    }
}