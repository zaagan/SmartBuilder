using System;
using System.Windows.Forms;

using gudusoft.gsqlparser;
using gudusoft.gsqlparser.Units;


namespace SmartBuilder.ToolSet.Controls
{
    public partial class SQLFormatter : UserControl
    {
        
        const int WS_MINIMIZEBOX = 0x20000;
        const int CS_DBLCLKS = 0x8;
        protected override CreateParams CreateParams
        {
         
            get
            {
                CreateParams cp = base.CreateParams;
                //cp.Style &= ~0x02000000;  // Turn off WS_CLIPCHILDREN
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                cp.Style |= WS_MINIMIZEBOX;
                cp.ClassStyle |= CS_DBLCLKS;
                return cp;
            }
        }

        public SQLFormatter()
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            tlpStage.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);
            cmbdatabases.SelectedIndex = 0;
        }

        private void setupformatoptions()
        {
            //for more format options, please check document

            lzbasetype.gFmtOpt.Select_Columnlist_Style = TAlignStyle.asStacked;
            lzbasetype.gFmtOpt.Select_Columnlist_Comma = TLinefeedsCommaOption.lfAfterComma;
            lzbasetype.gFmtOpt.SelectItemInNewLine = false;
            lzbasetype.gFmtOpt.AlignAliasInSelectList = true;
            lzbasetype.gFmtOpt.TreatDistinctAsVirtualColumn = false;

            //setup more format options ...

            lzbasetype.gFmtOpt.linenumber_enabled = false;

        }

        private void setuphighlighterAttributes()
        {
            lzbasetype.gFmtOpt.HighlightingFontname = "Courier New";
            lzbasetype.gFmtOpt.HighlightingFontsize = 10;

            //for other elements you want to customize, please check document
            lzbasetype.gFmtOpt.HighlightingElements[(int)TLzHighlightingElement.sfkIdentifer].SetForegroundInRGB("#008000");
            lzbasetype.gFmtOpt.HighlightingElements[(int)TLzHighlightingElement.sfkIdentifer].StyleBold = true;
            lzbasetype.gFmtOpt.HighlightingElements[(int)TLzHighlightingElement.sfkIdentifer].StyleItalic = false;
            lzbasetype.gFmtOpt.HighlightingElements[(int)TLzHighlightingElement.sfkIdentifer].StyleStrikeout = false;
            lzbasetype.gFmtOpt.HighlightingElements[(int)TLzHighlightingElement.sfkIdentifer].StyleUnderline = false;

            //setup more elements attributes ....
        }

        private void btnFormatSQL_Click(object sender, EventArgs e)
        {
            tbCtrlStage.SelectedIndex = 0;
            setupformatoptions();

            TGSqlParser sqlparser = new TGSqlParser(getDBVendor());
            sqlparser.SqlText.Text = inputsql.Text;
            int i = sqlparser.PrettyPrint();
            if (i == 0)
                outputsql.Text = sqlparser.FormattedSqlText.Text;
            else
                outputsql.Text = sqlparser.ErrorMessages;

        }

        private void btnFormatSqlToHtml_Click(object sender, EventArgs e)
        {
            tbCtrlStage.SelectedIndex = 1;
            setupformatoptions();
            setuphighlighterAttributes();

            TGSqlParser sqlparser = new TGSqlParser(getDBVendor());
            sqlparser.SqlText.Text = inputsql.Text;
            webBrowser1.DocumentText = sqlparser.ToHtml(TOutputFmt.ofhtml);

        }

        private void btnFormatSQLInRTF_Click(object sender, EventArgs e)
        {
            tbCtrlStage.SelectedIndex = 2;
            setupformatoptions();
            setuphighlighterAttributes();

            TGSqlParser sqlparser = new TGSqlParser(getDBVendor());
            sqlparser.SqlText.Text = inputsql.Text;
            //richTextBox1.Text = sqlparser.ToRTF(TOutputFmt.ofrtf);
            richTextBox1.Rtf = sqlparser.ToRTF(TOutputFmt.ofrtf);
        }

        private TDbVendor getDBVendor()
        {
            TDbVendor dbVendor = TDbVendor.DbVMssql;
            switch (cmbdatabases.SelectedIndex)
            {
                case 0:
                    dbVendor = TDbVendor.DbVMssql;
                    break;
                case 1:
                    dbVendor = TDbVendor.DbVOracle;
                    break;
                case 2:
                    dbVendor = TDbVendor.DbVDB2;
                    break;
                case 3:
                    dbVendor = TDbVendor.DbVMysql;
                    break;
                case 4:
                    dbVendor = TDbVendor.DbVAccess;
                    break;
                default:
                    break;
            }

            return dbVendor;
        }
    }
}
