using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Miao.Tools.Activiti.Extensions
{
    internal static class CommonExtensions
    {
        /// <summary>
        /// 布尔类型转化为字符串
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public static string ToLowerString(this bool b)
        {
            return b.ToString().ToLower();
        }

        /// <summary>
        /// 返回枚举项的描述信息
        /// </summary>
        /// <param name="value">要获取描述信息的枚举项</param>
        /// <returns>枚举想的描述信息</returns>
        public static string GetDescription(this Enum value)
        {
            Type enumType = value.GetType();
            // 获取枚举常数名称
            string name = Enum.GetName(enumType, value);
            if (name != null)
            {
                // 获取枚举字段
                FieldInfo fieldInfo = enumType.GetField(name);
                if (fieldInfo != null)
                {
                    // 获取描述的属性
                    DescriptionAttribute attr = Attribute.GetCustomAttribute(fieldInfo, typeof(DescriptionAttribute), false) as DescriptionAttribute;
                    if (attr != null)
                    {
                        return attr.Description;
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// 对象属性判空
        /// </summary>
        /// <param name="obj"></param>
        public static void CheckPropertiesNotNull(this object obj)
        {
            foreach (var property in obj.GetType().GetProperties())
            {
                var attr = Attribute.GetCustomAttribute(property, typeof(RequiredAttribute), false) as RequiredAttribute;
                if (attr == null)
                {
                    continue;
                }

                var objValue = property.GetValue(obj, null);
                if (objValue == null)
                {
                    throw new Exception($"'{property.Name}' is required.{attr.ErrorMessage}");
                }
                if (!attr.AllowEmptyStrings && objValue.ToString() == "")
                {
                    throw new Exception($"'{property.Name}' is required.{attr.ErrorMessage}");
                }
            }
        }

        /// <summary>
        /// 获取表达式的值,如: ${user1} -> user1
        /// </summary>
        /// <param name="input">表达式,如: ${user1}</param>
        /// <returns></returns>
        public static string ExpressionValue(this string input)
        {
            var reg = new Regex("\\$\\{(.*)\\}");
            var match = reg.Match(input);
            if (match.Success)
            {
                return match.Groups[1].Value.Trim();
            }
            return input;
        }
    }
}
