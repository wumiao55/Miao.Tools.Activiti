using Miao.Tools.Activiti.Extensions;
using Miao.Tools.Activiti.Form.Enums;

namespace Miao.Tools.Activiti.Form.Models
{
    /// <summary>
    /// 多行文本框
    /// </summary>
    public class MultilineTextElement : BaseFormElement
    {
        private readonly FormFieldType _formFieldType = FormFieldType.FormField;
        private readonly FormElementType _formElementType = FormElementType.MultiLineText;

        /// <summary>
        /// 构造方法
        /// </summary>
        public MultilineTextElement()
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
        public MultilineTextElement(string id, string name, bool required) : this()
        {
            this.Id = id;
            this.OverrideId = true;
            this.Name = name;
            this.Required = required;
            this.Placeholder = $"请填写{name}";
        }
    }
}
