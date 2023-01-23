using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace AspNetCoreCookieAuthentication.Pages
{
    [Authorize]
    public class ProductModel : PageModel
    {
        public string UserId { get; set; }

        public string MyProperty { get; set; }

        public void OnGet()
        {
            UserId = User.Claims.First().Value;

            MyProperty = User.Claims.Where(f => f.Type == ClaimTypes.Role).FirstOrDefault().Value;
        }
    }
}
