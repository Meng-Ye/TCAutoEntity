using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using ICSharpCode.TextEditor.Document;
using System.IO;

namespace AutoTcEntity
{
    public partial class f_main : Form
    {
        /// <summary>
        /// 代码文本框
        /// </summary>
        private ICSharpCode.TextEditor.TextEditorControl Code_TextEditorControl;
        private AutoConfigSetting autoConfigSetting;
        public f_main()
        {
            InitializeComponent();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_main));
            DefaultHighlightingStrategy defaultHighlightingStrategy1 = new DefaultHighlightingStrategy();
            DefaultTextEditorProperties defaultTextEditorProperties1 = new DefaultTextEditorProperties();
            this.Code_TextEditorControl = new ICSharpCode.TextEditor.TextEditorControl
            {
                Anchor = (((((AnchorStyles.Top | AnchorStyles.Bottom) | AnchorStyles.Left) | AnchorStyles.Right))),
                Encoding = ((Encoding)(resources.GetObject("Code_TextEditorControl.Encoding"))),
                Location = new System.Drawing.Point(300, 239),
                Name = "Code_TextEditorControl",
                ShowEOLMarkers = true,
                ShowSpaces = true,
                ShowTabs = true,
                ShowVRuler = true,
                Size = new System.Drawing.Size(1050, 500),
                TabIndex = 4,
                TextEditorProperties = defaultTextEditorProperties1
            };
            defaultHighlightingStrategy1.Extensions = new string[0];
            defaultTextEditorProperties1.AllowCaretBeyondEOL = false;
            defaultTextEditorProperties1.AutoInsertCurlyBracket = true;
            defaultTextEditorProperties1.BracketMatchingStyle = BracketMatchingStyle.After;
            defaultTextEditorProperties1.ConvertTabsToSpaces = false;
            defaultTextEditorProperties1.CreateBackupCopy = false;
            defaultTextEditorProperties1.DocumentSelectionMode = DocumentSelectionMode.Normal;
            defaultTextEditorProperties1.EnableFolding = true;
            defaultTextEditorProperties1.Encoding = ((System.Text.Encoding)(resources.GetObject("defaultTextEditorProperties1.Encoding")));
            defaultTextEditorProperties1.Font = new System.Drawing.Font("Courier New", 10F);
            defaultTextEditorProperties1.HideMouseCursor = false;
            defaultTextEditorProperties1.IndentStyle = IndentStyle.Smart;
            defaultTextEditorProperties1.IsIconBarVisible = true;
            defaultTextEditorProperties1.LineTerminator = "\r\n";
            defaultTextEditorProperties1.LineViewerStyle = LineViewerStyle.None;
            defaultTextEditorProperties1.MouseWheelScrollDown = true;
            defaultTextEditorProperties1.MouseWheelTextZoom = true;
            defaultTextEditorProperties1.ShowEOLMarker = true;
            defaultTextEditorProperties1.ShowHorizontalRuler = false;
            defaultTextEditorProperties1.ShowInvalidLines = true;
            defaultTextEditorProperties1.ShowLineNumbers = true;
            defaultTextEditorProperties1.ShowMatchingBracket = true;
            defaultTextEditorProperties1.ShowSpaces = true;
            defaultTextEditorProperties1.ShowTabs = true;
            defaultTextEditorProperties1.ShowVerticalRuler = true;
            defaultTextEditorProperties1.TabIndent = 4;
            defaultTextEditorProperties1.UseAntiAliasedFont = false;
            defaultTextEditorProperties1.UseCustomLine = false;
            defaultTextEditorProperties1.VerticalRulerRow = 80;
            this.Controls.Add(this.Code_TextEditorControl);
            this.Code_TextEditorControl.Document.HighlightingStrategy = HighlightingStrategyFactory.CreateHighlightingStrategy("C#");
            this.Code_TextEditorControl.Encoding = Encoding.Default;
            autoConfigSetting = new AutoConfigSetting();
        }

        private void f_main_Load(object sender, EventArgs e)
        {
            this.tv_LinkInfo.Nodes.Add(new TreeNode
            {
                Name = autoConfigSetting.DBConn,
                Text = "cityInfo"
            });
        }


        /// <summary>
        /// 获得类型
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        string GetTypeByString(string type)
        {
            switch (type.ToLower())
            {
                case "system.boolean":
                    return "bool";
                case "system.byte":
                    return "byte";
                case "system.sbyte":
                    return "sbyte";
                case "system.char":
                    return "string";
                case "system.decimal":
                    return "decimal";
                case "system.double":
                    return "double";
                case "system.single":
                    return "System.Single";
                case "system.int32":
                    return "int";
                case "system.uint32":
                    return "uint32";
                case "system.int64":
                    return "long";
                case "system.uint64":
                    return "uint64";
                case "system.object":
                    return "object";
                case "system.int16":
                    return "int";
                case "system.uint16":
                    return "UInt16";
                case "system.string":
                    return "string";
                case "system.datetime":
                case "datetime":
                    return "DateTime";
                case "system.guid":
                    return "Guid";
                default:
                    return type;
            }
        }

        /// <summary>
        /// 加载所有表
        /// </summary>
        /// <param name="node"></param>
        private void LoadingTables(TreeNode node)
        {
            var type = DataBaseType.MySQL;
            switch (type)
            {
                case DataBaseType.SQLServer:
                    var sql = @"select * from
(SELECT 
    表名       = case when a.colorder=1 then d.name else '' end,
    表说明     = case when a.colorder=1 then isnull(f.value,'') else '' end
FROM 
    syscolumns a
inner join 
    sysobjects d 
on 
    a.id=d.id  and d.xtype='U' and  d.name<>'dtproperties'
left join
sys.extended_properties f
on 
    d.id=f.major_id and f.minor_id=0) t
	where t.表名!=''";
                    var dt = SQLServerHelper.QueryDataTable(node.Name, sql);
                    if (dt?.Rows.Count > 0)
                    {
                        node.Nodes.Clear();
                        foreach (DataRow item in dt.Rows)
                        {
                            var nodeItem = new TreeNode
                            {
                                Text = item["表名"].ToString(),
                                Name = item["表说明"].ToString(),
                                Tag = type
                            };
                            node.Nodes.Add(nodeItem);
                        }
                        dt.Rows.Clear();
                        dt.Clear();
                        dt.Dispose();
                        dt = null;
                        GC.Collect();
                    }
                    break;
                case DataBaseType.MySQL:
                    var sql1 = $"SELECT TABLE_NAME as 表名, Table_Comment as 表说明 FROM INFORMATION_SCHEMA.TABLES where TABLE_SCHEMA = 'citydb'";
                    var dt1 = MySQLHelper.QueryDataTable(node.Name, sql1);
                    if (dt1?.Rows.Count > 0)
                    {
                        node.Nodes.Clear();
                        foreach (DataRow item in dt1.Rows)
                        {
                            var nodeItem = new TreeNode
                            {
                                Text = item["表名"].ToString(),
                                Name = item["表说明"].ToString(),
                                Tag = type
                            };
                            node.Nodes.Add(nodeItem);
                        }
                        dt1.Rows.Clear();
                        dt1.Clear();
                        dt1.Dispose();
                        dt1 = null;
                        GC.Collect();
                    }
                    break;
                case DataBaseType.Oracler:
                    break;
                case DataBaseType.SQLite:
                    break;
                case DataBaseType.PostgreSQL:
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// 获取实体类生成代码
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        private string GetEntityCode(TreeNode node)
        {
            var type = DataBaseType.MySQL;
            StringBuilder codeString = new StringBuilder();
            switch (type)
            {
                case DataBaseType.MySQL:
                    codeString.Append($@"{(string.IsNullOrWhiteSpace(this.txt_using.Text) ? "" : $"{this.txt_using.Text.Trim()}")}
namespace {this.txt_namespace.Text.Trim()}
{{
    /// <summary>
    /// {node.Name}
    /// </summary>{(string.IsNullOrWhiteSpace(this.txt_classattr.Text) ? "" : $"{Environment.NewLine}    {this.txt_classattr.Text.Trim()}")}
    public class {node.Text.SetLengthToUpperByStart(4)}
    {{");
                    var mysql_tableInfo = MySQLHelper.QueryTableInfo(node.Parent.Name, $"select * from {node.Text} where 1=2");
                    DataTable mysql_colsInfos = MySQLHelper.QueryDataTable(node.Parent.Name, $"select COLUMN_NAME as OBJNAME,column_comment as VALUE from INFORMATION_SCHEMA.Columns where table_name='{node.Text}' and table_schema='citydb'", null);
                    foreach (DataRow dr in mysql_tableInfo.Rows)
                    {
                        var zhuShi = string.Empty;//列名注释
                        foreach (DataRow uu in mysql_colsInfos.Rows)
                        {
                            if (uu["OBJNAME"].ToString().ToUpper() == dr["ColumnName"].ToString().ToUpper())
                                zhuShi = uu["VALUE"].ToString();
                        }
                        if ((bool)dr["IsKey"] && !(bool)dr["IsAutoIncrement"])
                        {
                            codeString.Append($@"
        /// <summary>
        /// -zhuShi-
        /// </summary>
       {txt_primarykey.Text}
        public -dbType- -colName- {{ get; set;  }} ");
                        }
                        else if ((bool)dr["IsKey"] && (bool)dr["IsAutoIncrement"])
                        {
                            codeString.Append($@"
        /// <summary>
        /// -zhuShi-
        /// </summary>
         {txt_autoprimarykey.Text}
        public -dbType- -colName- {{ get; set; }} -value-
");
                        }
                        else
                        {
                            codeString.Append($@"
        /// <summary>
        /// -zhuShi-
        /// </summary>
        {txt_fieldattr.Text}
        public -dbType- -colName- {{ get; set;  }} -value-
");
                        }
                        string ttttt = this.GetTypeByString(dr["DataType"].ToString());
                        if (dr["DataType"].ToString() == "System.String")
                        {
                            codeString.Replace("-dbType-", ttttt);  //替换数据类型
                            codeString.Replace("-value-", " = string.Intern(\"\");");
                        }
                        else if (dr["DataType"].ToString() == "System.DateTime")
                        {
                            codeString.Replace("-dbType-", ttttt);  //替换数据类型
                            codeString.Replace("-value-", " = DateTime.Now;");
                        }
                        else
                        {
                            codeString.Replace("-dbType-", ttttt);  //替换数据类型
                            codeString.Replace("-value-", "");
                        }
                        codeString.Replace("-colName-", dr["ColumnName"].ToString().SetLengthToUpperByStart());  //替换列名（属性名）
                        codeString.Replace("-zhuShi-", zhuShi);
                    }
                    codeString.Append(@"    }
}");
                    break;
                case DataBaseType.Oracler:
                    break;
                case DataBaseType.SQLite:
                    break;
                case DataBaseType.PostgreSQL:
                    break;
                default:
                    break;
            }
            return codeString.ToString();
        }

        private async void 加载表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectNode = this.tv_LinkInfo.SelectedNode;
            if (selectNode == null)
            {
                MessageBox.Show("请选择节点", "加载提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (selectNode.Parent != null)
            {
                selectNode = selectNode.Parent;
            }

            void Tables()
            {
                this.Invoke(new Action(() => LoadingTables(selectNode)));
            }

            await Task.Run(() => Tables());
        }

        private async void 预览生成ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            void YL()
            {
                this.Invoke(new Action(() =>
                {
                    var selectNode = this.tv_LinkInfo.SelectedNode;
                    if (selectNode == null || selectNode.Parent == null)
                    {
                        MessageBox.Show("请选择表名再生成预览", "预览提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    this.Code_TextEditorControl.Text = this.GetEntityCode(selectNode);
                }));
            }

            await Task.Run(() => YL());
        }

        private async void 生成所有ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            void CreateCodes()
            {
                this.Invoke(new Action(() =>
                {
                    var selectNode = this.tv_LinkInfo.SelectedNode;
                    if (selectNode == null)
                    {
                        MessageBox.Show("请选择节点", "生成提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    var folderBrowserDialog = new FolderBrowserDialog();
                    if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    {
                        if (selectNode.Parent != null)
                        {
                            selectNode = selectNode.Parent;
                        }
                        else
                        {
                            if (selectNode.Nodes.Count <= 0)
                            {
                                MessageBox.Show("请先加载出表", "生成提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return;
                            }
                        }
                        Directory.CreateDirectory(folderBrowserDialog.SelectedPath + "\\" + this.txt_namespace.Text.Trim());
                        foreach (TreeNode node in selectNode.Nodes)
                        {
                            using (StreamWriter sw = new StreamWriter(folderBrowserDialog.SelectedPath + "\\" + this.txt_namespace.Text.Trim() + "\\" + node.Text.SetLengthToUpperByStart(4) + ".cs"))
                            {
                                sw.Write(this.GetEntityCode(node));
                            }
                        }
                        MessageBox.Show("生成成功", "生成提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }));
            }

            await Task.Run(() =>
            {
                CreateCodes();
            });
        }

        private async void tv_LinkInfo_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Parent == null)
            {
                void Tables()
                {
                    this.Invoke(new Action(() => LoadingTables(e.Node)));
                }

                await Task.Run(() => Tables());
            }
            else
            {
                void CodeByText()
                {
                    this.Invoke(new Action(() => this.Code_TextEditorControl.Text = this.GetEntityCode(e.Node)));
                }

                this.Code_TextEditorControl.Text = "正在生成...";
                await Task.Run(() => CodeByText());
            }
        }
    }
}
