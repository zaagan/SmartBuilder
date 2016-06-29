//using SmartBuilder.Properties;

namespace SmartBuilder.QueryBase.Dump
{

    //public class TableInfoGenerator
    //{
    //    private enum InfoParamTypes { Name, Order, Namespace };
    //    public static string BuildInfoClassforGivenDataTable(DataTable dt, string ClassName, bool isNullableRequred, bool isSerializable)
    //    {
    //        StringBuilder strbText = new StringBuilder();

    //        if (isSerializable)
    //        { strbText.Append(GetDataContractString(USUtil.T)); }

    //        strbText.Append(USUtil.T);
    //        strbText.Append(USUtil.Public_Class_S);
    //        strbText.Append(ClassName);
    //        strbText.Append(USUtil.R);
    //        strbText.Append(USUtil.T_OpenBracket);

    //        for (int i = 0; i < dt.Rows.Count; i++)
    //        {
    //            int count = i;
    //            count++;
    //            string columnName = dt.Rows[i]["ColumnName"].ToString();

    //            strbText.Append(USUtil.R);
    //            if (isSerializable)
    //            {
    //                strbText.Append(GetRequiredString(USUtil.NTT).TrimEnd());
    //                strbText.Append(GetDisplayAttributeString(USUtil.NTT).TrimEnd());
    //                strbText.Append(GetDataMemberString(USUtil.NTT, columnName, count.ToString(), "#").TrimEnd());
    //            }
    //            strbText.Append(USUtil.NTT+" public " + dt.Rows[i]["ColumnType"].ToString() + USUtil.S);

    //            string nullable = USUtil.S;
    //            if (isNullableRequred)
    //            {
    //                nullable = dt.Rows[i]["NullableSign"].ToString() + USUtil.S;
    //            }
    //            strbText.Append(columnName + nullable + " { get; set; }");
    //        }

    //        strbText.Append(USUtil.R);
    //        strbText.Append(USUtil.T_CloseBracket);

    //        return strbText.ToString();
    //    }


    //    private static string GetDataContractString(string spacings)
    //    {
    //        string returnString = string.Empty;
    //        if (Settings.Default.EnableDataContract)
    //        {
    //            StringBuilder sb = new StringBuilder();
    //            sb.Append(spacings);
    //            sb.Append("[DataContract");
    //            sb.Append(OperatorComparator(Settings.Default.EnableDataContractName, Settings.Default.EnableDataContractNamespace, InfoParamTypes.Name.ToString(), InfoParamTypes.Namespace.ToString()));
    //            sb.Append("]\n");
    //            returnString = sb.ToString();
    //        }
    //        return returnString;
    //    }

    //    private static string GetDataMemberString(string spacings, params string[] itemCode)
    //    {
    //        string returnString = string.Empty;
    //        if (Settings.Default.EnableDataMember)
    //        {
    //            StringBuilder sb = new StringBuilder();
    //            sb.Append(spacings);
    //            sb.Append("[DataMember");
    //            sb.Append(OperatorComparator(Settings.Default.EnableDataMemberName, Settings.Default.EnableDataMemberOrder, InfoParamTypes.Name.ToString(), InfoParamTypes.Order.ToString(), itemCode));
    //            sb.Append("]\n");
    //            returnString = sb.ToString();
    //        }
    //        return returnString;
    //    }

    //    private static string GetDisplayAttributeString(string spacings)
    //    {
    //        string returnString = string.Empty;
    //        if (Settings.Default.EnableDisplayAttributes)
    //        {
    //            StringBuilder sb = new StringBuilder();
    //            sb.Append(spacings);
    //            sb.Append("[DisplayAttribute");
    //            sb.Append(OperatorComparator(Settings.Default.EnableDisplayAttributeName, Settings.Default.EnableDisplayAttributeOrder, InfoParamTypes.Name.ToString(), InfoParamTypes.Order.ToString()));
    //            sb.Append("]\n");
    //            returnString = sb.ToString();
    //        }
    //        return returnString;
    //    }

    //    private static string GetRequiredString(string spacings)
    //    {
    //        string returnString = string.Empty;
    //        if (Settings.Default.EnableRequired)
    //        {
    //            StringBuilder sb = new StringBuilder();
    //            sb.Append(spacings);
    //            sb.Append("[Required]\n");
    //            returnString = sb.ToString();
    //        }
    //        return returnString;
    //    }

    //    public static string LoadTableInfoPrimarySettings(string ClassName = "YourClassName")
    //    {
    //        StringBuilder sb = new StringBuilder();
    //        sb.Append(GetDataContractString(string.Empty));
    //        sb.Append(USUtil.Public_Class_S);
    //        sb.Append(ClassName);
    //        sb.Append("\n{\n");
    //        sb.Append(GetDisplayAttributeString(USUtil.T));
    //        sb.Append(GetDataMemberString(USUtil.T));
    //        sb.Append(GetRequiredString(USUtil.T));
    //        sb.Append("\tpublic string YourInfo { get; set; }\n");
    //        sb.Append("}");
    //        return sb.ToString();
    //    }

    //    private static string OperatorComparator(bool value1, bool value2, string item1, string item2, params string[] itemCode)
    //    {
    //        string param1 = string.Empty;
    //        string param2 = string.Empty;
    //        string param3 = string.Empty;

    //        if (itemCode != null && itemCode.Length > 0)
    //        {
    //            param1 = itemCode[0];
    //            param2 = itemCode[1];

    //            bool value = string.IsNullOrEmpty(itemCode[2]);
    //            if (!value)
    //                param3 = itemCode[2];
    //        }

    //        string returnString = "";
    //        if (value1 && value2)
    //        {
    //            StringBuilder sb = new StringBuilder();
    //            sb.Append("(");
    //            sb.Append(item1);
    //            sb.Append("=\"");
    //            sb.Append(param1);
    //            sb.Append("\",");
    //            sb.Append(item2);
    //            switch (param3)
    //            {
    //                case "#":
    //                    {
    //                        sb.Append("=");
    //                        sb.Append(param2);
    //                        sb.Append(")");
    //                        break;
    //                    }

    //                default:
    //                         {
    //                        sb.Append("=\"");
    //                        sb.Append(param2);
    //                        sb.Append("\")"); ;
    //                        break;
    //                    }
    //            }

    //            returnString = sb.ToString();
    //        }

    //        else if (value1 && !value2)
    //        {
    //            returnString = "(" + item1 + "=\"\")";
    //        }

    //        else if (!value1 && value2)
    //        {
    //            StringBuilder sb = new StringBuilder();
    //            sb.Append("(");
    //            sb.Append(item2);

    //            switch (param3)
    //            {
    //                case "#":
    //                    {
    //                        sb.Append("=");
    //                        sb.Append(param2);
    //                        sb.Append(")");
    //                        break;
    //                    }

    //                default:
    //                    {
    //                        sb.Append("=\"");
    //                        sb.Append(param2);
    //                        sb.Append("\")");
    //                        break;
    //                    }
    //            }
    //            returnString = sb.ToString();
    //        }

    //        else
    //        { returnString = string.Empty; }

    //        return returnString;
    //    }
    //}

}