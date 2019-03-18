using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace YaAlice.Webhook.Models
{
    /// <summary>
    /// Имя, фамилия, отчество
    /// </summary>
    public class Fio : Value
    {
        /// <summary>
        /// Имя
        /// </summary>
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// Отчество
        /// </summary>
        [JsonProperty("patronymic_name")]
        public string PatronymicName { get; set; }

        /// <summary>
        /// Фамилия
        /// </summary>
        [JsonProperty("last_name")]
        public string LastName { get; set; }
    }
}
