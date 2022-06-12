using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using WinTagger.db1DataSetTableAdapters;

namespace WinTagger
{
  public class Form3 : Form
  {
    private BindingSource bs = new BindingSource();
    private IContainer components = (IContainer) null;
    private DataGridView dataGridView1;
    private TextBox textBox1;
    private BindingSource bindingSource1;
    private BindingNavigator bindingNavigator1;
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
    private db1DataSet db1DataSet;
    private BindingSource giatahotelBindingSource;
    private Giata_hotelTableAdapter giata_hotelTableAdapter;
    private DataGridViewTextBoxColumn giataidDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn hotelnameDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn cityidDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn citynameDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn countrycodeDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn address1DataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn address2DataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn addressmoreDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn streetnumberDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn addresscitynameDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn postalcodeDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn addressadditionalinfoDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn addresscountrycodeDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn voicephoneDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn urlDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn geoaccuracyDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn latitudeDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn longitudeDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn ghgmlDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn locationdescDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn facilitiesdescDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn roomsdescDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn sportsentdescDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn mealsdescDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn paymentdescDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn giatalastupdateDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn updatedonDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn languagecodeDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn stateprovDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
    private TextBox textBox2;
    private Button button1;
    private DataGridView dataGridView2;

    public Form3() => this.InitializeComponent();

    private void Form3_Load(object sender, EventArgs e)
    {
      this.giata_hotelTableAdapter.Fill(this.db1DataSet.Giata_hotel);
      OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0; Data Source=./data/db1.mdb");
      try
      {
        connection.Open();
        OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(new OleDbCommand("SELECT * from Giata_hotel", connection));
        DataSet dataSet = new DataSet();
        oleDbDataAdapter.Fill(dataSet);
        this.dataGridView2.DataSource = (object) dataSet;
        this.bs.DataSource = (object) dataSet;
        this.bs.DataMember = dataSet.Tables[0].TableName;
        this.dataGridView2.DataSource = (object) this.bs;
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.Message);
      }
      finally
      {
        connection.Close();
      }
      this.textBox1.DataBindings.Add("Text", (object) this.bs, "hotel_name", true);
    }

