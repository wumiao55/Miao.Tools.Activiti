using Newtonsoft.Json;

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
