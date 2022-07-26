using Miao.Tools.Activiti.Extensions;
using Miao.Tools.Activiti.Form.Enums;

namespace Miao.Tools.Activiti.Form.Models
{
    /// <summary>
    /// 日期
    /// </summary>
    public class DateElement : BaseFormElement
    {
        private readonly FormFieldType _formFieldType = FormFieldType.FormField;
        private readonly FormElementType _formElementType = FormElementType.Date;

        /// <summary>
        /// 构造方法
        /// </summary>
        public DateElement()
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
        public DateElement(string id, string name, bool required) : this()
        {
            this.Id = id;
            this.OverrideId = true;
            this.Name = name;
            this.Required = required;
            this.Placeholder = $"请选择{name}";
        }
    }
}
