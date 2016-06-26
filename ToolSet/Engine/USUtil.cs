using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace SmartBuilder
{
    public enum ICD { Info, Controller, DataProvider };
    /// <summary>
    /// Universal Static Utilities consisting of Constant variables and Static Helper methods
    /// </summary>
    class USUtil
    {
        internal const string UID = "User Id";
        internal const string DS = "Data Source";
        internal const string PWD = "Password";
        internal const string IC = "Initial Catalog";
        internal const string IS = "Integrated Security";
        internal const string DataSource_Catalog = DS + "={0};" + IC + "={1};";
        internal const string UserID_PWD = UID + "={0};" + PWD + "={1};";
        internal const string IntegratedSecurity = IS + "=SSPI;";

        public const string DumpFolderName = "Adonai Dump";

        public const string Tbl = "Table";
        public const string IN = "InstanceName";
        public const string SN = "ServerName";
        public const string Name = "Name";
        public static string DefaultServerName = "(local)";

        private static string OpenBracket = "\r\t\t{";
        private static string CloseBracket = "\r\t\t}";
        public const string T = "\t";
        public const string R = "\r";
        public const string S = " ";
        public const string NTT = "\r\t\t";   //N= New Line,T=Tab
        public const string NTTT = "\r\t\t\t";
        public const string T_OpenBracket = "\t{";
        public const string T_CloseBracket = "\t}";
        public const string Public_Class_S = "public class ";


        public const string msg_CopiedToClipboard = "Copied to clipboard !!";
        public const string msg_CopiedCaption = "Copied";
        public const string msg_TestSuccessfull = "Test successfull !!";
        public const string msg_TestFailed = "Test Failed !!";
        public const string msg_TestCaption = "Test";
        public const string msg_ErrorCaption = "Error Occured";
        public const string msg_FieldMissingCaption = "Fields Missing";
        public const string msg_UNnPwd = "UserName & Password required";
        public const string msg_SPHasNoParam = "Sp has no parameters";

        public const string Query_GetDatabaseList = "SELECT name, database_id FROM sys.databases ORDER BY Name";

        public const string Info = "Info";
        public const string Controller = "Controller";
        public const string Provider = "DataProvider";

        public const string DefaultNameSpace = "YourProject.ModuleName";

        public static string CurrentPath = string.Empty;
        public static string SavePath = string.Empty;




        /// <summary>
        /// Get a List of Tables from the database
        /// </summary>
        /// <param name="databaseName">The name of the database to query</param>
        /// <param name="connectionString">Connection parameters</param>
        /// <returns></returns>
        public static AutoCompleteStringCollection GetTableList(string databaseName, string connectionString)
        {
            string strSelctTableQuery = SQLSelectQueryBuilder.BuildSelectQueryForTableBuilder(databaseName);
            AppUtilityDataProvider CtlUtility = new AppUtilityDataProvider();
            DataTable dt = CtlUtility.GetTableListofDataBase(strSelctTableQuery, connectionString);
            AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
            for (int i = 0; i < dt.Rows.Count; i++)
                namesCollection.Add(dt.Rows[i]["TABLE_NAME"].ToString());
            return namesCollection;
        }


        /// <summary>
        /// Get a list of StoredProcedures from the database
        /// </summary>
        /// <param name="databaseName">The name of the database to query</param>
        /// <param name="connectionString">Connection parameters</param>
        /// <returns></returns>
        public static AutoCompleteStringCollection GetStoredProcedureList(string databaseName, string connectionString)
        {
            string strSelctTableQuery = SQLSelectQueryBuilder.BuildSelectQueryForStoredProcedureBuilder(databaseName);
            AppUtilityDataProvider CtlUtility = new AppUtilityDataProvider();
            DataTable dt = CtlUtility.GetTableListofDataBase(strSelctTableQuery, connectionString);
            AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
            for (int i = 0; i < dt.Rows.Count; i++)
                namesCollection.Add(dt.Rows[i]["ROUTINE_NAME"].ToString());
            return namesCollection;
        }


        /// <summary>
        /// Convert the first letter of a string to uppercase
        /// </summary>
        /// <param name="s">input</param>
        /// <returns>Input</returns>
        public static string CovertFirstLetterToCapital(string s)
        {
            if (string.IsNullOrEmpty(s))
            { return string.Empty; }
            return char.ToUpper(s[0]) + s.Substring(1);
        }


        public static void DisplayMessage(string message, string caption, bool positive)
        {
            MessageBoxIcon icon = MessageBoxIcon.Information;
            if (!positive)
                icon = MessageBoxIcon.Error;
            MessageBox.Show(message, caption, MessageBoxButtons.OK, icon);
        }



        #region Using Statement Controller

        /// <summary>
        /// Append text with line breaks
        /// </summary>
        /// <param name="codex">"param1","param2","param3"</param>
        /// <returns></returns>
        public static string DynamicAppenderWithLineBreak(params string[] codex)
        {
            if (codex.Length > 0)
            {
                StringBuilder sb = new StringBuilder();
                foreach (string code in codex)
                { sb.Append("\r"); sb.Append(code); }
                return sb.ToString();
            }
            else { return ""; }
        }


        /// <summary>
        /// Add using statements 
        /// </summary>
        /// <param name="codex">"using System;","using System.Collections.Generic;"...</param>
        /// <returns></returns>
        /// <returns></returns>
        public static string LoadUsingCodex(string defaultNameSpace, params string[] codex)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(USUtil.DynamicAppenderWithLineBreak("using System;", "using System.Collections.Generic;", "using System.Linq;", "using System.Text;"));
            sb.Append(USUtil.DynamicAppenderWithLineBreak(codex));
            sb.Append("\r\r");
            sb.Append("namespace " + defaultNameSpace);
            sb.Append("\r");
            sb.Append("{ \r");
            return sb.ToString();
        }

        #endregion


        public static string Initialize_UsingStatementAndClassHeader(string nameSpace, string ClassName, ICD icdType)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append(USUtil.LoadUsingCodex(nameSpace, ""));

            strBuilder.Append("\tpublic class ");
            strBuilder.Append(ClassName);
            strBuilder.Append(icdType.ToString());
            strBuilder.Append("\r");
            strBuilder.Append("\t{");

            switch (icdType)
            {
                case ICD.Controller:
                    strBuilder.Append(BuilControllerMethods(ClassName));
                    break;

                case ICD.DataProvider:
                    strBuilder.Append(BuilSQLDataProviderMethods(ClassName));
                    break;

                case ICD.Info:
                    break;
            }

            strBuilder.Append("\r");
            strBuilder.Append("\t}");

            strBuilder.Append(" \r }");//Close namespace bracket

            return strBuilder.ToString();
        }

        public static void CreateClassFileForGivenTypeClass(string ClassName, string strCode, ICD CodeType)
        {
            string RootlibraryPath = SavePath;
            FileManager.CreateDirectory(RootlibraryPath);
            string infoPath = RootlibraryPath;
            switch (CodeType)
            {
                case ICD.Info:
                    infoPath = infoPath + "/Info";
                    break;
                case ICD.Controller:
                    infoPath = infoPath + "/Controller";
                    break;
                case ICD.DataProvider:
                    infoPath = infoPath + "/DataProvider";
                    break;
                default:
                    break;
            }

            FileManager.CreateDirectory(infoPath);
            string destinationPath = infoPath + "/" + ClassName + ".cs";
            using (StreamWriter sw = new StreamWriter(destinationPath))
            {
                sw.Write(strCode);
            }
        }

        private static string SQLDataProviderAddUpdateControlLogic(string TableName, string AddUpdateType)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append(CreateHeaderObject(TableName));
            strBuilder.Append(string.Format("\r\t\t\tobj{1}Provider.{0}(obj{1});", TableName + AddUpdateType, TableName));
            return strBuilder.ToString();
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="TableName"></param>
        /// <returns>/*TableNameDataProvider objTableNameProvider = new TableNameDataProvide();*/ </returns>
        private static string CreateHeaderObject(string TableName)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\t\t\t");
            strBuilder.Append(string.Format("{0}DataProvider obj{0}Provider = new {0}DataProvider();", TableName));
            return strBuilder.ToString();
        }

        private static string AddUpdateHeader(string TableName, string AddUpdateType)
        {
            string preText = TableName + AddUpdateType;
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append(string.Format("\r\t\tpublic void {0}({1}Info obj{1})", preText, TableName));
            strBuilder.Append("\r\t\t{");
            strBuilder.Append(CreateHeaderObject(TableName));
            strBuilder.Append(string.Format("\r\t\t\tobj{1}Provider.{0}(obj{1});", preText, TableName));
            strBuilder.Append(CloseBracket);

            return strBuilder.ToString();
        }


        /// <summary>
        /// SQLDataProvider Add, Update method Creator
        /// </summary>
        /// <param name="TableName"></param>
        /// <param name="AddUpdate"></param>
        /// <returns></returns>
        public static string SQLDataProviderAddUpdateCodex(string TableName, string AddUpdateType)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(string.Format("\r\t\tinternal void {0}({1}Info obj{1})", TableName + AddUpdateType, TableName));
            sb.Append(OpenBracket);
            sb.Append("\r\t\t\t//Your implementation logic");
            sb.Append(CloseBracket);

            return sb.ToString();
        }


        private static string BuilSQLDataProviderMethods(string TableName)
        {
            StringBuilder strBuilder = new StringBuilder();

            string implemenationLogic = OpenBracket + "\r\t\t\t//Your implementation logic";

            //Add
            strBuilder.Append(SQLDataProviderAddUpdateCodex(TableName, "Add"));
            //Update
            strBuilder.Append(SQLDataProviderAddUpdateCodex(TableName, "Update"));
            //GetByID
            strBuilder.Append(string.Format("\r\t\tinternal {0}Info {0}GetByID(int id)", TableName));
            strBuilder.Append(implemenationLogic);
            strBuilder.Append(string.Format("\r\t\t\t{0}Info obj{0}Info = new {0}Info();", TableName));
            strBuilder.Append("\r\t\t\treturn obj" + TableName + "Info;");
            strBuilder.Append(CloseBracket);

            //GetList
            strBuilder.Append(string.Format("\r\t\tinternal List<{0}Info> {0}GetList()", TableName));
            strBuilder.Append(implemenationLogic);
            strBuilder.Append(string.Format("\r\t\t\tList<{0}Info> lst{0}Info = new List<{0}Info>();", TableName));
            strBuilder.Append("\r\t\t\treturn lst" + TableName + "Info;");
            strBuilder.Append(CloseBracket);

            //Delete
            strBuilder.Append("\r\t\tinternal void " + TableName + "DeleteByID(int id)");
            strBuilder.Append(implemenationLogic);
            strBuilder.Append(CloseBracket);

            return strBuilder.ToString();
        }

        private static string BuilControllerMethods(string TableName)
        {
            StringBuilder strBuilder = new StringBuilder();

            string tableNameInfo = TableName + "Info";
            string tableNameInfo_spaced = tableNameInfo + " ";

            //ADD
            strBuilder.Append(AddUpdateHeader(TableName, "Add"));

            //UPDATE
            strBuilder.Append(AddUpdateHeader(TableName, "Update"));

            //GetByID
            strBuilder.Append(string.Format("\r\t\tpublic {0}GetByID(int id)", tableNameInfo_spaced + TableName));
            strBuilder.Append(OpenBracket);
            strBuilder.Append(CreateHeaderObject(TableName));
            strBuilder.Append(string.Format("\r\t\t\t{0} objInfo = obj{1}Provider.{1}GetByID(id);", tableNameInfo_spaced, TableName));
            strBuilder.Append("\r\t\t\treturn objInfo;");
            strBuilder.Append(CloseBracket);


            //GetList
            strBuilder.Append(string.Format("\r\t\tpublic List<{0}Info> {0}GetList()", TableName));
            strBuilder.Append(OpenBracket);
            strBuilder.Append(CreateHeaderObject(TableName));
            strBuilder.Append(string.Format("\r\t\t\tList<{0}Info> lst{0}Info = obj{0}Provider.{0}GetList();", TableName));
            strBuilder.Append("\r\t\t\treturn lst" + TableName + "Info;");
            strBuilder.Append(CloseBracket);

            //Delete
            strBuilder.Append(string.Format("\r\t\tpublic void {0}DeleteByID(int id)", TableName));
            strBuilder.Append(OpenBracket);
            strBuilder.Append(CreateHeaderObject(TableName));
            strBuilder.Append(string.Format("\r\t\t\tobj{0}Provider.{0}DeleteByID(id);", TableName));
            strBuilder.Append(CloseBracket);


            return strBuilder.ToString();

        }


    }
}
