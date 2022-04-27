using Miao.Tools.Activiti.ProcessDef.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Miao.Tools.Activiti.ProcessDef.Models.ComponentElements
{
    /// <summary>
    /// xml element: conditionExpression
    /// </summary>
    public class ConditionExpressionModel : BPMNElementModel
    {
        private static readonly string _elementName = "conditionExpression";
        private static readonly string _defaultType = "tFormalExpression";

        /// <summary>
        /// 构造方法
        /// </summary>
        public ConditionExpressionModel()
        {
            ElementName = _elementName;
            CData = true;
            Type = _defaultType;
        }

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="innerText">内部文本</param>
        public ConditionExpressionModel(string innerText) : this()
        {
            InnerText = innerText;
        }

        /// <summary>
        /// 表达式类型
        /// </summary>
        [ElementProperty("xsi:type")]
        public string Type { get; set; }
    }
}
