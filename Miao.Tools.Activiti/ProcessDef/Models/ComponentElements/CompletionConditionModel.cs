namespace Miao.Tools.Activiti.ProcessDef.Models.ComponentElements
{
    /// <summary>
    /// xml element: completionCondition
    /// </summary>
    public class CompletionConditionModel : BPMNElementModel
    {
        private static readonly string _elementName = "completionCondition";

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="completionCondition">完成条件, 如: ${nrOfCompletedInstances/nrOfInstances >= 0.6 } </param>
        public CompletionConditionModel(string completionCondition)
        {
            this.ElementName = _elementName;
            this.InnerText = completionCondition;
        }
    }
}
