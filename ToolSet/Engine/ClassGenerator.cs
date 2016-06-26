using System.Text;
using System.Data;

namespace SmartBuilder
{
    public class ClassGenerator
    {
        public string GenerateInfoClassFromDataTable(DataTable table, string ClassName)
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\t");
            strBuilder.Append("public class ");
            strBuilder.Append(ClassName);
            strBuilder.Append(USUtil.R);
            strBuilder.Append(USUtil.T_OpenBracket);

            foreach (DataColumn dc in table.Columns)
            {
                strBuilder.Append(USUtil.NTT);
                strBuilder.Append(" public ");
                string SystdataType = dc.DataType.ToString();
                strBuilder.Append(GetDataTypeBySystemDataType(SystdataType));
                strBuilder.Append(" ");
                string strColName = dc.ColumnName;
                strColName =USUtil.CovertFirstLetterToCapital(strColName);
                strBuilder.Append(strColName);
                strBuilder.Append(" ");

                strBuilder.Append(" { get; set; }");
            }
            strBuilder.Append(USUtil.R);
            strBuilder.Append(USUtil.T_CloseBracket);

            return strBuilder.ToString();
        }

        private string GetDataTypeBySystemDataType(string DataType)
        {            

            string strDType = string.Empty;
            switch (DataType)
            {
                case "System.String":
                    strDType = "string";
                    break;
                case "System.Int16":
                    strDType = "Int16";
                    break;
                case "System.Int32":
                    strDType = "Int32";
                    break;
                case "System.Int64":
                    strDType = "Int64";
                    break;
                case "System.DateTime":
                    strDType = "DateTime";
                    break;
                case "System.TimeSpan":
                    strDType = "TimeSpan";
                    break;
                case "System.DateTimeOffset":
                    strDType = "DateTimeOffset";
                    break;
                case "System.Boolean":
                    strDType = "bool";
                    break;
                case "System.Decimal":
                    strDType = "decimal";
                    break;
                case "System.Double":
                    strDType = "double";
                    break;
                case "System.Object":
                    strDType = "object";
                    break;               
                case "System.Byte[]":
                    strDType = "byte[]";
                    break;
                case "System.Byte":
                    strDType = "Byte";
                    break; 
                case "System.Guid":
                    strDType = "Guid";
                    break;                                            
                case "System.Single":
                    strDType = "Single";
                    break;                              
                case "Microsoft.SqlServer.Types.SqlHierarchyId":
                    strDType = "Microsoft.SqlServer.Types.SqlHierarchyId";
                    break;
                case "Microsoft.SqlServer.Types.SqlGeometry":
                    strDType = "Microsoft.SqlServer.Types.SqlGeometry";
                    break;
                case "Microsoft.SqlServer.Types.SqlGeography":
                    strDType = "Microsoft.SqlServer.Types.SqlGeography";
                    break;               
                default:
                    break;
            }
            return strDType;

        }

      
        private string GetSystemType(string tstrSqlType)
        {
            string _Type = string.Empty;

            switch (tstrSqlType)
            {
                case "biginit":
                    {
                        _Type = "long";
                    } break;
                case "smallint":
                    {
                        _Type = "short";
                    } break;
                case "tinyint":
                    {
                        _Type = "byte";
                    } break;
                case "int":
                    {
                        _Type = "int";
                    } break;
                case "bit":
                    {
                        _Type = "bool";
                    } break;
                case "decimal":
                case "numeric":
                    {
                        _Type = "decimal";
                    } break;
                case "money":
                case "smallmoney":
                    {
                        _Type = "decimal";
                    } break;
                case "float":
                case "real":
                    {
                        _Type = "float";
                    } break;
                case "datetime":
                case "smalldatetime":
                    {
                        _Type = "System.DateTime";
                    } break;
                case "char":
                    {
                        _Type = "char";
                    } break;
                case "sql_variant":
                    {
                        _Type = "object";
                    } break;
                case "varchar":
                case "text":
                case "nchar":
                case "nvarchar":
                case "ntext":
                    {
                        _Type = "string";
                    } break;
                case "binary":
                case "varbinary":
                    {
                        _Type = "byte[]";
                    } break;
                case "image":
                    {
                        _Type = "System.Drawing.Image";
                    } break;
                case "timestamp":
                case "uniqueidentifier":
                    {
                        _Type = "string";
                    } break;
                default:
                    {
                        _Type = "unknown";
                    } break;
            }
            return _Type;
        }
    }
}
