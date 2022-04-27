using Miao.Tools.Activiti.Extensions;
using Miao.Tools.Activiti.Form.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Miao.Tools.Activiti.Form.Models
{
    /// <summary>
    /// 普通文本框
    /// </summary>
    public class TextElement : BaseFormElement
    {
        private readonly FormFieldType _formFieldType = FormFieldType.FormField;
        private readonly FormElementType _formElementType = FormElementType.Text;

        /// <summary>
        /// 构造方法
        /// </summary>
        public TextElement()
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
        public TextElement(string id, string name, bool required) : this()
        {
            Id = id;
            OverrideId = true;
            Name = name;
            Required = required;
            Placeholder = $"请填写{name}";
        }
    }
}
