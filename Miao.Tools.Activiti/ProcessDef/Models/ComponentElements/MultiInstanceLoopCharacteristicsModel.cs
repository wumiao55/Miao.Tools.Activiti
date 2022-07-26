using Miao.Tools.Activiti.Extensions;
using Miao.Tools.Activiti.ProcessDef.Attributes;

namespace Miao.Tools.Activiti.ProcessDef.Models.ComponentElements
{
    /// <summary>
    /// xml element: multiInstanceLoopCharacteristics
    /// </summary>
    public class MultiInstanceLoopCharacteristicsModel : BPMNElementModel
    {
        private static readonly string _elementName = "multiInstanceLoopCharacteristics";

        /// <summary>
        /// 构造方法
        /// </summary>
        public MultiInstanceLoopCharacteristicsModel()
        {
            this.ElementName = _elementName;
        }

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="isSequential">是否串行方式</param>
        /// <param name="collection">变量集合, 如: assigneeList</param>
        /// <param name="elementVariable">变量元素, 如: assignee</param>
        public MultiInstanceLoopCharacteristicsModel(bool isSequential, string collection, string elementVariable) : this()
        {
            this.IsSequential = isSequential.ToLowerString();
            this.Collection = collection;
            this.ElementVariable = elementVariable;
        }

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="isSequential">是否串行方式</param>
        /// <param name="collection">变量集合, 如: assigneeList</param>
        /// <param name="elementVariable">变量元素, 如: assignee</param>
        /// <param name="completionCondition">完成条件, 如: ${nrOfCompletedInstances/nrOfInstances >= 0.6 }</param>
        public MultiInstanceLoopCharacteristicsModel(bool isSequential, string collection, string elementVariable, string completionCondition) : this()
        {
            this.IsSequential = isSequential.ToLowerString();
            this.Collection = collection;
            this.ElementVariable = elementVariable;
            this.CompletionCondition = new CompletionConditionModel(completionCondition);
        }

        /// <summary>
        /// 设置完成条件
        /// </summary>
        /// <param name="completionCondition">完成条件, 如: ${nrOfCompletedInstances/nrOfInstances >= 0.6 }</param>
        public MultiInstanceLoopCharacteristicsModel SetCompletionCondition(string completionCondition)
        {
            this.CompletionCondition = new CompletionConditionModel(completionCondition);
            return this;
        }

        /// <summary>
        /// 是否串行方式
        /// </summary>
        [ElementProperty("isSequential")]
        public string IsSequential { get; set; }

        /// <summary>
        /// 变量集合, 如: assigneeList
        /// </summary>
        [ElementProperty("activiti:collection")]
        public string Collection { get; set; }

        /// <summary>
        /// 变量元素, 如: assignee
        /// </summary>
        [ElementProperty("activiti:elementVariable")]
        public string ElementVariable { get; set; }

        /// <summary>
        /// 完成条件
        /// </summary>
        [ChildElement]
        public CompletionConditionModel CompletionCondition { get; set; }
    }
}
