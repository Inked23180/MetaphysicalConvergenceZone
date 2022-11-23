using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MetaphysicalConvergenceZone1._0.Pages
{
    [Authorize]
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

