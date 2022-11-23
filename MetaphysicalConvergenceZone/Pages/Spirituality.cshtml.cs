using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetaphysicalConvergenceZone.Pages
{
    public class SpiritualityModel : PageModel
    {
        private readonly ILogger<SpiritualityModel> _logger;

        public SpiritualityModel(ILogger<SpiritualityModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
