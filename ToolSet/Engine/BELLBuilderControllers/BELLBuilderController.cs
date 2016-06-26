using System.Collections;
using System.Data;
using System.Text;

namespace SmartBuilder
{
    public class BELLBuilderController
    {
        public string GetTableInfoByTableNameandClassName(AdonaiBuildStrucutreInfo buildInfo)
        {
            string tableName = USUtil.CovertFirstLetterToCapital(buildInfo.TableName);
            string infoClassName = USUtil.CovertFirstLetterToCapital(buildInfo.InfoClassName);

            string strFinalinfoString = string.Empty;
            string strScript = SQLSelectQueryBuilder.SelectQueryBuilderForTable(tableName);
            AppUtilityDataProvider objInfoDataProvider = new AppUtilityDataProvider();

            DataTable dt = objInfoDataProvider.GetTableColumnsBySQLScritpt(strScript, buildInfo.ConnectionString);

            //Process data of data table to build final string for the C# info class
            strFinalinfoString = TableInfoGenerator.BuildInfoClassforGivenDataTable(dt, infoClassName, buildInfo.IsNullableRequired, buildInfo.IsSerializable);

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append(USUtil.LoadUsingCodex(buildInfo.InfoNameSpace, string.Empty));
            strBuilder.Append(strFinalinfoString);
            strBuilder.Append(" \r }");
            USUtil.CreateClassFileForGivenTypeClass(infoClassName, strBuilder.ToString(), ICD.Info);

            //Add Controller Class
            if (buildInfo.IsControllerRequired)
            {
                strBuilder.Append(AddContentHeader("Your Controller Class"));

                string txtControllerCode = USUtil.Initialize_UsingStatementAndClassHeader(buildInfo.InfoNameSpace, tableName, ICD.Controller);
                USUtil.CreateClassFileForGivenTypeClass(tableName + USUtil.Controller, txtControllerCode, ICD.Controller);

                strBuilder.Append(txtControllerCode);
            }

            //Add SQL DataProvider Class
            if (buildInfo.IsProviderRequired)
            {
                strBuilder.Append(AddContentHeader("Your SQL Data Provider Class"));

                string txtProviderCode = USUtil.Initialize_UsingStatementAndClassHeader(buildInfo.InfoNameSpace,tableName, ICD.DataProvider);
                USUtil.CreateClassFileForGivenTypeClass(tableName + USUtil.Provider, txtProviderCode, ICD.DataProvider);
                strBuilder.Append(txtProviderCode);
            }
            return strBuilder.ToString();
        }


        private string AddContentHeader(string content)
        { return "\r\r//" + content + USUtil.R; }


        public string BuildInfoClassForMulitpleTables(ArrayList arrTableNameList, AdonaiBuildStrucutreInfo buildInfo)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\r");

            strBuilder.Append("--------------------------------------------------\r");
            strBuilder.Append("Note:\r");
            strBuilder.Append(" The Data contained in this output folder will be ");
            strBuilder.Append("\r overridden next time,Please do keep that in mind \r");
            strBuilder.Append("--------------------------------------------------\r");
            strBuilder.Append("\r\r");
            for (int i = 0; i < arrTableNameList.Count; i++)
            {

                buildInfo.TableName = arrTableNameList[i].ToString();
                buildInfo.InfoClassName = buildInfo.TableName + "Info";
                strBuilder.Append(GetTableInfoByTableNameandClassName(buildInfo));
                strBuilder.Append("\r\r");
            }
            return strBuilder.ToString();
        }

    }
}
