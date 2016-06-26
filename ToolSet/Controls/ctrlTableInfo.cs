using System;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;

namespace SmartBuilder.Controls
{
    public partial class ctrlTableInfo : UserControl
    {
        Action<string> AddToFastNote;
        string ConnectionString = string.Empty, databaseName = string.Empty;
        public ctrlTableInfo(string connectionString, string databaseName, Action<string> addToFastNote)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.databaseName = databaseName;
            this.ConnectionString = connectionString;
            this.AddToFastNote = addToFastNote;

            BuinTypeDropdown();
            txtTableName.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtTableName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
            namesCollection = USUtil.GetTableList(databaseName, connectionString);
            txtTableName.AutoCompleteCustomSource = namesCollection;
        }

        private void ddlType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTableName.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtTableName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();

            if (ddlType.SelectedValue.ToString() == USUtil.Tbl || ddlType.SelectedValue.ToString() == "")
            {
                namesCollection = USUtil.GetTableList(databaseName, ConnectionString);
                txtTableName.AutoCompleteCustomSource = namesCollection;
            }
            else
            {
                namesCollection = USUtil.GetStoredProcedureList(databaseName, ConnectionString);
                txtTableName.AutoCompleteCustomSource = namesCollection;
            }
        }


        private ArrayList BuildSQLParameter(IList<KeyValuePair<string, object>> inputParamList)
        {
            ArrayList ControlNames = new ArrayList();
            if (inputParamList != null && inputParamList.Count > 0)
            {

                for (int i = 0; i < inputParamList.Count; i++)
                {
                    KeyValuePair<string, object> objKeyvalu = inputParamList[i];
                    string strKey = objKeyvalu.Key;
                    object strValue = objKeyvalu.Value;

                    string[] split = strKey.Split(',');
                    if (split != null && split.Length > 0)
                    {
                        string strParaName = split[0].ToString();
                        string strParaTrype = split[1].ToString();

                        string txtBoxName = strParaName; ;

                        ControlNames.Add(txtBoxName);
                    }

                }
            }
            return ControlNames;
        }

        private void BuinTypeDropdown()
        {
            ArrayList arrColl = new ArrayList();
            arrColl.Add(USUtil.Tbl);
            arrColl.Add("Stored Procedure");
            ddlType.DataSource = arrColl;
        }

        private void btnGenrate_Click(object sender, EventArgs e)
        {
            try
            {
                string RootlibraryPath = USUtil.SavePath;
                FileManager.DeleteDirectory(RootlibraryPath);

                string defaultNameSpace = tbxDefaultNamespace.Text.Trim();
                if (defaultNameSpace == string.Empty)
                { defaultNameSpace = USUtil.DefaultNameSpace; }

                if (ddlType.SelectedValue.ToString().Trim() == USUtil.Tbl || ddlType.SelectedValue.ToString().Trim() == string.Empty)
                {
                    AdonaiBuildStrucutreInfo buildInfo = new AdonaiBuildStrucutreInfo();
                    buildInfo.TableName = txtTableName.Text.Trim();
                    buildInfo.InfoClassName = txtClassName.Text.Trim();
                    buildInfo.ConnectionString = ConnectionString;
                    buildInfo.IsNullableRequired = chkIsNullableRequred.Checked;
                    buildInfo.IsSerializable = chklsSerializable.Checked;
                    buildInfo.IsControllerRequired = chkIsController.Checked;
                    buildInfo.IsProviderRequired = chkIsProviderRequred.Checked;
                    buildInfo.InfoNameSpace = defaultNameSpace;
                    BELLBuilderController ctlBELL = new BELLBuilderController();
                    string output = ctlBELL.GetTableInfoByTableNameandClassName(buildInfo);

                    AddToFastNote(output);
                }
                else
                {
                    AppUtilityDataProvider dataProvider = new AppUtilityDataProvider();
                    IList<KeyValuePair<string, object>> inputParamList = dataProvider.GetSpPrametersBySpName(txtTableName.Text.Trim(), ConnectionString);
                    if (inputParamList.Count > 0)
                    {
                        IList<KeyValuePair<string, object>> listColl = new List<KeyValuePair<string, object>>();

                        ArrayList arrColl = BuildSQLParameter(inputParamList);
                        for (int i = 0; i < arrColl.Count; i++)
                        {
                            listColl.Add(new KeyValuePair<string, object>(arrColl[i].ToString(), "1"));
                        }

                        string strInfoText = dataProvider.ExecuteGivenProcedureBuildInfoClass(txtTableName.Text, tbxDefaultNamespace.Text.Trim(), txtClassName.Text.Trim(), listColl, ConnectionString);

                        AddToFastNote(strInfoText);
                    }
                    else
                        USUtil.DisplayMessage(USUtil.msg_SPHasNoParam, USUtil.msg_ErrorCaption, false);
                }

            }
            catch (Exception ex)
            {
                USUtil.DisplayMessage(ex.Message, USUtil.msg_ErrorCaption, false);
            }
        }

        private void txtTableName_TextChanged(object sender, EventArgs e)
        {
            txtClassName.Text = txtTableName.Text.Trim();
        }

    }
}
