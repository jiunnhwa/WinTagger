using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using WinTagger.HELPER;

namespace WinTagger
{
  public class Form6 : Form
  {
    private BindingSource bsProvider = new BindingSource();
    private DataTable dtProvider = (DataTable) null;
    private DataSet dsProvider = (DataSet) null;
    private string JobSelection;
    private MySQL DB = new MySQL();
    private string strSQL;
    private IContainer components = (IContainer) null;
    private BindingSource bindingSource1;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem fileToolStripMenuItem;
    private ToolStripMenuItem exitToolStripMenuItem;
    private ToolStrip toolStrip1;
    private ToolStripComboBox toolStripComboBox1;
    private ToolStripTextBox toolStripTextBox1;
    private ToolStripButton toolStripButton1;
    private StatusStrip statusStrip1;
    private SplitContainer splitContainer1;
    private DataGridView dgvProvider;
    private BindingNavigator bnavProvider;
    private ToolStripButton bindingNavigatorAddNewItem;
    private ToolStripLabel bindingNavigatorCountItem;
    private ToolStripButton bindingNavigatorDeleteItem;
    private ToolStripButton bindingNavigatorMoveFirstItem;
    private ToolStripButton bindingNavigatorMovePreviousItem;
    private ToolStripSeparator bindingNavigatorSeparator;
    private ToolStripTextBox bindingNavigatorPositionItem;
    private ToolStripSeparator bindingNavigatorSeparator1;
    private ToolStripButton bindingNavigatorMoveNextItem;
    private ToolStripButton bindingNavigatorMoveLastItem;
    private ToolStripSeparator bindingNavigatorSeparator2;
    private TextBox tbProviderAddress;
    private ToolStripButton toolStripSplitButton1;
    private Label lblStatus;
    private ComboBox cboStatus;
    private Button cmdSave;
    private TextBox tbGiataID;
    private Label lblGiataID;
    private ToolStripStatusLabel tsStatusText;
    private TextBox txtCriteriaHotel;

    public Form6()
    {
      this.InitializeComponent();
      this.InitializeEvents();
      this.InitializeParameters();
      this.Text = " - [Invoice Email Form]";
    }

    private void InitializeEvents()
    {
      this.Load += new EventHandler(this.Form_Load);
      this.Shown += new EventHandler(this.Form_Shown);
      this.Resize += new EventHandler(this.Form_Resize);
      this.FormClosing += new FormClosingEventHandler(this.Form_Closing);
    }

    private void Form_Resize(object sender, EventArgs e) => this.ResizeDGV();

    private void Form_Shown(object sender, EventArgs e) => this.ClearJobSelection();

    private void Form_Load(object sender, EventArgs e)
    {
      this.LoadComboBox(this.toolStripComboBox1.ComboBox);
      this.LoadJobStatusItems();
    }

    private void Form_Closing(object sender, FormClosingEventArgs e)
    {
    }

    private void InitializeParameters()
    {
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();

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
        this.LoadProviderData();
    }

    private void toolStripSplitButton1_Click(object sender, EventArgs e) => this.ClearJobSelection();

    private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.JobSelection = this.toolStripComboBox1.Text;
      this.Text = this.toolStripComboBox1.Text;
    }

    private void dgvProvider_CellClick(object sender, DataGridViewCellEventArgs e) => this.tbProviderAddress.Text = this.dgvProvider.CurrentRow.Cells["provideraddress"].Value.ToString();

    private void splitContainer1_SizeChanged(object sender, EventArgs e) => this.ResizeDGV();

