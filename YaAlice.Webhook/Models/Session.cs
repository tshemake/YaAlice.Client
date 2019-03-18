using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace YaAlice.Webhook.Models
{
    /// <summary>
    /// Данные о сессии
    /// </summary>
    public class Session
    {
        /// <summary>
        /// Признак новой сессии.
        /// Возможные значения:
        /// <list type="bullet">
        /// <item>
        /// <term>true</term>  
        /// <description>Пользователь начинает новый разговор с навыком</description>
        /// </item>
        /// <item>
        /// <term>false</term>  
        /// <description>Запрос отправлен в рамках уже начатого разговора</description>
        /// </item>
        /// </list>
        /// </summary>
        [JsonProperty("new")]
        public bool New { get; set; }

        /// <summary>
        /// Идентификатор сообщения в рамках сессии
        /// </summary>
        /// <remarks>
        /// Инкрементируется с каждым следующим запросом
        /// </remarks>
        [JsonProperty("message_id")]
        public long MessageId { get; set; }

        /// <summary>
        /// Уникальный идентификатор сессии, максимум 64 символов
        /// </summary>
        [JsonProperty("session_id")]
        [MaxLength(64)]
        public string SessionId { get; set; }

        /// <summary>
        /// Идентификатор вызываемого навыка, присвоенный при создании
        /// </summary>
        /// <remarks>
        /// Чтобы узнать идентификатор своего навыка, откройте его в
        /// личном кабинете — идентификатор будет в адресе страницы,
        /// <see href="https://.../developer/skills/<идентификатор>/">
        /// </remarks>
        [JsonProperty("skill_id")]
        public string SkillId { get; set; }

        /// <summary>
        /// Идентификатор экземпляра приложения, в котором пользователь общается с Алисой, максимум 64 символа
        /// </summary>
        /// <remarks>
        /// Даже если пользователь авторизован с одним и тем же аккаунтом в приложении Яндекс для Android и iOS,
        /// Яндекс.Диалоги присвоят отдельный user_id каждому из этих приложений
        /// </remarks>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
