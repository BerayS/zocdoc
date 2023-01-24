using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetCoreCookieAuthentication.Pages
{
    [Authorize(Policy = "MustBeDoctor")]
    public class DoctorPanelModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
