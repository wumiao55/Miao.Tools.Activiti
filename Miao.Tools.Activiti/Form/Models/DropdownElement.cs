using Miao.Tools.Activiti.Extensions;
using Miao.Tools.Activiti.Form;
using Miao.Tools.Activiti.Form.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

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
            FieldType = _formFieldType.GetDescription();
            Type = _formElementType.GetDescription();
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
            Id = id;
            OverrideId = true;
            Name = name;
            Required = required;
            Placeholder = $"请选择{name}";
            Options = options;
            if (options != null && options.Count > 0)
            {
                HasEmptyValue = true;
                Value = options[0].Id;
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
