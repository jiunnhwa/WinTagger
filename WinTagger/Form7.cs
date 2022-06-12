
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WinTagger.HELPER;

namespace WinTagger
{
  public class Form7 : Form
  {
    private System.Timers.Timer StatusTimer = new System.Timers.Timer();
    private BindingSource bsProvider = new BindingSource();
    private DataTable dtProvider = (DataTable) null;
    private DataSet dsProvider = (DataSet) null;
    private BindingSource bsGiata = new BindingSource();
    private DataTable dtGiata = (DataTable) null;
    private DataSet dsGiata = (DataSet) null;
    private string JobSelection;
    private MySQL DB = new MySQL();
    private string strSQL;
    private IContainer components = (IContainer) null;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem fileToolStripMenuItem;
    private ToolStripMenuItem exitToolStripMenuItem;
    private StatusStrip statusStrip1;
    private SplitContainer splitContainer1;
    private ToolStrip toolStrip1;
    private ToolStripTextBox toolStripTextBox1;
    private ToolStripComboBox toolStripComboBox1;
    private ToolStripButton toolStripButton1;
    private ToolStripButton toolStripSplitButton1;
    private BindingNavigator bnavProvider;
    private ToolStripLabel bindingNavigatorCountItem;
    private ToolStripButton bindingNavigatorMoveFirstItem;
    private ToolStripButton bindingNavigatorMovePreviousItem;
    private ToolStripSeparator bindingNavigatorSeparator;
    private ToolStripTextBox bindingNavigatorPositionItem;
    private ToolStripSeparator bindingNavigatorSeparator1;
    private ToolStripButton bindingNavigatorMoveNextItem;
    private ToolStripButton bindingNavigatorMoveLastItem;
    private ToolStripSeparator bindingNavigatorSeparator2;
    private TextBox tbGiataID;
    private Label lblGiataID;
    private Label lblStatus;
    private ComboBox cboStatus;
    private Button cmdSave;
    private TextBox tbProviderAddress;
    private DataGridView dgvProvider;
    private TextBox tbSQLWhere;
    private Label lblSQL;
    private TextBox tbCriteriaCountry;
    private Label lbCriteriaCountry;
    private TextBox tbCriteriaCity;
    private Label lblCriteriaCity;
    private TextBox tbCriteriaHotel;
    private Label lblCriteriaHotel;
    private Button cmdCriteriaC;
    private Button cmdCriteriaB;
    private Button cmdCriteriaA;
    private Button cmdSearch;
    private ToolStripStatusLabel tsStatusText;
    private ToolTip toolTip1;
    private CheckBox chkAutoRefresh;
    private Button cmdReload;
    private DataGridView dgvGiata;
    private TextBox tbGiataAddress3;
    private TextBox tbGiataAddress2;
    private TextBox tbGiataAddress1;
    private Button cmdCopyGiataID;
    private TextBox tbGiataGID;
    private Button cmdFilter;
    private ComboBox cboFilterJobStatus;
    private ToolStripStatusLabel tsConnServer;

    public Form7()
    {
      this.InitializeComponent();
      this.InitializeFormEvents();
    }

    private void InitializeFormEvents()
    {
      this.Load += new EventHandler(this.Form_Load);
      this.Shown += new EventHandler(this.Form_Shown);
      this.Resize += new EventHandler(this.Form_Resize);
      this.FormClosing += new FormClosingEventHandler(this.Form_Closing);
      this.bsProvider.PositionChanged += new EventHandler(this.BsProvider_PositionChanged);
      this.tbSQLWhere.TextChanged += new EventHandler(this.TbSQLWhere_TextChanged);
    }

    private void BsProvider_PositionChanged(object sender, EventArgs e) => this.dgvProvide_ResetOnPositionChange();

    private void TbSQLWhere_TextChanged(object sender, EventArgs e) => this.cmdSearch.Enabled = !string.IsNullOrWhiteSpace(this.tbSQLWhere.Text);

    private void Form_Resize(object sender, EventArgs e) => this.HandleResize();

    private void Form_Shown(object sender, EventArgs e) => this.ClearJobSelection();

    private void Form_Load(object sender, EventArgs e)
    {
      this.Text = string.Format(string.Format("WinTagger[v{0}]", (object) Program.AppVer)) + ": " + ((IEnumerable<string>) Program.ConnStringMYSQL.Split(';')).Where<string>((Func<string, bool>) (item => item.ToLower().Contains("server"))).First<string>();
      this.LoadToolTips();
      this.LoadComboBox(this.toolStripComboBox1.ComboBox);
      this.LoadJobStatusItems();
      this.LoadJobFilterStatusItems();
    }

    private void LoadToolTips()
    {
      this.toolTip1.SetToolTip((Control) this.chkAutoRefresh, "Auto-Refresh table upon Save. Do not check if slow internet, or too many records.");
      this.toolTip1.SetToolTip((Control) this.cmdCriteriaA, "Hotel + City + Country.");
      this.toolTip1.SetToolTip((Control) this.cmdCriteriaB, "Hotel + Country.");
      this.toolTip1.SetToolTip((Control) this.cmdCriteriaC, "Hotel.");
      this.toolTip1.SetToolTip((Control) this.cmdCopyGiataID, "Copy giata id.");
    }

