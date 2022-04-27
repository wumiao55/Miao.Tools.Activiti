using Miao.Tools.Activiti.ProcessDef.Attributes;
using Miao.Tools.Activiti.ProcessDef.Models.ComponentElements;
using System;
using System.Text;

namespace Miao.Tools.Activiti.ProcessDef.Models.NodeElements
{
    /// <summary>
    /// xml element: exclusiveGateway
    /// </summary>
    public class ExclusiveGatewayModel : BPMNNodeElementModel
    {
        private static readonly string _elementName = "exclusiveGateway";

        /// <summary>
        /// 构造方法
        /// </summary>
        public ExclusiveGatewayModel()
        {
            Id = GenerateElementId();
            ElementName = _elementName;
        }

        /// <summary>
        /// 设置文档
        /// </summary>
        /// <param name="documentation">文档</param>
        public void SetDocumentation(string documentation)
        {
            Documentation = new DocumentationModel(documentation);
        }

        /// <summary>
        /// 名称
        /// </summary>
        [ElementProperty("name", false)]
        public string Name { get; set; }

        /// <summary>
        /// 文档
        /// </summary>
        [ChildElement]
        public DocumentationModel Documentation { get; set; }
    }
}
