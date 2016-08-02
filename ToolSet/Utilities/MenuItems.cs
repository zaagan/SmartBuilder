using System.Collections.Generic;

namespace SmartBuilder.ToolSet.Utilities
{

    public class MenuItems
    {


        public static List<KeyValuePair<int, string>> GetItems()
        {
            List<KeyValuePair<int, string>> lstItems = new List<KeyValuePair<int, string>>();
            lstItems.Add(new KeyValuePair<int, string>(1, "SQL Generator"));
            lstItems.Add(new KeyValuePair<int, string>(2, "Code Comparer"));
            lstItems.Add(new KeyValuePair<int, string>(3, "GS Generator"));
            return lstItems;
        }


    }
}
