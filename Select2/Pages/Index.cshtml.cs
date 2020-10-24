using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;

namespace Select2.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public SelectList DDValue { get; set; }
        [BindProperty]
        public string simpleSelect1 { get; set; }
        [BindProperty]
        public string simpleSelect2 { get; set; }
        [BindProperty]
        public string simpleSelect3 { get; set; }
        [BindProperty]
        public string[] simpleSelect4 { get; set; }

        public void OnGet()
        {
            List<string> ddList = new List<string>() { "One", "Two", "Three", "Four", "Five" };
            DDValue = new SelectList(ddList);
            List<SelectListItem> data = new List<SelectListItem>()
            {
                new SelectListItem { Text = "Alaska", Value = "AL" },
                new SelectListItem { Text = "Hawaii", Value = "HI" },
                new SelectListItem { Text = "California", Value = "CA", Selected = true },
                new SelectListItem { Text = "Nevada", Value = "NV", Selected = true }
            };
        }
        public void OnPost()
        {
            string One = simpleSelect1;
            string Two = simpleSelect2;
            string Three = simpleSelect3;
            string[] Four = simpleSelect4;
        }
        public JsonResult OnGetDD3()
        {
            List<string> ddList = new List<string>() { "100", "200", "300", "400", "500" };
            return new JsonResult(ddList);
        }
    }
}