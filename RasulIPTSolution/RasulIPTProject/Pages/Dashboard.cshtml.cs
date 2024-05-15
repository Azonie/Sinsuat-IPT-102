using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RasulIPTProject.Pages
{
    public class DashboardModel : PageModel
    {
        public IActionResult OnPostLog()
        {
            return RedirectToPage("/Accounts");
        }
        public IActionResult OnPostLogOut()
        {
            return RedirectToPage("/Index");
        }
        public IActionResult OnPostPrivacy()
        {
            return RedirectToPage("/Privacy");
        }
        public IActionResult OnPostAbout()
        {
            return RedirectToPage("/About");
        }
    }
}
