using System;
using System.Collections.Generic;
using System.Text;

namespace Miao.Tools.Activiti.ProcessDef.Attributes
{
    /// <summary>
    /// ElementPropertyAttribute
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class ElementPropertyAttribute : Attribute
    {
        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="name"></param>
        /// <param name="required"></param>
        public ElementPropertyAttribute(string name, bool required = true)
        {
            Name = name;
            Required = required;
        }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 是否必须
        /// </summary>
        public bool Required { get; set; }
    }
}
