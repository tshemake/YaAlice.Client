using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace YaAlice.Webhook.Models
{
    /// <summary>
    /// Дата и время
    /// </summary>
    public class DateTime : Value
    {
        /// <summary>
        /// Точный год
        /// </summary>
        [JsonProperty("year")]
        public int Year { get; set; }

        /// <summary>
        /// Признак того, что в поле year указано относительное количество лет
        /// </summary>
        [JsonProperty("year_is_relative")]
        public bool YearIsRelative { get; set; }

        /// <summary>
        /// Месяц
        /// </summary>
        [JsonProperty("month")]
        public int Month { get; set; }

        /// <summary>
        /// Признак того, что в поле month указано относительное количество месяцев
        /// </summary>
        [JsonProperty("month_is_relative")]
        public bool MonthIsRelative { get; set; }

        /// <summary>
        /// День
        /// </summary>
        [JsonProperty("day")]
        public int Day { get; set; }

        /// <summary>
        /// Признак того, что в поле day указано относительное количество дней
        /// </summary>
        [JsonProperty("day_is_relative")]
        public bool DayIsRelative { get; set; }

        /// <summary>
        /// Час
        /// </summary>
        [JsonProperty("hour")]
        public int Hour { get; set; }

        /// <summary>
        /// Признак того, что в поле hour указано относительное количество часов
        /// </summary>
        [JsonProperty("hour_is_relative")]
        public bool HourIsRelative { get; set; }

        /// <summary>
        /// минута
        /// </summary>
        [JsonProperty("minute")]
        public int Minute { get; set; }

        /// <summary>
        /// Признак того, что в поле minute указано относительное количество минут
        /// </summary>
        [JsonProperty("minute_is_relative")]
        public bool MinuteIsRelative { get; set; }
    }
}
