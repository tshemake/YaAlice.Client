using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace YaAlice.Webhook.Models
{
    /// <summary>
    /// Формальные характеристики реплики, которые удалось выделить Яндекс.Диалогам
    /// Отсутствует, если ни одно из вложенных свойств не применимо
    /// </summary>
    public class Markup
    {
        /// <summary>
        /// Признак реплики, которая содержит криминальный подтекст (самоубийство, разжигание ненависти, угрозы).
        /// Вы можете настроить навык на определенную реакцию для таких случаев — например,
        /// отвечать «Не понимаю, о чем вы. Пожалуйста, переформулируйте вопрос.»
        /// </summary>
        /// <remarks>
        /// Возможно только значение true. Если признак не применим, это свойство не включается в ответ
        /// </remarks>
        [JsonProperty("dangerous_context")]
        public bool DangerousContext { get; set; }
    }
}
