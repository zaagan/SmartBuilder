namespace SmartBuilder.ToolSet.Utilities
{
    public class SystemSettings
    {
        public static SystemSettingsInfo GetSystemSettings()
        {
            return new SystemSettingsInfo()
            {
                EnableDataContract = Properties.Settings.Default.EnableDataContract,
                EnableDataContractName = Properties.Settings.Default.EnableDataContractName,
                EnableDataContractNamespace = Properties.Settings.Default.EnableDataContractNamespace,
                EnableDataMember = Properties.Settings.Default.EnableDataMember,
                EnableDataMemberName = Properties.Settings.Default.EnableDataMemberName,
                EnableDataMemberOrder = Properties.Settings.Default.EnableDataMemberOrder,
                EnableDisplayAttributeName = Properties.Settings.Default.EnableDisplayAttributeName,
                EnableDisplayAttributeOrder = Properties.Settings.Default.EnableDisplayAttributeOrder,
                EnableDisplayAttributes = Properties.Settings.Default.EnableDisplayAttributes,
                EnableRequired = Properties.Settings.Default.EnableRequired
            };
        }
    }
}
