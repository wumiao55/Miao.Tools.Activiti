using Newtonsoft.Json;

namespace Miao.Tools.Activiti.Form.Models
{
    /// <summary>
    /// 基础表单元素
    /// </summary>
    public abstract class BaseFormElement
    {
        /// <summary>
        /// FieldType
        /// </summary>
        [JsonProperty("fieldType")]
        public string FieldType { get; set; }

        /// <summary>
        /// Id
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Value
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("required")]
        public bool Required { get; set; }

        /// <summary>
        /// ReadOnly
        /// </summary>
        [JsonProperty("readOnly")]
        public bool ReadOnly { get; set; }

        /// <summary>
        /// OverrideId
        /// </summary>
        [JsonProperty("overrideId")]
        public bool OverrideId { get; set; }

        /// <summary>
        /// Placeholder
        /// </summary>
        [JsonProperty("placeholder")]
        public string Placeholder { get; set; }

        /// <summary>
        /// Layout
        /// </summary>
        [JsonProperty("layout")]
        public string Layout { get; set; }

        /// <summary>
        /// SizeX
        /// </summary>
        [JsonProperty("sizeX")]
        public int SizeX { get; set; }

        /// <summary>
        /// SizeY
        /// </summary>
        [JsonProperty("sizeY")]
        public int SizeY { get; set; }
    }
}
