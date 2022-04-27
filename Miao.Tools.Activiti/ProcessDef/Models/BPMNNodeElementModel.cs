using Miao.Tools.Activiti.ProcessDef.Attributes;
using System;
using System.Text;

namespace Miao.Tools.Activiti.ProcessDef.Models
{
    /// <summary>
    /// BPMN元素节点
    /// </summary>
    public abstract class BPMNNodeElementModel : BPMNElementModel
    {
        private string _id;

        /// <summary>
        /// id
        /// </summary>
        [ElementProperty("id")]
        public string Id
        {
            get
            {
                return _id;
            }
            set
            {
                if (!string.IsNullOrEmpty(value) &&
                    !IsValidNCName(value))
                {
                    throw new Exception($"'{GetType().Name} node id {value}' 不是 'NCName' 的有效值");
                }
                _id = value;
            }
        }
    }
}
