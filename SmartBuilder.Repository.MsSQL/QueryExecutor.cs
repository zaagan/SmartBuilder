using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SmartBuilder.Repository.MsSQL
{
    public class QueryExecutor
    {

        public QueryExecutor() { }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="strScript"></param>
        /// <param name="connectionString"></param>
        /// <returns></returns>
        internal DataTable GetTableColumnsBySQLScritpt(string strScript, string connectionString)
        {
            DataSet ds = ExecuteScriptAsDataSet(strScript, connectionString);
            DataTable dt = new DataTable();
            if (ds != null && ds.Tables != null && ds.Tables.Count > 0)
                dt = ds.Tables[0];
            return dt;
        }



        internal DataSet ExecuteScriptAsDataSet(string SQL, string connectionString)
        {

            SqlConnection SQLConn = new SqlConnection(connectionString);
            try
            {
                SqlCommand SQLCmd = new SqlCommand();
                SqlDataAdapter SQLAdapter = new SqlDataAdapter();
                DataSet SQLds = new DataSet();
                SQLCmd.Connection = SQLConn;
                SQLCmd.CommandText = SQL;
                SQLCmd.CommandType = CommandType.Text;
                SQLAdapter.SelectCommand = SQLCmd;
                SQLConn.Open();
                SQLAdapter.Fill(SQLds);
                SQLConn.Close();
                return SQLds;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Exception Occured", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }
            finally
            { SQLConn.Close(); }

        }


        //public static void DoSomething(string databaseName)
        //{
        //    string strSelctTableQuery = QueryCollaborator.GenerateQuery_GetListOfTableNamesByDatabaseName(databaseName);
        //    AppUtilityDataProvider CtlUtility = new AppUtilityDataProvider();
        //    DataTable dt = CtlUtility.GetTableListofDataBase(strSelctTableQuery, connectionString);
        //    AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
        //    for (int i = 0; i < dt.Rows.Count; i++)
        //        namesCollection.Add(dt.Rows[i]["TABLE_NAME"].ToString());
        //    return namesCollection;

        //}

    }
}
