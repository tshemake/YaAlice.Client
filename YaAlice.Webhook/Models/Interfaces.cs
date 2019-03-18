using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace YaAlice.Webhook.Models
{
    /// <summary>
    /// Интерфейсы, доступные на устройстве пользователя
    /// </summary>
    public class Interfaces
    {
        /// <summary>
        /// Пользователь может видеть ответ навыка на экране и открывать ссылки в браузере
        /// </summary>
        [JsonProperty("screen")]
        public Screen Screen { get; set; }

        [JsonProperty("account_linking")]
        public AccountLinking AccountLinking { get; set; }

        [JsonProperty("payments")]
        public Payments Payments { get; set; }
    }
}
