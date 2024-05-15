using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;
using System.Data;
using Dapper;
using System.Security.Principal;
namespace RasulIPTProject.Pages
{
    [BindProperties]
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public HUB hub { get; set; } = new HUB();

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            hub.Dis();
            hub.LoginPass();

        }
        public IActionResult OnPostAdd()
        {
            hub.Login(hub.Account_Class.Username, hub.Account_Class.Password);
            return Page();
        }
        public IActionResult OnPostPrivacy()
        {
            return RedirectToPage("/Privacy");
        }
        public IActionResult OnPostAbout()
        {
            return RedirectToPage("/About");
        }
        public IActionResult OnPostLog()
        {
            return RedirectToPage("/Dashboard");
        }
        public IActionResult OnPostLog2()
        {
            return RedirectToPage();
        }
    }
}
