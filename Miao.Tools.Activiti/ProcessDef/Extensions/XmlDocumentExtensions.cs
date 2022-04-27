using Miao.Tools.Activiti.Extensions;
using Miao.Tools.Activiti.ProcessDef.Attributes;
using Miao.Tools.Activiti.ProcessDef.Models;
using Miao.Tools.Activiti.ProcessDef.Models.ComponentElements;
using Miao.Tools.Activiti.ProcessDef.Models.NodeElements;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Xml;

namespace Miao.Tools.Activiti.ProcessDef.Extensions
{
    /// <summary>
    /// XmlDocument扩展方法类
    /// </summary>
    public static class XmlDocumentExtensions
    {
        private static readonly IDictionary<string, string> XmlNameSpaceMaps = new Dictionary<string, string>
        {
            {"xmlns" , "http://www.omg.org/spec/BPMN/20100524/MODEL" },
            {"xsi" , "http://www.w3.org/2001/XMLSchema-instance" },
            {"xsd" , "http://www.w3.org/2001/XMLSchema" },
            {"activiti" , "http://activiti.org/bpmn" },
            {"bpmndi" , "http://www.omg.org/spec/BPMN/20100524/DI" },
            {"omgdc" , "http://www.omg.org/spec/DD/20100524/DC" },
            {"omgdi" , "http://www.omg.org/spec/DD/20100524/DI" },
            {"modeler" , "http://activiti.com/modeler" }
        };

        /// <summary>
        /// 创建节点
        /// </summary>
        /// <param name="xmldoc"></param>
        /// <param name="elementModel"></param>
        /// <returns></returns>
        public static XmlElement CreateElement(this XmlDocument xmldoc, BPMNElementModel elementModel)
        {
            if (elementModel == null)
            {
                return null;
            }

            XmlElement element;
            // 处理元素节点命名空间
            if (elementModel.ElementName.Contains(":"))
            {
                string elementNameSpace = elementModel.ElementName.Split(new char[] { ':' })[0];
                element = xmldoc.CreateElement(elementModel.ElementName, XmlNameSpaceMaps[elementNameSpace]);
            }
            else
            {
                element = xmldoc.CreateElement(elementModel.ElementName);
            }

            // element innerText
            if (!string.IsNullOrEmpty(elementModel.InnerText))
            {
                if (elementModel.CData)
                {
                    var cdataSection = xmldoc.CreateCDataSection(elementModel.InnerText);
                    element.AppendChild(cdataSection);
                }
                else
                {
                    element.InnerText = elementModel.InnerText;
                }
            }

            // element innerXml
            if (!string.IsNullOrEmpty(elementModel.InnerXml))
            {
                element.InnerXml = element.InnerXml;
            }

            // element attributes
            var propertities = elementModel.GetType().GetProperties();
            foreach (PropertyInfo pi in propertities)
            {
                var propertyValue = pi.GetValue(elementModel);

                // 处理ElementProperty特性
                ElementPropertyAttribute elementProperty = Attribute.GetCustomAttribute(pi, typeof(ElementPropertyAttribute)) as ElementPropertyAttribute;
                if (elementProperty != null && !string.IsNullOrEmpty(elementProperty.Name))
                {
                    // 非必需的属性
                    if (!elementProperty.Required && propertyValue == null)
                    {
                        continue;
                    }

                    string propertyName = elementProperty.Name;
                    // 处理元素属性命名空间
                    if (propertyName.Contains(":"))
                    {
                        string elementAttributeNamespace = propertyName.Split(new char[] { ':' })[0];
                        string elementAttributeName = propertyName.Split(new char[] { ':' })[1];
                        element.SetAttribute(elementAttributeName, XmlNameSpaceMaps[elementAttributeNamespace], propertyValue?.ToString());
                    }
                    else
                    {
                        string elementAttributeName = propertyName;
                        element.SetAttribute(elementAttributeName, propertyValue?.ToString());
                    }
                }

                //处理ChildElementAttribute特性
                ChildElementAttribute childElementAttribute = Attribute.GetCustomAttribute(pi, typeof(ChildElementAttribute)) as ChildElementAttribute;
                if (childElementAttribute == null || propertyValue == null)
                {
                    continue;
                }
                if (propertyValue.GetType().IsSubclassOf(typeof(BPMNElementModel)))
                {
                    var childElement = xmldoc.CreateElement((BPMNElementModel)propertyValue);
                    element.AppendChild(childElement);
                }
                else if (typeof(IEnumerable).IsAssignableFrom(propertyValue.GetType()))
                {
                    var enumerator = (propertyValue as IEnumerable).GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        var currentType = enumerator.Current.GetType();
                        if (currentType.IsSubclassOf(typeof(BPMNElementModel)))
                        {
                            var childElement = xmldoc.CreateElement((BPMNElementModel)enumerator.Current);
                            element.AppendChild(childElement);
                        }
                    }
                }
            }

