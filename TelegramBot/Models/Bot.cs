﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Telegram.Bot;
using TelegramBot.Models.Commands;

namespace TelegramBot.Models
{
    public static class Bot
    {
        private static TelegramBotClient client;

        private static List<Command> commandsList;

        public static IReadOnlyList<Command> Commands => commandsList.AsReadOnly();

        public static async Task<TelegramBotClient> Get()
        {
            if (client != null)
            {
                return client;
            }

            // adding commands
            commandsList = new List<Command>();
            commandsList.Add(new HelloCommand());

            client = new TelegramBotClient(AppSettings.Key);

            var hook = string.Format(AppSettings.Url, "api/message/update");
            await client.SetWebhookAsync(hook);

            return client;
        
        }
    }
}