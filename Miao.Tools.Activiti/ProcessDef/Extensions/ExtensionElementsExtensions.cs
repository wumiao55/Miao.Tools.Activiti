using System.Collections.Generic;
using System.Linq;
using Miao.Tools.Activiti.ProcessDef.Models.ComponentElements;

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
        public static ExtensionElementsModel AddExecutionListeners(this ExtensionElementsModel extensionElementsModel, params ExecutionListenerModel[] executionListeners)
        {
            if(extensionElementsModel == null || executionListeners == null)
            {
                return extensionElementsModel;
            }
            if(extensionElementsModel.ExecutionListeners == null)
            {
                extensionElementsModel.ExecutionListeners = new List<ExecutionListenerModel>(executionListeners);
            }
            else
            {
                extensionElementsModel.ExecutionListeners = extensionElementsModel.ExecutionListeners.Concat(executionListeners);
            }
            return extensionElementsModel;
        }

        /// <summary>
        /// 添加事件监听器
        /// </summary>
        /// <param name="extensionElementsModel"></param>
        /// <param name="eventListeners"></param>
        public static ExtensionElementsModel AddEventListeners(this ExtensionElementsModel extensionElementsModel, params EventListenerModel[] eventListeners)
        {
            if(extensionElementsModel == null || eventListeners == null)
            {
                return extensionElementsModel;
            }
            if(extensionElementsModel.EventListeners == null)
            {
                extensionElementsModel.EventListeners = new List<EventListenerModel>(eventListeners);
            }
            else
            {
                extensionElementsModel.EventListeners = extensionElementsModel.EventListeners.Concat(eventListeners);
            }
            return extensionElementsModel;
        }
    
        /// <summary>
        /// 添加任务监听器
        /// </summary>
        /// <param name="extensionElementsModel"></param>
        /// <param name="taskListeners"></param>
        public static ExtensionElementsModel AddTaskListeners(this ExtensionElementsModel extensionElementsModel, params TaskListenerModel[] taskListeners)
        {
            if(extensionElementsModel == null || taskListeners == null)
            {
                return extensionElementsModel;
            }
            if(extensionElementsModel.TaskListeners == null)
            {
                extensionElementsModel.TaskListeners = new List<TaskListenerModel>(taskListeners);
            }
            else
            {
                extensionElementsModel.TaskListeners = extensionElementsModel.TaskListeners.Concat(taskListeners);
            }
            return extensionElementsModel;
        }

        /// <summary>
        /// 添加表单属性
        /// </summary>
        /// <param name="extensionElementsModel"></param>
        /// <param name="formProperties"></param>
        public static ExtensionElementsModel AddFormProperties(this ExtensionElementsModel extensionElementsModel, params FormPropertyModel[] formProperties)
        {
            if(extensionElementsModel == null || formProperties == null)
            {
                return extensionElementsModel;
            }
            if(extensionElementsModel.FormProperties == null)
            {
                extensionElementsModel.FormProperties = new List<FormPropertyModel>(formProperties);
            }
            else
            {
                extensionElementsModel.FormProperties = extensionElementsModel.FormProperties.Concat(formProperties);
            }
            return extensionElementsModel;
        }

        /// <summary>
        /// 添加字段
        /// </summary>
        /// <param name="extensionElementsModel"></param>
        /// <param name="activitiFields"></param>
        /// <returns></returns>
        public static ExtensionElementsModel AddActivitiFields(this ExtensionElementsModel extensionElementsModel, params ActivitiFieldModel[] activitiFields)
        {
            if(extensionElementsModel == null || activitiFields == null)
            {
                return extensionElementsModel;
            }
            if(extensionElementsModel.ActivitiFields == null)
            {
                extensionElementsModel.ActivitiFields = new List<ActivitiFieldModel>();
            }
            else
            {
                extensionElementsModel.ActivitiFields = extensionElementsModel.ActivitiFields.Concat(activitiFields);
            }
            return extensionElementsModel;
        }
    }
}
