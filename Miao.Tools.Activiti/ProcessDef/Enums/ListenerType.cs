using System;
using System.Collections.Generic;
using System.Text;

namespace Miao.Tools.Activiti.ProcessDef.Enums
{
    /// <summary>
    /// 监听类型
    /// </summary>
    public enum ListenerType
    {
        /// <summary>
        /// ACTIVITY_COMPENSATE
        /// </summary>
        ACTIVITY_COMPENSATE,

        /// <summary>
        /// ACTIVITY_COMPLETED
        /// </summary>
        ACTIVITY_COMPLETED,

        /// <summary>
        /// ACTIVITY_ERROR_RECEIVED
        /// </summary>
        ACTIVITY_ERROR_RECEIVED,

        /// <summary>
        /// ACTIVITY_MESSAGE_RECEIVED
        /// </summary>
        ACTIVITY_MESSAGE_RECEIVED,

        /// <summary>
        /// ACTIVITY_SIGNALED
        /// </summary>
        ACTIVITY_SIGNALED,

        /// <summary>
        /// ACTIVITY_STARTED
        /// </summary>
        ACTIVITY_STARTED,

        /// <summary>
        /// ENGINE_CLOSED
        /// </summary>
        ENGINE_CLOSED,

        /// <summary>
        /// ENGINE_CREATED
        /// </summary>
        ENGINE_CREATED,

        /// <summary>
        /// ENTITY_ACTIVATED
        /// </summary>
        ENTITY_ACTIVATED,

        /// <summary>
        /// ENTITY_CREATED
        /// </summary>
        ENTITY_CREATED,

        /// <summary>
        /// ENTITY_DELETED
        /// </summary>
        ENTITY_DELETED,

        /// <summary>
        /// ENTITY_INITIALIZED
        /// </summary>
        ENTITY_INITIALIZED,

        /// <summary>
        /// ENTITY_SUSPENDED
        /// </summary>
        ENTITY_SUSPENDED,

        /// <summary>
        /// ENTITY_UPDATED
        /// </summary>
        ENTITY_UPDATED,

        /// <summary>
        /// JOB_EXECUTION_FAILURE
        /// </summary>
        JOB_EXECUTION_FAILURE,

        /// <summary>
        /// JOB_EXECUTION_SUCCESS
        /// </summary>
        JOB_EXECUTION_SUCCESS,

        /// <summary>
        /// JOB_RETRIES_DECREMENTED
        /// </summary>
        JOB_RETRIES_DECREMENTED,

        /// <summary>
        /// MEMBERSHIP_CREATED
        /// </summary>
        MEMBERSHIP_CREATED,

        /// <summary>
        /// MEMBERSHIP_DELETED
        /// </summary>
        MEMBERSHIP_DELETED,

        /// <summary>
        /// MEMBERSHIPS_DELETED
        /// </summary>
        MEMBERSHIPS_DELETED,

        /// <summary>
        /// TASK_ASSIGNED
        /// </summary>
        TASK_ASSIGNED,

        /// <summary>
        /// TASK_COMPLETED
        /// </summary>
        TASK_COMPLETED,

        /// <summary>
        /// TIMER_FIRED
        /// </summary>
        TIMER_FIRED,

        /// <summary>
        /// UNCAUGHT_BPMN_ERROR
        /// </summary>
        UNCAUGHT_BPMN_ERROR,

        /// <summary>
        /// VARIABLE_CREATED
        /// </summary>
        VARIABLE_CREATED,

        /// <summary>
        /// VARIABLE_DELETED
        /// </summary>
        VARIABLE_DELETED,

        /// <summary>
        /// VARIABLE_UPDATED
        /// </summary>
        VARIABLE_UPDATED
    }
}
