namespace SmartBuilder.QueryBase
{
    public static class MsSQL
    {
        public const string QUERY_GetTableNamesByDBName = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' AND TABLE_CATALOG='{0}'";

        public const string QUERY_GetSpNamesByDBName = "SELECT ROUTINE_NAME FROM {0}.INFORMATION_SCHEMA.ROUTINES WHERE ROUTINE_TYPE = 'PROCEDURE' ORDER BY ROUTINE_NAME;";

        public const string QUERY_GetColumnInfoByTableName = "SELECT REPLACE(col.name, ' ', '_') ColumnName,column_id ColumnId,CASE typ.name  WHEN 'bigint' THEN 'long' WHEN 'binary' THEN 'byte[]' WHEN 'bit' THEN 'bool' WHEN 'char' THEN 'string' WHEN 'date' THEN 'DateTime' WHEN 'datetime' THEN 'DateTime' WHEN 'datetime2' THEN 'DateTime' WHEN 'datetimeoffset' THEN 'DateTimeOffset' WHEN 'decimal' THEN 'decimal' WHEN 'float' THEN 'float' WHEN 'image' THEN 'byte[]' WHEN 'int' THEN 'int' WHEN 'money' THEN 'decimal' WHEN 'nchar' THEN 'char' WHEN 'ntext' THEN 'string' WHEN 'numeric' THEN 'decimal' WHEN 'nvarchar' THEN 'string' WHEN 'real' THEN 'double' WHEN 'smalldatetime' THEN 'DateTime' WHEN 'smallint' THEN 'short' WHEN 'smallmoney' THEN 'decimal' WHEN 'text' THEN 'string'WHEN 'time' THEN 'TimeSpan' WHEN 'timestamp' THEN 'DateTime' WHEN 'tinyint' THEN 'byte' WHEN 'uniqueidentifier' THEN 'Guid' WHEN 'varbinary' THEN 'byte[]' WHEN 'varchar' THEN 'string' ELSE 'UNKNOWN_' + typ.name  END ColumnType, CASE  WHEN col.is_nullable = 1 and typ.name in ('bigint', 'bit', 'date', 'datetime', 'datetime2', 'datetimeoffset', 'decimal', 'float', 'int', 'money', 'numeric', 'real', 'smalldatetime', 'smallint', 'smallmoney', 'time', 'tinyint', 'uniqueidentifier')  THEN '?'  ELSE '' END NullableSign FROM sys.columns col  join sys.types typ ON col.system_type_id = typ.system_type_id AND col.user_type_id = typ.user_type_id WHERE OBJECT_ID = OBJECT_ID('{0}')";


    }
}
