using System.Collections.Generic;
using Miao.Tools.Activiti.Extensions;
using Miao.Tools.Activiti.ProcessDef.Attributes;
using Miao.Tools.Activiti.ProcessDef.Enums;

namespace Miao.Tools.Activiti.ProcessDef.Models.ComponentElements
{
    /// <summary>
    /// xml element: activiti:formProperty
    /// </summary>
    public class FormPropertyModel : BPMNElementModel
    {
        private static readonly string _elementName = "activiti:formProperty";
        private static readonly string _defaultDatePattern = "MM-dd-yyyy hh:mm";

        /// <summary>
        /// 构造方法
        /// </summary>
        public FormPropertyModel()
        {
            this.ElementName = _elementName;
        }

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="name">名称</param>
        /// <param name="formPropertyType">表单属性类型</param>
        /// <param name="required">是否必须</param>
        public FormPropertyModel(string id, string name, FormPropertyType formPropertyType, bool required = false) : this()
        {
            this.Id = id;
            this.Name = name;
            this.Type = formPropertyType.GetDescription();
            if(formPropertyType == FormPropertyType.Date)
            {
                this.DatePattern = _defaultDatePattern;
            }
            if (required)
            {
                this.Required = required.ToLowerString();
            }
        }

        /// <summary>
        /// id
        /// </summary>
        [ElementProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [ElementProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 类型(string/boolean/long/enum/date)
        /// </summary>
        [ElementProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// 变量名称
        /// </summary>
        [ElementProperty("variable", false)]
        public string Variable { get; set; }

        /// <summary>
        /// 日期格式
        /// </summary>
        [ElementProperty("datePattern", false)]
        public string DatePattern { get; set; }

        /// <summary>
        /// 表达式
        /// </summary>
        [ElementProperty("expression", false)]
        public string Expression { get; set; }

        /// <summary>
        /// 是否必须(true/false)
        /// </summary>
        [ElementProperty("required", false)]
        public string Required { get; set; }

        /// <summary>
        /// 是否可读(true/false)
        /// </summary>
        [ElementProperty("required", false)]
        public string Readable { get; set; }

        /// <summary>
        /// 是否可写(true/false)
        /// </summary>
        [ElementProperty("required", false)]
        public string Writable { get; set; }

        /// <summary>
        /// 值
        /// </summary>
        [ChildElement]
        public IEnumerable<ActivitiValueModel> Values { get; set; }

    }
}
