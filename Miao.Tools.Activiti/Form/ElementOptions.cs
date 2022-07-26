using Newtonsoft.Json;

namespace Miao.Tools.Activiti.Form
{
    /// <summary>
    /// ElementOptions
    /// </summary>
    public class ElementOptions
    {
        /// <summary>
        /// 构造方法
        /// </summary>
        public ElementOptions() { }

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        public ElementOptions(string id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        /// <summary>
        /// Id
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
