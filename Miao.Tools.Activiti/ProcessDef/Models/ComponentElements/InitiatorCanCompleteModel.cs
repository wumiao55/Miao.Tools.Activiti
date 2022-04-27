using Miao.Tools.Activiti.Extensions;
using System;
using System.Text;

namespace Miao.Tools.Activiti.ProcessDef.Models.ComponentElements
{
    /// <summary>
    /// xml element: modeler:initiator-can-complete
    /// </summary>
    public class InitiatorCanCompleteModel : BPMNElementModel
    {
        private static readonly string _elementName = "modeler:initiator-can-complete";

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="initiatorCanComplete">初始人是否可以完成</param>
        public InitiatorCanCompleteModel(bool initiatorCanComplete = false)
        {
            ElementName = _elementName;
            CData = true;
            InnerText = initiatorCanComplete.ToLowerString();
        }

        //[ElementProperty("xmlns:modeler")]
        //public string Modeler { get; set; } = "http://activiti.com/modeler";

    }
}
