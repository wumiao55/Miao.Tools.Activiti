using Miao.Tools.Activiti.ProcessDef.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Miao.Tools.Activiti.ProcessDef.Models.ComponentElements
{
    /// <summary>
    /// xml element: activiti:value
    /// </summary>
    public class ActivitiValueModel : BPMNElementModel
    {
        private static readonly string _elementName = "activiti:value";

        /// <summary>
        /// 构造方法
        /// </summary>
        public ActivitiValueModel()
        {
            ElementName = _elementName;
        }

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="name">名称</param>
        public ActivitiValueModel(string id, string name) : this()
        {
            Id = id;
            Name = name;
        }

        /// <summary>
        /// id
        /// </summary>
        [ElementProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [ElementProperty("name")]
        public string Name { get; set; }
    }
}
