using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace Final.Pages
{
    public class IndexModel : PageModel
    {
        private static System.Timers.Timer timer;

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }


        public void OnGet()
        {
            string dateTime = DateTime.Now.ToString();
            ViewData["TimeStamp"] = dateTime;
        }


    }
}
