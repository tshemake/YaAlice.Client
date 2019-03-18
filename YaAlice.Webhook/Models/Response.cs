using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace YaAlice.Webhook.Models
{
    /// <summary>
    /// Данные для ответа пользователю
    /// </summary>
    public class Response
    {
        /// <summary>
        /// Текст, который следует показать и сказать пользователю. Максимум 1024 символа. Не должен быть пустым.
        /// Текст также используется, если у Алисы не получилось отобразить включенную в ответ карточку (свойство response.card).
        /// На устройствах, которые поддерживают только голосовое общение с навыком, это будет происходить каждый раз, когда навык присылает карточку в ответе.
        /// </summary>
        /// <remarks>
        /// В тексте ответа можно указать переводы строк последовательностью «\n»
        /// </remarks>
        [JsonProperty("text")]
        [Required(AllowEmptyStrings = false)]
        [MaxLength(1024)]
        public string Text { get; set; }

        /// <summary>
        /// Ответ в формате TTS (text-to-speech), максимум 1024 символа
        /// </summary>
        [JsonProperty("tts")]
        [MaxLength(1024)]
        public string Tts { get; set; }

        /// <summary>
        /// Кнопки, которые следует показать пользователю
        /// </summary>
        public IEnumerable<Button> Buttons { get; set; }

        /// <summary>
        /// Признак конца разговора
        /// Допустимые значения:
        /// <list type="bullet">
        /// <item>
        /// <term>true</term>  
        /// <description>Сессию следует завершить</description>
        /// </item>
        /// <item>
        /// <term>false</term>  
        /// <description>Сессию следует продолжить</description>
        /// </item>
        /// </list>
        /// </summary>
        [JsonProperty("end_session")]
        public bool EndSession { get; set; }
    }
}
