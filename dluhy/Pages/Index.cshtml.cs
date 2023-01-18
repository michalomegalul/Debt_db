using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using dluhy.Module;
using Microsoft.EntityFrameworkCore;

namespace dluhy.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            
        }
        
        
        public void OnGet()
        {
        }
        public void OnPost()
        {
            string userinput = Request.Form["userinput"];
            var x = 0;
            string userinputvalid = Convert.ToString(userinput);
            if (userinputvalid != null)
            {
                x++;
                using (var db = new ApplicationDbContext())
                {
                    var input = new ApplicationDbContext.Input() { input = userinput, Id = 1 };
                    db.Add(input);
                    db.SaveChanges();
                }
            }
            else
            {

            }
            


        }



    }
}