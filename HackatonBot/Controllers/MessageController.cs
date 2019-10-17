using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HackatonBot.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Telegram.Bot.Types;

namespace HackatonBot.Controllers
{
    [Route("api/message/update")]
    public class MessageController : Controller
    {
        [HttpGet]
        public async Task<OkResult> Post([FromBody]Update update)
        {
            if (update == null) return Ok();

            var commands = Bot.Commands;
            var message = update.Message;
            var botClient = await Bot.GetBotClientAsync();

            foreach (var command in commands)
            {
                if (command.Contains(message))
                {
                    await command.Execute(message, botClient);
                    break;
                }
            }

            return Ok();
        }
    }
}
