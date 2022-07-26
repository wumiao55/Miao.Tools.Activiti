using System.ComponentModel;

namespace Miao.Tools.Activiti.Form.Enums
{
    /// <summary>
    /// 表单元素类型
    /// </summary>
    public enum FormElementType
    {
        /// <summary>
        /// 普通文本框
        /// </summary>
        [Description("text")]
        Text = 0,

        /// <summary>
        /// 多行文本框
        /// </summary>
        [Description("multi-line-text")]
        MultiLineText = 1,

        /// <summary>
        /// 数字输入框
        /// </summary>
        [Description("integer")]
        Integer = 2,

        /// <summary>
        /// 复选框
        /// </summary>
        [Description("boolean")]
        Boolean = 3,

        /// <summary>
        /// 日期
        /// </summary>
        [Description("date")]
        Date = 4,

        /// <summary>
        /// 下拉框
        /// </summary>
        [Description("dropdown")]
        Dropdown = 5,

        /// <summary>
        /// 单选按钮
        /// </summary>
        [Description("radio-buttons")]
        RadioButtons = 6,

        /// <summary>
        /// 附件
        /// </summary>
        [Description("upload")]
        Upload = 7,
    }
}
