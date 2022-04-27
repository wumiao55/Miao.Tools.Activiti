﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Miao.Tools.Activiti.Form.Enums
{
    /// <summary>
    /// 表单字段类型
    /// </summary>
    public enum FormFieldType
    {
        /// <summary>
        /// FormField
        /// </summary>
        [Description("FormField")]
        FormField = 0,

        /// <summary>
        /// OptionFormField
        /// </summary>
        [Description("OptionFormField")]
        OptionFormField = 1,
    }
}
