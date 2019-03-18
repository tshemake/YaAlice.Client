using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace YaAlice.Webhook.Models.Types
{
    // <summary>
    /// Тип именованной сущности
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter), true)]
    public enum ValueType
    {
        /// <summary>
        /// Неизвестный тип сообщения
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// Дата и время, абсолютные или относительные
        /// </summary>
        [EnumMember(Value = "YANDEX.DATETIME")]
        DATETIME,

        /// <summary>
        /// Фамилия, имя и отчество
        /// </summary>
        [EnumMember(Value = "YANDEX.FIO")]
        FIO,

        /// <summary>
        /// Местоположение (адрес или аэропорт)
        /// </summary>
        [EnumMember(Value = "YANDEX.GEO")]
        GEO,

        /// <summary>
        /// Число, целое или с плавающей точкой
        /// </summary>
        [EnumMember(Value = "YANDEX.NUMBER")]
        NUMBER
    }
}
