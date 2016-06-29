/// 
///             Combines the query base and the parameters into a single query string
///             Author: Ozesh Thapa (@zaagan)
///             Email: dablackscarlet@gmail.com , ojthapa@gmail.com
///             

namespace SmartBuilder.Repository.MsSQL
{
    /// <summary>
    /// Collaborates Query Base and the given parameters into one single query string
    /// </summary>
    public class QueryCollaborator
    {


        /// <summary>
        /// Generate a query string to obtain a list of table names from the database
        /// </summary>
        /// <param name="databaseName"></param>
        /// <returns></returns>
        public static string GenerateQuery_GetListOfTableNamesByDatabaseName(string databaseName)
        {
            return string.Format(QueryBase.QUERY_GetTableNamesByDBName, databaseName);
        }



        /// <summary>
        /// Generate a query string to obtain a list of stored procedures from the database
        /// </summary>
        /// <param name="databaseName"></param>
        /// <returns></returns>
        public static string GenerateQuery_GetListOfStoredProceduresByDatabaseName(string databaseName)
        {
            return string.Format(QueryBase.QUERY_GetSpNamesByDBName, databaseName);
        }




        /// <summary>
        /// Generate a query string to obtain a list of Column Info
        /// (ColumnName, ColumnId,ColumnType,NullableSign) 
        /// from the database table
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public static string GenerateQuery_GetListOfColumnInfoByTableName(string tableName)
        {
            return string.Format(QueryBase.QUERY_GetColumnInfoByTableName, tableName);
        }


    }
}
