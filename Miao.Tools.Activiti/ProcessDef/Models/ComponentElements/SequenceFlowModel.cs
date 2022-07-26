using Miao.Tools.Activiti.ProcessDef.Attributes;
using Miao.Tools.Activiti.ProcessDef.Extensions;

namespace Miao.Tools.Activiti.ProcessDef.Models.ComponentElements
{
    /// <summary>
    /// xml element: sequenceFlow
    /// </summary>
    public class SequenceFlowModel : BPMNElementModel
    {
        private static readonly string _elementName = "sequenceFlow";

        /// <summary>
        /// 构造方法
        /// </summary>
        public SequenceFlowModel() 
        {
            this.Id = GenerateElementId();
            this.ElementName = _elementName;
        }

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="name">名称</param>
        /// <param name="sourceRef">源</param>
        /// <param name="targetRef">目标</param>
        public SequenceFlowModel(string name, string sourceRef, string targetRef) : this()
        {
            this.Name = name;
            this.SourceRef = sourceRef;
            this.TargetRef = targetRef;
        }

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="name">名称</param>
        /// <param name="sourceRef">源</param>
        /// <param name="targetRef">目标</param>
        /// <param name="conditionExpression">条件表达式, 如: ${AuditResult=='通过'} </param>
        public SequenceFlowModel(string name, string sourceRef, string targetRef, string conditionExpression)
            : this(name, sourceRef, targetRef)
        {
            this.ConditionExpression = new ConditionExpressionModel(conditionExpression);
        }

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="name">名称</param>
        /// <param name="sourceRef">源</param>
        /// <param name="targetRef">目标</param>
        /// <param name="executionListeners">执行监听器</param>
        public SequenceFlowModel(string name, string sourceRef, string targetRef, params ExecutionListenerModel[] executionListeners)
            : this(name, sourceRef, targetRef)
        {
            this.ExtensionElements = new ExtensionElementsModel(executionListeners);
        }

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="name">名称</param>
        /// <param name="sourceRef">源</param>
        /// <param name="targetRef">目标</param>
        /// <param name="conditionExpression">条件表达式, 如: ${AuditResult=='通过'} </param>
        /// <param name="executionListeners">执行监听器</param>
        public SequenceFlowModel(string name, string sourceRef, string targetRef, string conditionExpression, params ExecutionListenerModel[] executionListeners) 
            : this(name, sourceRef, targetRef)
        {
            this.ConditionExpression = new ConditionExpressionModel(conditionExpression);
            this.ExtensionElements = new ExtensionElementsModel(executionListeners);
        }

        /// <summary>
        /// 设置文档
        /// </summary>
        /// <param name="documentation">文档</param>
        public SequenceFlowModel SetDocumentation(string documentation)
        {
            this.Documentation = new DocumentationModel(documentation);
            return this;
        }

        /// <summary>
        /// 设置条件表达式
        /// </summary>
        /// <param name="conditionExpression">条件表达式, 如: ${AuditResult=='通过'}</param>
        public SequenceFlowModel SetConditionExpression(string conditionExpression)
        {
            this.ConditionExpression = new ConditionExpressionModel(conditionExpression);
            return this;
        }

        /// <summary>
        /// 添加执行监听器
        /// </summary>
        /// <param name="executionListeners">添加执行监听器</param>
        public SequenceFlowModel AddExecutionListeners(params ExecutionListenerModel[] executionListeners)
        {
            if(this.ExtensionElements == null)
            {
                this.ExtensionElements = new ExtensionElementsModel();
            }
            this.ExtensionElements.AddExecutionListeners(executionListeners);
            return this;
        }

        /// <summary>
        /// id
        /// </summary>
        [ElementProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [ElementProperty("name", false)]
        public string Name { get; set; }

        /// <summary>
        /// 源
        /// </summary>
        [ElementProperty("sourceRef")]
        public string SourceRef { get; set; }

        /// <summary>
        /// 目标
        /// </summary>
        [ElementProperty("targetRef")]
        public string TargetRef { get; set; }

        /// <summary>
        /// 文档
        /// </summary>
        [ChildElement]
        public DocumentationModel Documentation { get; set; }

        /// <summary>
        /// 扩展元素
        /// </summary>
        [ChildElement]
        public ExtensionElementsModel ExtensionElements { get; set; }

        /// <summary>
        /// 条件表达式
        /// </summary>
        [ChildElement]
        public ConditionExpressionModel ConditionExpression { get; set; }

    }
}
