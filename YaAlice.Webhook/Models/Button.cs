using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace YaAlice.Webhook.Models
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Кнопки, которые следует показать пользователю
    /// </summary>
    /// <remarks>
    /// Все указанные кнопки выводятся после основного ответа Алисы, описанного в свойствах response.text и response.card.
    /// Кнопки можно использовать как релевантные ответу ссылки или подсказки для продолжения разговора
    /// </remarks>
    public class Button
    {
        /// <summary>
        /// Текст кнопки, обязателен для каждой кнопки. Максимум 64 символа
        /// </summary>
        /// <remarks>
        /// Если для кнопки не указано свойство url, по нажатию текст кнопки будет отправлен навыку как реплика пользователя
        /// </remarks>
        [JsonProperty("title")]
        [MaxLength(64)]
        public string Title { get; set; }

        /// <summary>
        /// Произвольный JSON, который Яндекс.Диалоги должны отправить обработчику, если данная кнопка будет нажата. Максимум 4096 байт
        /// </summary>
        [JsonProperty("payload")]
        public JObject Payload { get; set; }

        /// <summary>
        /// URL, который должна открывать кнопка, максимум 1024 байта
        /// </summary>
        /// <remarks>
        /// Если свойство url не указано, по нажатию кнопки навыку будет отправлен текст кнопки
        /// </remarks>
        [JsonProperty("url")]
        [MaxLength(1024)]
        public string Url { get; set; }

        /// <summary>
        /// Признак того, что кнопку нужно убрать после следующей реплики пользователя
        /// Допустимые значения:
        /// <list type="bullet">
        /// <item>
        /// <term>true</term>  
        /// <description>Кнопку нужно скрывать после нажатия</description>
        /// </item>
        /// <item>
        /// <term>false</term>  
        /// <description>Кнопка должна оставаться активной (значение по умолчанию)</description>
        /// </item>
        /// </list>
        /// </summary>
        [JsonProperty("hide")]
        public bool Hide { get; set; }
    }
}
