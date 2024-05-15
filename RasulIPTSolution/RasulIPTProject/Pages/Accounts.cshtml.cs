using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;
using System.Data;

namespace RasulIPTProject.Pages
{
    [BindProperties]
    public class AccountsModel : PageModel
    {
        private readonly ILogger<AccountsModel> _logger;
        public HUB hub { get; set; } = new HUB();
        public string ORDER { get; set; } = "false";
        public AccountsModel(ILogger<AccountsModel> logger)
        {
            _logger = logger;
            hub.Dis();
        }
        public void OnPostCreate()
        {
            hub.Add(hub.Account_Class.Name,hub.Account_Class.Username, hub.Account_Class.Password);
            hub.Dis();
        }
        public void OnPostUpdate()
        {
            hub.Upd(hub.Account_Class.Id, hub.Account_Class.Name,hub.Account_Class.Username, hub.Account_Class.Password);
            hub.Dis();
        }
        public void OnPostDelete()
        {
            hub.Del(hub.Account_Class.Id);
            hub.Dis();
        }
        public void OnPostSearch()
        {
            hub.Sea(hub.Search);
        }
        public void OnPostEnable()
        {
            ORDER = "true";
            hub.Dis();
        }
        public void OnPostEnable2()
        {
            ORDER = "false";
            hub.Dis();
        }
        public IActionResult OnPostBack()
        {
            return RedirectToPage("/Dashboard");
        }
    }
}
