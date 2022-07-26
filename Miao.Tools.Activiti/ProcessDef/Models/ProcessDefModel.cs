using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Miao.Tools.Activiti.ProcessDef.Models
{
    /// <summary>
    /// 流程定义模型
    /// </summary>
    public class ProcessDefModel
    {
        /// <summary>
        /// 流程定义key
        /// </summary>
        [Required]
        public string ProcessDefKey { get; set; }

        /// <summary>
        /// 流程定义名称
        /// </summary>
        [Required]
        public string ProcessName { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 流程节点
        /// </summary>
        [Required]
        public List<BPMNNodeElementModel> NodeElements { get; set; }

    }
}
