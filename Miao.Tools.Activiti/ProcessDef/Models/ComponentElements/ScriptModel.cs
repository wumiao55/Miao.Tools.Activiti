namespace Miao.Tools.Activiti.ProcessDef.Models.ComponentElements
{
    /// <summary>
    /// xml element: script
    /// </summary>
    public class ScriptModel : BPMNElementModel
    {
        private static readonly string _elementName = "script";

        /// <summary>
        /// 构造方法
        /// </summary>
        public ScriptModel()
        {
            this.ElementName = _elementName;
            this.CData = true;
        }

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="script">脚本内容</param>
        public ScriptModel(string script) : this()
        {
            this.InnerText = script;
        }
    }
}
