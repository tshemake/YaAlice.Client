using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace YaAlice.Webhook.Models
{
    /// <summary>
    /// Ответ
    /// </summary>
    public class YaAliceResponse
    {
        /// <summary>
        /// Данные для ответа пользователю
        /// </summary>
        [JsonProperty("response")]
        public Response Response { get; set; }

        /// <summary>
        /// Данные о сессии
        /// </summary>
        [JsonProperty("session")]
        public Session Session { get; set; }

        /// <summary>
        /// Версия протокола
        /// </summary>
        [JsonProperty("version")]
        public string Version { get; set; }
    }

    public static class AliceExtensions
    {
        public static YaAliceResponse Reply(
            this YaAliceRequest request,
            string text,
            bool endSession = false,
            IList<Button> buttons = null) => new YaAliceResponse
            {
                Response = new Response()
                {
                    Text = text,
                    Tts = text,
                    Buttons = buttons,
                    EndSession = endSession,
                },
                Session = new Session()
                {
                    SessionId = request.Session.SessionId,
                    MessageId = request.Session.MessageId,
                    UserId = request.Session.UserId,
                },
                Version = request.Version,
            };
    }
}
