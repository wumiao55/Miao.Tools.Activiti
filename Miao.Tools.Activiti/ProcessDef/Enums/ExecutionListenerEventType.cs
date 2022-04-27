using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Miao.Tools.Activiti.ProcessDef.Enums
{
    /// <summary>
    /// 执行监听器事件类型
    /// </summary>
    public enum ExecutionListenerEventType
    {
        /// <summary>
        /// start
        /// </summary>
        [Description("start")]
        Start = 0,

        /// <summary>
        /// end
        /// </summary>
        [Description("end")]
        End = 1,

        /// <summary>
        /// take
        /// </summary>
        [Description("take")]
        Take = 2
    }
}
