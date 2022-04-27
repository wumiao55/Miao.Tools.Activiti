using Miao.Tools.Activiti.ProcessDef.Models.ComponentElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Miao.Tools.Activiti.ProcessDef.Extensions
{
    /// <summary>
    /// ExtensionElementsModel扩展方法类
    /// </summary>
    public static class ExtensionElementsExtensions
    {
        /// <summary>
        /// 添加执行监听器
        /// </summary>
        /// <param name="extensionElementsModel"></param>
        /// <param name="executionListeners"></param>
        public static void AddExecutionListeners(this ExtensionElementsModel extensionElementsModel, params ExecutionListenerModel[] executionListeners)
        {
            if (extensionElementsModel == null || executionListeners == null)
            {
                return;
            }
            if (extensionElementsModel.ExecutionListeners == null)
            {
                extensionElementsModel.ExecutionListeners = new List<ExecutionListenerModel>(executionListeners);
            }
            else
            {
                extensionElementsModel.ExecutionListeners = extensionElementsModel.ExecutionListeners.Concat(executionListeners);
            }
        }

        /// <summary>
        /// 添加事件监听器
        /// </summary>
        /// <param name="extensionElementsModel"></param>
        /// <param name="eventListeners"></param>
        public static void AddEventListeners(this ExtensionElementsModel extensionElementsModel, params EventListenerModel[] eventListeners)
        {
            if (extensionElementsModel == null || eventListeners == null)
            {
                return;
            }
            if (extensionElementsModel.EventListeners == null)
            {
                extensionElementsModel.EventListeners = new List<EventListenerModel>(eventListeners);
            }
            else
            {
                extensionElementsModel.EventListeners = extensionElementsModel.EventListeners.Concat(eventListeners);
            }
        }

        /// <summary>
        /// 添加任务监听器
        /// </summary>
        /// <param name="extensionElementsModel"></param>
        /// <param name="taskListeners"></param>
        public static void AddTaskListeners(this ExtensionElementsModel extensionElementsModel, params TaskListenerModel[] taskListeners)
        {
            if (extensionElementsModel == null || taskListeners == null)
            {
                return;
            }
            if (extensionElementsModel.TaskListeners == null)
            {
                extensionElementsModel.TaskListeners = new List<TaskListenerModel>(taskListeners);
            }
            else
            {
                extensionElementsModel.TaskListeners = extensionElementsModel.TaskListeners.Concat(taskListeners);
            }
        }

        /// <summary>
        /// 添加表单属性
        /// </summary>
        /// <param name="extensionElementsModel"></param>
        /// <param name="formProperties"></param>
        public static void AddFormProperties(this ExtensionElementsModel extensionElementsModel, params FormPropertyModel[] formProperties)
        {
            if (extensionElementsModel == null || formProperties == null)
            {
                return;
            }
            if (extensionElementsModel.FormProperties == null)
            {
                extensionElementsModel.FormProperties = new List<FormPropertyModel>(formProperties);
            }
            else
            {
                extensionElementsModel.FormProperties = extensionElementsModel.FormProperties.Concat(formProperties);
            }
        }
    }
}