    private void Form_Closing(object sender, FormClosingEventArgs e)
    {
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();

    private void fileToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void toolStripButton1_Click(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(this.toolStripTextBox1.Text.ToString()))
      {
        int num = (int) MessageBox.Show("Please enter your username.", "Error: No UserName.");
        this.toolStripTextBox1.Focus();
      }
      else if (string.IsNullOrEmpty(this.JobSelection))
      {
        int num = (int) MessageBox.Show("Please select a job from the dropdown list.", "Error: No Selection.");
        this.toolStripComboBox1.Focus();
      }
      else
        this.LoadProvider();
    }

    private void toolStripSplitButton1_Click(object sender, EventArgs e) => this.ClearJobSelection();

    private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.JobSelection = this.toolStripComboBox1.Text;
      this.Text = this.toolStripComboBox1.Text;
    }

    private void cboStatus_SelectedIndexChanged(object sender, EventArgs e)
    {
      string str = this.cboStatus.SelectedItem.ToString();
      if (!(str == "OK"))
      {
        if (!(str == "Giata ID not found"))
        {
          if (!(str == "KIV"))
            return;
          this.tbGiataID.Text = "0";
        }
        else
          this.tbGiataID.Text = "0";
      }
      else
        this.tbGiataID.Text = this.tbGiataGID.Text;
    }

    private void cmdReload_Click(object sender, EventArgs e) => this.ReloadProviderData();

    private void cboFilterJobStatus_Click(object sender, EventArgs e)
    {
    }

    private void cmdFilter_Click(object sender, EventArgs e)
    {
      if (this.toolStripComboBox1.SelectedIndex == -1)
        return;
      string str1 = this.cboFilterJobStatus.SelectedIndex == -1 ? "" : this.cboFilterJobStatus.SelectedItem.ToString();
      string str2 = str1;
      if (!(str2 == "ALL"))
      {
        if (str2 == "NEW")
          this.FilterProviderData(string.Format(" AND status IS NULL "));
        else
          this.FilterProviderData(string.Format(string.Format(" AND status = '{0}' ", (object) str1)));
      }
      else
        this.FilterProviderData(string.Format(""));
    }

