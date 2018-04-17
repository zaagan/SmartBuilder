using System.Data;
using System.Text;

namespace SmartBuilder.Repository.MsSQL
{
    public class InfoClassGenerator
    {
        private enum InfoParamTypes { Name, Order, Namespace };

        SystemSettingsInfo settings = null;

        public InfoClassGenerator(SystemSettingsInfo systemSettingsInfo)
        { this.settings = systemSettingsInfo; }
     

        public string BuildInfoClassforGivenDataTable(DataTable dt, string ClassName, bool isNullableRequred, bool isSerializable)
        {
            StringBuilder strbText = new StringBuilder();

            if (isSerializable)
            { strbText.Append(GetDataContractString(Helper.T)); }

            strbText.Append(Helper.T);
            strbText.Append(Helper.Public_Class_S);
            strbText.Append(ClassName);
            strbText.Append(Helper.R);
            strbText.Append(Helper.T_OpenBracket);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int count = i;
                count++;
                string columnName = dt.Rows[i]["ColumnName"].ToString();

                strbText.Append(Helper.R);
                if (isSerializable)
                {
                    strbText.Append(GetRequiredString(Helper.NTT).TrimEnd());
                    strbText.Append(GetDisplayAttributeString(Helper.NTT).TrimEnd());
                    strbText.Append(GetDataMemberString(Helper.NTT, columnName, count.ToString(), "#").TrimEnd());
                }

                string nullable = Helper.S;
                if (isNullableRequred)
                {
                    nullable = dt.Rows[i]["NullableSign"].ToString() + Helper.S;
                }

                strbText.Append(Helper.NTT + " public " + dt.Rows[i]["ColumnType"].ToString() + nullable);

                strbText.Append(columnName + " { get; set; }");
            }

            strbText.Append(Helper.R);
            strbText.Append(Helper.T_CloseBracket);

            return strbText.ToString();
        }


        private string GetDataContractString(string spacings)
        {
            string returnString = string.Empty;
            if (settings.EnableDataContract)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(spacings);
                sb.Append("[DataContract");
                sb.Append(OperatorComparator(settings.EnableDataContractName, settings.EnableDataContractNamespace, InfoParamTypes.Name.ToString(), InfoParamTypes.Namespace.ToString()));
                sb.Append("]\n");
                returnString = sb.ToString();
            }
            return returnString;
        }

        private string GetDataMemberString(string spacings, params string[] itemCode)
        {
            string returnString = string.Empty;
            if (settings.EnableDataMember)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(spacings);
                sb.Append("[DataMember");
                sb.Append(OperatorComparator(settings.EnableDataMemberName, settings.EnableDataMemberOrder, InfoParamTypes.Name.ToString(), InfoParamTypes.Order.ToString(), itemCode));
                sb.Append("]\n");
                returnString = sb.ToString();
            }
            return returnString;
        }

        private string GetDisplayAttributeString(string spacings)
        {
            string returnString = string.Empty;
            if (settings.EnableDisplayAttributes)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(spacings);
                sb.Append("[DisplayAttribute");
                sb.Append(OperatorComparator(settings.EnableDisplayAttributeName, settings.EnableDisplayAttributeOrder, InfoParamTypes.Name.ToString(), InfoParamTypes.Order.ToString()));
                sb.Append("]\n");
                returnString = sb.ToString();
            }
            return returnString;
        }

        private  string GetRequiredString(string spacings)
        {
            string returnString = string.Empty;
            if (settings.EnableRequired)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(spacings);
                sb.Append("[Required]\n");
                returnString = sb.ToString();
            }
            return returnString;
        }

        public string LoadTableInfoPrimarySettings(string ClassName = "YourClassName")
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(GetDataContractString(string.Empty));
            sb.Append(Helper.Public_Class_S);
            sb.Append(ClassName);
            sb.Append("\n{\n");
            sb.Append(GetDisplayAttributeString(Helper.T));
            sb.Append(GetDataMemberString(Helper.T));
            sb.Append(GetRequiredString(Helper.T));
            sb.Append("\tpublic string YourInfo { get; set; }\n");
            sb.Append("}");
            return sb.ToString();
        }

        private static string OperatorComparator(bool value1, bool value2, string item1, string item2, params string[] itemCode)
        {
            string param1 = string.Empty;
            string param2 = string.Empty;
            string param3 = string.Empty;

            if (itemCode != null && itemCode.Length > 0)
            {
                param1 = itemCode[0];
                param2 = itemCode[1];

                bool value = string.IsNullOrEmpty(itemCode[2]);
                if (!value)
                    param3 = itemCode[2];
            }

            string returnString = "";
            if (value1 && value2)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("(");
                sb.Append(item1);
                sb.Append("=\"");
                sb.Append(param1);
                sb.Append("\",");
                sb.Append(item2);
                switch (param3)
                {
                    case "#":
                        {
                            sb.Append("=");
                            sb.Append(param2);
                            sb.Append(")");
                            break;
                        }

                    default:
                        {
                            sb.Append("=\"");
                            sb.Append(param2);
                            sb.Append("\")"); ;
                            break;
                        }
                }

                returnString = sb.ToString();
            }

            else if (value1 && !value2)
            {
                returnString = "(" + item1 + "=\"\")";
            }

            else if (!value1 && value2)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("(");
                sb.Append(item2);

                switch (param3)
                {
                    case "#":
                        {
                            sb.Append("=");
                            sb.Append(param2);
                            sb.Append(")");
                            break;
                        }

                    default:
                        {
                            sb.Append("=\"");
                            sb.Append(param2);
                            sb.Append("\")");
                            break;
                        }
                }
                returnString = sb.ToString();
            }

            else
            { returnString = string.Empty; }

            return returnString;
        }
    }
}
