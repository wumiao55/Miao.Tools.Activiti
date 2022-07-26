using System.Collections.Generic;
using Newtonsoft.Json;
using Miao.Tools.Activiti.Extensions;
using Miao.Tools.Activiti.Form.Enums;


namespace Miao.Tools.Activiti.Form.Models
{
    /// <summary>
    /// 下拉框
    /// </summary>
    public class DropdownElement : BaseFormElement
    {
        private readonly FormFieldType _formFieldType = FormFieldType.OptionFormField;
        private readonly FormElementType _formElementType = FormElementType.Dropdown;

        /// <summary>
        /// 构造方法
        /// </summary>
        public DropdownElement()
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
        /// <param name="options"></param>
        public DropdownElement(string id, string name, bool required, List<ElementOptions> options) : this() 
        {
            this.Id = id;
            this.OverrideId = true;
            this.Name = name;
            this.Required = required;
            this.Placeholder = $"请选择{name}";
            this.Options = options;
            if(options != null && options.Count > 0)
            {
                this.HasEmptyValue = true;
                this.Value = options[0].Id;
            }
        }

        /// <summary>
        /// OptionType
        /// </summary>
        [JsonProperty("optionType")]
        public string OptionType { get; set; }

        /// <summary>
        /// HasEmptyValue
        /// </summary>
        [JsonProperty("hasEmptyValue")]
        public bool? HasEmptyValue { get; set; }

        /// <summary>
        /// Options
        /// </summary>
        [JsonProperty("options")]
        public List<ElementOptions> Options { get; set; }
    }
}
