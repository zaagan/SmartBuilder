using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Collections;
using SmartBuilder.ToolSet.Utilities;

namespace SmartBuilder.Controls
{
    public partial class ctrlMultiTableSelector : UserControl
    {
        string ConnectionString = string.Empty, databaseName = string.Empty;
        Action<string> AddToFastNote;
        public ctrlMultiTableSelector(string connectionString, string databaseName, Action<string> addToFastNote)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.databaseName = databaseName;
            this.ConnectionString = connectionString;
            this.AddToFastNote = addToFastNote;
            BindCheckBoxList();
        }


        private void BindCheckBoxList()
        {
            AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
            namesCollection = USUtil.GetTablesFromDatabase(databaseName, ConnectionString);
            List<RandomClass> lst = new List<RandomClass>();

            for (int i = 0; i < namesCollection.Count; i++)
            { lst.Add(new RandomClass(namesCollection[i].ToString())); }

            ((ListBox)this.chkList).DataSource = lst;
            ((ListBox)this.chkList).DisplayMember = "Name";
            ((ListBox)this.chkList).ValueMember = "IsChecked";

        }

        private void btnCheckAll_Click(object sender, EventArgs e)
        { ProcessCheck(true); }

        private void ProcessCheck(bool value)
        {
            for (int i = 0; i < chkList.Items.Count; i++)
            {
                RandomClass obj = (RandomClass)chkList.Items[i];
                chkList.SetItemChecked(i, value);
            }
        }

        private void btnUncheckAll_Click(object sender, EventArgs e)
        { ProcessCheck(false); }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            string RootlibraryPath = USUtil.SavePath;
            FileManager.DeleteDirectory(RootlibraryPath);
            GetCheckedItemFromList();
            this.Cursor = Cursors.Arrow;
        }

        private void GetCheckedItemFromList()
        {
            
            ArrayList arrColl = new ArrayList();
            foreach (object itemChecked in chkList.CheckedItems)
            {
                RandomClass obj = (RandomClass)itemChecked;
                arrColl.Add(obj.Name);
            }

            if (arrColl.Count > 0)
            {
                AdonaiBuildStructureInfo buildInfo = new AdonaiBuildStructureInfo();
                buildInfo.IsSerializable = chklsSerializable.Checked;
                buildInfo.IsControllerRequired = chkIsController.Checked;
                buildInfo.IsProviderRequired = chkIsProviderRequred.Checked;
                buildInfo.IsNullableRequired = false;
                buildInfo.ConnectionString = ConnectionString;

                BELLBuilderController ctl = new BELLBuilderController();
                string message = ctl.BuildInfoClassForMulitpleTables(arrColl, buildInfo);
                AddToFastNote(message);
            }
        }
    }

    public class RandomClass
    {
        public bool IsChecked { get; set; }
        public string Name { get; set; }
        public RandomClass(string name)
        {
            this.IsChecked = false;
            Name = name;
        }
    }
}