    private void button1_Click(object sender, EventArgs e)
    {
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form3));
      this.dataGridView1 = new DataGridView();
      this.textBox1 = new TextBox();
      this.bindingSource1 = new BindingSource(this.components);
      this.bindingNavigator1 = new BindingNavigator(this.components);
      this.bindingNavigatorMoveFirstItem = new ToolStripButton();
      this.bindingNavigatorMovePreviousItem = new ToolStripButton();
      this.bindingNavigatorSeparator = new ToolStripSeparator();
      this.bindingNavigatorPositionItem = new ToolStripTextBox();
      this.bindingNavigatorCountItem = new ToolStripLabel();
      this.bindingNavigatorSeparator1 = new ToolStripSeparator();
      this.bindingNavigatorMoveNextItem = new ToolStripButton();
      this.bindingNavigatorMoveLastItem = new ToolStripButton();
      this.bindingNavigatorSeparator2 = new ToolStripSeparator();
      this.bindingNavigatorAddNewItem = new ToolStripButton();
      this.bindingNavigatorDeleteItem = new ToolStripButton();
      this.db1DataSet = new db1DataSet();
      this.giatahotelBindingSource = new BindingSource(this.components);
      this.giata_hotelTableAdapter = new Giata_hotelTableAdapter();
      this.giataidDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.hotelnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.cityidDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.citynameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.countrycodeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.address1DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.address2DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.addressmoreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.streetDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.streetnumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.addresscitynameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.postalcodeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.addressadditionalinfoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.addresscountrycodeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.voicephoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.urlDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.geoaccuracyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.latitudeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.longitudeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.ghgmlDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.locationdescDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.facilitiesdescDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.roomsdescDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.sportsentdescDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.mealsdescDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.paymentdescDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.giatalastupdateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.updatedonDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.languagecodeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.stateprovDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.ratingDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.textBox2 = new TextBox();
      this.button1 = new Button();
      this.dataGridView2 = new DataGridView();
      ((ISupportInitialize) this.dataGridView1).BeginInit();
      ((ISupportInitialize) this.bindingSource1).BeginInit();
      this.bindingNavigator1.BeginInit();
      this.bindingNavigator1.SuspendLayout();
      this.db1DataSet.BeginInit();
      ((ISupportInitialize) this.giatahotelBindingSource).BeginInit();
      ((ISupportInitialize) this.dataGridView2).BeginInit();
      this.SuspendLayout();
      this.dataGridView1.AutoGenerateColumns = false;
      this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange((DataGridViewColumn) this.giataidDataGridViewTextBoxColumn, (DataGridViewColumn) this.hotelnameDataGridViewTextBoxColumn, (DataGridViewColumn) this.cityidDataGridViewTextBoxColumn, (DataGridViewColumn) this.citynameDataGridViewTextBoxColumn, (DataGridViewColumn) this.countrycodeDataGridViewTextBoxColumn, (DataGridViewColumn) this.address1DataGridViewTextBoxColumn, (DataGridViewColumn) this.address2DataGridViewTextBoxColumn, (DataGridViewColumn) this.addressmoreDataGridViewTextBoxColumn, (DataGridViewColumn) this.streetDataGridViewTextBoxColumn, (DataGridViewColumn) this.streetnumberDataGridViewTextBoxColumn, (DataGridViewColumn) this.addresscitynameDataGridViewTextBoxColumn, (DataGridViewColumn) this.postalcodeDataGridViewTextBoxColumn, (DataGridViewColumn) this.addressadditionalinfoDataGridViewTextBoxColumn, (DataGridViewColumn) this.addresscountrycodeDataGridViewTextBoxColumn, (DataGridViewColumn) this.voicephoneDataGridViewTextBoxColumn, (DataGridViewColumn) this.emailDataGridViewTextBoxColumn, (DataGridViewColumn) this.urlDataGridViewTextBoxColumn, (DataGridViewColumn) this.geoaccuracyDataGridViewTextBoxColumn, (DataGridViewColumn) this.latitudeDataGridViewTextBoxColumn, (DataGridViewColumn) this.longitudeDataGridViewTextBoxColumn, (DataGridViewColumn) this.ghgmlDataGridViewTextBoxColumn, (DataGridViewColumn) this.locationdescDataGridViewTextBoxColumn, (DataGridViewColumn) this.facilitiesdescDataGridViewTextBoxColumn, (DataGridViewColumn) this.roomsdescDataGridViewTextBoxColumn, (DataGridViewColumn) this.sportsentdescDataGridViewTextBoxColumn, (DataGridViewColumn) this.mealsdescDataGridViewTextBoxColumn, (DataGridViewColumn) this.paymentdescDataGridViewTextBoxColumn, (DataGridViewColumn) this.giatalastupdateDataGridViewTextBoxColumn, (DataGridViewColumn) this.updatedonDataGridViewTextBoxColumn, (DataGridViewColumn) this.languagecodeDataGridViewTextBoxColumn, (DataGridViewColumn) this.stateprovDataGridViewTextBoxColumn, (DataGridViewColumn) this.ratingDataGridViewTextBoxColumn);
      this.dataGridView1.DataSource = (object) this.giatahotelBindingSource;
      this.dataGridView1.Location = new Point(110, 54);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new Size(705, 150);
      this.dataGridView1.TabIndex = 0;
      this.textBox1.Location = new Point(818, 319);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new Size(153, 20);
      this.textBox1.TabIndex = 1;
      this.bindingSource1.DataSource = (object) this.db1DataSet;
      this.bindingSource1.Position = 0;
      this.bindingNavigator1.AddNewItem = (ToolStripItem) this.bindingNavigatorAddNewItem;
      this.bindingNavigator1.BindingSource = this.bindingSource1;
      this.bindingNavigator1.CountItem = (ToolStripItem) this.bindingNavigatorCountItem;
      this.bindingNavigator1.DeleteItem = (ToolStripItem) this.bindingNavigatorDeleteItem;
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
        (ToolStripItem) this.bindingNavigatorAddNewItem,
        (ToolStripItem) this.bindingNavigatorDeleteItem
      });
      this.bindingNavigator1.Location = new Point(0, 0);
      this.bindingNavigator1.MoveFirstItem = (ToolStripItem) this.bindingNavigatorMoveFirstItem;
      this.bindingNavigator1.MoveLastItem = (ToolStripItem) this.bindingNavigatorMoveLastItem;
      this.bindingNavigator1.MoveNextItem = (ToolStripItem) this.bindingNavigatorMoveNextItem;
      this.bindingNavigator1.MovePreviousItem = (ToolStripItem) this.bindingNavigatorMovePreviousItem;
      this.bindingNavigator1.Name = "bindingNavigator1";
      this.bindingNavigator1.PositionItem = (ToolStripItem) this.bindingNavigatorPositionItem;
      this.bindingNavigator1.Size = new Size(983, 25);
      this.bindingNavigator1.TabIndex = 2;
      this.bindingNavigator1.Text = "bindingNavigator1";
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
      this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
      this.bindingNavigatorCountItem.Size = new Size(35, 22);
      this.bindingNavigatorCountItem.Text = "of {0}";
      this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
      this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
      this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator2.Size = new Size(6, 25);
      this.bindingNavigatorAddNewItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorAddNewItem.Image = (Image) componentResourceManager.GetObject("bindingNavigatorAddNewItem.Image");
      this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
      this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorAddNewItem.Size = new Size(23, 22);
      this.bindingNavigatorAddNewItem.Text = "Add new";
      this.bindingNavigatorDeleteItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorDeleteItem.Image = (Image) componentResourceManager.GetObject("bindingNavigatorDeleteItem.Image");
      this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
      this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorDeleteItem.Size = new Size(23, 22);
      this.bindingNavigatorDeleteItem.Text = "Delete";
      this.db1DataSet.DataSetName = "db1DataSet";
      this.db1DataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.giatahotelBindingSource.DataMember = "Giata_hotel";
      this.giatahotelBindingSource.DataSource = (object) this.bindingSource1;
      this.giata_hotelTableAdapter.ClearBeforeFill = true;
      this.giataidDataGridViewTextBoxColumn.DataPropertyName = "giata_id";
      this.giataidDataGridViewTextBoxColumn.HeaderText = "giata_id";
      this.giataidDataGridViewTextBoxColumn.Name = "giataidDataGridViewTextBoxColumn";
      this.hotelnameDataGridViewTextBoxColumn.DataPropertyName = "hotel_name";
      this.hotelnameDataGridViewTextBoxColumn.HeaderText = "hotel_name";
      this.hotelnameDataGridViewTextBoxColumn.Name = "hotelnameDataGridViewTextBoxColumn";
      this.cityidDataGridViewTextBoxColumn.DataPropertyName = "city_id";
      this.cityidDataGridViewTextBoxColumn.HeaderText = "city_id";
      this.cityidDataGridViewTextBoxColumn.Name = "cityidDataGridViewTextBoxColumn";
      this.citynameDataGridViewTextBoxColumn.DataPropertyName = "city_name";
      this.citynameDataGridViewTextBoxColumn.HeaderText = "city_name";
      this.citynameDataGridViewTextBoxColumn.Name = "citynameDataGridViewTextBoxColumn";
      this.countrycodeDataGridViewTextBoxColumn.DataPropertyName = "country_code";
      this.countrycodeDataGridViewTextBoxColumn.HeaderText = "country_code";
      this.countrycodeDataGridViewTextBoxColumn.Name = "countrycodeDataGridViewTextBoxColumn";
      this.address1DataGridViewTextBoxColumn.DataPropertyName = "address1";
      this.address1DataGridViewTextBoxColumn.HeaderText = "address1";
      this.address1DataGridViewTextBoxColumn.Name = "address1DataGridViewTextBoxColumn";
      this.address2DataGridViewTextBoxColumn.DataPropertyName = "address2";
      this.address2DataGridViewTextBoxColumn.HeaderText = "address2";
      this.address2DataGridViewTextBoxColumn.Name = "address2DataGridViewTextBoxColumn";
      this.addressmoreDataGridViewTextBoxColumn.DataPropertyName = "address_more";
      this.addressmoreDataGridViewTextBoxColumn.HeaderText = "address_more";
      this.addressmoreDataGridViewTextBoxColumn.Name = "addressmoreDataGridViewTextBoxColumn";
      this.streetDataGridViewTextBoxColumn.DataPropertyName = "street";
      this.streetDataGridViewTextBoxColumn.HeaderText = "street";
      this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
      this.streetnumberDataGridViewTextBoxColumn.DataPropertyName = "street_number";
      this.streetnumberDataGridViewTextBoxColumn.HeaderText = "street_number";
      this.streetnumberDataGridViewTextBoxColumn.Name = "streetnumberDataGridViewTextBoxColumn";
      this.addresscitynameDataGridViewTextBoxColumn.DataPropertyName = "address_city_name";
      this.addresscitynameDataGridViewTextBoxColumn.HeaderText = "address_city_name";
      this.addresscitynameDataGridViewTextBoxColumn.Name = "addresscitynameDataGridViewTextBoxColumn";
      this.postalcodeDataGridViewTextBoxColumn.DataPropertyName = "postal_code";
      this.postalcodeDataGridViewTextBoxColumn.HeaderText = "postal_code";
      this.postalcodeDataGridViewTextBoxColumn.Name = "postalcodeDataGridViewTextBoxColumn";
      this.addressadditionalinfoDataGridViewTextBoxColumn.DataPropertyName = "address_additional_info";
      this.addressadditionalinfoDataGridViewTextBoxColumn.HeaderText = "address_additional_info";
      this.addressadditionalinfoDataGridViewTextBoxColumn.Name = "addressadditionalinfoDataGridViewTextBoxColumn";
      this.addresscountrycodeDataGridViewTextBoxColumn.DataPropertyName = "address_country_code";
      this.addresscountrycodeDataGridViewTextBoxColumn.HeaderText = "address_country_code";
      this.addresscountrycodeDataGridViewTextBoxColumn.Name = "addresscountrycodeDataGridViewTextBoxColumn";
      this.voicephoneDataGridViewTextBoxColumn.DataPropertyName = "voice_phone";
      this.voicephoneDataGridViewTextBoxColumn.HeaderText = "voice_phone";
      this.voicephoneDataGridViewTextBoxColumn.Name = "voicephoneDataGridViewTextBoxColumn";
      this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
      this.emailDataGridViewTextBoxColumn.HeaderText = "email";
      this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
      this.urlDataGridViewTextBoxColumn.DataPropertyName = "url";
      this.urlDataGridViewTextBoxColumn.HeaderText = "url";
      this.urlDataGridViewTextBoxColumn.Name = "urlDataGridViewTextBoxColumn";
      this.geoaccuracyDataGridViewTextBoxColumn.DataPropertyName = "geo_accuracy";
      this.geoaccuracyDataGridViewTextBoxColumn.HeaderText = "geo_accuracy";
      this.geoaccuracyDataGridViewTextBoxColumn.Name = "geoaccuracyDataGridViewTextBoxColumn";
      this.latitudeDataGridViewTextBoxColumn.DataPropertyName = "latitude";
      this.latitudeDataGridViewTextBoxColumn.HeaderText = "latitude";
      this.latitudeDataGridViewTextBoxColumn.Name = "latitudeDataGridViewTextBoxColumn";
      this.longitudeDataGridViewTextBoxColumn.DataPropertyName = "longitude";
      this.longitudeDataGridViewTextBoxColumn.HeaderText = "longitude";
      this.longitudeDataGridViewTextBoxColumn.Name = "longitudeDataGridViewTextBoxColumn";
      this.ghgmlDataGridViewTextBoxColumn.DataPropertyName = "ghgml";
      this.ghgmlDataGridViewTextBoxColumn.HeaderText = "ghgml";
      this.ghgmlDataGridViewTextBoxColumn.Name = "ghgmlDataGridViewTextBoxColumn";
      this.locationdescDataGridViewTextBoxColumn.DataPropertyName = "location_desc";
      this.locationdescDataGridViewTextBoxColumn.HeaderText = "location_desc";
      this.locationdescDataGridViewTextBoxColumn.Name = "locationdescDataGridViewTextBoxColumn";
      this.facilitiesdescDataGridViewTextBoxColumn.DataPropertyName = "facilities_desc";
      this.facilitiesdescDataGridViewTextBoxColumn.HeaderText = "facilities_desc";
      this.facilitiesdescDataGridViewTextBoxColumn.Name = "facilitiesdescDataGridViewTextBoxColumn";
      this.roomsdescDataGridViewTextBoxColumn.DataPropertyName = "rooms_desc";
      this.roomsdescDataGridViewTextBoxColumn.HeaderText = "rooms_desc";
      this.roomsdescDataGridViewTextBoxColumn.Name = "roomsdescDataGridViewTextBoxColumn";
      this.sportsentdescDataGridViewTextBoxColumn.DataPropertyName = "sports_ent_desc";
      this.sportsentdescDataGridViewTextBoxColumn.HeaderText = "sports_ent_desc";
      this.sportsentdescDataGridViewTextBoxColumn.Name = "sportsentdescDataGridViewTextBoxColumn";
      this.mealsdescDataGridViewTextBoxColumn.DataPropertyName = "meals_desc";
      this.mealsdescDataGridViewTextBoxColumn.HeaderText = "meals_desc";
      this.mealsdescDataGridViewTextBoxColumn.Name = "mealsdescDataGridViewTextBoxColumn";
      this.paymentdescDataGridViewTextBoxColumn.DataPropertyName = "payment_desc";
      this.paymentdescDataGridViewTextBoxColumn.HeaderText = "payment_desc";
      this.paymentdescDataGridViewTextBoxColumn.Name = "paymentdescDataGridViewTextBoxColumn";
      this.giatalastupdateDataGridViewTextBoxColumn.DataPropertyName = "giata_last_update";
      this.giatalastupdateDataGridViewTextBoxColumn.HeaderText = "giata_last_update";
      this.giatalastupdateDataGridViewTextBoxColumn.Name = "giatalastupdateDataGridViewTextBoxColumn";
      this.updatedonDataGridViewTextBoxColumn.DataPropertyName = "updated_on";
      this.updatedonDataGridViewTextBoxColumn.HeaderText = "updated_on";
      this.updatedonDataGridViewTextBoxColumn.Name = "updatedonDataGridViewTextBoxColumn";
      this.languagecodeDataGridViewTextBoxColumn.DataPropertyName = "language_code";
      this.languagecodeDataGridViewTextBoxColumn.HeaderText = "language_code";
      this.languagecodeDataGridViewTextBoxColumn.Name = "languagecodeDataGridViewTextBoxColumn";
      this.stateprovDataGridViewTextBoxColumn.DataPropertyName = "stateprov";
      this.stateprovDataGridViewTextBoxColumn.HeaderText = "stateprov";
      this.stateprovDataGridViewTextBoxColumn.Name = "stateprovDataGridViewTextBoxColumn";
      this.ratingDataGridViewTextBoxColumn.DataPropertyName = "rating";
      this.ratingDataGridViewTextBoxColumn.HeaderText = "rating";
      this.ratingDataGridViewTextBoxColumn.Name = "ratingDataGridViewTextBoxColumn";
      this.textBox2.Location = new Point(381, 29);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new Size(100, 20);
      this.textBox2.TabIndex = 3;
      this.button1.Location = new Point(561, 25);
      this.button1.Name = "button1";
      this.button1.Size = new Size(75, 23);
      this.button1.TabIndex = 4;
      this.button1.Text = "button1";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView2.Location = new Point(110, 234);
      this.dataGridView2.Name = "dataGridView2";
      this.dataGridView2.Size = new Size(645, 150);
      this.dataGridView2.TabIndex = 5;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(983, 441);
      this.Controls.Add((Control) this.dataGridView2);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.textBox2);
      this.Controls.Add((Control) this.bindingNavigator1);
      this.Controls.Add((Control) this.textBox1);
      this.Controls.Add((Control) this.dataGridView1);
      this.Name = nameof (Form3);
      this.Text = nameof (Form3);
      this.Load += new EventHandler(this.Form3_Load);
      ((ISupportInitialize) this.dataGridView1).EndInit();
      ((ISupportInitialize) this.bindingSource1).EndInit();
      this.bindingNavigator1.EndInit();
      this.bindingNavigator1.ResumeLayout(false);
      this.bindingNavigator1.PerformLayout();
      this.db1DataSet.EndInit();
      ((ISupportInitialize) this.giatahotelBindingSource).EndInit();
      ((ISupportInitialize) this.dataGridView2).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
