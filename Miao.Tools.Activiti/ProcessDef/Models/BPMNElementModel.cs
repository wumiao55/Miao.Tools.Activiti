using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using Miao.Tools.Activiti.ProcessDef.Extensions;

namespace Miao.Tools.Activiti.ProcessDef.Models
{
    /// <summary>
    /// BPMN元素
    /// </summary>
    public abstract class BPMNElementModel
    {
        /// <summary>
        /// 元素名称
        /// </summary>
        public string ElementName { get; protected set; }

        /// <summary>
        /// 内部文本
        /// </summary>
        public string InnerText { get; set; }

        /// <summary>
        /// 是否使用&lt;![CDATA[xxx]]&gt;格式标记内容
        /// </summary>
        public bool CData { get; set; }

        /// <summary>
        /// 内部Xml
        /// </summary>
        public string InnerXml { get; set; }

        /// <summary>
        /// 生成元素唯一id
        /// </summary>
        /// <returns></returns>
        protected string GenerateElementId()
        {
            return $"sid-{Guid.NewGuid().ToString().ToUpper()}";
        }

        /// <summary>
        /// 是否是 'NCName' 的有效值
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        protected bool IsValidNCName(string value)
        {
            /*
               NCName 以字母或下划线 (_) 字符开头，
               后接 XML 规范中允许的任意字母、数字、重音字符、变音符号、句点 (.)、连字符 (-) 和下划线 (_) 的组合
            */
            var regex = new Regex("^([a-z]+|[A-Z]+|[_]+).*");
            return regex.IsMatch(value);
        }

        /// <summary>
        /// 转化为Xml元素
        /// </summary>
        /// <param name="xmldoc"></param>
        /// <returns></returns>
        public XmlElement ToXmlElement(XmlDocument xmldoc)
        {
            return xmldoc.CreateElement(this);
        }

        /// <summary>
        /// 转化为字符串
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            var xmldoc = new XmlDocument();
            xmldoc.AppendChild(xmldoc.CreateElement(this));
            using var ms = new MemoryStream();
            xmldoc.Save(ms);
            return Encoding.UTF8.GetString(ms.ToArray());
        }
    }
}
