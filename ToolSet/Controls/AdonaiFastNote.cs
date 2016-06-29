using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Threading.Tasks;
using SmartBuilder.Properties;
using System.IO;
using System.ComponentModel;
using SmartBuilder.ToolSet.Utilities;
using SmartBuilder.Repository.MsSQL;

namespace SmartBuilder.Controls
{
    public partial class AdonaiFastNote : UserControl
    {
        /// <summary>
        /// Remove Application Flickering
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        public AdonaiFastNote()
        {
            InitializeComponent();
            FileManager.InitializeMainFolder();
            lblSavePath.Text = Properties.Settings.Default.SavePath;
            cbxAuthentication.SelectedIndex = 1;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.ftpTextBox.Text))
            {
                Clipboard.SetText(this.ftpTextBox.Text);
                USUtil.DisplayMessage(USUtil.msg_CopiedToClipboard, USUtil.msg_CopiedCaption, true);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        { ftpTextBox.Clear(); }


        #region Database Manipulator

        private Boolean isServerFilled = false;
        private Boolean isDatabaseFilled = false;
        public string ErrorConnection { get; private set; }
        public int DatabaseIndex
        {
            get { return cboDatabase.SelectedIndex; }
            set
            {
                if (cboDatabase.Items.Count > 0)
                    cboDatabase.SelectedIndex = value;
            }
        }
        public string DatabaseName
        { get { return cboDatabase.Text.Trim(); } set { cboDatabase.Text = value; } }

        public string UserName
        { get { return txtUsername.Text.Trim(); } set { txtUsername.Text = value; } }

        public string Password
        { get { return txtPassword.Text.Trim(); } set { txtPassword.Text = value; } }

        public string ServerName
        { get { return cbxServer.Text.Trim(); } set { cbxServer.Text = value; } }


        private delegate void clearCombo();
        private delegate void addCombo(string item);

        private void btnTest_Click(object sender, EventArgs e)
        {
            pnlInfoGenerator.Controls.Clear();
            if (TestConnection())
            {
                USUtil.DisplayMessage(USUtil.msg_TestSuccessfull, USUtil.msg_TestCaption, true);
                cboDatabase.Enabled = true;
                cbxGenerateInfo.Enabled = true;
            }
            else
            {
                USUtil.DisplayMessage(USUtil.msg_TestFailed + "\r\n" + ErrorConnection, USUtil.msg_ErrorCaption, false);
                cboDatabase.Enabled = false;
            }
        }

        public Boolean TestConnection()
        {
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = this.ConnectionString;
                connection.Open();
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                ErrorConnection = ex.Message;
                return false;
            }
        }

