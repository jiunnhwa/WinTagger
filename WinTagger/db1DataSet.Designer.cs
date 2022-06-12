using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace WinTagger
{
  [DesignerCategory("code")]
  [ToolboxItem(true)]
  [XmlSchemaProvider("GetTypedDataSetSchema")]
  [XmlRoot("db1DataSet")]
  [HelpKeyword("vs.data.DataSet")]
  [Serializable]
  public class db1DataSet : DataSet
  {
    private db1DataSet.Giata_hotelDataTable tableGiata_hotel;
    private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public db1DataSet()
    {
      this.BeginInit();
      this.InitClass();
      CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
      base.Tables.CollectionChanged += changeEventHandler;
      base.Relations.CollectionChanged += changeEventHandler;
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected db1DataSet(SerializationInfo info, StreamingContext context)
      : base(info, context, false)
    {
      if (this.IsBinarySerialized(info, context))
      {
        this.InitVars(false);
        CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
        this.Tables.CollectionChanged += changeEventHandler;
        this.Relations.CollectionChanged += changeEventHandler;
      }
      else
      {
        string s = (string) info.GetValue("XmlSchema", typeof (string));
        if (this.DetermineSchemaSerializationMode(info, context) == SchemaSerializationMode.IncludeSchema)
        {
          DataSet dataSet = new DataSet();
          dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
          if (dataSet.Tables[nameof (Giata_hotel)] != null)
            base.Tables.Add((DataTable) new db1DataSet.Giata_hotelDataTable(dataSet.Tables[nameof (Giata_hotel)]));
          this.DataSetName = dataSet.DataSetName;
          this.Prefix = dataSet.Prefix;
          this.Namespace = dataSet.Namespace;
          this.Locale = dataSet.Locale;
          this.CaseSensitive = dataSet.CaseSensitive;
          this.EnforceConstraints = dataSet.EnforceConstraints;
          this.Merge(dataSet, false, MissingSchemaAction.Add);
          this.InitVars();
        }
        else
          this.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
        this.GetSerializationData(info, context);
        CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
        base.Tables.CollectionChanged += changeEventHandler;
        this.Relations.CollectionChanged += changeEventHandler;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public db1DataSet.Giata_hotelDataTable Giata_hotel => this.tableGiata_hotel;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public override SchemaSerializationMode SchemaSerializationMode
    {
      get => this._schemaSerializationMode;
      set => this._schemaSerializationMode = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public new DataTableCollection Tables => base.Tables;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public new DataRelationCollection Relations => base.Relations;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void InitializeDerivedDataSet()
    {
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataSet Clone()
    {
      db1DataSet db1DataSet = (db1DataSet) base.Clone();
      db1DataSet.InitVars();
      db1DataSet.SchemaSerializationMode = this.SchemaSerializationMode;
      return (DataSet) db1DataSet;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override bool ShouldSerializeTables() => false;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override bool ShouldSerializeRelations() => false;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void ReadXmlSerializable(XmlReader reader)
    {
      if (this.DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
      {
        this.Reset();
        DataSet dataSet = new DataSet();
        int num = (int) dataSet.ReadXml(reader);
        if (dataSet.Tables["Giata_hotel"] != null)
          base.Tables.Add((DataTable) new db1DataSet.Giata_hotelDataTable(dataSet.Tables["Giata_hotel"]));
        this.DataSetName = dataSet.DataSetName;
        this.Prefix = dataSet.Prefix;
        this.Namespace = dataSet.Namespace;
        this.Locale = dataSet.Locale;
        this.CaseSensitive = dataSet.CaseSensitive;
        this.EnforceConstraints = dataSet.EnforceConstraints;
        this.Merge(dataSet, false, MissingSchemaAction.Add);
        this.InitVars();
      }
      else
      {
        int num = (int) this.ReadXml(reader);
        this.InitVars();
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override XmlSchema GetSchemaSerializable()
    {
      MemoryStream memoryStream = new MemoryStream();
      this.WriteXmlSchema((XmlWriter) new XmlTextWriter((Stream) memoryStream, (Encoding) null));
      memoryStream.Position = 0L;
      return XmlSchema.Read((XmlReader) new XmlTextReader((Stream) memoryStream), (ValidationEventHandler) null);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars() => this.InitVars(true);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars(bool initTable)
    {
      this.tableGiata_hotel = (db1DataSet.Giata_hotelDataTable) base.Tables["Giata_hotel"];
      if (!initTable || this.tableGiata_hotel == null)
        return;
      this.tableGiata_hotel.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.DataSetName = nameof (db1DataSet);
      this.Prefix = "";
      this.Namespace = "http://tempuri.org/db1DataSet.xsd";
      this.EnforceConstraints = true;
      this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tableGiata_hotel = new db1DataSet.Giata_hotelDataTable();
      base.Tables.Add((DataTable) this.tableGiata_hotel);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private bool ShouldSerializeGiata_hotel() => false;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void SchemaChanged(object sender, CollectionChangeEventArgs e)
    {
      if (e.Action != CollectionChangeAction.Remove)
        return;
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
    {
      db1DataSet db1DataSet = new db1DataSet();
      XmlSchemaComplexType typedDataSetSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      xmlSchemaSequence.Items.Add((XmlSchemaObject) new XmlSchemaAny()
      {
        Namespace = db1DataSet.Namespace
      });
      typedDataSetSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = db1DataSet.GetSchemaSerializable();
      if (xs.Contains(schemaSerializable.TargetNamespace))
      {
        MemoryStream memoryStream1 = new MemoryStream();
        MemoryStream memoryStream2 = new MemoryStream();
        try
        {
          schemaSerializable.Write((Stream) memoryStream1);
          IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
          while (enumerator.MoveNext())
          {
            XmlSchema current = (XmlSchema) enumerator.Current;
            memoryStream2.SetLength(0L);
            current.Write((Stream) memoryStream2);
            if (memoryStream1.Length == memoryStream2.Length)
            {
              memoryStream1.Position = 0L;
              memoryStream2.Position = 0L;
              do
                ;
              while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
              if (memoryStream1.Position == memoryStream1.Length)
                return typedDataSetSchema;
            }
          }
        }
        finally
        {
          memoryStream1?.Close();
          memoryStream2?.Close();
        }
      }
      xs.Add(schemaSerializable);
      return typedDataSetSchema;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public delegate void Giata_hotelRowChangeEventHandler(
      object sender,
      db1DataSet.Giata_hotelRowChangeEvent e);

    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class Giata_hotelDataTable : TypedTableBase<db1DataSet.Giata_hotelRow>
    {
      private DataColumn columngiata_id;
      private DataColumn columnhotel_name;
      private DataColumn columncity_id;
      private DataColumn columncity_name;
      private DataColumn columncountry_code;
      private DataColumn columnaddress1;
      private DataColumn columnaddress2;
      private DataColumn columnaddress_more;
      private DataColumn columnstreet;
      private DataColumn columnstreet_number;
      private DataColumn columnaddress_city_name;
      private DataColumn columnpostal_code;
      private DataColumn columnaddress_additional_info;
      private DataColumn columnaddress_country_code;
      private DataColumn columnvoice_phone;
      private DataColumn columnemail;
      private DataColumn columnurl;
      private DataColumn columngeo_accuracy;
      private DataColumn columnlatitude;
      private DataColumn columnlongitude;
      private DataColumn columnghgml;
      private DataColumn columnlocation_desc;
      private DataColumn columnfacilities_desc;
      private DataColumn columnrooms_desc;
      private DataColumn columnsports_ent_desc;
      private DataColumn columnmeals_desc;
      private DataColumn columnpayment_desc;
      private DataColumn columngiata_last_update;
      private DataColumn columnupdated_on;
      private DataColumn columnlanguage_code;
      private DataColumn columnstateprov;
      private DataColumn columnrating;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public Giata_hotelDataTable()
      {
        this.TableName = "Giata_hotel";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      internal Giata_hotelDataTable(DataTable table)
      {
        this.TableName = table.TableName;
        if (table.CaseSensitive != table.DataSet.CaseSensitive)
          this.CaseSensitive = table.CaseSensitive;
        if (table.Locale.ToString() != table.DataSet.Locale.ToString())
          this.Locale = table.Locale;
        if (table.Namespace != table.DataSet.Namespace)
          this.Namespace = table.Namespace;
        this.Prefix = table.Prefix;
        this.MinimumCapacity = table.MinimumCapacity;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected Giata_hotelDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn giata_idColumn => this.columngiata_id;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn hotel_nameColumn => this.columnhotel_name;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn city_idColumn => this.columncity_id;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn city_nameColumn => this.columncity_name;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn country_codeColumn => this.columncountry_code;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn address1Column => this.columnaddress1;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn address2Column => this.columnaddress2;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn address_moreColumn => this.columnaddress_more;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn streetColumn => this.columnstreet;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn street_numberColumn => this.columnstreet_number;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn address_city_nameColumn => this.columnaddress_city_name;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn postal_codeColumn => this.columnpostal_code;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn address_additional_infoColumn => this.columnaddress_additional_info;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn address_country_codeColumn => this.columnaddress_country_code;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn voice_phoneColumn => this.columnvoice_phone;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn emailColumn => this.columnemail;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn urlColumn => this.columnurl;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn geo_accuracyColumn => this.columngeo_accuracy;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn latitudeColumn => this.columnlatitude;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn longitudeColumn => this.columnlongitude;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn ghgmlColumn => this.columnghgml;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn location_descColumn => this.columnlocation_desc;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn facilities_descColumn => this.columnfacilities_desc;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn rooms_descColumn => this.columnrooms_desc;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn sports_ent_descColumn => this.columnsports_ent_desc;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn meals_descColumn => this.columnmeals_desc;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn payment_descColumn => this.columnpayment_desc;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn giata_last_updateColumn => this.columngiata_last_update;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn updated_onColumn => this.columnupdated_on;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn language_codeColumn => this.columnlanguage_code;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn stateprovColumn => this.columnstateprov;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn ratingColumn => this.columnrating;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public db1DataSet.Giata_hotelRow this[int index] => (db1DataSet.Giata_hotelRow) this.Rows[index];

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event db1DataSet.Giata_hotelRowChangeEventHandler Giata_hotelRowChanging;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event db1DataSet.Giata_hotelRowChangeEventHandler Giata_hotelRowChanged;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event db1DataSet.Giata_hotelRowChangeEventHandler Giata_hotelRowDeleting;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event db1DataSet.Giata_hotelRowChangeEventHandler Giata_hotelRowDeleted;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void AddGiata_hotelRow(db1DataSet.Giata_hotelRow row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public db1DataSet.Giata_hotelRow AddGiata_hotelRow(
        int giata_id,
        string hotel_name,
        int city_id,
        string city_name,
        string country_code,
        string address1,
        string address2,
        string address_more,
        string street,
        string street_number,
        string address_city_name,
        string postal_code,
        string address_additional_info,
        string address_country_code,
        string voice_phone,
        string email,
        string url,
        string geo_accuracy,
        string latitude,
        string longitude,
        string ghgml,
        string location_desc,
        string facilities_desc,
        string rooms_desc,
        string sports_ent_desc,
        string meals_desc,
        string payment_desc,
        string giata_last_update,
        DateTime updated_on,
        string language_code,
        string stateprov,
        string rating)
      {
        db1DataSet.Giata_hotelRow row = (db1DataSet.Giata_hotelRow) this.NewRow();
        object[] objArray = new object[32]
        {
          (object) giata_id,
          (object) hotel_name,
          (object) city_id,
          (object) city_name,
          (object) country_code,
          (object) address1,
          (object) address2,
          (object) address_more,
          (object) street,
          (object) street_number,
          (object) address_city_name,
          (object) postal_code,
          (object) address_additional_info,
          (object) address_country_code,
          (object) voice_phone,
          (object) email,
          (object) url,
          (object) geo_accuracy,
          (object) latitude,
          (object) longitude,
          (object) ghgml,
          (object) location_desc,
          (object) facilities_desc,
          (object) rooms_desc,
          (object) sports_ent_desc,
          (object) meals_desc,
          (object) payment_desc,
          (object) giata_last_update,
          (object) updated_on,
          (object) language_code,
          (object) stateprov,
          (object) rating
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public db1DataSet.Giata_hotelRow FindBygiata_id(int giata_id) => (db1DataSet.Giata_hotelRow) this.Rows.Find(new object[1]
      {
        (object) giata_id
      });

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public override DataTable Clone()
      {
        db1DataSet.Giata_hotelDataTable giataHotelDataTable = (db1DataSet.Giata_hotelDataTable) base.Clone();
        giataHotelDataTable.InitVars();
        return (DataTable) giataHotelDataTable;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override DataTable CreateInstance() => (DataTable) new db1DataSet.Giata_hotelDataTable();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      internal void InitVars()
      {
        this.columngiata_id = this.Columns["giata_id"];
        this.columnhotel_name = this.Columns["hotel_name"];
        this.columncity_id = this.Columns["city_id"];
        this.columncity_name = this.Columns["city_name"];
        this.columncountry_code = this.Columns["country_code"];
        this.columnaddress1 = this.Columns["address1"];
        this.columnaddress2 = this.Columns["address2"];
        this.columnaddress_more = this.Columns["address_more"];
        this.columnstreet = this.Columns["street"];
        this.columnstreet_number = this.Columns["street_number"];
        this.columnaddress_city_name = this.Columns["address_city_name"];
        this.columnpostal_code = this.Columns["postal_code"];
        this.columnaddress_additional_info = this.Columns["address_additional_info"];
        this.columnaddress_country_code = this.Columns["address_country_code"];
        this.columnvoice_phone = this.Columns["voice_phone"];
        this.columnemail = this.Columns["email"];
        this.columnurl = this.Columns["url"];
        this.columngeo_accuracy = this.Columns["geo_accuracy"];
        this.columnlatitude = this.Columns["latitude"];
        this.columnlongitude = this.Columns["longitude"];
        this.columnghgml = this.Columns["ghgml"];
        this.columnlocation_desc = this.Columns["location_desc"];
        this.columnfacilities_desc = this.Columns["facilities_desc"];
        this.columnrooms_desc = this.Columns["rooms_desc"];
        this.columnsports_ent_desc = this.Columns["sports_ent_desc"];
        this.columnmeals_desc = this.Columns["meals_desc"];
        this.columnpayment_desc = this.Columns["payment_desc"];
        this.columngiata_last_update = this.Columns["giata_last_update"];
        this.columnupdated_on = this.Columns["updated_on"];
        this.columnlanguage_code = this.Columns["language_code"];
        this.columnstateprov = this.Columns["stateprov"];
        this.columnrating = this.Columns["rating"];
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      private void InitClass()
      {
        this.columngiata_id = new DataColumn("giata_id", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columngiata_id);
        this.columnhotel_name = new DataColumn("hotel_name", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnhotel_name);
        this.columncity_id = new DataColumn("city_id", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columncity_id);
        this.columncity_name = new DataColumn("city_name", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columncity_name);
        this.columncountry_code = new DataColumn("country_code", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columncountry_code);
        this.columnaddress1 = new DataColumn("address1", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnaddress1);
        this.columnaddress2 = new DataColumn("address2", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnaddress2);
        this.columnaddress_more = new DataColumn("address_more", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnaddress_more);
        this.columnstreet = new DataColumn("street", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnstreet);
        this.columnstreet_number = new DataColumn("street_number", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnstreet_number);
        this.columnaddress_city_name = new DataColumn("address_city_name", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnaddress_city_name);
        this.columnpostal_code = new DataColumn("postal_code", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnpostal_code);
        this.columnaddress_additional_info = new DataColumn("address_additional_info", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnaddress_additional_info);
        this.columnaddress_country_code = new DataColumn("address_country_code", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnaddress_country_code);
        this.columnvoice_phone = new DataColumn("voice_phone", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnvoice_phone);
        this.columnemail = new DataColumn("email", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnemail);
        this.columnurl = new DataColumn("url", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnurl);
        this.columngeo_accuracy = new DataColumn("geo_accuracy", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columngeo_accuracy);
        this.columnlatitude = new DataColumn("latitude", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnlatitude);
        this.columnlongitude = new DataColumn("longitude", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnlongitude);
        this.columnghgml = new DataColumn("ghgml", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnghgml);
        this.columnlocation_desc = new DataColumn("location_desc", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnlocation_desc);
        this.columnfacilities_desc = new DataColumn("facilities_desc", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnfacilities_desc);
        this.columnrooms_desc = new DataColumn("rooms_desc", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnrooms_desc);
        this.columnsports_ent_desc = new DataColumn("sports_ent_desc", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnsports_ent_desc);
        this.columnmeals_desc = new DataColumn("meals_desc", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnmeals_desc);
        this.columnpayment_desc = new DataColumn("payment_desc", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnpayment_desc);
        this.columngiata_last_update = new DataColumn("giata_last_update", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columngiata_last_update);
        this.columnupdated_on = new DataColumn("updated_on", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnupdated_on);
        this.columnlanguage_code = new DataColumn("language_code", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnlanguage_code);
        this.columnstateprov = new DataColumn("stateprov", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnstateprov);
        this.columnrating = new DataColumn("rating", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnrating);
        this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
        {
          this.columngiata_id
        }, true));
        this.columngiata_id.AllowDBNull = false;
        this.columngiata_id.Unique = true;
        this.columnhotel_name.MaxLength = (int) byte.MaxValue;
        this.columncity_name.MaxLength = (int) byte.MaxValue;
        this.columncountry_code.MaxLength = (int) byte.MaxValue;
        this.columnaddress1.MaxLength = (int) byte.MaxValue;
        this.columnaddress2.MaxLength = (int) byte.MaxValue;
        this.columnaddress_more.MaxLength = (int) byte.MaxValue;
        this.columnstreet.MaxLength = (int) byte.MaxValue;
        this.columnstreet_number.MaxLength = (int) byte.MaxValue;
        this.columnaddress_city_name.MaxLength = (int) byte.MaxValue;
        this.columnpostal_code.MaxLength = (int) byte.MaxValue;
        this.columnaddress_additional_info.MaxLength = (int) byte.MaxValue;
        this.columnaddress_country_code.MaxLength = (int) byte.MaxValue;
        this.columnvoice_phone.MaxLength = (int) byte.MaxValue;
        this.columnemail.MaxLength = (int) byte.MaxValue;
        this.columnurl.MaxLength = (int) byte.MaxValue;
        this.columngeo_accuracy.MaxLength = (int) byte.MaxValue;
        this.columnlatitude.MaxLength = (int) byte.MaxValue;
        this.columnlongitude.MaxLength = (int) byte.MaxValue;
        this.columnghgml.MaxLength = (int) byte.MaxValue;
        this.columnlocation_desc.MaxLength = (int) byte.MaxValue;
        this.columnfacilities_desc.MaxLength = (int) byte.MaxValue;
        this.columnrooms_desc.MaxLength = (int) byte.MaxValue;
        this.columnsports_ent_desc.MaxLength = (int) byte.MaxValue;
        this.columnmeals_desc.MaxLength = (int) byte.MaxValue;
        this.columnpayment_desc.MaxLength = (int) byte.MaxValue;
        this.columngiata_last_update.MaxLength = (int) byte.MaxValue;
        this.columnlanguage_code.MaxLength = (int) byte.MaxValue;
        this.columnstateprov.MaxLength = (int) byte.MaxValue;
        this.columnrating.MaxLength = (int) byte.MaxValue;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public db1DataSet.Giata_hotelRow NewGiata_hotelRow() => (db1DataSet.Giata_hotelRow) this.NewRow();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder) => (DataRow) new db1DataSet.Giata_hotelRow(builder);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override Type GetRowType() => typeof (db1DataSet.Giata_hotelRow);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.Giata_hotelRowChanged == null)
          return;
        this.Giata_hotelRowChanged((object) this, new db1DataSet.Giata_hotelRowChangeEvent((db1DataSet.Giata_hotelRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.Giata_hotelRowChanging == null)
          return;
        this.Giata_hotelRowChanging((object) this, new db1DataSet.Giata_hotelRowChangeEvent((db1DataSet.Giata_hotelRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.Giata_hotelRowDeleted == null)
          return;
        this.Giata_hotelRowDeleted((object) this, new db1DataSet.Giata_hotelRowChangeEvent((db1DataSet.Giata_hotelRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.Giata_hotelRowDeleting == null)
          return;
        this.Giata_hotelRowDeleting((object) this, new db1DataSet.Giata_hotelRowChangeEvent((db1DataSet.Giata_hotelRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void RemoveGiata_hotelRow(db1DataSet.Giata_hotelRow row) => this.Rows.Remove((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        db1DataSet db1DataSet = new db1DataSet();
        XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
        xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
        xmlSchemaAny1.MinOccurs = 0M;
        xmlSchemaAny1.MaxOccurs = Decimal.MaxValue;
        xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
        XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
        xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
        xmlSchemaAny2.MinOccurs = 1M;
        xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "namespace",
          FixedValue = db1DataSet.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (Giata_hotelDataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = db1DataSet.GetSchemaSerializable();
        if (xs.Contains(schemaSerializable.TargetNamespace))
        {
          MemoryStream memoryStream1 = new MemoryStream();
          MemoryStream memoryStream2 = new MemoryStream();
          try
          {
            schemaSerializable.Write((Stream) memoryStream1);
            IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
            while (enumerator.MoveNext())
            {
              XmlSchema current = (XmlSchema) enumerator.Current;
              memoryStream2.SetLength(0L);
              current.Write((Stream) memoryStream2);
              if (memoryStream1.Length == memoryStream2.Length)
              {
                memoryStream1.Position = 0L;
                memoryStream2.Position = 0L;
                do
                  ;
                while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
                if (memoryStream1.Position == memoryStream1.Length)
                  return typedTableSchema;
              }
            }
          }
          finally
          {
            memoryStream1?.Close();
            memoryStream2?.Close();
          }
        }
        xs.Add(schemaSerializable);
        return typedTableSchema;
      }
    }

    public class Giata_hotelRow : DataRow
    {
      private db1DataSet.Giata_hotelDataTable tableGiata_hotel;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      internal Giata_hotelRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableGiata_hotel = (db1DataSet.Giata_hotelDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public int giata_id
      {
        get => (int) this[this.tableGiata_hotel.giata_idColumn];
        set => this[this.tableGiata_hotel.giata_idColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string hotel_name
      {
        get
        {
          try
          {
            return (string) this[this.tableGiata_hotel.hotel_nameColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'hotel_name' in table 'Giata_hotel' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableGiata_hotel.hotel_nameColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public int city_id
      {
        get
        {
          try
          {
            return (int) this[this.tableGiata_hotel.city_idColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'city_id' in table 'Giata_hotel' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableGiata_hotel.city_idColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string city_name
      {
        get
        {
          try
          {
            return (string) this[this.tableGiata_hotel.city_nameColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'city_name' in table 'Giata_hotel' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableGiata_hotel.city_nameColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string country_code
      {
        get
        {
          try
          {
            return (string) this[this.tableGiata_hotel.country_codeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'country_code' in table 'Giata_hotel' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableGiata_hotel.country_codeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string address1
      {
        get
        {
          try
          {
            return (string) this[this.tableGiata_hotel.address1Column];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'address1' in table 'Giata_hotel' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableGiata_hotel.address1Column] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string address2
      {
        get
        {
          try
          {
            return (string) this[this.tableGiata_hotel.address2Column];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'address2' in table 'Giata_hotel' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableGiata_hotel.address2Column] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string address_more
      {
        get
        {
          try
          {
            return (string) this[this.tableGiata_hotel.address_moreColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'address_more' in table 'Giata_hotel' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableGiata_hotel.address_moreColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string street
      {
        get
        {
          try
          {
            return (string) this[this.tableGiata_hotel.streetColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'street' in table 'Giata_hotel' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableGiata_hotel.streetColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string street_number
      {
        get
        {
          try
          {
            return (string) this[this.tableGiata_hotel.street_numberColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'street_number' in table 'Giata_hotel' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableGiata_hotel.street_numberColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string address_city_name
      {
        get
        {
          try
          {
            return (string) this[this.tableGiata_hotel.address_city_nameColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'address_city_name' in table 'Giata_hotel' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableGiata_hotel.address_city_nameColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string postal_code
      {
        get
        {
          try
          {
            return (string) this[this.tableGiata_hotel.postal_codeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'postal_code' in table 'Giata_hotel' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableGiata_hotel.postal_codeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string address_additional_info
      {
        get
        {
          try
          {
            return (string) this[this.tableGiata_hotel.address_additional_infoColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'address_additional_info' in table 'Giata_hotel' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableGiata_hotel.address_additional_infoColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string address_country_code
      {
        get
        {
          try
          {
            return (string) this[this.tableGiata_hotel.address_country_codeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'address_country_code' in table 'Giata_hotel' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableGiata_hotel.address_country_codeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string voice_phone
      {
        get
        {
          try
          {
            return (string) this[this.tableGiata_hotel.voice_phoneColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'voice_phone' in table 'Giata_hotel' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableGiata_hotel.voice_phoneColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string email
      {
        get
        {
          try
          {
            return (string) this[this.tableGiata_hotel.emailColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'email' in table 'Giata_hotel' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableGiata_hotel.emailColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string url
      {
        get
        {
          try
          {
            return (string) this[this.tableGiata_hotel.urlColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'url' in table 'Giata_hotel' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableGiata_hotel.urlColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string geo_accuracy
      {
        get
        {
          try
          {
            return (string) this[this.tableGiata_hotel.geo_accuracyColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'geo_accuracy' in table 'Giata_hotel' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableGiata_hotel.geo_accuracyColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string latitude
      {
        get
        {
          try
          {
            return (string) this[this.tableGiata_hotel.latitudeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'latitude' in table 'Giata_hotel' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableGiata_hotel.latitudeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string longitude
      {
        get
        {
          try
          {
            return (string) this[this.tableGiata_hotel.longitudeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'longitude' in table 'Giata_hotel' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableGiata_hotel.longitudeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string ghgml
      {
        get
        {
          try
          {
            return (string) this[this.tableGiata_hotel.ghgmlColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'ghgml' in table 'Giata_hotel' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableGiata_hotel.ghgmlColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string location_desc
      {
        get
        {
          try
          {
            return (string) this[this.tableGiata_hotel.location_descColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'location_desc' in table 'Giata_hotel' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableGiata_hotel.location_descColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string facilities_desc
      {
        get
        {
          try
          {
            return (string) this[this.tableGiata_hotel.facilities_descColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'facilities_desc' in table 'Giata_hotel' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableGiata_hotel.facilities_descColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string rooms_desc
      {
        get
        {
          try
          {
            return (string) this[this.tableGiata_hotel.rooms_descColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'rooms_desc' in table 'Giata_hotel' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableGiata_hotel.rooms_descColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string sports_ent_desc
      {
        get
        {
          try
          {
            return (string) this[this.tableGiata_hotel.sports_ent_descColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'sports_ent_desc' in table 'Giata_hotel' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableGiata_hotel.sports_ent_descColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string meals_desc
      {
        get
        {
          try
          {
            return (string) this[this.tableGiata_hotel.meals_descColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'meals_desc' in table 'Giata_hotel' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableGiata_hotel.meals_descColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string payment_desc
      {
        get
        {
          try
          {
            return (string) this[this.tableGiata_hotel.payment_descColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'payment_desc' in table 'Giata_hotel' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableGiata_hotel.payment_descColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string giata_last_update
      {
        get
        {
          try
          {
            return (string) this[this.tableGiata_hotel.giata_last_updateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'giata_last_update' in table 'Giata_hotel' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableGiata_hotel.giata_last_updateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DateTime updated_on
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableGiata_hotel.updated_onColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'updated_on' in table 'Giata_hotel' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableGiata_hotel.updated_onColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string language_code
      {
        get
        {
          try
          {
            return (string) this[this.tableGiata_hotel.language_codeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'language_code' in table 'Giata_hotel' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableGiata_hotel.language_codeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string stateprov
      {
        get
        {
          try
          {
            return (string) this[this.tableGiata_hotel.stateprovColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'stateprov' in table 'Giata_hotel' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableGiata_hotel.stateprovColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string rating
      {
        get
        {
          try
          {
            return (string) this[this.tableGiata_hotel.ratingColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'rating' in table 'Giata_hotel' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableGiata_hotel.ratingColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool Ishotel_nameNull() => this.IsNull(this.tableGiata_hotel.hotel_nameColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void Sethotel_nameNull() => this[this.tableGiata_hotel.hotel_nameColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool Iscity_idNull() => this.IsNull(this.tableGiata_hotel.city_idColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void Setcity_idNull() => this[this.tableGiata_hotel.city_idColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool Iscity_nameNull() => this.IsNull(this.tableGiata_hotel.city_nameColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void Setcity_nameNull() => this[this.tableGiata_hotel.city_nameColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool Iscountry_codeNull() => this.IsNull(this.tableGiata_hotel.country_codeColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void Setcountry_codeNull() => this[this.tableGiata_hotel.country_codeColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool Isaddress1Null() => this.IsNull(this.tableGiata_hotel.address1Column);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void Setaddress1Null() => this[this.tableGiata_hotel.address1Column] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool Isaddress2Null() => this.IsNull(this.tableGiata_hotel.address2Column);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void Setaddress2Null() => this[this.tableGiata_hotel.address2Column] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool Isaddress_moreNull() => this.IsNull(this.tableGiata_hotel.address_moreColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void Setaddress_moreNull() => this[this.tableGiata_hotel.address_moreColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsstreetNull() => this.IsNull(this.tableGiata_hotel.streetColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetstreetNull() => this[this.tableGiata_hotel.streetColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool Isstreet_numberNull() => this.IsNull(this.tableGiata_hotel.street_numberColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void Setstreet_numberNull() => this[this.tableGiata_hotel.street_numberColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool Isaddress_city_nameNull() => this.IsNull(this.tableGiata_hotel.address_city_nameColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void Setaddress_city_nameNull() => this[this.tableGiata_hotel.address_city_nameColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool Ispostal_codeNull() => this.IsNull(this.tableGiata_hotel.postal_codeColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void Setpostal_codeNull() => this[this.tableGiata_hotel.postal_codeColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool Isaddress_additional_infoNull() => this.IsNull(this.tableGiata_hotel.address_additional_infoColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void Setaddress_additional_infoNull() => this[this.tableGiata_hotel.address_additional_infoColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool Isaddress_country_codeNull() => this.IsNull(this.tableGiata_hotel.address_country_codeColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void Setaddress_country_codeNull() => this[this.tableGiata_hotel.address_country_codeColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool Isvoice_phoneNull() => this.IsNull(this.tableGiata_hotel.voice_phoneColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void Setvoice_phoneNull() => this[this.tableGiata_hotel.voice_phoneColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsemailNull() => this.IsNull(this.tableGiata_hotel.emailColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetemailNull() => this[this.tableGiata_hotel.emailColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsurlNull() => this.IsNull(this.tableGiata_hotel.urlColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SeturlNull() => this[this.tableGiata_hotel.urlColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool Isgeo_accuracyNull() => this.IsNull(this.tableGiata_hotel.geo_accuracyColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void Setgeo_accuracyNull() => this[this.tableGiata_hotel.geo_accuracyColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IslatitudeNull() => this.IsNull(this.tableGiata_hotel.latitudeColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetlatitudeNull() => this[this.tableGiata_hotel.latitudeColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IslongitudeNull() => this.IsNull(this.tableGiata_hotel.longitudeColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetlongitudeNull() => this[this.tableGiata_hotel.longitudeColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsghgmlNull() => this.IsNull(this.tableGiata_hotel.ghgmlColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetghgmlNull() => this[this.tableGiata_hotel.ghgmlColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool Islocation_descNull() => this.IsNull(this.tableGiata_hotel.location_descColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void Setlocation_descNull() => this[this.tableGiata_hotel.location_descColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool Isfacilities_descNull() => this.IsNull(this.tableGiata_hotel.facilities_descColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void Setfacilities_descNull() => this[this.tableGiata_hotel.facilities_descColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool Isrooms_descNull() => this.IsNull(this.tableGiata_hotel.rooms_descColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void Setrooms_descNull() => this[this.tableGiata_hotel.rooms_descColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool Issports_ent_descNull() => this.IsNull(this.tableGiata_hotel.sports_ent_descColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void Setsports_ent_descNull() => this[this.tableGiata_hotel.sports_ent_descColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool Ismeals_descNull() => this.IsNull(this.tableGiata_hotel.meals_descColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void Setmeals_descNull() => this[this.tableGiata_hotel.meals_descColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool Ispayment_descNull() => this.IsNull(this.tableGiata_hotel.payment_descColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void Setpayment_descNull() => this[this.tableGiata_hotel.payment_descColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool Isgiata_last_updateNull() => this.IsNull(this.tableGiata_hotel.giata_last_updateColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void Setgiata_last_updateNull() => this[this.tableGiata_hotel.giata_last_updateColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool Isupdated_onNull() => this.IsNull(this.tableGiata_hotel.updated_onColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void Setupdated_onNull() => this[this.tableGiata_hotel.updated_onColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool Islanguage_codeNull() => this.IsNull(this.tableGiata_hotel.language_codeColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void Setlanguage_codeNull() => this[this.tableGiata_hotel.language_codeColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsstateprovNull() => this.IsNull(this.tableGiata_hotel.stateprovColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetstateprovNull() => this[this.tableGiata_hotel.stateprovColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsratingNull() => this.IsNull(this.tableGiata_hotel.ratingColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetratingNull() => this[this.tableGiata_hotel.ratingColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public class Giata_hotelRowChangeEvent : EventArgs
    {
      private db1DataSet.Giata_hotelRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public Giata_hotelRowChangeEvent(db1DataSet.Giata_hotelRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public db1DataSet.Giata_hotelRow Row => this.eventRow;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataRowAction Action => this.eventAction;
    }
  }
}
