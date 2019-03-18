using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace YaAlice.Webhook.Models
{
    /// <summary>
    /// Информация об устройстве, с помощью которого пользователь разговаривает с Алисой
    /// </summary>
    public class Meta
    {
        /// <summary>
        /// Язык в POSIX-формате, максимум 64 символа
        /// </summary>
        [JsonProperty("locale")]
        [MaxLength(64)]
        public string Locale { get; set; }

        /// <summary>
        /// Название часового пояса, включая алиасы, максимум 64 символа
        /// </summary>
        [JsonProperty("timezone")]
        [MaxLength(64)]
        public string Timezone { get; set; }

        /// <summary>
        /// Идентификатор устройства и приложения, в котором идет разговор, максимум 1024 символа
        /// </summary>
        [JsonProperty("client_id")]
        [MaxLength(1024)]
        [Obsolete("Интерфейсы, доступные на клиентском устройстве, перечислены в свойстве Interfaces")]
        public string ClientId { get; set; }

        /// <summary>
        /// Интерфейсы, доступные на устройстве пользователя
        /// </summary>
        [JsonProperty("interfaces")]
        public Interfaces Interfaces { get; set; }
    }
}