    private void dgvProvider_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      this.dgvProvide_ResetOnPositionChange();
      this.ClearRightPaneItems();
      this.tbProviderAddress.Text = this.dgvProvider.CurrentRow.Cells["provideraddress"].Value.ToString();
      this.tbCriteriaHotel.Text = this.Sanitize(this.dgvProvider.CurrentRow.Cells["providerhotelname"].Value.ToString());
      this.tbCriteriaCity.Text = this.dgvProvider.CurrentRow.Cells["providercity"].Value.ToString();
      this.tbCriteriaCountry.Text = this.dgvProvider.CurrentRow.Cells["providercountry"].Value.ToString();
      this.cmdCriteriaA.PerformClick();
    }

    private void dgvProvide_ResetOnPositionChange()
    {
      this.tbGiataGID.Text = "";
      this.tbGiataID.Text = "";
      this.tbProviderAddress.Text = "";
      this.cboStatus.Text = "";
      this.tsStatusText.Text = "";
    }

    private void dgvGiata_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      this.tbGiataAddress1.Text = this.dgvGiata.CurrentRow.Cells["address1"].Value.ToString();
      this.tbGiataAddress2.Text = this.dgvGiata.CurrentRow.Cells["address2"].Value.ToString();
      this.tbGiataAddress3.Text = this.dgvGiata.CurrentRow.Cells["address_more"].Value.ToString();
      this.tbGiataGID.Text = this.dgvGiata.CurrentRow.Cells["giata_id"].Value.ToString();
    }

    private void cmdCopyGiataID_Click(object sender, EventArgs e) => this.tbGiataID.Text = this.tbGiataGID.Text;

    private void splitContainer1_SizeChanged(object sender, EventArgs e) => this.HandleResize();

    private void cmdSave_Click(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(this.cboStatus.Text.ToString()))
      {
        int num = (int) MessageBox.Show("Please set job status.", "Error: No Job Status.");
        this.cboStatus.Focus();
      }
      else
      {
        if (this.cboStatus.Text.ToString().ToUpper().Trim() == "OK")
        {
          if (string.IsNullOrEmpty(this.tbGiataID.Text.ToString()))
          {
            int num = (int) MessageBox.Show("Please set Giata ID.", "Error: Status OK but No Giata ID.");
            this.tbGiataID.Focus();
            return;
          }
        }
        else
        {
          this.tbGiataID.Text = "";
          this.tsStatusText.Text = "";
        }
        using (new WaitCursor((Control) this))
        {
          this.SaveJob();
          if (!this.chkAutoRefresh.Checked)
            return;
          this.ReloadProviderData();
        }
      }
    }

    private void cmdCriteriaA_Click(object sender, EventArgs e) => this.tbSQLWhere.Text = string.Format(string.Format("hotel_name Like '%{0}%' AND city_name = '{1}' AND country_code = '{2}'", (object) this.tbCriteriaHotel.Text.Trim().Replace(" ", "%").Replace("%%", "%"), (object) this.tbCriteriaCity.Text.Trim(), (object) this.tbCriteriaCountry.Text.Trim()));

    private void cmdCriteriaB_Click(object sender, EventArgs e) => this.tbSQLWhere.Text = string.Format(string.Format("hotel_name Like '%{0}%' AND country_code = '{1}'", (object) this.tbCriteriaHotel.Text.Trim().Replace(" ", "%").Replace("%%", "%"), (object) this.tbCriteriaCountry.Text.Trim()));

    private void cmdCriteriaC_Click(object sender, EventArgs e) => this.tbSQLWhere.Text = string.Format(string.Format("hotel_name Like '%{0}%'", (object) this.tbCriteriaHotel.Text.Trim().Replace(" ", "%").Replace("%%", "%")));

    private void cmdSearch_Click(object sender, EventArgs e)
    {
      DateTime now = DateTime.Now;
      this.tsStatusText.Text = "Searching started ...";
      using (new WaitCursor((Control) this))
        this.LoadGiataData("WHERE " + this.tbSQLWhere.Text.Trim());
      this.tsStatusText.Text = "Searching took " + (object) Math.Round(DateTime.Now.Subtract(now).TotalSeconds, 2) + "s";
    }

    private void HandleResize()
    {
      this.dgvProvider.Width = this.splitContainer1.Panel1.Width - 10;
      this.tbProviderAddress.Left = this.dgvProvider.Right - this.tbProviderAddress.Width;
    }

    private void LoadComboBox(ComboBox cbo)
    {
      foreach (DataRow row in (InternalDataCollectionBase) this.DB.Reader2DataTable("SELECT providercity, providercountry FROM stagingmap GROUP BY 1,2 ORDER BY 1,2", Program.ConnStringMYSQL).Rows)
        cbo.Items.Add((object) (row.ItemArray[0].ToString() + "|" + row.ItemArray[1].ToString()));
    }

    private void LoadJobStatusItems() => this.cboStatus.Items.AddRange(new object[3]
    {
      (object) "OK",
      (object) "Giata ID not found",
      (object) "KIV"
    });

    private void LoadJobFilterStatusItems() => this.cboFilterJobStatus.Items.AddRange(new object[5]
    {
      (object) "ALL",
      (object) "NEW",
      (object) "OK",
      (object) "Giata ID not found",
      (object) "KIV"
    });

    private void FilterProviderData(string jobstatusSQL) => this.LoadProviderData(this.GetProviderBaseSQL() + jobstatusSQL);

    private void LoadProvider() => this.LoadProviderData(this.GetProviderBaseSQL());

    private string GetProviderBaseSQL()
    {
      string[] strArray = this.toolStripComboBox1.ComboBox.Text.Trim().Split('|');
      return string.Format(string.Format("SELECT providerhotelname, providercity, providercountry, provideraddress, giataid, providercode, status, sno FROM stagingmap WHERE providercity = '{0}' AND providercountry = '{1}' ", (object) strArray[0], (object) strArray[1]));
    }

    private void LoadProviderData(string strSQL)
    {
      this.dsProvider = this.DB.GetDataSet(strSQL, Program.ConnStringMYSQL);
      this.dtProvider = this.dsProvider.Tables[0];
      this.bsProvider.DataSource = (object) this.dsProvider;
      this.bsProvider.DataMember = this.dsProvider.Tables[0].TableName;
      this.dgvProvider.DataSource = (object) this.bsProvider;
      this.bnavProvider.BindingSource = this.bsProvider;
    }

    private void ReloadProviderData()
    {
      int position = this.bsProvider.Position;
      this.LoadProvider();
      this.bsProvider.Position = position;
    }

    private void LoadGiataData(string SQLwhere)
    {
      try
      {
        this.dgvGiata.ColumnHeadersVisible = false;
        this.dgvGiata.DataSource = (object) null;
        this.dsGiata = this.DB.GetDataSet("SELECT hotel_name, city_name, address1, address2, address_more, giata_id FROM tbl_giata_hotel " + SQLwhere + " AND giata_id>0 ", Program.ConnStringMYSQL);
        this.dtGiata = this.dsGiata.Tables[0];
        this.bsGiata.DataSource = (object) this.dsGiata;
        this.bsGiata.DataMember = this.dsGiata.Tables[0].TableName;
        this.dgvGiata.ColumnHeadersVisible = true;
        this.dgvGiata.DataSource = (object) this.bsGiata;
      }
      catch (Exception ex)
      {
        throw;
      }
    }

    private void ClearJobSelection()
    {
      this.JobSelection = "";
      this.toolStripComboBox1.SelectedItem = (object) null;
      this.toolStripComboBox1.Text = "";
      this.toolStripTextBox1.Text = "";
      this.toolStripTextBox1.Focus();
      this.chkAutoRefresh.Checked = false;
      this.dgvProvider.DataSource = (object) null;
      this.bnavProvider.BindingSource = (BindingSource) null;
      this.tbProviderAddress.Text = "";
    }

    private void ClearRightPaneItems()
    {
      this.tbCriteriaHotel.Text = "";
      this.tbCriteriaCity.Text = "";
      this.tbCriteriaCountry.Text = "";
      this.tbSQLWhere.Text = "";
      this.tbGiataAddress1.Text = "";
      this.tbGiataAddress2.Text = "";
      this.tbGiataAddress3.Text = "";
      this.tbGiataGID.Text = "";
    }

    private string Sanitize(string str) => str.Trim().ToUpper().Replace("HOTEL", "");

    private void SaveJob()
    {
      long num = string.IsNullOrEmpty(this.tbGiataID.Text) ? 0L : Convert.ToInt64(this.tbGiataID.Text);
      this.strSQL = "";
      this.strSQL += "UPDATE stagingmap ";
      this.strSQL += string.Format("SET ");
      this.strSQL += string.Format(string.Format("giataid = {0},", (object) num));
      this.strSQL += string.Format(string.Format("status = '{0}',", (object) this.cboStatus.Text));
      this.strSQL += string.Format(string.Format("lastupdateby = '{0}',", (object) this.toolStripTextBox1.Text));
      this.strSQL += string.Format(string.Format("lastupdate = '{0}' ", (object) DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")));
      this.strSQL += string.Format(string.Format("WHERE sno = '{0}' ", (object) this.dgvProvider.CurrentRow.Cells["sno"].Value.ToString()));
      Debug.Print(this.strSQL);
      Program.ErrStr = string.Empty;
      this.DB.ExecNonQuery(this.strSQL, Program.ConnStringMYSQL);
      if (string.IsNullOrEmpty(Program.ErrStr))
        this.tsStatusText.Text = string.Format("Save Done.");
      else
        this.tsStatusText.Text = Program.ErrStr;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form7));
      DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
      this.menuStrip1 = new MenuStrip();
      this.fileToolStripMenuItem = new ToolStripMenuItem();
      this.exitToolStripMenuItem = new ToolStripMenuItem();
      this.statusStrip1 = new StatusStrip();
      this.tsStatusText = new ToolStripStatusLabel();
      this.splitContainer1 = new SplitContainer();
      this.cmdFilter = new Button();
      this.cmdCopyGiataID = new Button();
      this.cmdReload = new Button();
      this.chkAutoRefresh = new CheckBox();
      this.tbGiataID = new TextBox();
      this.lblGiataID = new Label();
      this.lblStatus = new Label();
      this.cboStatus = new ComboBox();
      this.cmdSave = new Button();
      this.tbProviderAddress = new TextBox();
      this.dgvProvider = new DataGridView();
      this.bnavProvider = new BindingNavigator(this.components);
      this.bindingNavigatorCountItem = new ToolStripLabel();
      this.bindingNavigatorMoveFirstItem = new ToolStripButton();
      this.bindingNavigatorMovePreviousItem = new ToolStripButton();
      this.bindingNavigatorSeparator = new ToolStripSeparator();
      this.bindingNavigatorPositionItem = new ToolStripTextBox();
      this.bindingNavigatorSeparator1 = new ToolStripSeparator();
      this.bindingNavigatorMoveNextItem = new ToolStripButton();
      this.bindingNavigatorMoveLastItem = new ToolStripButton();
      this.bindingNavigatorSeparator2 = new ToolStripSeparator();
      this.toolStrip1 = new ToolStrip();
      this.toolStripTextBox1 = new ToolStripTextBox();
      this.toolStripComboBox1 = new ToolStripComboBox();
      this.toolStripButton1 = new ToolStripButton();
      this.toolStripSplitButton1 = new ToolStripButton();
      this.tbGiataGID = new TextBox();
      this.tbGiataAddress3 = new TextBox();
      this.tbGiataAddress2 = new TextBox();
      this.tbGiataAddress1 = new TextBox();
      this.dgvGiata = new DataGridView();
      this.cmdCriteriaC = new Button();
      this.cmdCriteriaB = new Button();
      this.cmdCriteriaA = new Button();
      this.cmdSearch = new Button();
      this.tbSQLWhere = new TextBox();
      this.lblSQL = new Label();
      this.tbCriteriaCountry = new TextBox();
      this.lbCriteriaCountry = new Label();
      this.tbCriteriaCity = new TextBox();
      this.lblCriteriaCity = new Label();
      this.tbCriteriaHotel = new TextBox();
      this.lblCriteriaHotel = new Label();
      this.toolTip1 = new ToolTip(this.components);
      this.cboFilterJobStatus = new ComboBox();
      this.tsConnServer = new ToolStripStatusLabel();
      this.menuStrip1.SuspendLayout();
      this.statusStrip1.SuspendLayout();
      this.splitContainer1.BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      ((ISupportInitialize) this.dgvProvider).BeginInit();
      this.bnavProvider.BeginInit();
      this.bnavProvider.SuspendLayout();
      this.toolStrip1.SuspendLayout();
      ((ISupportInitialize) this.dgvGiata).BeginInit();
      this.SuspendLayout();
      this.menuStrip1.Items.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.fileToolStripMenuItem
      });
      this.menuStrip1.Location = new Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new Size(1074, 24);
      this.menuStrip1.TabIndex = 4;
      this.menuStrip1.Text = "menuStrip1";
      this.fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.exitToolStripMenuItem
      });
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new Size(37, 20);
      this.fileToolStripMenuItem.Text = "File";
      this.fileToolStripMenuItem.Click += new EventHandler(this.fileToolStripMenuItem_Click);
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new Size(92, 22);
      this.exitToolStripMenuItem.Text = "Exit";
      this.exitToolStripMenuItem.Click += new EventHandler(this.exitToolStripMenuItem_Click);
      this.statusStrip1.Items.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.tsStatusText,
        (ToolStripItem) this.tsConnServer
      });
      this.statusStrip1.Location = new Point(0, 473);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new Size(1074, 22);
      this.statusStrip1.TabIndex = 5;
      this.statusStrip1.Text = "statusStrip1";
      this.tsStatusText.Name = "tsStatusText";
      this.tsStatusText.Size = new Size(0, 17);
      this.splitContainer1.Dock = DockStyle.Fill;
      this.splitContainer1.Location = new Point(0, 24);
      this.splitContainer1.Name = "splitContainer1";
      this.splitContainer1.Panel1.Controls.Add((Control) this.cboFilterJobStatus);
      this.splitContainer1.Panel1.Controls.Add((Control) this.cmdFilter);
      this.splitContainer1.Panel1.Controls.Add((Control) this.cmdCopyGiataID);
      this.splitContainer1.Panel1.Controls.Add((Control) this.cmdReload);
      this.splitContainer1.Panel1.Controls.Add((Control) this.chkAutoRefresh);
      this.splitContainer1.Panel1.Controls.Add((Control) this.tbGiataID);
      this.splitContainer1.Panel1.Controls.Add((Control) this.lblGiataID);
      this.splitContainer1.Panel1.Controls.Add((Control) this.lblStatus);
      this.splitContainer1.Panel1.Controls.Add((Control) this.cboStatus);
      this.splitContainer1.Panel1.Controls.Add((Control) this.cmdSave);
      this.splitContainer1.Panel1.Controls.Add((Control) this.tbProviderAddress);
      this.splitContainer1.Panel1.Controls.Add((Control) this.dgvProvider);
      this.splitContainer1.Panel1.Controls.Add((Control) this.bnavProvider);
      this.splitContainer1.Panel1.Controls.Add((Control) this.toolStrip1);
      this.splitContainer1.Panel2.Controls.Add((Control) this.tbGiataGID);
      this.splitContainer1.Panel2.Controls.Add((Control) this.tbGiataAddress3);
      this.splitContainer1.Panel2.Controls.Add((Control) this.tbGiataAddress2);
      this.splitContainer1.Panel2.Controls.Add((Control) this.tbGiataAddress1);
      this.splitContainer1.Panel2.Controls.Add((Control) this.dgvGiata);
      this.splitContainer1.Panel2.Controls.Add((Control) this.cmdCriteriaC);
      this.splitContainer1.Panel2.Controls.Add((Control) this.cmdCriteriaB);
      this.splitContainer1.Panel2.Controls.Add((Control) this.cmdCriteriaA);
      this.splitContainer1.Panel2.Controls.Add((Control) this.cmdSearch);
      this.splitContainer1.Panel2.Controls.Add((Control) this.tbSQLWhere);
      this.splitContainer1.Panel2.Controls.Add((Control) this.lblSQL);
      this.splitContainer1.Panel2.Controls.Add((Control) this.tbCriteriaCountry);
      this.splitContainer1.Panel2.Controls.Add((Control) this.lbCriteriaCountry);
      this.splitContainer1.Panel2.Controls.Add((Control) this.tbCriteriaCity);
      this.splitContainer1.Panel2.Controls.Add((Control) this.lblCriteriaCity);
      this.splitContainer1.Panel2.Controls.Add((Control) this.tbCriteriaHotel);
      this.splitContainer1.Panel2.Controls.Add((Control) this.lblCriteriaHotel);
      this.splitContainer1.Size = new Size(1074, 449);
      this.splitContainer1.SplitterDistance = 540;
      this.splitContainer1.TabIndex = 6;
      this.cmdFilter.Location = new Point(486, 69);
      this.cmdFilter.Name = "cmdFilter";
      this.cmdFilter.Size = new Size(51, 23);
      this.cmdFilter.TabIndex = 18;
      this.cmdFilter.Text = "Filter";
      this.cmdFilter.UseVisualStyleBackColor = true;
      this.cmdFilter.Click += new EventHandler(this.cmdFilter_Click);
      this.cmdCopyGiataID.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdCopyGiataID.ForeColor = Color.Navy;
      this.cmdCopyGiataID.Location = new Point(502, 380);
      this.cmdCopyGiataID.Name = "cmdCopyGiataID";
      this.cmdCopyGiataID.Size = new Size(35, 25);
      this.cmdCopyGiataID.TabIndex = 17;
      this.cmdCopyGiataID.Text = "<-";
      this.cmdCopyGiataID.UseVisualStyleBackColor = true;
      this.cmdCopyGiataID.Click += new EventHandler(this.cmdCopyGiataID_Click);
      this.cmdReload.Location = new Point(98, 71);
      this.cmdReload.Name = "cmdReload";
      this.cmdReload.Size = new Size(51, 23);
      this.cmdReload.TabIndex = 16;
      this.cmdReload.Text = "Reload";
      this.cmdReload.UseVisualStyleBackColor = true;
      this.cmdReload.Click += new EventHandler(this.cmdReload_Click);
      this.chkAutoRefresh.AutoSize = true;
      this.chkAutoRefresh.Location = new Point(6, 74);
      this.chkAutoRefresh.Name = "chkAutoRefresh";
      this.chkAutoRefresh.Size = new Size(88, 17);
      this.chkAutoRefresh.TabIndex = 15;
      this.chkAutoRefresh.Text = "Auto-Refresh";
      this.chkAutoRefresh.UseVisualStyleBackColor = true;
      this.tbGiataID.BackColor = Color.Beige;
      this.tbGiataID.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.tbGiataID.ForeColor = Color.Navy;
      this.tbGiataID.Location = new Point(339, 380);
      this.tbGiataID.Name = "tbGiataID";
      this.tbGiataID.Size = new Size(160, 26);
      this.tbGiataID.TabIndex = 14;
      this.lblGiataID.AutoSize = true;
      this.lblGiataID.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblGiataID.Location = new Point(273, 386);
      this.lblGiataID.Name = "lblGiataID";
      this.lblGiataID.Size = new Size(62, 17);
      this.lblGiataID.TabIndex = 13;
      this.lblGiataID.Text = "GiataID";
      this.lblStatus.AutoSize = true;
      this.lblStatus.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblStatus.Location = new Point(14, 417);
      this.lblStatus.Name = "lblStatus";
      this.lblStatus.Size = new Size(54, 17);
      this.lblStatus.TabIndex = 12;
      this.lblStatus.Text = "Status";
      this.cboStatus.AutoCompleteSource = AutoCompleteSource.ListItems;
      this.cboStatus.BackColor = Color.Beige;
      this.cboStatus.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cboStatus.ForeColor = Color.Navy;
      this.cboStatus.FormattingEnabled = true;
      this.cboStatus.Location = new Point(71, 412);
      this.cboStatus.Name = "cboStatus";
      this.cboStatus.Size = new Size(379, 24);
      this.cboStatus.TabIndex = 11;
      this.cboStatus.SelectedIndexChanged += new EventHandler(this.cboStatus_SelectedIndexChanged);
      this.cmdSave.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdSave.ForeColor = Color.Navy;
      this.cmdSave.Location = new Point(464, 412);
      this.cmdSave.Name = "cmdSave";
      this.cmdSave.Size = new Size(75, 25);
      this.cmdSave.TabIndex = 10;
      this.cmdSave.Text = "Save";
      this.cmdSave.UseVisualStyleBackColor = true;
      this.cmdSave.Click += new EventHandler(this.cmdSave_Click);
      this.tbProviderAddress.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.tbProviderAddress.Location = new Point(337, 254);
      this.tbProviderAddress.Multiline = true;
      this.tbProviderAddress.Name = "tbProviderAddress";
      this.tbProviderAddress.Size = new Size(200, 90);
      this.tbProviderAddress.TabIndex = 9;
      this.dgvProvider.AllowUserToAddRows = false;
      this.dgvProvider.AllowUserToDeleteRows = false;
      this.dgvProvider.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvProvider.Location = new Point(6, 99);
      this.dgvProvider.Name = "dgvProvider";
      gridViewCellStyle1.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.dgvProvider.RowsDefaultCellStyle = gridViewCellStyle1;
      this.dgvProvider.Size = new Size(531, 150);
      this.dgvProvider.TabIndex = 8;
      this.dgvProvider.CellClick += new DataGridViewCellEventHandler(this.dgvProvider_CellClick);
      this.bnavProvider.AddNewItem = (ToolStripItem) null;
      this.bnavProvider.CountItem = (ToolStripItem) this.bindingNavigatorCountItem;
      this.bnavProvider.DeleteItem = (ToolStripItem) null;
      this.bnavProvider.Items.AddRange(new ToolStripItem[9]
      {
        (ToolStripItem) this.bindingNavigatorMoveFirstItem,
        (ToolStripItem) this.bindingNavigatorMovePreviousItem,
        (ToolStripItem) this.bindingNavigatorSeparator,
        (ToolStripItem) this.bindingNavigatorPositionItem,
        (ToolStripItem) this.bindingNavigatorCountItem,
        (ToolStripItem) this.bindingNavigatorSeparator1,
        (ToolStripItem) this.bindingNavigatorMoveNextItem,
        (ToolStripItem) this.bindingNavigatorMoveLastItem,
        (ToolStripItem) this.bindingNavigatorSeparator2
      });
      this.bnavProvider.Location = new Point(0, 27);
      this.bnavProvider.MoveFirstItem = (ToolStripItem) this.bindingNavigatorMoveFirstItem;
      this.bnavProvider.MoveLastItem = (ToolStripItem) this.bindingNavigatorMoveLastItem;
      this.bnavProvider.MoveNextItem = (ToolStripItem) this.bindingNavigatorMoveNextItem;
      this.bnavProvider.MovePreviousItem = (ToolStripItem) this.bindingNavigatorMovePreviousItem;
      this.bnavProvider.Name = "bnavProvider";
      this.bnavProvider.PositionItem = (ToolStripItem) this.bindingNavigatorPositionItem;
      this.bnavProvider.Size = new Size(540, 25);
      this.bnavProvider.TabIndex = 6;
      this.bnavProvider.Text = "bindingNavigator1";
      this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
      this.bindingNavigatorCountItem.Size = new Size(35, 22);
      this.bindingNavigatorCountItem.Text = "of {0}";
      this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
      this.bindingNavigatorMoveFirstItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveFirstItem.Image = (Image) componentResourceManager.GetObject("bindingNavigatorMoveFirstItem.Image");
      this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
      this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveFirstItem.Size = new Size(23, 22);
      this.bindingNavigatorMoveFirstItem.Text = "Move first";
      this.bindingNavigatorMovePreviousItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMovePreviousItem.Image = (Image) componentResourceManager.GetObject("bindingNavigatorMovePreviousItem.Image");
      this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
      this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMovePreviousItem.Size = new Size(23, 22);
      this.bindingNavigatorMovePreviousItem.Text = "Move previous";
      this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator.Size = new Size(6, 25);
      this.bindingNavigatorPositionItem.AccessibleName = "Position";
      this.bindingNavigatorPositionItem.AutoSize = false;
      this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
      this.bindingNavigatorPositionItem.Size = new Size(50, 23);
      this.bindingNavigatorPositionItem.Text = "0";
      this.bindingNavigatorPositionItem.ToolTipText = "Current position";
      this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
      this.bindingNavigatorSeparator1.Size = new Size(6, 25);
      this.bindingNavigatorMoveNextItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveNextItem.Image = (Image) componentResourceManager.GetObject("bindingNavigatorMoveNextItem.Image");
      this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
      this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveNextItem.Size = new Size(23, 22);
      this.bindingNavigatorMoveNextItem.Text = "Move next";
      this.bindingNavigatorMoveLastItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveLastItem.Image = (Image) componentResourceManager.GetObject("bindingNavigatorMoveLastItem.Image");
      this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
      this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveLastItem.Size = new Size(23, 22);
      this.bindingNavigatorMoveLastItem.Text = "Move last";
      this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
      this.bindingNavigatorSeparator2.Size = new Size(6, 25);
      this.toolStrip1.Items.AddRange(new ToolStripItem[4]
      {
        (ToolStripItem) this.toolStripTextBox1,
        (ToolStripItem) this.toolStripComboBox1,
        (ToolStripItem) this.toolStripButton1,
        (ToolStripItem) this.toolStripSplitButton1
      });
      this.toolStrip1.Location = new Point(0, 0);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new Size(540, 27);
      this.toolStrip1.TabIndex = 5;
      this.toolStrip1.Text = "toolStrip1";
      this.toolStripTextBox1.BackColor = Color.Beige;
      this.toolStripTextBox1.Font = new Font("Segoe UI", 10f);
      this.toolStripTextBox1.ForeColor = Color.Navy;
      this.toolStripTextBox1.Name = "toolStripTextBox1";
      this.toolStripTextBox1.Size = new Size(150, 27);
      this.toolStripTextBox1.ToolTipText = "Enter your username.";
      this.toolStripComboBox1.BackColor = Color.Beige;
      this.toolStripComboBox1.Font = new Font("Segoe UI", 10f);
      this.toolStripComboBox1.ForeColor = Color.Navy;
      this.toolStripComboBox1.Name = "toolStripComboBox1";
      this.toolStripComboBox1.Size = new Size(180, 27);
      this.toolStripComboBox1.ToolTipText = "Select a job item.";
      this.toolStripComboBox1.SelectedIndexChanged += new EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
      this.toolStripButton1.BackColor = Color.LightSteelBlue;
      this.toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
      this.toolStripButton1.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
      this.toolStripButton1.ForeColor = Color.Navy;
      this.toolStripButton1.Image = (Image) componentResourceManager.GetObject("toolStripButton1.Image");
      this.toolStripButton1.ImageTransparentColor = Color.Magenta;
      this.toolStripButton1.Name = "toolStripButton1";
      this.toolStripButton1.Size = new Size(64, 24);
      this.toolStripButton1.Text = "TAKE JOB";
      this.toolStripButton1.Click += new EventHandler(this.toolStripButton1_Click);
      this.toolStripSplitButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
      this.toolStripSplitButton1.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
      this.toolStripSplitButton1.ForeColor = Color.DarkRed;
      this.toolStripSplitButton1.Image = (Image) componentResourceManager.GetObject("toolStripSplitButton1.Image");
      this.toolStripSplitButton1.ImageTransparentColor = Color.Magenta;
      this.toolStripSplitButton1.Name = "toolStripSplitButton1";
      this.toolStripSplitButton1.Size = new Size(23, 24);
      this.toolStripSplitButton1.Text = "X";
      this.toolStripSplitButton1.ToolTipText = "Clear selection.";
      this.toolStripSplitButton1.Click += new EventHandler(this.toolStripSplitButton1_Click);
      this.tbGiataGID.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.tbGiataGID.Location = new Point(5, 380);
      this.tbGiataGID.Name = "tbGiataGID";
      this.tbGiataGID.Size = new Size(200, 26);
      this.tbGiataGID.TabIndex = 16;
      this.tbGiataAddress3.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.tbGiataAddress3.Location = new Point(6, 318);
      this.tbGiataAddress3.Name = "tbGiataAddress3";
      this.tbGiataAddress3.Size = new Size(200, 26);
      this.tbGiataAddress3.TabIndex = 15;
      this.tbGiataAddress2.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.tbGiataAddress2.Location = new Point(7, 286);
      this.tbGiataAddress2.Name = "tbGiataAddress2";
      this.tbGiataAddress2.Size = new Size(200, 26);
      this.tbGiataAddress2.TabIndex = 14;
      this.tbGiataAddress1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.tbGiataAddress1.Location = new Point(6, 254);
      this.tbGiataAddress1.Name = "tbGiataAddress1";
      this.tbGiataAddress1.Size = new Size(200, 26);
      this.tbGiataAddress1.TabIndex = 13;
      this.dgvGiata.AllowUserToAddRows = false;
      this.dgvGiata.AllowUserToDeleteRows = false;
      this.dgvGiata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvGiata.Location = new Point(6, 99);
      this.dgvGiata.Name = "dgvGiata";
      gridViewCellStyle2.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.dgvGiata.RowsDefaultCellStyle = gridViewCellStyle2;
      this.dgvGiata.Size = new Size(512, 150);
      this.dgvGiata.TabIndex = 12;
      this.dgvGiata.CellClick += new DataGridViewCellEventHandler(this.dgvGiata_CellClick);
      this.cmdCriteriaC.Location = new Point(426, 40);
      this.cmdCriteriaC.Name = "cmdCriteriaC";
      this.cmdCriteriaC.Size = new Size(21, 21);
      this.cmdCriteriaC.TabIndex = 11;
      this.cmdCriteriaC.Text = "C";
      this.cmdCriteriaC.UseVisualStyleBackColor = true;
      this.cmdCriteriaC.Click += new EventHandler(this.cmdCriteriaC_Click);
      this.cmdCriteriaB.Location = new Point(399, 40);
      this.cmdCriteriaB.Name = "cmdCriteriaB";
      this.cmdCriteriaB.Size = new Size(21, 21);
      this.cmdCriteriaB.TabIndex = 10;
      this.cmdCriteriaB.Text = "B";
      this.cmdCriteriaB.UseVisualStyleBackColor = true;
      this.cmdCriteriaB.Click += new EventHandler(this.cmdCriteriaB_Click);
      this.cmdCriteriaA.Location = new Point(372, 40);
      this.cmdCriteriaA.Name = "cmdCriteriaA";
      this.cmdCriteriaA.Size = new Size(21, 21);
      this.cmdCriteriaA.TabIndex = 9;
      this.cmdCriteriaA.Text = "A";
      this.cmdCriteriaA.UseVisualStyleBackColor = true;
      this.cmdCriteriaA.Click += new EventHandler(this.cmdCriteriaA_Click);
      this.cmdSearch.Enabled = false;
      this.cmdSearch.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdSearch.Location = new Point(371, 67);
      this.cmdSearch.Name = "cmdSearch";
      this.cmdSearch.Size = new Size(76, 25);
      this.cmdSearch.TabIndex = 8;
      this.cmdSearch.Text = "Search";
      this.cmdSearch.UseVisualStyleBackColor = true;
      this.cmdSearch.Click += new EventHandler(this.cmdSearch_Click);
      this.tbSQLWhere.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.tbSQLWhere.Location = new Point(45, 40);
      this.tbSQLWhere.Multiline = true;
      this.tbSQLWhere.Name = "tbSQLWhere";
      this.tbSQLWhere.Size = new Size(320, 55);
      this.tbSQLWhere.TabIndex = 7;
      this.lblSQL.AutoSize = true;
      this.lblSQL.Font = new Font("Microsoft Sans Serif", 7f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblSQL.Location = new Point(4, 45);
      this.lblSQL.Name = "lblSQL";
      this.lblSQL.Size = new Size(44, 26);
      this.lblSQL.TabIndex = 6;
      this.lblSQL.Text = "SQL\r\nWHERE";
      this.tbCriteriaCountry.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.tbCriteriaCountry.Location = new Point(368, 13);
      this.tbCriteriaCountry.Name = "tbCriteriaCountry";
      this.tbCriteriaCountry.Size = new Size(100, 21);
      this.tbCriteriaCountry.TabIndex = 5;
      this.lbCriteriaCountry.AutoSize = true;
      this.lbCriteriaCountry.Location = new Point(326, 17);
      this.lbCriteriaCountry.Name = "lbCriteriaCountry";
      this.lbCriteriaCountry.Size = new Size(43, 13);
      this.lbCriteriaCountry.TabIndex = 4;
      this.lbCriteriaCountry.Text = "Country";
      this.tbCriteriaCity.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.tbCriteriaCity.Location = new Point(221, 13);
      this.tbCriteriaCity.Name = "tbCriteriaCity";
      this.tbCriteriaCity.Size = new Size(100, 21);
      this.tbCriteriaCity.TabIndex = 3;
      this.lblCriteriaCity.AutoSize = true;
      this.lblCriteriaCity.Location = new Point(191, 17);
      this.lblCriteriaCity.Name = "lblCriteriaCity";
      this.lblCriteriaCity.Size = new Size(24, 13);
      this.lblCriteriaCity.TabIndex = 2;
      this.lblCriteriaCity.Text = "City";
      this.tbCriteriaHotel.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.tbCriteriaHotel.Location = new Point(45, 13);
      this.tbCriteriaHotel.Name = "tbCriteriaHotel";
      this.tbCriteriaHotel.Size = new Size(140, 21);
      this.tbCriteriaHotel.TabIndex = 1;
      this.lblCriteriaHotel.AutoSize = true;
      this.lblCriteriaHotel.Location = new Point(3, 17);
      this.lblCriteriaHotel.Name = "lblCriteriaHotel";
      this.lblCriteriaHotel.Size = new Size(32, 13);
      this.lblCriteriaHotel.TabIndex = 0;
      this.lblCriteriaHotel.Text = "Hotel";
      this.cboFilterJobStatus.FormattingEnabled = true;
      this.cboFilterJobStatus.Location = new Point(359, 69);
      this.cboFilterJobStatus.Name = "cboFilterJobStatus";
      this.cboFilterJobStatus.Size = new Size(121, 21);
      this.cboFilterJobStatus.TabIndex = 19;
      this.cboFilterJobStatus.Click += new EventHandler(this.cboFilterJobStatus_Click);
      this.tsConnServer.Name = "tsConnServer";
      this.tsConnServer.Size = new Size(89, 17);
      this.tsConnServer.Text = "No connection.";
      this.tsConnServer.Visible = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1074, 495);
      this.Controls.Add((Control) this.splitContainer1);
      this.Controls.Add((Control) this.statusStrip1);
      this.Controls.Add((Control) this.menuStrip1);
      this.Name = nameof (Form7);
      this.Text = nameof (Form7);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel1.PerformLayout();
      this.splitContainer1.Panel2.ResumeLayout(false);
      this.splitContainer1.Panel2.PerformLayout();
      this.splitContainer1.EndInit();
      this.splitContainer1.ResumeLayout(false);
      ((ISupportInitialize) this.dgvProvider).EndInit();
      this.bnavProvider.EndInit();
      this.bnavProvider.ResumeLayout(false);
      this.bnavProvider.PerformLayout();
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      ((ISupportInitialize) this.dgvGiata).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
