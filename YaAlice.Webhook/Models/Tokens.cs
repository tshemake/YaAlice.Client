using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace YaAlice.Webhook.Models
{
    /// <summary>
    /// Обозначение начала и конца именованной сущности в массиве слов.
    /// Нумерация слов в массиве начинается с 0
    /// </summary>
    public class Tokens
    {
        /// <summary>
        /// Первое слово именованной сущности
        /// </summary>
        [JsonProperty("start")]
        public int Start { get; set; }

        /// <summary>
        /// Последнее слово после именованной сущности
        /// </summary>
        [JsonProperty("end")]
        public int End { get; set; }
    }
}
