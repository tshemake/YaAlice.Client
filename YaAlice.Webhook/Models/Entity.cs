using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace YaAlice.Webhook.Models
{
    using YaAlice.Webhook.Models.Types;

    public class Entity
    {
        /// <summary>
        /// Обозначение начала и конца именованной сущности в массиве слов
        /// </summary>
        [JsonProperty("tokens")]
        public Tokens Tokens { get; set; }

        /// <summary>
        /// Тип именованной сущности
        /// </summary>
        public Types.ValueType Type { get; set; }

        /// <summary>
        /// Формальное описание именованной сущности
        /// </summary>
        [JsonProperty("value")]
        public object ValueRaw { get; set; }

        [JsonIgnore]
        public Value Value
        {
            get
            {
                Value value = null;
                switch (Type)
                {
                    case ValueType.FIO:
                        value = JsonConvert.DeserializeObject<Fio>(ValueRaw.ToString());
                        break;
                    case ValueType.DATETIME:
                        value = JsonConvert.DeserializeObject<DateTime>(ValueRaw.ToString());
                        break;
                    case ValueType.GEO:
                        value = JsonConvert.DeserializeObject<Geo>(ValueRaw.ToString());
                        break;
                    case ValueType.NUMBER:
                        if (double.TryParse(ValueRaw.ToString(), out var number))
                            value = new Number { Value = number };
                        break;
                }

                return value;
            }
        }
    }
}
