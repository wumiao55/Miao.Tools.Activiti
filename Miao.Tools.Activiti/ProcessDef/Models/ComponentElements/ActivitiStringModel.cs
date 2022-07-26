namespace Miao.Tools.Activiti.ProcessDef.Models.ComponentElements
{
    /// <summary>
    ///  xml element: activiti:string
    /// </summary>
    public class ActivitiStringModel : BPMNElementModel
    {
        private static readonly string _elementName = "activiti:string";

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="str"></param>
        public ActivitiStringModel(string str)
        {
            this.ElementName = _elementName;
            this.CData = true;
            this.InnerText = str;
        }
    }
}
