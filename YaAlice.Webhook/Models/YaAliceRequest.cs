using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace YaAlice.Webhook.Models
{
    /// <summary>
    /// Запрос
    /// </summary>
    public class YaAliceRequest
    {
        /// <summary>
        /// Информация об устройстве, с помощью которого пользователь разговаривает с Алисой
        /// </summary>
        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        /// <summary>
        /// Данные, полученные от пользователя
        /// </summary>
        [JsonProperty("request")]
        public Request Request { get; set; }

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
}