    private void cmdSave_Click(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(this.cboStatus.Text.ToString()))
      {
        int num = (int) MessageBox.Show("Please set job status.", "Error: No Job Status.");
        this.cboStatus.Focus();
      }
      else
      {
        if (!(this.cboStatus.Text.ToString().ToUpper().Trim() == "OK"))
          return;
        if (string.IsNullOrEmpty(this.tbGiataID.Text.ToString()))
        {
          int num = (int) MessageBox.Show("Please set Giata ID.", "Error: Status OK but No Giata ID.");
          this.tbGiataID.Focus();
        }
        else
          this.SaveJob();
      }
    }

    private void LoadComboBox(ComboBox cbo)
    {
      foreach (DataRow row in (InternalDataCollectionBase) this.DB.Reader2DataTable("SELECT providercity, providercountry FROM stagingmap", Program.ConnStringMYSQL).Rows)
        cbo.Items.Add((object) (row.ItemArray[0].ToString() + "," + row.ItemArray[1].ToString()));
    }

    private void LoadJobStatusItems() => this.cboStatus.Items.AddRange(new object[2]
    {
      (object) "OK",
      (object) "Giata ID not found"
    });

    private void LoadProviderData()
    {
      this.dsProvider = this.DB.GetDataSet("SELECT providerhotelname, providercity, providercountry, provideraddress FROM stagingmap", Program.ConnStringMYSQL);
      this.dtProvider = this.dsProvider.Tables[0];
      this.bsProvider.DataSource = (object) this.dsProvider;
      this.bsProvider.DataMember = this.dsProvider.Tables[0].TableName;
      this.dgvProvider.DataSource = (object) this.bsProvider;
      this.bnavProvider.BindingSource = this.bsProvider;
    }

    private void ClearJobSelection()
    {
      this.JobSelection = "";
      this.toolStripComboBox1.SelectedItem = (object) null;
      this.toolStripComboBox1.Text = "";
      this.toolStripTextBox1.Text = "";
      this.toolStripTextBox1.Focus();
    }

    private void ResizeDGV()
    {
      this.dgvProvider.Width = this.splitContainer1.Panel1.Width - 10;
      this.tbProviderAddress.Left = this.dgvProvider.Right - this.tbProviderAddress.Width;
    }

    private void SaveJob()
    {
      this.strSQL = "";
      this.strSQL += "UPDATE stagingmap ";
      this.strSQL += string.Format(string.Format("SET giataid = {0} ", (object) this.tbGiataID.Text));
      this.strSQL = this.strSQL + "WHERE providerid = '" + (object) 3 + "' ";
      Program.ErrStr = string.Empty;
      this.DB.ExecNonQuery(this.strSQL, Program.ConnStringMYSQL);
      if (string.IsNullOrEmpty(Program.ErrStr))
        this.tsStatusText.Text = "Save OK.";
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form6));
      DataGridViewCellStyle gridViewCellStyle = new DataGridViewCellStyle();
      this.bindingSource1 = new BindingSource(this.components);
      this.menuStrip1 = new MenuStrip();
      this.fileToolStripMenuItem = new ToolStripMenuItem();
      this.exitToolStripMenuItem = new ToolStripMenuItem();
      this.toolStrip1 = new ToolStrip();
      this.toolStripTextBox1 = new ToolStripTextBox();
      this.toolStripComboBox1 = new ToolStripComboBox();
      this.toolStripButton1 = new ToolStripButton();
      this.toolStripSplitButton1 = new ToolStripButton();
      this.statusStrip1 = new StatusStrip();
      this.tsStatusText = new ToolStripStatusLabel();
      this.splitContainer1 = new SplitContainer();
      this.tbGiataID = new TextBox();
      this.lblGiataID = new Label();
      this.lblStatus = new Label();
      this.cboStatus = new ComboBox();
      this.cmdSave = new Button();
      this.tbProviderAddress = new TextBox();
      this.dgvProvider = new DataGridView();
      this.bnavProvider = new BindingNavigator(this.components);
      this.bindingNavigatorAddNewItem = new ToolStripButton();
      this.bindingNavigatorCountItem = new ToolStripLabel();
      this.bindingNavigatorDeleteItem = new ToolStripButton();
      this.bindingNavigatorMoveFirstItem = new ToolStripButton();
      this.bindingNavigatorMovePreviousItem = new ToolStripButton();
      this.bindingNavigatorSeparator = new ToolStripSeparator();
      this.bindingNavigatorPositionItem = new ToolStripTextBox();
      this.bindingNavigatorSeparator1 = new ToolStripSeparator();
      this.bindingNavigatorMoveNextItem = new ToolStripButton();
      this.bindingNavigatorMoveLastItem = new ToolStripButton();
      this.bindingNavigatorSeparator2 = new ToolStripSeparator();
      this.txtCriteriaHotel = new TextBox();
      ((ISupportInitialize) this.bindingSource1).BeginInit();
      this.menuStrip1.SuspendLayout();
      this.toolStrip1.SuspendLayout();
      this.statusStrip1.SuspendLayout();
      this.splitContainer1.BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      ((ISupportInitialize) this.dgvProvider).BeginInit();
      this.bnavProvider.BeginInit();
      this.bnavProvider.SuspendLayout();
      this.SuspendLayout();
      this.menuStrip1.Items.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.fileToolStripMenuItem
      });
      this.menuStrip1.Location = new Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new Size(1052, 24);
      this.menuStrip1.TabIndex = 3;
      this.menuStrip1.Text = "menuStrip1";
      this.fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.exitToolStripMenuItem
      });
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new Size(37, 20);
      this.fileToolStripMenuItem.Text = "File";
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new Size(92, 22);
      this.exitToolStripMenuItem.Text = "Exit";
      this.exitToolStripMenuItem.Click += new EventHandler(this.exitToolStripMenuItem_Click);
      this.toolStrip1.Items.AddRange(new ToolStripItem[4]
      {
        (ToolStripItem) this.toolStripTextBox1,
        (ToolStripItem) this.toolStripComboBox1,
        (ToolStripItem) this.toolStripButton1,
        (ToolStripItem) this.toolStripSplitButton1
      });
      this.toolStrip1.Location = new Point(0, 24);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new Size(1052, 27);
      this.toolStrip1.TabIndex = 4;
      this.toolStrip1.Text = "toolStrip1";
      this.toolStripTextBox1.BackColor = Color.LightGreen;
      this.toolStripTextBox1.Font = new Font("Segoe UI", 10f);
      this.toolStripTextBox1.ForeColor = Color.Blue;
      this.toolStripTextBox1.Name = "toolStripTextBox1";
      this.toolStripTextBox1.Size = new Size(150, 27);
      this.toolStripTextBox1.ToolTipText = "Enter your username.";
      this.toolStripComboBox1.BackColor = Color.LightGreen;
      this.toolStripComboBox1.Font = new Font("Segoe UI", 10f);
      this.toolStripComboBox1.ForeColor = Color.Blue;
      this.toolStripComboBox1.Name = "toolStripComboBox1";
      this.toolStripComboBox1.Size = new Size(180, 27);
      this.toolStripComboBox1.ToolTipText = "Select a job item.";
      this.toolStripComboBox1.SelectedIndexChanged += new EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
      this.toolStripButton1.BackColor = Color.LightSteelBlue;
      this.toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
      this.toolStripButton1.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
      this.toolStripButton1.ForeColor = Color.Blue;
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
      this.statusStrip1.Items.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.tsStatusText
      });
      this.statusStrip1.Location = new Point(0, 383);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new Size(1052, 22);
      this.statusStrip1.TabIndex = 5;
      this.statusStrip1.Text = "statusStrip1";
      this.tsStatusText.Name = "tsStatusText";
      this.tsStatusText.Size = new Size(0, 17);
      this.tsStatusText.ToolTipText = "Shows critical exception";
      this.splitContainer1.Dock = DockStyle.Fill;
      this.splitContainer1.Location = new Point(0, 51);
      this.splitContainer1.Name = "splitContainer1";
      this.splitContainer1.Panel1.Controls.Add((Control) this.tbGiataID);
      this.splitContainer1.Panel1.Controls.Add((Control) this.lblGiataID);
      this.splitContainer1.Panel1.Controls.Add((Control) this.lblStatus);
      this.splitContainer1.Panel1.Controls.Add((Control) this.cboStatus);
      this.splitContainer1.Panel1.Controls.Add((Control) this.cmdSave);
      this.splitContainer1.Panel1.Controls.Add((Control) this.tbProviderAddress);
      this.splitContainer1.Panel1.Controls.Add((Control) this.dgvProvider);
      this.splitContainer1.Panel1.Controls.Add((Control) this.bnavProvider);
      this.splitContainer1.Panel2.Controls.Add((Control) this.txtCriteriaHotel);
      this.splitContainer1.Size = new Size(1052, 332);
      this.splitContainer1.SplitterDistance = 547;
      this.splitContainer1.TabIndex = 6;
      this.splitContainer1.SizeChanged += new EventHandler(this.splitContainer1_SizeChanged);
      this.tbGiataID.BackColor = Color.LightGreen;
      this.tbGiataID.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.tbGiataID.ForeColor = Color.Blue;
      this.tbGiataID.Location = new Point(330, 270);
      this.tbGiataID.Name = "tbGiataID";
      this.tbGiataID.Size = new Size(200, 26);
      this.tbGiataID.TabIndex = 7;
      this.lblGiataID.AutoSize = true;
      this.lblGiataID.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblGiataID.Location = new Point(264, 276);
      this.lblGiataID.Name = "lblGiataID";
      this.lblGiataID.Size = new Size(62, 17);
      this.lblGiataID.TabIndex = 6;
      this.lblGiataID.Text = "GiataID";
      this.lblStatus.AutoSize = true;
      this.lblStatus.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblStatus.Location = new Point(5, 307);
      this.lblStatus.Name = "lblStatus";
      this.lblStatus.Size = new Size(54, 17);
      this.lblStatus.TabIndex = 5;
      this.lblStatus.Text = "Status";
      this.cboStatus.AutoCompleteSource = AutoCompleteSource.ListItems;
      this.cboStatus.BackColor = Color.LightGreen;
      this.cboStatus.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cboStatus.ForeColor = Color.Blue;
      this.cboStatus.FormattingEnabled = true;
      this.cboStatus.Location = new Point(62, 302);
      this.cboStatus.Name = "cboStatus";
      this.cboStatus.Size = new Size(379, 24);
      this.cboStatus.TabIndex = 4;
      this.cmdSave.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdSave.ForeColor = Color.Blue;
      this.cmdSave.Location = new Point(455, 302);
      this.cmdSave.Name = "cmdSave";
      this.cmdSave.Size = new Size(75, 25);
      this.cmdSave.TabIndex = 3;
      this.cmdSave.Text = "Save";
      this.cmdSave.UseVisualStyleBackColor = true;
      this.cmdSave.Click += new EventHandler(this.cmdSave_Click);
      this.tbProviderAddress.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.tbProviderAddress.Location = new Point(334, 213);
      this.tbProviderAddress.Name = "tbProviderAddress";
      this.tbProviderAddress.Size = new Size(200, 26);
      this.tbProviderAddress.TabIndex = 2;
      this.dgvProvider.AllowUserToAddRows = false;
      this.dgvProvider.AllowUserToDeleteRows = false;
      this.dgvProvider.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvProvider.Location = new Point(3, 40);
      this.dgvProvider.Name = "dgvProvider";
      gridViewCellStyle.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.dgvProvider.RowsDefaultCellStyle = gridViewCellStyle;
      this.dgvProvider.Size = new Size(531, 150);
      this.dgvProvider.TabIndex = 1;
      this.dgvProvider.CellClick += new DataGridViewCellEventHandler(this.dgvProvider_CellClick);
      this.bnavProvider.AddNewItem = (ToolStripItem) this.bindingNavigatorAddNewItem;
      this.bnavProvider.CountItem = (ToolStripItem) this.bindingNavigatorCountItem;
      this.bnavProvider.DeleteItem = (ToolStripItem) this.bindingNavigatorDeleteItem;
      this.bnavProvider.Items.AddRange(new ToolStripItem[11]
      {
        (ToolStripItem) this.bindingNavigatorMoveFirstItem,
        (ToolStripItem) this.bindingNavigatorMovePreviousItem,
        (ToolStripItem) this.bindingNavigatorSeparator,
        (ToolStripItem) this.bindingNavigatorPositionItem,
        (ToolStripItem) this.bindingNavigatorCountItem,
        (ToolStripItem) this.bindingNavigatorSeparator1,
        (ToolStripItem) this.bindingNavigatorMoveNextItem,
        (ToolStripItem) this.bindingNavigatorMoveLastItem,
        (ToolStripItem) this.bindingNavigatorSeparator2,
        (ToolStripItem) this.bindingNavigatorAddNewItem,
        (ToolStripItem) this.bindingNavigatorDeleteItem
      });
      this.bnavProvider.Location = new Point(0, 0);
      this.bnavProvider.MoveFirstItem = (ToolStripItem) this.bindingNavigatorMoveFirstItem;
      this.bnavProvider.MoveLastItem = (ToolStripItem) this.bindingNavigatorMoveLastItem;
      this.bnavProvider.MoveNextItem = (ToolStripItem) this.bindingNavigatorMoveNextItem;
      this.bnavProvider.MovePreviousItem = (ToolStripItem) this.bindingNavigatorMovePreviousItem;
      this.bnavProvider.Name = "bnavProvider";
      this.bnavProvider.PositionItem = (ToolStripItem) this.bindingNavigatorPositionItem;
      this.bnavProvider.Size = new Size(547, 25);
      this.bnavProvider.TabIndex = 0;
      this.bnavProvider.Text = "bindingNavigator1";
      this.bindingNavigatorAddNewItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorAddNewItem.Image = (Image) componentResourceManager.GetObject("bindingNavigatorAddNewItem.Image");
      this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
      this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorAddNewItem.Size = new Size(23, 22);
      this.bindingNavigatorAddNewItem.Text = "Add new";
      this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
      this.bindingNavigatorCountItem.Size = new Size(35, 22);
      this.bindingNavigatorCountItem.Text = "of {0}";
      this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
      this.bindingNavigatorDeleteItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorDeleteItem.Image = (Image) componentResourceManager.GetObject("bindingNavigatorDeleteItem.Image");
      this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
      this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorDeleteItem.Size = new Size(23, 22);
      this.bindingNavigatorDeleteItem.Text = "Delete";
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
      this.txtCriteriaHotel.Location = new Point(41, 3);
      this.txtCriteriaHotel.Name = "txtCriteriaHotel";
      this.txtCriteriaHotel.Size = new Size(117, 20);
      this.txtCriteriaHotel.TabIndex = 6;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1052, 405);
      this.Controls.Add((Control) this.splitContainer1);
      this.Controls.Add((Control) this.statusStrip1);
      this.Controls.Add((Control) this.toolStrip1);
      this.Controls.Add((Control) this.menuStrip1);
      this.Name = nameof (Form6);
      this.Text = nameof (Form6);
      ((ISupportInitialize) this.bindingSource1).EndInit();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
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
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
