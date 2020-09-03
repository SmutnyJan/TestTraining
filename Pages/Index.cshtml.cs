using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WebApplication1.InputModel;
using WebApplication1.Services;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public readonly SessionStorage _ss;

        [BindProperty]
        public string name { get; set; }

        [BindProperty]
        public string secondName { get; set; }

        [BindProperty]
        public DateTime date { get; set; }


        public IndexModel(SessionStorage ss)
        {
            _ss = ss;
        }

        public void OnGet()
        {

        }
        public ActionResult OnPost()
        {
            UserSubscription user = new UserSubscription(name, secondName, date);
            _ss.setUser(user);
            DateTime currentDate = DateTime.Now;
            if(user.Age(date, currentDate) > 18)
            {
                return Redirect("./Show");
            }
            return Redirect("./Index");
        }
    }
}
