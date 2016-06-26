namespace SmartBuilder
{
    public class AdonaiBuildStrucutreInfo
    {
        public string ConnectionString { get; set; }
        public bool IsNullableRequired { get; set; }
        public bool IsSerializable { get; set; }
        public bool IsControllerRequired { get; set; }
        public bool IsProviderRequired { get; set; }

        public string TableName { get; set; }

        public string InfoNameSpace { get; set; }
        public string ControllerNameSpace { get; set; }
        public string ProviderNameSpace { get; set; }

        public string InfoClassName { get; set; }
        public string ControllerClassName { get; set; }
        public string ProviderClassName { get; set; }


    }
}
