using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Miao.Tools.Activiti.Form
{
    /// <summary>
    /// ElementParams
    /// </summary>
    public class ElementParams
    {
        /// <summary>
        /// Multiple
        /// </summary>
        [JsonProperty("multiple")]
        public bool Multiple { get; set; }
    }
}
