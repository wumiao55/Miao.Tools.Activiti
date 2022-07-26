using System.ComponentModel;

namespace Miao.Tools.Activiti.ProcessDef.Enums
{
    /// <summary>
    /// 表单属性类型
    /// </summary>
    public enum FormPropertyType
    {
        /// <summary>
        /// 字符串
        /// </summary>
        [Description("string")]
        String = 0,

        /// <summary>
        /// 长整数
        /// </summary>
        [Description("long")]
        Long = 1,

        /// <summary>
        /// 布尔值
        /// </summary>
        [Description("boolean")]
        Boolean = 2,

        /// <summary>
        /// 日期
        /// </summary>
        [Description("date")]
        Date = 3,

        /// <summary>
        /// 枚举
        /// </summary>
        [Description("enum")]
        Enum = 4
    }
}
