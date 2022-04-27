using Miao.Tools.Activiti.Form.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Miao.Tools.Activiti.Form
{
    /// <summary>
    /// ActivitiForm
    /// </summary>
    public class ActivitiForm
    {
        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="name"></param>
        /// <param name="key"></param>
        /// <param name="version"></param>
        public ActivitiForm(string name, string key, int version)
        {
            Name = name;
            Key = key;
            Version = version;
        }

        /// <summary>
        /// 添加字段
        /// </summary>
        /// <param name="formElements"></param>
        public void AddFields(params BaseFormElement[] formElements)
        {
            Fields.AddRange(formElements);
        }

        /// <summary>
        /// 添加Outcoumes
        /// </summary>
        /// <param name="outcomes"></param>
        public void AddOutcomes(params ElementOptions[] outcomes)
        {
            Outcomes.AddRange(outcomes);
        }

        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Key
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; set; }

        /// <summary>
        /// Version
        /// </summary>
        [JsonProperty("version")]
        public int Version { get; set; }

        /// <summary>
        /// Fields
        /// </summary>
        [JsonProperty("fields")]
        public List<BaseFormElement> Fields { get; protected set; } = new List<BaseFormElement>();

        /// <summary>
        /// Outcomes
        /// </summary>
        [JsonProperty("outcomes")]
        public List<ElementOptions> Outcomes { get; protected set; } = new List<ElementOptions>();
    }
}
