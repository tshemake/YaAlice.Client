using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace YaAlice.Webhook.Models
{
    /// <summary>
    /// Данные, полученные от пользователя
    /// </summary>
    public class Request
    {
        /// <summary>
        /// Запрос, который был передан вместе с командой активации навыка
        /// </summary>
        /// <remarks>
        /// Например, если пользователь активирует навык словами
        /// «спроси у Сбербанка где ближайшее отделение»,
        /// в этом поле будет передана строка «где ближайшее отделение»
        /// </remarks>
        [JsonProperty("command")]
        public string Command { get; set; }

        /// <summary>
        /// Полный текст пользовательского запроса, максимум 1024 символа
        /// </summary>
        [JsonProperty("original_utterance")]
        [MaxLength(1024)]
        public string OriginalUtterance { get; set; }

        /// <summary>
        /// Тип ввода
        /// </summary>
        [JsonProperty("type")]
        [Required]
        public Types.RequestType Type { get; set; }

        /// <summary>
        /// Формальные характеристики реплики, которые удалось выделить Яндекс.Диалогам
        /// Отсутствует, если ни одно из вложенных свойств не применимо
        /// </summary>
        [JsonProperty("markup")]
        public Markup Markup { get; set; }

        /// <summary>
        /// JSON, полученный с нажатой кнопкой от обработчика навыка (в ответе на предыдущий запрос)
        /// </summary>
        [JsonProperty("payload")]
        public JObject Payload { get; set; }

        /// <summary>
        /// Слова и именованные сущности, которые Диалоги извлекли из запроса пользователя
        /// </summary>
        [JsonProperty("nlu")]
        public Nlu Nlu { get; set; }
    }
}