        public string ConnectionString
        {
            get
            {
                string connStr = string.Format(USUtil.DataSource_Catalog, ServerName, DatabaseName);
                if (cbxAuthentication.SelectedIndex == 1)
                    connStr += string.Format(USUtil.UserID_PWD, UserName, Password);
                else
                    connStr += USUtil.IntegratedSecurity;
                return connStr;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    string[] items = value.Split(';');
                    for (int j = 0; j < items.Length; j++)
                    {
                        string[] item = items[j].Split('=');
                        if (item[0].Equals(USUtil.UID, StringComparison.InvariantCultureIgnoreCase))
                        {
                            UserName = item[1];
                            cbxAuthentication.SelectedIndex = 1;
                        }
                        if (item[0].Equals(USUtil.PWD, StringComparison.InvariantCultureIgnoreCase))
                            Password = item[1];
                        if (item[0].Equals(USUtil.DS, StringComparison.InvariantCultureIgnoreCase))
                            ServerName = item[1];
                        if (item[0].Equals(USUtil.IC, StringComparison.InvariantCultureIgnoreCase))
                            DatabaseName = item[1];
                        if (item[0].Equals(USUtil.IS, StringComparison.InvariantCultureIgnoreCase))
                        {
                            cbxAuthentication.SelectedIndex = 0;
                            UserName = string.Empty;
                            Password = string.Empty;
                        }
                    }
                }
                else
                {
                    cbxAuthentication.SelectedIndex = 1;
                    UserName = string.Empty;
                    Password = string.Empty;
                    ServerName = USUtil.DefaultServerName;
                    DatabaseName = string.Empty;
                }
            }
        }

        public string SavePath { get; private set; }

        private void cboAuthentication_SelectedIndexChanged(object sender, EventArgs e)
        {
            UserName = string.Empty;
            Password = string.Empty;

            txtUsername.Enabled = cbxAuthentication.SelectedIndex == 1;
            txtPassword.Enabled = cbxAuthentication.SelectedIndex == 1;
            isDatabaseFilled = false;
            ClearDatabase();
            cboDatabase.Enabled = false;
        }

        private void ClearDatabase()
        {
            if (!InvokeRequired)
            {
                cbxGenerateInfo.SelectedIndex = -1;
                cboDatabase.Items.Clear();
                pnlInfoGenerator.Controls.Clear();
            }
            else
            {
                clearCombo clear = new clearCombo(ClearDatabase);
                Invoke(clear);
            }

            cbxGenerateInfo.Enabled = false;
        }

        private void cboServer_SelectedIndexChanged(object sender, EventArgs e)
        {
            isDatabaseFilled = false;
        }

        private void tbx_TextChanged(object sender, EventArgs e)
        {
            isDatabaseFilled = false;
            ClearDatabase();
            cboDatabase.Enabled = false;
        }

        private void cboServer_DropDown(object sender, EventArgs e)
        {
            try
            {
                if (!isServerFilled)
                {
                    this.Cursor = Cursors.WaitCursor;
                    List<string> servers = null;

                    var t = Task.Factory.StartNew(() =>
                      {
                          servers = GetServerList();
                      });
                    if (t.IsCompleted)
                    {
                        servers.ForEach(item => cbxServer.Items.Add(item));
                        isServerFilled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                USUtil.DisplayMessage(ex.Message, USUtil.msg_ErrorCaption, false);
            }

            Cursor = Cursors.Default;
        }

        public List<string> GetServerList()
        {
            SqlDataSourceEnumerator sqlSource = SqlDataSourceEnumerator.Instance;
            DataTable dt = sqlSource.GetDataSources();

            List<string> serverList = new List<string>();
            string serverName = null;
            string instanceName = null;

            foreach (DataRow dr in dt.Rows)
            {
                serverName = dr[USUtil.SN].ToString();
                instanceName = dr[USUtil.IN] != null ? dr[USUtil.IN].ToString() : null;

                if (string.IsNullOrEmpty(instanceName))
                    serverList.Add(serverName);
                else
                    serverList.Add(string.Format("{0}\\{1}", serverName, instanceName));
            }
            return serverList;
        }

        private void cboDatabase_DropDown(object sender, EventArgs e)
        {
            try
            {
                if (cbxAuthentication.SelectedIndex == 1)
                    if ((UserName == string.Empty) || Password == string.Empty)
                    {
                        USUtil.DisplayMessage(USUtil.msg_UNnPwd, USUtil.msg_FieldMissingCaption, false);
                        cboDatabase.DroppedDown = false;
                        return;
                    }
                this.Cursor = Cursors.WaitCursor;
                FillDatabase();
            }
            catch (Exception ex)
            {
                cboDatabase.Items.Clear();
                USUtil.DisplayMessage(ex.Message, USUtil.msg_ErrorCaption, false);
            }

            this.Cursor = Cursors.Default;

        }



        private void cboServer_TextChanged(object sender, EventArgs e)
        { isDatabaseFilled = false; }



        private void FillDatabase()
        {
            if (!isDatabaseFilled)
            {
                String connectionString = ConnectionString;
                ClearDatabase();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand(USUtil.Query_GetDatabaseList, conn))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            { AddComboItem(reader[USUtil.Name].ToString()); }

                            isDatabaseFilled = true;
                            cbxGenerateInfo.Enabled = true;
                        }
                    }
                }
            }
        }

        private void AddComboItem(string item)
        {
            if (!InvokeRequired)
                cboDatabase.Items.Add(item);
            else
            {
                addCombo add = new addCombo(AddComboItem);
                Invoke(add, new string[] { item });
            }
        }



        #endregion

        private void cbxGenerateInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isDatabaseFilled && cboDatabase.SelectedIndex >= 0)
            {
                LoadGenerator();
                pnlInfoGenerator.Select();
            }
        }

        private void LoadGenerator()
        {
            pnlInfoGenerator.Controls.Clear();
            switch (cbxGenerateInfo.SelectedIndex)
            {
                case 0:
                    pnlInfoGenerator.Controls.Add(new ctrlTableInfo(ConnectionString, DatabaseName, AddToFastNote));
                    break;
                case 1:
                    pnlInfoGenerator.Controls.Add(new ctrlMultiTableSelector(ConnectionString, DatabaseName, AddToFastNote));
                    break;
                case 2:
                    pnlInfoGenerator.Controls.Add(new ctrlSpDefinitions(ConnectionString, DatabaseName, AddToFastNote));
                    break;
            }
        }

        private void cboDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGenerator();
            pnlInfoGenerator.Select();
        }


        public void AddToFastNote(string message)
        {
            ftpTextBox.Clear();
            tbCtrlCubix.SelectedIndex = 1;
            ftpTextBox.Text = message;
        }

        private void btnBrowseFolder_Click(object sender, EventArgs e)
        {
            string path = USUtil.SavePath;
            try { System.Diagnostics.Process.Start(path); }
            catch { }
        }


        /// <summary>
        /// The Settings Tab Selected Index Change Controller
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbList_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tbList.SelectedIndex)
            {
                case 1:
                    LoadProperties();
                    break;

                default:
                    break;
            }
        }


        #region DataContract
        private void LoadProperties()
        {
            chkDisplayAttribute.Checked = Settings.Default.EnableDisplayAttributes;
            chkDisplayAttributeName.Checked = Settings.Default.EnableDisplayAttributeName;
            chkDisplayAttributeOrder.Checked = Settings.Default.EnableDisplayAttributeOrder;

            chkDataMember.Checked = Settings.Default.EnableDataMember;
            chkDataMemberName.Checked = Settings.Default.EnableDataMemberName;
            chkDataMemberOrder.Checked = Settings.Default.EnableDataMemberOrder;

            chkDataContract.Checked = Settings.Default.EnableDataContract;
            chkDataContractName.Checked = Settings.Default.EnableDataContractName;
            chkDataContractNamespace.Checked = Settings.Default.EnableDataContractNamespace;

            chkEnableRequired.Checked = Settings.Default.EnableRequired;
        }

        private void chkDefaults_CheckedChanged(object sender, EventArgs e)
        {
            pnlDataContract.Enabled = Settings.Default.EnableDataContract = chkDataContract.Checked;
            Settings.Default.EnableDataContractNamespace = chkDataContractNamespace.Checked;
            pnlDisplayAttribute.Enabled = Settings.Default.EnableDisplayAttributes = chkDisplayAttribute.Checked;
            Settings.Default.EnableDataContractName = chkDataContractName.Checked;
            Settings.Default.EnableDisplayAttributeOrder = chkDisplayAttributeOrder.Checked;
            Settings.Default.EnableDisplayAttributeName = chkDisplayAttributeName.Checked;
            Settings.Default.EnableDataMemberName = chkDataMemberName.Checked;
            Settings.Default.EnableDataMemberOrder = chkDataMemberOrder.Checked;
            pnlDataMember.Enabled = Settings.Default.EnableDataMember = chkDataMember.Checked;
            Settings.Default.EnableRequired = chkEnableRequired.Checked;

            Settings.Default.Save();
            InfoClassGenerator infoClassGenerator = new InfoClassGenerator(SystemSettings.GetSystemSettings());
            lblOutputString.Text = infoClassGenerator.LoadTableInfoPrimarySettings();
        }

        #endregion


        #region Painting the UI
        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        { GraphicsManager.DrawLineInFooter(gradientPanel1, Color.Black, 3); }
        private void spcDashboard_Panel1_Paint(object sender, PaintEventArgs e)
        { GraphicsManager.DrawLineInFooter(spcDashboard.Panel1, Color.Black, 3); }
        private void pnlTypeSelector_Paint(object sender, PaintEventArgs e)
        {
            GraphicsManager.DrawLineInHeader(pnlTypeSelector, Color.DimGray, 5);
            GraphicsManager.DrawLineInFooter(pnlTypeSelector, Color.Black, 3);
        }

        #endregion


        string oldLocationPath = string.Empty;

        private void btnBrowseDefaultSavePath_Click(object sender, EventArgs e)
        {

            var folderBrowser = new FolderBrowserDialog();
            folderBrowser.SelectedPath = Properties.Settings.Default.SavePath;
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                string destinationPath = folderBrowser.SelectedPath;

                oldLocationPath = Properties.Settings.Default.SavePath.Trim();
                if (oldLocationPath == folderBrowser.SelectedPath)
                { return; }

                lblSavePath.Text = Properties.Settings.Default.SavePath = destinationPath;
                Properties.Settings.Default.Save();
                MessageBox.Show("The new location has been saved !!", "Location Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FileManager.InitializeMainFolder();

                DialogResult objDialogResult = MessageBox.Show("Do you wish to move your files to the new location now ??", "Transport Files", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (objDialogResult == DialogResult.Yes)
                {
                    bgWorker = new BackgroundWorker();
                    bgWorker.RunWorkerAsync();
                    bgWorker.RunWorkerCompleted += bgLocationChanger_RunWorkerCompleted;
                    bgWorker.DoWork += bgLocationChanger_DoWork;
                }

            }
        }
        void bgLocationChanger_DoWork(object sender, DoWorkEventArgs e)
        {
            CopyAndReplace(oldLocationPath + "\\" + USUtil.DumpFolderName, USUtil.CurrentPath + "\\" + USUtil.DumpFolderName);
        }

        void bgLocationChanger_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Location has been changed", "Location Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CopyAndReplace(string sourcePath, string destinationPath)
        {
            foreach (string dirPath in Directory.GetDirectories(sourcePath, "*",
    SearchOption.AllDirectories))
                Directory.CreateDirectory(dirPath.Replace(sourcePath, destinationPath));

            foreach (string newPath in Directory.GetFiles(sourcePath, "*.*",
                SearchOption.AllDirectories))
                File.Copy(newPath, newPath.Replace(sourcePath, destinationPath), true);

            if (Directory.Exists(sourcePath))
            {
                try
                { Directory.Delete(sourcePath, true); }

                catch (IOException e)
                {
                    MessageBox.Show(e.Message, USUtil.msg_ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }


    }
}
