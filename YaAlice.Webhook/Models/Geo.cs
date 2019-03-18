using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace YaAlice.Webhook.Models
{
    /// <summary>
    /// Местоположение
    /// </summary>
    public class Geo : Value
    {
        /// <summary>
        /// Страна
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// Город
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// Улица
        /// </summary>
        [JsonProperty("street")]
        public string Street { get; set; }

        /// <summary>
        /// Номер дома
        /// </summary>
        [JsonProperty("house_number")]
        public string HouseNumber { get; set; }

        /// <summary>
        /// Название аэропорта
        /// </summary>
        [JsonProperty("airport")]
        public string Airport { get; set; }
    }
}
