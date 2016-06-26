using System;
using System.Collections.Generic;
using System.Data;

using System.Data.SqlClient;
using System.Text;

namespace SmartBuilder
{
    public class AppUtilityDataProvider
    {

        internal DataTable GetTableColumnsBySQLScritpt(string strScript, string connectionString)
        {
            DataSet ds = ExecuteScriptAsDataSet(strScript, connectionString);
            DataTable dt = new DataTable();
            if (ds != null && ds.Tables != null && ds.Tables.Count > 0)
                dt = ds.Tables[0];
            return dt;
        }

        internal DataTable GetTableListofDataBase(string SelectQuery, string connectionString)
        {
            DataSet ds = ExecuteScriptAsDataSet(SelectQuery, connectionString);

            DataTable dt = new DataTable();
            if (ds != null && ds.Tables != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
            }
            return dt;
        }

        internal DataSet ExecuteScriptAsDataSet(string SQL, string connectionString)
        {
            DataSet SQLds;
            SqlConnection SQLConn = new SqlConnection(connectionString);
            try
            {
                SqlCommand SQLCmd = new SqlCommand();
                SqlDataAdapter SQLAdapter = new SqlDataAdapter();
                SQLds = new DataSet();
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
                System.Windows.Forms.MessageBox.Show(e.Message, "Exception Occured", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation);
                return null;
            }
            finally
            { SQLConn.Close(); }

        }



        internal List<KeyValuePair<string, object>> GetSpPrametersBySpName(string StoredProcedureName, string connectionString)
        {
            List<KeyValuePair<string, object>> ParamCollInput = new List<KeyValuePair<string, object>>();
            using (SqlConnection myConnection = new SqlConnection())
            {
                myConnection.ConnectionString = connectionString;

                SqlCommand myCommand = new SqlCommand();
                myCommand.Connection = myConnection;
                myCommand.CommandText = StoredProcedureName;
                myCommand.CommandType = CommandType.StoredProcedure;

                myConnection.Open();
                SqlCommandBuilder.DeriveParameters(myCommand);
                myConnection.Close();
                foreach (SqlParameter param in myCommand.Parameters)
                {
                    if (param.Direction == ParameterDirection.Input || param.Direction == ParameterDirection.InputOutput)
                    {
                        ParamCollInput.Add(new KeyValuePair<string, object>(param.ParameterName + "," + param.SqlDbType.ToString(), param));
                    }
                }
            }
            return ParamCollInput;
        }



        /// <summary>
        /// Execute give procedure as data set
        /// </summary>
        /// <param name="StroredProcedureName"></param>
        /// <param name="ParaMeterCollection"></param>
        /// <param name="connectionString"></param>
        /// <returns></returns>
        internal DataSet ExecuteAsDataSet(string StroredProcedureName, IList<KeyValuePair<string, object>> ParaMeterCollection, string connectionString)
        {
            SqlConnection SQLConn = new SqlConnection(connectionString);
            try
            {
                SqlCommand SQLCmd = new SqlCommand();
                SqlDataAdapter SQLAdapter = new SqlDataAdapter();
                DataSet SQLds = new DataSet();
                SQLCmd.Connection = SQLConn;
                SQLCmd.CommandText = StroredProcedureName;
                SQLCmd.CommandType = CommandType.StoredProcedure;

                //Loop for Paramets
                for (int i = 0; i < ParaMeterCollection.Count; i++)
                {
                    SqlParameter sqlParaMeter = new SqlParameter();
                    sqlParaMeter.IsNullable = true;
                    sqlParaMeter.ParameterName = ParaMeterCollection[i].Key;
                    sqlParaMeter.Value = ParaMeterCollection[i].Value;
                    SQLCmd.Parameters.Add(sqlParaMeter);
                }
                //End of for loop

                SQLAdapter.SelectCommand = SQLCmd;
                SQLConn.Open();
                SQLAdapter.Fill(SQLds);
                SQLConn.Close();
                return SQLds;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                SQLConn.Close();
            }
        }


        internal string ExecuteGivenProcedureBuildInfoClass(string ProcedureName, string defaultNameSpace, string ClassName, IList<KeyValuePair<string, object>> listColl, string connectionString)
        {
            string strText = string.Empty;
            StringBuilder strBuilder = new StringBuilder();
            DataSet ds = ExecuteAsDataSet(ProcedureName, listColl, connectionString);

            if (ds != null && ds.Tables != null && ds.Tables.Count > 0)
            {
                DataTable dt = ds.Tables[0];
                ClassGenerator dtInfoBuilder = new ClassGenerator();
                strText = dtInfoBuilder.GenerateInfoClassFromDataTable(dt, ClassName);

                strBuilder.Append(USUtil.LoadUsingCodex(defaultNameSpace, string.Empty));
                strBuilder.Append(strText);
                strBuilder.Append(" \r }");
                USUtil.CreateClassFileForGivenTypeClass(ClassName, strBuilder.ToString(), ICD.Info);
            }

            return strBuilder.ToString();

        }


    }
}
