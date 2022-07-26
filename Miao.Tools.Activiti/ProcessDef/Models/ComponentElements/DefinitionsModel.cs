namespace Miao.Tools.Activiti.ProcessDef.Models.ComponentElements
{
    /// <summary>
    /// xml element: definitions
    /// </summary>
    public class DefinitionsModel : BPMNElementModel
    {
        private static readonly string _elementName = "definitions";

        /// <summary>
        /// 构造方法
        /// </summary>
        public DefinitionsModel()
        {
            this.ElementName = _elementName;
        }
    }
}
