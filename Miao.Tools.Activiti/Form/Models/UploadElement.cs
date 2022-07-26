using Newtonsoft.Json;
using Miao.Tools.Activiti.Extensions;
using Miao.Tools.Activiti.Form.Enums;

namespace Miao.Tools.Activiti.Form.Models
{
    /// <summary>
    /// 附件
    /// </summary>
    public class UploadElement : BaseFormElement
    {
        private readonly FormFieldType _formFieldType = FormFieldType.FormField;
        private readonly FormElementType _formElementType = FormElementType.Upload;

        /// <summary>
        /// 构造方法
        /// </summary>
        public UploadElement()
        {
            this.FieldType = _formFieldType.GetDescription();
            this.Type = _formElementType.GetDescription();
        }

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="required"></param>
        /// <param name="multiple"></param>
        public UploadElement(string id, string name, bool required, bool multiple) : this()
        {
            this.Id = id;
            this.OverrideId = true;
            this.Name = name;
            this.Required = required;
            this.Placeholder = $"请上传{name}";
            this.Params.Multiple = multiple;
        }

        /// <summary>
        /// Params
        /// </summary>
        [JsonProperty("params")]
        public ElementParams Params { get; set; } = new ElementParams();
    }
}
