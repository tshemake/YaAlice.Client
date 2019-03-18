using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YaAlice.Webhook.Models
{
    /// <summary>
    /// Число
    /// </summary>
    public class Number : Value
    {
        public double Value { get; set; }
    }
}
