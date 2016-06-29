using SmartBuilder.Interface;
using System;
using System.Data;
using System.Text;

namespace SmartBuilder.Repository.MsSQL
{
    public class MsSQLRepo : IQueryHouse
    {
        public string GenerateTableInfo(AdonaiBuildStructureInfo buildInfo, SystemSettingsInfo systemSettings)
        {
            string tableName = Helper.CovertFirstLetterToCapital(buildInfo.TableName);
            string infoClassName = Helper.CovertFirstLetterToCapital(buildInfo.InfoClassName);

            string strFinalinfoString = string.Empty;
            string strScript = QueryCollaborator.GenerateQuery_GetListOfColumnInfoByTableName(tableName);

            QueryExecutor objInfoDataProvider = new QueryExecutor();

            DataTable dataTable = objInfoDataProvider.GetTableColumnsBySQLScritpt(strScript, buildInfo.ConnectionString);

            InfoClassGenerator infoClassGenerator = new InfoClassGenerator(systemSettings);
            strFinalinfoString = infoClassGenerator.BuildInfoClassforGivenDataTable(dataTable, infoClassName, buildInfo.IsNullableRequired, buildInfo.IsSerializable);

            //StringBuilder strBuilder = new StringBuilder();
            //strBuilder.Append(USUtil.LoadUsingCodex(buildInfo.InfoNameSpace, string.Empty));
            //strBuilder.Append(strFinalinfoString);
            //strBuilder.Append(" \r }");
            //USUtil.CreateClassFileForGivenTypeClass(infoClassName, strBuilder.ToString(), ICD.Info);


            //if (buildInfo.IsControllerRequired)
            //{
            //    strBuilder.Append(AddContentHeader("Your Controller Class"));

            //    string txtControllerCode = USUtil.Initialize_UsingStatementAndClassHeader(buildInfo.InfoNameSpace, tableName, ICD.Controller);
            //    USUtil.CreateClassFileForGivenTypeClass(tableName + USUtil.Controller, txtControllerCode, ICD.Controller);

            //    strBuilder.Append(txtControllerCode);
            //}

            ////Add SQL DataProvider Class
            //if (buildInfo.IsProviderRequired)
            //{
            //    strBuilder.Append(AddContentHeader("Your SQL Data Provider Class"));

            //    string txtProviderCode = USUtil.Initialize_UsingStatementAndClassHeader(buildInfo.InfoNameSpace, tableName, ICD.DataProvider);
            //    USUtil.CreateClassFileForGivenTypeClass(tableName + USUtil.Provider, txtProviderCode, ICD.DataProvider);
            //    strBuilder.Append(txtProviderCode);
            //}
            //return strBuilder.ToString();
            return string.Empty;
        }

        public string GetTableListByDatabaseName(string dbName)
        {
            return string.Empty;
        }
    }
}