            return element;
        }

        /// <summary>
        /// 创建XmlDefinitions节点
        /// </summary>
        /// <param name="xmldoc"></param>
        /// <param name="definitionsElement"></param>
        /// <returns></returns>
        public static XmlElement CreateDefinitions(this XmlDocument xmldoc, DefinitionsModel definitionsElement)
        {
            var element = xmldoc.CreateElement(definitionsElement.ElementName);
            element.SetAttribute("xmlns", XmlNameSpaceMaps["xmlns"]);
            element.SetAttribute("xmlns:xsi", XmlNameSpaceMaps["xsi"]);
            element.SetAttribute("xmlns:xsd", XmlNameSpaceMaps["xsd"]);
            element.SetAttribute("xmlns:activiti", XmlNameSpaceMaps["activiti"]);
            element.SetAttribute("xmlns:bpmndi", XmlNameSpaceMaps["bpmndi"]);
            element.SetAttribute("xmlns:omgdc", XmlNameSpaceMaps["omgdc"]);
            element.SetAttribute("xmlns:omgdi", XmlNameSpaceMaps["omgdi"]);
            element.SetAttribute("typeLanguage", "http://www.w3.org/2001/XMLSchema");
            element.SetAttribute("expressionLanguage", "http://www.w3.org/1999/XPath");
            element.SetAttribute("targetNamespace", "http://www.activiti.org/processdef");
            return element;
        }

        /// <summary>
        /// 生成BPMN流程部署xml文件
        /// </summary>
        /// <param name="xmldoc"></param>
        /// <param name="savePath"></param>
        /// <param name="processDefData"></param>
        public static void GenerateBPMNXml(this XmlDocument xmldoc, string savePath, ProcessDefModel processDefData)
        {
            processDefData.CheckPropertiesNotNull();
            if (processDefData.NodeElements == null || processDefData.NodeElements.Count <= 0)
            {
                throw new ArgumentException("流程定义节点为空");
            }
            if (!(processDefData.NodeElements[0] is StartEventModel))
            {
                throw new Exception("流程定义节点集合中第一个元素必须是'StartEventModel'实例");
            }

            // version
            XmlDeclaration xmldec = xmldoc.CreateXmlDeclaration("1.0", "UTF-8", null);
            xmldoc.AppendChild(xmldec);
            // definitions
            var definitionsNode = xmldoc.CreateDefinitions(new DefinitionsModel());
            xmldoc.AppendChild(definitionsNode);
            // process
            var processModel = new ProcessModel(processDefData.ProcessDefKey, processDefData.ProcessName);
            processModel.SetDocumentation(processDefData.Description);
            var processNode = xmldoc.CreateElement(processModel);
            definitionsNode.AppendChild(processNode);

            // 生成流程节点
            XmlNode currentNode = processNode.LastChild;
            string currentRef = string.Empty;
            var elementDatas = processDefData.NodeElements;
            for (int i = 0; i < elementDatas.Count; i++)
            {
                string elementDataId = elementDatas[i].Id;
                // 插入节点
                var nodeElement = xmldoc.CreateElement(elementDatas[i]);
                currentNode = processNode.InsertAfter(nodeElement, currentNode);
                if (string.IsNullOrEmpty(currentRef))
                {
                    currentRef = elementDataId;
                    continue;
                }
                // 连接节点
                if (elementDatas[i] is ExclusiveGatewayModel)
                {
                    // "不通过"回退上一节点
                    SequenceFlowModel backSequenceFlowModel
                        = new SequenceFlowModel("不通过", elementDataId, elementDatas[i - 1].Id, "${AuditResult=='不通过'}", new ExecutionListenerModel());
                    var backSequenceFlow = xmldoc.CreateElement(backSequenceFlowModel);
                    currentNode = processNode.InsertAfter(backSequenceFlow, currentNode);
                }
                SequenceFlowModel sequenceFlowModel = elementDatas[i - 1] is ExclusiveGatewayModel
                    ? new SequenceFlowModel("通过", currentRef, elementDataId, "${AuditResult=='通过'}", new ExecutionListenerModel())
                    : new SequenceFlowModel("提交", currentRef, elementDataId, new ExecutionListenerModel());
                var sequenceFlow = xmldoc.CreateElement(sequenceFlowModel);
                currentNode = processNode.InsertAfter(sequenceFlow, currentNode);
                currentRef = elementDataId;
            }

            using var sw = new StreamWriter(savePath, false, new UTF8Encoding(false));
            xmldoc.Save(sw);
        }

    }
}
