using System;
using System.Collections.Generic;
using System.Text;

namespace Miao.Tools.Activiti.ProcessDef.Models.ComponentElements
{
    /// <summary>
    /// xml element: documentation
    /// </summary>
    public class DocumentationModel : BPMNElementModel
    {
        private static readonly string _elementName = "documentation";

        /// <summary>
        /// 构造方法
        /// </summary>
        public DocumentationModel()
        {
            ElementName = _elementName;
        }

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="innerText">内部文本</param>
        public DocumentationModel(string innerText) : this()
        {
            InnerText = innerText;
        }
    }
}
