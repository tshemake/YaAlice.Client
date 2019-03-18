using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YaAlice.Webhook.Models.Types
{
    /// <summary>
    /// Тип ввода
    /// </summary>
    public enum RequestType
    {
        /// <summary>
        /// Неизвестный тип сообщения
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// Голосовой ввод
        /// </summary>
        SimpleUtterance,

        /// <summary>
        /// Нажатие кнопки
        /// </summary>
        ButtonPressed,
    }
}
