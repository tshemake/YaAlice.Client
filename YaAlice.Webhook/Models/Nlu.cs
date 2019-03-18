using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace YaAlice.Webhook.Models
{
    /// <summary>
    /// Слова и именованные сущности, которые Диалоги извлекли из запроса пользователя
    /// </summary>
    public class Nlu
    {
        /// <summary>
        /// Массив слов из произнесенной пользователем фразы
        /// </summary>
        [JsonProperty("tokens")]
        public IEnumerable<string> Tokens { get; set; }

        /// <summary>
        /// Массив именованных сущностей
        /// </summary>
        [JsonProperty("entities")]
        public IEnumerable<Entity> Entities { get; set; }
    }
}
