using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetCoreCookieAuthentication.Pages
{
    [Authorize(Policy = "MustBeClient")]
    public class ClientPanelModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
