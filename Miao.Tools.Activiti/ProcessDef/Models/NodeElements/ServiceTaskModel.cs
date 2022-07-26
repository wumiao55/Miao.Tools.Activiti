using Miao.Tools.Activiti.ProcessDef.Attributes;
using Miao.Tools.Activiti.ProcessDef.Models.ComponentElements;

namespace Miao.Tools.Activiti.ProcessDef.Models.NodeElements
{
    /// <summary>
    /// xml element: serviceTask
    /// </summary>
    public class ServiceTaskModel : BPMNNodeElementModel
    {
        private static readonly string _elementName = "serviceTask";

        /// <summary>
        /// 构造方法
        /// </summary>
        public ServiceTaskModel()
        {
            this.Id = GenerateElementId();
            this.ElementName = _elementName;
        }

        /// <summary>
        /// 设置文档
        /// </summary>
        /// <param name="documentation">文档</param>
        public ServiceTaskModel SetDocumentation(string documentation)
        {
            this.Documentation = new DocumentationModel(documentation);
            return this;
        }

        /// <summary>
        /// 设置类
        /// </summary>
        /// <param name="cls">类, </param>
        /// <returns></returns>
        public ServiceTaskModel SetClass(string cls)
        {
            this.Class = cls;
            return this;
        }

        /// <summary>
        /// 设置表达式
        /// </summary>
        /// <param name="expression">表达式, 如: #{split.ready}</param>
        /// <returns></returns>
        public ServiceTaskModel SetExpression(string expression)
        {
            this.Expression = expression;
            return this;
        }

        /// <summary>
        /// 设置委托表达式
        /// </summary>
        /// <param name="delegateExpression">委托表达式: 如: ${delegateExpressionBean}</param>
        /// <returns></returns>
        public ServiceTaskModel SetDelegateExpression(string delegateExpression)
        {
            this.DelegateExpression = delegateExpression;
            return this;
        }

        /// <summary>
        /// 名称
        /// </summary>
        [ElementProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 类
        /// </summary>
        [ElementProperty("activiti:class", false)]
        public string Class { get; set; }

        /// <summary>
        /// 表达式, 如: #{split.ready}
        /// </summary>
        [ElementProperty("activiti:expression", false)]
        public string Expression { get; set; }

        /// <summary>
        /// 委托表达式: 如: ${delegateExpressionBean}
        /// </summary>
        [ElementProperty("activiti:delegateExpression", false)]
        public string DelegateExpression { get; set; }

        /// <summary>
        /// 结果变量名称
        /// </summary>
        [ElementProperty("activiti:resultVariableName", false)]
        public string ResultVariableName { get; set; }

        /// <summary>
        /// 文档
        /// </summary>
        [ChildElement]
        public DocumentationModel Documentation { get; set; }
    }
}
