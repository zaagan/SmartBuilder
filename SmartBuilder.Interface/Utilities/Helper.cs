namespace SmartBuilder
{
    public class Helper
    {


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

    }
}
