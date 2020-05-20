using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace AutoTcEntity
{
    public class AutoConfigSetting
    {
        /// <summary>
        /// 数据库连接
        /// </summary>
        public string DBConn => ConfigurationManager.AppSettings["sqlCon"];
        /// <summary>
        /// 要引入的命名空间
        /// </summary>
        public string UsingStr { get; set; } = string.Intern("");
        /// <summary>
        /// 父类的字符串
        /// </summary>
        public string BaseStr { get; set; } = string.Intern("");
        /// <summary>
        /// 命名空间
        /// </summary>
        public string NamespaceStr { get; set; } = string.Intern("");
        /// <summary>
        /// 字段的标注
        /// </summary>
        public string FieldAttrStr { get; set; } = string.Intern("");
        /// <summary>
        /// 实体类标注
        /// </summary>
        public string ClassAttrStr { get; set; } = string.Intern("");
        /// <summary>
        /// 自增主键标注
        /// </summary>
        public string AutoPrimaryKeyStr { get; set; } = string.Intern("");
        /// <summary>
        /// 非自增主键标注
        /// </summary>
        public string PrimaryKeyStr { get; set; } = string.Intern("");
    }

    /// <summary>
    /// 数据库类型
    /// </summary>
    internal enum DataBaseType
    {
        SQLServer = 1,
        MySQL,
        Oracler,
        SQLite,
        PostgreSQL
    }
}
