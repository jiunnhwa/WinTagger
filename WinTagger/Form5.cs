using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace WinTagger
{
  public class Form5 : Form
  {
    private BindingSource bindingSource1 = new BindingSource();
    private BindingSource bindingSource2 = new BindingSource();
    private OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
    private OleDbDataAdapter dataAdapter1;
    private OleDbDataAdapter dataAdapter2 = new OleDbDataAdapter();
    private MySqlDataAdapter dataAdapter1MYSQL = new MySqlDataAdapter();
    private MySqlDataAdapter dataAdapter2MYSQL = new MySqlDataAdapter();
    private DataTable dataTable1 = (DataTable) null;
    private string CITYNAME = "bali";
    private string COUNTRY = "id";
    private string HOTELNAME = "gino feruci";
    private IContainer components = (IContainer) null;
    private StatusStrip statusStrip1;
    private ToolStrip toolStrip1;
    private ToolStripComboBox toolStripComboBox1;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem fileToolStripMenuItem;
    private ToolStripMenuItem exitToolStripMenuItem;
    private SplitContainer splitContainer1;
    private DataGridView dataGridView1;
    private DataGridView dataGridView2;
    private TextBox textBox1;
    private TextBox textBox2;
    private TextBox textBox3;
    private TextBox textBox4;
    private Label label1;
    private TextBox textBox5;
    private Button button1;
    private ToolStripTextBox toolStripTextBox1;
    private ToolStripButton toolStripButton1;
    private Button cmdSaveDG1;
    private BindingNavigator bindingNavigator1;
    private ToolStripLabel bindingNavigatorCountItem;
    private ToolStripButton bindingNavigatorMoveFirstItem;
    private ToolStripButton bindingNavigatorMovePreviousItem;
    private ToolStripSeparator bindingNavigatorSeparator;
    private ToolStripTextBox bindingNavigatorPositionItem;
    private ToolStripSeparator bindingNavigatorSeparator1;
    private ToolStripButton bindingNavigatorMoveNextItem;
    private ToolStripButton bindingNavigatorMoveLastItem;
    private ToolStripSeparator bindingNavigatorSeparator2;
    private ToolStripButton saveToolStripButton;
    private ToolStripSeparator toolStripSeparator1;
    private Button button3;
    private Button button2;
    private Button button4;
    private Button button5;
    private Button button6;
    private Button button7;

    public Form5() => this.InitializeComponent();

    private void GetDataTable(string selectCommand)
    {
      try
      {
        string connString = Program.ConnString;
        this.dataAdapter = new OleDbDataAdapter(selectCommand, connString);
        OleDbCommandBuilder dbCommandBuilder = new OleDbCommandBuilder(this.dataAdapter);
        DataTable dataTable = new DataTable();
        dataTable.Locale = CultureInfo.InvariantCulture;
        this.dataAdapter.Fill(dataTable);
        this.bindingSource1.DataSource = (object) dataTable;
        this.dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.Message);
      }
    }

    private void GetData(string selectCommand)
    {
      try
      {
        string connString = Program.ConnString;
        this.dataAdapter1 = new OleDbDataAdapter(selectCommand, connString);
        OleDbCommandBuilder dbCommandBuilder = new OleDbCommandBuilder(this.dataAdapter);
        this.dataTable1 = new DataTable();
        this.dataTable1.Locale = CultureInfo.InvariantCulture;
        this.dataAdapter.Fill(this.dataTable1);
        this.bindingSource1.DataSource = (object) this.dataTable1;
        this.dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.Message);
      }
    }

    private void GetData(string selectCommand, string ConnString)
    {
      OleDbConnection connection = new OleDbConnection(ConnString);
      try
      {
        connection.Open();
        OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(new OleDbCommand(selectCommand, connection));
        DataSet dataSet = new DataSet();
        oleDbDataAdapter.Fill(dataSet);
        this.dataGridView1.DataSource = (object) dataSet;
        this.bindingSource1.DataSource = (object) dataSet;
        this.bindingSource1.DataMember = dataSet.Tables[0].TableName;
        this.dataGridView1.DataSource = (object) this.bindingSource1;
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.Message);
      }
      finally
      {
        connection.Close();
      }
    }

    private void GetData(
      string selectCommand,
      string ConnString,
      OleDbDataAdapter da,
      DataGridView dgv,
      BindingSource bs)
    {
      OleDbConnection connection = new OleDbConnection(ConnString);
      try
      {
        connection.Open();
        da = new OleDbDataAdapter(new OleDbCommand(selectCommand, connection));
        DataSet dataSet = new DataSet();
        da.Fill(dataSet);
        dgv.DataSource = (object) dataSet;
        bs.DataSource = (object) dataSet;
        bs.DataMember = dataSet.Tables[0].TableName;
        dgv.DataSource = (object) bs;
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.Message);
      }
      finally
      {
        connection.Close();
      }
    }

    private void GetDataMYSQL(
      string selectCommand,
      string ConnString,
      MySqlDataAdapter da,
      DataGridView dgv,
      BindingSource bs)
    {
      MySqlConnection connection = new MySqlConnection(ConnString);
      try
      {
        connection.Open();
        da = new MySqlDataAdapter(new MySqlCommand(selectCommand, connection));
        DataSet dataSet = new DataSet();
        da.Fill(dataSet);
        dgv.DataSource = (object) dataSet;
        bs.DataSource = (object) dataSet;
        bs.DataMember = dataSet.Tables[0].TableName;
        dgv.DataSource = (object) bs;
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.Message);
      }
      finally
      {
        connection.Close();
      }
    }

    private DataSet GetDataSet(string selectCommand, string ConnString)
    {
      OleDbConnection connection = new OleDbConnection(ConnString);
      DataSet dataSet = new DataSet();
      try
      {
        connection.Open();
        new OleDbDataAdapter(new OleDbCommand(selectCommand, connection)).Fill(dataSet);
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.Message);
      }
      finally
      {
        connection.Close();
      }
      return dataSet;
    }

    private void Form5_Load(object sender, EventArgs e)
    {
      this.GetDataMYSQL("SELECT providercity, providercountry FROM stagingmap", Program.ConnStringMYSQL, this.dataAdapter1MYSQL, this.dataGridView1, this.bindingSource1);
      this.GetDataMYSQL("SELECT hotel_name, giata_id, city_name, city_id, address1, address2, address_more, latitude, longitude FROM tbl_giata_hotel", Program.ConnStringMYSQL, this.dataAdapter2MYSQL, this.dataGridView2, this.bindingSource2);
      this.bindingNavigator1.BindingSource = this.bindingSource1;
    }

    private void toolStripButton1_Click(object sender, EventArgs e)
    {
    }

    private void cmdSaveDG1_Click(object sender, EventArgs e) => this.SaveChanges();

    private void SaveChanges()
    {
      if (MessageBox.Show("Confirm save changes?", "Class Session Change Form", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
        return;
      try
      {
        this.dataAdapter1.Update((DataSet) this.bindingSource1.DataSource);
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.ToString());
      }
      finally
      {
      }
      using (new WaitCursor((Control) this))
        ;
    }

    private void saveToolStripButton_Click(object sender, EventArgs e) => this.UpdateDataTable();

    private void UpdateDataTable() => this.dataAdapter.Update((DataSet) this.bindingSource1.DataSource);

    private void button2_Click(object sender, EventArgs e)
    {
      this.CITYNAME = this.dataGridView1.CurrentRow.Cells["city_name"].Value.ToString();
      this.COUNTRY = this.dataGridView1.CurrentRow.Cells["country_code"].Value.ToString();
      this.HOTELNAME = this.dataGridView1.CurrentRow.Cells["hotel_name"].Value.ToString();
      this.textBox5.Text = string.Format(string.Format("SELECT * FROM tbl_giata_hotel WHERE hotel_name LIKE '%{0}%' AND  city_name like '%{1}%' AND country_code = '{2}';", (object) this.HOTELNAME, (object) this.CITYNAME, (object) this.COUNTRY));
      this.button1.PerformClick();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      this.CITYNAME = this.dataGridView1.CurrentRow.Cells["city_name"].Value.ToString();
      this.COUNTRY = this.dataGridView1.CurrentRow.Cells["country_code"].Value.ToString();
      this.HOTELNAME = this.dataGridView1.CurrentRow.Cells["hotel_name"].Value.ToString();
      this.textBox5.Text = string.Format(string.Format("SELECT * FROM tbl_giata_hotel WHERE hotel_name LIKE '%{0}%' AND  city_name like '%{1}%' ;", (object) this.HOTELNAME, (object) this.CITYNAME));
      this.button1.PerformClick();
    }

    private void button7_Click(object sender, EventArgs e)
    {
      this.CITYNAME = this.dataGridView1.CurrentRow.Cells["city_name"].Value.ToString();
      this.COUNTRY = this.dataGridView1.CurrentRow.Cells["country_code"].Value.ToString();
      this.HOTELNAME = this.dataGridView1.CurrentRow.Cells["hotel_name"].Value.ToString();
      this.textBox5.Text = string.Format(string.Format("SELECT * FROM tbl_giata_hotel WHERE hotel_name LIKE '%{0}%';", (object) this.HOTELNAME));
      this.button1.PerformClick();
    }

    private void button1_Click(object sender, EventArgs e) => this.GetDataMYSQL(this.textBox5.Text, Program.ConnStringMYSQL, this.dataAdapter2MYSQL, this.dataGridView2, this.bindingSource2);

    private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex == -1)
        return;
      this.HOTELNAME = this.dataGridView1.CurrentRow.Cells["hotel_name"].Value.ToString();
      this.COUNTRY = this.dataGridView1.CurrentRow.Cells["country_code"].Value.ToString();
      this.textBox5.Text = string.Format(string.Format("SELECT * FROM tbl_giata_hotel WHERE hotel_name LIKE '%{0}%' AND  city_name like '%bali%' AND country_code = '{1}';", (object) this.HOTELNAME, (object) this.COUNTRY));
      this.button1.PerformClick();
    }

    private void button4_Click(object sender, EventArgs e) => this.textBox1.Text = this.textBox2.Text;

    private void button5_Click(object sender, EventArgs e)
    {
      Form5.ExecNonQuery(string.Format(string.Format("UPDATE Provider_hotel SET hotel_name = '{0}', city_name = '{1}' WHERE hotel_id = 100", (object) this.textBox1.Text, (object) this.textBox3.Text)), Program.ConnString);
      this.dataGridView1.DataSource = (object) null;
      this.dataGridView1.DataSource = (object) this.bindingSource1;
    }

    public static void ExecNonQuery(string strSQL, string strConnection)
    {
      Debug.WriteLine(strSQL);
      OleDbConnection connection = new OleDbConnection(strConnection);
      OleDbCommand oleDbCommand = new OleDbCommand(strSQL, connection);
      connection.Open();
      try
      {
        oleDbCommand.ExecuteNonQuery();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.ToString());
      }
      finally
      {
        connection.Close();
      }
    }

    private void button6_Click(object sender, EventArgs e) => this.textBox3.Text = this.textBox4.Text;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form5));
      this.statusStrip1 = new StatusStrip();
      this.toolStrip1 = new ToolStrip();
      this.toolStripComboBox1 = new ToolStripComboBox();
      this.toolStripTextBox1 = new ToolStripTextBox();
      this.toolStripButton1 = new ToolStripButton();
      this.menuStrip1 = new MenuStrip();
      this.fileToolStripMenuItem = new ToolStripMenuItem();
      this.exitToolStripMenuItem = new ToolStripMenuItem();
      this.splitContainer1 = new SplitContainer();
      this.bindingNavigator1 = new BindingNavigator(this.components);
      this.bindingNavigatorCountItem = new ToolStripLabel();
      this.bindingNavigatorMoveFirstItem = new ToolStripButton();
      this.bindingNavigatorMovePreviousItem = new ToolStripButton();
      this.bindingNavigatorSeparator = new ToolStripSeparator();
      this.bindingNavigatorPositionItem = new ToolStripTextBox();
      this.bindingNavigatorSeparator1 = new ToolStripSeparator();
      this.bindingNavigatorMoveNextItem = new ToolStripButton();
      this.bindingNavigatorMoveLastItem = new ToolStripButton();
      this.bindingNavigatorSeparator2 = new ToolStripSeparator();
      this.saveToolStripButton = new ToolStripButton();
      this.toolStripSeparator1 = new ToolStripSeparator();
      this.cmdSaveDG1 = new Button();
      this.textBox3 = new TextBox();
      this.textBox1 = new TextBox();
      this.dataGridView1 = new DataGridView();
      this.button3 = new Button();
      this.button2 = new Button();
      this.label1 = new Label();
      this.textBox5 = new TextBox();
      this.button1 = new Button();
      this.textBox4 = new TextBox();
      this.textBox2 = new TextBox();
      this.dataGridView2 = new DataGridView();
      this.button4 = new Button();
      this.button5 = new Button();
      this.button6 = new Button();
      this.button7 = new Button();
      this.toolStrip1.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.splitContainer1.BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.bindingNavigator1.BeginInit();
      this.bindingNavigator1.SuspendLayout();
      ((ISupportInitialize) this.dataGridView1).BeginInit();
      ((ISupportInitialize) this.dataGridView2).BeginInit();
      this.SuspendLayout();
      this.statusStrip1.Location = new Point(0, 415);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new Size(1210, 22);
      this.statusStrip1.TabIndex = 0;
      this.statusStrip1.Text = "statusStrip1";
      this.toolStrip1.Items.AddRange(new ToolStripItem[3]
      {
        (ToolStripItem) this.toolStripComboBox1,
        (ToolStripItem) this.toolStripTextBox1,
        (ToolStripItem) this.toolStripButton1
      });
      this.toolStrip1.Location = new Point(0, 24);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new Size(1210, 25);
      this.toolStrip1.TabIndex = 1;
      this.toolStrip1.Text = "toolStrip1";
      this.toolStripComboBox1.Items.AddRange(new object[5]
      {
        (object) "Darwin,Australia",
        (object) "Sydney,Australia",
        (object) "CityA,Indonesia",
        (object) "CityB,Indonesia",
        (object) "CityA,Malaysia"
      });
      this.toolStripComboBox1.Name = "toolStripComboBox1";
      this.toolStripComboBox1.Size = new Size(121, 25);
      this.toolStripTextBox1.Name = "toolStripTextBox1";
      this.toolStripTextBox1.Size = new Size(100, 25);
      this.toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
      this.toolStripButton1.Image = (Image) componentResourceManager.GetObject("toolStripButton1.Image");
      this.toolStripButton1.ImageTransparentColor = Color.Magenta;
      this.toolStripButton1.Name = "toolStripButton1";
      this.toolStripButton1.Size = new Size(35, 22);
      this.toolStripButton1.Text = "Take";
      this.toolStripButton1.Click += new EventHandler(this.toolStripButton1_Click);
      this.menuStrip1.Items.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.fileToolStripMenuItem
      });
      this.menuStrip1.Location = new Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new Size(1210, 24);
      this.menuStrip1.TabIndex = 2;
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
      this.splitContainer1.Dock = DockStyle.Fill;
      this.splitContainer1.Location = new Point(0, 49);
      this.splitContainer1.Name = "splitContainer1";
      this.splitContainer1.Panel1.Controls.Add((Control) this.button5);
      this.splitContainer1.Panel1.Controls.Add((Control) this.bindingNavigator1);
      this.splitContainer1.Panel1.Controls.Add((Control) this.cmdSaveDG1);
      this.splitContainer1.Panel1.Controls.Add((Control) this.textBox3);
      this.splitContainer1.Panel1.Controls.Add((Control) this.textBox1);
      this.splitContainer1.Panel1.Controls.Add((Control) this.dataGridView1);
      this.splitContainer1.Panel2.BackColor = SystemColors.ActiveCaption;
      this.splitContainer1.Panel2.Controls.Add((Control) this.button7);
      this.splitContainer1.Panel2.Controls.Add((Control) this.button6);
      this.splitContainer1.Panel2.Controls.Add((Control) this.button4);
      this.splitContainer1.Panel2.Controls.Add((Control) this.button3);
      this.splitContainer1.Panel2.Controls.Add((Control) this.button2);
      this.splitContainer1.Panel2.Controls.Add((Control) this.label1);
      this.splitContainer1.Panel2.Controls.Add((Control) this.textBox5);
      this.splitContainer1.Panel2.Controls.Add((Control) this.button1);
      this.splitContainer1.Panel2.Controls.Add((Control) this.textBox4);
      this.splitContainer1.Panel2.Controls.Add((Control) this.textBox2);
      this.splitContainer1.Panel2.Controls.Add((Control) this.dataGridView2);
      this.splitContainer1.Size = new Size(1210, 366);
      this.splitContainer1.SplitterDistance = 591;
      this.splitContainer1.TabIndex = 3;
      this.bindingNavigator1.AddNewItem = (ToolStripItem) null;
      this.bindingNavigator1.CountItem = (ToolStripItem) this.bindingNavigatorCountItem;
      this.bindingNavigator1.DeleteItem = (ToolStripItem) null;
      this.bindingNavigator1.Items.AddRange(new ToolStripItem[11]
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
        (ToolStripItem) this.saveToolStripButton,
        (ToolStripItem) this.toolStripSeparator1
      });
      this.bindingNavigator1.Location = new Point(0, 0);
      this.bindingNavigator1.MoveFirstItem = (ToolStripItem) this.bindingNavigatorMoveFirstItem;
      this.bindingNavigator1.MoveLastItem = (ToolStripItem) this.bindingNavigatorMoveLastItem;
      this.bindingNavigator1.MoveNextItem = (ToolStripItem) this.bindingNavigatorMoveNextItem;
      this.bindingNavigator1.MovePreviousItem = (ToolStripItem) this.bindingNavigatorMovePreviousItem;
      this.bindingNavigator1.Name = "bindingNavigator1";
      this.bindingNavigator1.PositionItem = (ToolStripItem) this.bindingNavigatorPositionItem;
      this.bindingNavigator1.Size = new Size(591, 25);
      this.bindingNavigator1.TabIndex = 4;
      this.bindingNavigator1.Text = "bindingNavigator1";
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
      this.saveToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.saveToolStripButton.Image = (Image) componentResourceManager.GetObject("saveToolStripButton.Image");
      this.saveToolStripButton.ImageTransparentColor = Color.Magenta;
      this.saveToolStripButton.Name = "saveToolStripButton";
      this.saveToolStripButton.Size = new Size(23, 22);
      this.saveToolStripButton.Text = "&Save";
      this.saveToolStripButton.Click += new EventHandler(this.saveToolStripButton_Click);
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new Size(6, 25);
      this.cmdSaveDG1.Location = new Point(388, 324);
      this.cmdSaveDG1.Name = "cmdSaveDG1";
      this.cmdSaveDG1.Size = new Size(75, 23);
      this.cmdSaveDG1.TabIndex = 3;
      this.cmdSaveDG1.Text = "Save";
      this.cmdSaveDG1.UseVisualStyleBackColor = true;
      this.cmdSaveDG1.Visible = false;
      this.cmdSaveDG1.Click += new EventHandler(this.cmdSaveDG1_Click);
      this.textBox3.Location = new Point(368, 232);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new Size(200, 20);
      this.textBox3.TabIndex = 2;
      this.textBox1.Location = new Point(368, 206);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new Size(200, 20);
      this.textBox1.TabIndex = 1;
      this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new Point(12, 50);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new Size(568, 150);
      this.dataGridView1.TabIndex = 0;
      this.dataGridView1.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
      this.button3.Location = new Point(551, 25);
      this.button3.Name = "button3";
      this.button3.Size = new Size(29, 23);
      this.button3.TabIndex = 8;
      this.button3.Text = "B";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new EventHandler(this.button3_Click);
      this.button2.Location = new Point(516, 25);
      this.button2.Name = "button2";
      this.button2.Size = new Size(31, 23);
      this.button2.TabIndex = 7;
      this.button2.Text = "A";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.label1.AutoSize = true;
      this.label1.Location = new Point(11, 27);
      this.label1.Name = "label1";
      this.label1.Size = new Size(28, 13);
      this.label1.TabIndex = 6;
      this.label1.Text = "SQL";
      this.textBox5.Location = new Point(45, 27);
      this.textBox5.Name = "textBox5";
      this.textBox5.Size = new Size(411, 20);
      this.textBox5.TabIndex = 5;
      this.button1.Location = new Point(460, 25);
      this.button1.Name = "button1";
      this.button1.Size = new Size(58, 23);
      this.button1.TabIndex = 4;
      this.button1.Text = "Filter";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.textBox4.Location = new Point(14, 232);
      this.textBox4.Name = "textBox4";
      this.textBox4.Size = new Size(200, 20);
      this.textBox4.TabIndex = 3;
      this.textBox2.Location = new Point(14, 206);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new Size(200, 20);
      this.textBox2.TabIndex = 2;
      this.dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView2.Location = new Point(14, 50);
      this.dataGridView2.Name = "dataGridView2";
      this.dataGridView2.Size = new Size(598, 150);
      this.dataGridView2.TabIndex = 1;
      this.button4.Location = new Point(220, 204);
      this.button4.Name = "button4";
      this.button4.Size = new Size(29, 23);
      this.button4.TabIndex = 9;
      this.button4.Text = "<-";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new EventHandler(this.button4_Click);
      this.button5.Location = new Point(482, 324);
      this.button5.Name = "button5";
      this.button5.Size = new Size(75, 23);
      this.button5.TabIndex = 5;
      this.button5.Text = "Save";
      this.button5.UseVisualStyleBackColor = true;
      this.button5.Click += new EventHandler(this.button5_Click);
      this.button6.Location = new Point(220, 233);
      this.button6.Name = "button6";
      this.button6.Size = new Size(29, 23);
      this.button6.TabIndex = 10;
      this.button6.Text = "<-";
      this.button6.UseVisualStyleBackColor = true;
      this.button6.Click += new EventHandler(this.button6_Click);
      this.button7.Location = new Point(583, 24);
      this.button7.Name = "button7";
      this.button7.Size = new Size(29, 23);
      this.button7.TabIndex = 11;
      this.button7.Text = "C";
      this.button7.UseVisualStyleBackColor = true;
      this.button7.Click += new EventHandler(this.button7_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1210, 437);
      this.Controls.Add((Control) this.splitContainer1);
      this.Controls.Add((Control) this.toolStrip1);
      this.Controls.Add((Control) this.statusStrip1);
      this.Controls.Add((Control) this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = nameof (Form5);
      this.Text = nameof (Form5);
      this.Load += new EventHandler(this.Form5_Load);
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel1.PerformLayout();
      this.splitContainer1.Panel2.ResumeLayout(false);
      this.splitContainer1.Panel2.PerformLayout();
      this.splitContainer1.EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.bindingNavigator1.EndInit();
      this.bindingNavigator1.ResumeLayout(false);
      this.bindingNavigator1.PerformLayout();
      ((ISupportInitialize) this.dataGridView1).EndInit();
      ((ISupportInitialize) this.dataGridView2).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
