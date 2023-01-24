using AspNetCoreCookieAuthentication.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using System.Security.Principal;

namespace AspNetCoreCookieAuthentication.Pages
{
    [Authorize(Policy = "AdminOnly")]
    public class AdminModel : PageModel
    {
        public string Role { get; set; }

        public ApplicationDbContext _context;


        public  List<User> Users = new List<User>();
        public List<int> UserIds = new List<int>();


        public AdminModel(ApplicationDbContext context) {
            _context = context;
        }

        public int MyProperty { get; set; }

        public void OnGet() {
            foreach (var user in _context.Users) {
                UserIds.Add(user.Id);
            }

            foreach (var user in _context.Users) {
                Users.Add(user);
            }

       
        }
    }
}
