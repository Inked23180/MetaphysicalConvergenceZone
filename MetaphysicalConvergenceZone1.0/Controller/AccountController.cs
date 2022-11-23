using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetaphysicalConvergenceZone1._0.Controller
{
    public class AccountController: Controller
    {
        public AccountController(IUserRepository userRepository)
        {
            this.userRepository = userRepository
        }
    [AllowAnonymous]
    }
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
    }
}
