using AspNetCoreCookieAuthentication.Data;
using AspNetCoreCookieAuthentication.Migrations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace AspNetCoreCookieAuthentication.Pages.Account
{
    [Authorize(Policy = "AdminOnly" )]
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public EditModel(ApplicationDbContext context) {
            _context = context;
        }


        public User User { get; set; }

        public void OnGet(int id)
        {   
            User = _context.Users.FirstOrDefault(m => m.Id == id);



        }

        public IActionResult OnPost(User user) {
            _context.Users.Update(user);
            _context.SaveChanges();
            return RedirectToPage("../Admin");
        }
    }
}
