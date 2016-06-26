using System.Text;

namespace SmartBuilder
{
    public class SQLSelectQueryBuilder
    {
        public static string BuildSelectQueryForTableBuilder(string databaseName)
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' AND TABLE_CATALOG='");
            strBuilder.Append(databaseName);
            strBuilder.Append("'");

            return strBuilder.ToString();
        }

        public static string BuildSelectQueryForStoredProcedureBuilder(string databaseName)
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("SELECT ROUTINE_NAME  from ");
            strBuilder.Append(databaseName);
            strBuilder.Append(".information_schema.routines where routine_type = 'PROCEDURE'");

            return strBuilder.ToString();
        }

        public static string SelectQueryBuilderForTable(string TableName)
        {
            StringBuilder strbQueryBuilder = new StringBuilder();
            //Exact Query
            strbQueryBuilder.Append("SELECT ");
            strbQueryBuilder.Append("REPLACE(col.name, ' ', '_') ColumnName,");
            strbQueryBuilder.Append("column_id ColumnId,");
            strbQueryBuilder.Append("CASE typ.name ");
            strbQueryBuilder.Append(" WHEN 'bigint' THEN 'long'");
            strbQueryBuilder.Append(" WHEN 'binary' THEN 'byte[]'");
            strbQueryBuilder.Append(" WHEN 'bit' THEN 'bool'");
            strbQueryBuilder.Append(" WHEN 'char' THEN 'string'");
            strbQueryBuilder.Append(" WHEN 'date' THEN 'DateTime'");
            strbQueryBuilder.Append(" WHEN 'datetime' THEN 'DateTime'");
            strbQueryBuilder.Append(" WHEN 'datetime2' THEN 'DateTime'");
            strbQueryBuilder.Append(" WHEN 'datetimeoffset' THEN 'DateTimeOffset'");
            strbQueryBuilder.Append(" WHEN 'decimal' THEN 'decimal'");
            strbQueryBuilder.Append(" WHEN 'float' THEN 'float'");
            strbQueryBuilder.Append(" WHEN 'image' THEN 'byte[]'");
            strbQueryBuilder.Append(" WHEN 'int' THEN 'int'");
            strbQueryBuilder.Append(" WHEN 'money' THEN 'decimal'");
            strbQueryBuilder.Append(" WHEN 'nchar' THEN 'char'");
            strbQueryBuilder.Append(" WHEN 'ntext' THEN 'string'");
            strbQueryBuilder.Append(" WHEN 'numeric' THEN 'decimal'");
            strbQueryBuilder.Append(" WHEN 'nvarchar' THEN 'string'");
            strbQueryBuilder.Append(" WHEN 'real' THEN 'double'");
            strbQueryBuilder.Append(" WHEN 'smalldatetime' THEN 'DateTime'");
            strbQueryBuilder.Append(" WHEN 'smallint' THEN 'short'");
            strbQueryBuilder.Append(" WHEN 'smallmoney' THEN 'decimal'");
            strbQueryBuilder.Append(" WHEN 'text' THEN 'string'");
            strbQueryBuilder.Append( "WHEN 'time' THEN 'TimeSpan'");
            strbQueryBuilder.Append(" WHEN 'timestamp' THEN 'DateTime'");
            strbQueryBuilder.Append(" WHEN 'tinyint' THEN 'byte'");
            strbQueryBuilder.Append(" WHEN 'uniqueidentifier' THEN 'Guid'");
            strbQueryBuilder.Append(" WHEN 'varbinary' THEN 'byte[]'");
            strbQueryBuilder.Append(" WHEN 'varchar' THEN 'string'");
            strbQueryBuilder.Append(" ELSE 'UNKNOWN_' + typ.name ");
            strbQueryBuilder.Append(" END ColumnType, ");
            strbQueryBuilder.Append("CASE ");
            strbQueryBuilder.Append(" WHEN col.is_nullable = 1 and typ.name in ('bigint', 'bit', 'date', 'datetime', 'datetime2', 'datetimeoffset', 'decimal', 'float', 'int', 'money', 'numeric', 'real', 'smalldatetime', 'smallint', 'smallmoney', 'time', 'tinyint', 'uniqueidentifier') ");
            strbQueryBuilder.Append(" THEN '?' ");
            strbQueryBuilder.Append(" ELSE '' ");
            strbQueryBuilder.Append("END NullableSign ");
            strbQueryBuilder.Append("FROM sys.columns col ");
            strbQueryBuilder.Append(" join sys.types typ ON");
            strbQueryBuilder.Append(" col.system_type_id = typ.system_type_id AND col.user_type_id = typ.user_type_id");
            strbQueryBuilder.Append(" WHERE OBJECT_ID = OBJECT_ID('");
            strbQueryBuilder.Append(TableName);
            strbQueryBuilder.Append("')");


            return strbQueryBuilder.ToString();
        }
   
    }
}
