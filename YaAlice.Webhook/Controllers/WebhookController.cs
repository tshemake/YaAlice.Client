using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YaAlice.Webhook.Models;

namespace YaAlice.Webhook.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebhookController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public IActionResult Post([FromBody] YaAliceRequest update)
        {
            var response = string.IsNullOrEmpty(update.Request.Command) ? "Привет!" : update.Request.Command;
            return Ok(update.Reply(response));
        }
    }
}
