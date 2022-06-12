using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Diagnostics;
using WinTagger.Properties;

namespace WinTagger.db1DataSetTableAdapters
{
  [DesignerCategory("code")]
  [ToolboxItem(true)]
  [DataObject(true)]
  [Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [HelpKeyword("vs.data.TableAdapter")]
  public class Giata_hotelTableAdapter : Component
  {
    private OleDbDataAdapter _adapter;
    private OleDbConnection _connection;
    private OleDbTransaction _transaction;
    private OleDbCommand[] _commandCollection;
    private bool _clearBeforeFill;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Giata_hotelTableAdapter() => this.ClearBeforeFill = true;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected internal OleDbDataAdapter Adapter
    {
      get
      {
        if (this._adapter == null)
          this.InitAdapter();
        return this._adapter;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal OleDbConnection Connection
    {
      get
      {
        if (this._connection == null)
          this.InitConnection();
        return this._connection;
      }
      set
      {
        this._connection = value;
        if (this.Adapter.InsertCommand != null)
          this.Adapter.InsertCommand.Connection = value;
        if (this.Adapter.DeleteCommand != null)
          this.Adapter.DeleteCommand.Connection = value;
        if (this.Adapter.UpdateCommand != null)
          this.Adapter.UpdateCommand.Connection = value;
        for (int index = 0; index < this.CommandCollection.Length; ++index)
        {
          if (this.CommandCollection[index] != null)
            this.CommandCollection[index].Connection = value;
        }
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal OleDbTransaction Transaction
    {
      get => this._transaction;
      set
      {
        this._transaction = value;
        for (int index = 0; index < this.CommandCollection.Length; ++index)
          this.CommandCollection[index].Transaction = this._transaction;
        if (this.Adapter != null && this.Adapter.DeleteCommand != null)
          this.Adapter.DeleteCommand.Transaction = this._transaction;
        if (this.Adapter != null && this.Adapter.InsertCommand != null)
          this.Adapter.InsertCommand.Transaction = this._transaction;
        if (this.Adapter == null || this.Adapter.UpdateCommand == null)
          return;
        this.Adapter.UpdateCommand.Transaction = this._transaction;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected OleDbCommand[] CommandCollection
    {
      get
      {
        if (this._commandCollection == null)
          this.InitCommandCollection();
        return this._commandCollection;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool ClearBeforeFill
    {
      get => this._clearBeforeFill;
      set => this._clearBeforeFill = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitAdapter()
    {
      this._adapter = new OleDbDataAdapter();
      this._adapter.TableMappings.Add((object) new DataTableMapping()
      {
        SourceTable = "Table",
        DataSetTable = "Giata_hotel",
        ColumnMappings = {
          {
            "giata_id",
            "giata_id"
          },
          {
            "hotel_name",
            "hotel_name"
          },
          {
            "city_id",
            "city_id"
          },
          {
            "city_name",
            "city_name"
          },
          {
            "country_code",
            "country_code"
          },
          {
            "address1",
            "address1"
          },
          {
            "address2",
            "address2"
          },
          {
            "address_more",
            "address_more"
          },
          {
            "street",
            "street"
          },
          {
            "street_number",
            "street_number"
          },
          {
            "address_city_name",
            "address_city_name"
          },
          {
            "postal_code",
            "postal_code"
          },
          {
            "address_additional_info",
            "address_additional_info"
          },
          {
            "address_country_code",
            "address_country_code"
          },
          {
            "voice_phone",
            "voice_phone"
          },
          {
            "email",
            "email"
          },
          {
            "url",
            "url"
          },
          {
            "geo_accuracy",
            "geo_accuracy"
          },
          {
            "latitude",
            "latitude"
          },
          {
            "longitude",
            "longitude"
          },
          {
            "ghgml",
            "ghgml"
          },
          {
            "location_desc",
            "location_desc"
          },
          {
            "facilities_desc",
            "facilities_desc"
          },
          {
            "rooms_desc",
            "rooms_desc"
          },
          {
            "sports_ent_desc",
            "sports_ent_desc"
          },
          {
            "meals_desc",
            "meals_desc"
          },
          {
            "payment_desc",
            "payment_desc"
          },
          {
            "giata_last_update",
            "giata_last_update"
          },
          {
            "updated_on",
            "updated_on"
          },
          {
            "language_code",
            "language_code"
          },
          {
            "stateprov",
            "stateprov"
          },
          {
            "rating",
            "rating"
          }
        }
      });
      this._adapter.DeleteCommand = new OleDbCommand();
      this._adapter.DeleteCommand.Connection = this.Connection;
      this._adapter.DeleteCommand.CommandText = "DELETE FROM `Giata_hotel` WHERE ((`giata_id` = ?) AND ((? = 1 AND `hotel_name` IS NULL) OR (`hotel_name` = ?)) AND ((? = 1 AND `city_id` IS NULL) OR (`city_id` = ?)) AND ((? = 1 AND `city_name` IS NULL) OR (`city_name` = ?)) AND ((? = 1 AND `country_code` IS NULL) OR (`country_code` = ?)) AND ((? = 1 AND `address1` IS NULL) OR (`address1` = ?)) AND ((? = 1 AND `address2` IS NULL) OR (`address2` = ?)) AND ((? = 1 AND `address_more` IS NULL) OR (`address_more` = ?)) AND ((? = 1 AND `street` IS NULL) OR (`street` = ?)) AND ((? = 1 AND `street_number` IS NULL) OR (`street_number` = ?)) AND ((? = 1 AND `address_city_name` IS NULL) OR (`address_city_name` = ?)) AND ((? = 1 AND `postal_code` IS NULL) OR (`postal_code` = ?)) AND ((? = 1 AND `address_additional_info` IS NULL) OR (`address_additional_info` = ?)) AND ((? = 1 AND `address_country_code` IS NULL) OR (`address_country_code` = ?)) AND ((? = 1 AND `voice_phone` IS NULL) OR (`voice_phone` = ?)) AND ((? = 1 AND `email` IS NULL) OR (`email` = ?)) AND ((? = 1 AND `url` IS NULL) OR (`url` = ?)) AND ((? = 1 AND `geo_accuracy` IS NULL) OR (`geo_accuracy` = ?)) AND ((? = 1 AND `latitude` IS NULL) OR (`latitude` = ?)) AND ((? = 1 AND `longitude` IS NULL) OR (`longitude` = ?)) AND ((? = 1 AND `ghgml` IS NULL) OR (`ghgml` = ?)) AND ((? = 1 AND `location_desc` IS NULL) OR (`location_desc` = ?)) AND ((? = 1 AND `facilities_desc` IS NULL) OR (`facilities_desc` = ?)) AND ((? = 1 AND `rooms_desc` IS NULL) OR (`rooms_desc` = ?)) AND ((? = 1 AND `sports_ent_desc` IS NULL) OR (`sports_ent_desc` = ?)) AND ((? = 1 AND `meals_desc` IS NULL) OR (`meals_desc` = ?)) AND ((? = 1 AND `payment_desc` IS NULL) OR (`payment_desc` = ?)) AND ((? = 1 AND `giata_last_update` IS NULL) OR (`giata_last_update` = ?)) AND ((? = 1 AND `updated_on` IS NULL) OR (`updated_on` = ?)) AND ((? = 1 AND `language_code` IS NULL) OR (`language_code` = ?)) AND ((? = 1 AND `stateprov` IS NULL) OR (`stateprov` = ?)) AND ((? = 1 AND `rating` IS NULL) OR (`rating` = ?)))";
      this._adapter.DeleteCommand.CommandType = CommandType.Text;
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_giata_id", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "giata_id", DataRowVersion.Original, false, (object) null));
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_hotel_name", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "hotel_name", DataRowVersion.Original, true, (object) null));
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_hotel_name", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "hotel_name", DataRowVersion.Original, false, (object) null));
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_city_id", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "city_id", DataRowVersion.Original, true, (object) null));
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_city_id", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "city_id", DataRowVersion.Original, false, (object) null));
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_city_name", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "city_name", DataRowVersion.Original, true, (object) null));
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_city_name", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "city_name", DataRowVersion.Original, false, (object) null));
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_country_code", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "country_code", DataRowVersion.Original, true, (object) null));
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_country_code", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "country_code", DataRowVersion.Original, false, (object) null));
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_address1", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "address1", DataRowVersion.Original, true, (object) null));
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_address1", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "address1", DataRowVersion.Original, false, (object) null));
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_address2", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "address2", DataRowVersion.Original, true, (object) null));
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_address2", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "address2", DataRowVersion.Original, false, (object) null));
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_address_more", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "address_more", DataRowVersion.Original, true, (object) null));
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_address_more", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "address_more", DataRowVersion.Original, false, (object) null));
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_street", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "street", DataRowVersion.Original, true, (object) null));
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_street", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "street", DataRowVersion.Original, false, (object) null));
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_street_number", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "street_number", DataRowVersion.Original, true, (object) null));
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_street_number", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "street_number", DataRowVersion.Original, false, (object) null));
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_address_city_name", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "address_city_name", DataRowVersion.Original, true, (object) null));
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_address_city_name", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "address_city_name", DataRowVersion.Original, false, (object) null));
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_postal_code", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "postal_code", DataRowVersion.Original, true, (object) null));
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_postal_code", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "postal_code", DataRowVersion.Original, false, (object) null));
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_address_additional_info", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "address_additional_info", DataRowVersion.Original, true, (object) null));
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_address_additional_info", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "address_additional_info", DataRowVersion.Original, false, (object) null));
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_address_country_code", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "address_country_code", DataRowVersion.Original, true, (object) null));
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_address_country_code", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "address_country_code", DataRowVersion.Original, false, (object) null));
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_voice_phone", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "voice_phone", DataRowVersion.Original, true, (object) null));
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_voice_phone", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "voice_phone", DataRowVersion.Original, false, (object) null));
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_email", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "email", DataRowVersion.Original, true, (object) null));
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_email", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "email", DataRowVersion.Original, false, (object) null));
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_url", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "url", DataRowVersion.Original, true, (object) null));
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_url", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "url", DataRowVersion.Original, false, (object) null));
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_geo_accuracy", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "geo_accuracy", DataRowVersion.Original, true, (object) null));
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_geo_accuracy", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "geo_accuracy", DataRowVersion.Original, false, (object) null));
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_latitude", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "latitude", DataRowVersion.Original, true, (object) null));
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_latitude", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "latitude", DataRowVersion.Original, false, (object) null));
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_longitude", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "longitude", DataRowVersion.Original, true, (object) null));
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_longitude", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "longitude", DataRowVersion.Original, false, (object) null));
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_ghgml", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ghgml", DataRowVersion.Original, true, (object) null));
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_ghgml", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ghgml", DataRowVersion.Original, false, (object) null));
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_location_desc", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "location_desc", DataRowVersion.Original, true, (object) null));
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_location_desc", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "location_desc", DataRowVersion.Original, false, (object) null));
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_facilities_desc", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "facilities_desc", DataRowVersion.Original, true, (object) null));
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_facilities_desc", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "facilities_desc", DataRowVersion.Original, false, (object) null));
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_rooms_desc", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "rooms_desc", DataRowVersion.Original, true, (object) null));
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_rooms_desc", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "rooms_desc", DataRowVersion.Original, false, (object) null));
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_sports_ent_desc", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "sports_ent_desc", DataRowVersion.Original, true, (object) null));
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_sports_ent_desc", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "sports_ent_desc", DataRowVersion.Original, false, (object) null));
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_meals_desc", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "meals_desc", DataRowVersion.Original, true, (object) null));
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_meals_desc", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "meals_desc", DataRowVersion.Original, false, (object) null));
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_payment_desc", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "payment_desc", DataRowVersion.Original, true, (object) null));
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_payment_desc", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "payment_desc", DataRowVersion.Original, false, (object) null));
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_giata_last_update", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "giata_last_update", DataRowVersion.Original, true, (object) null));
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_giata_last_update", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "giata_last_update", DataRowVersion.Original, false, (object) null));
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_updated_on", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "updated_on", DataRowVersion.Original, true, (object) null));
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_updated_on", OleDbType.Date, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "updated_on", DataRowVersion.Original, false, (object) null));
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_language_code", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "language_code", DataRowVersion.Original, true, (object) null));
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_language_code", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "language_code", DataRowVersion.Original, false, (object) null));
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_stateprov", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "stateprov", DataRowVersion.Original, true, (object) null));
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_stateprov", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "stateprov", DataRowVersion.Original, false, (object) null));
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_rating", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "rating", DataRowVersion.Original, true, (object) null));
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_rating", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "rating", DataRowVersion.Original, false, (object) null));
      this._adapter.InsertCommand = new OleDbCommand();
      this._adapter.InsertCommand.Connection = this.Connection;
      this._adapter.InsertCommand.CommandText = "INSERT INTO `Giata_hotel` (`giata_id`, `hotel_name`, `city_id`, `city_name`, `country_code`, `address1`, `address2`, `address_more`, `street`, `street_number`, `address_city_name`, `postal_code`, `address_additional_info`, `address_country_code`, `voice_phone`, `email`, `url`, `geo_accuracy`, `latitude`, `longitude`, `ghgml`, `location_desc`, `facilities_desc`, `rooms_desc`, `sports_ent_desc`, `meals_desc`, `payment_desc`, `giata_last_update`, `updated_on`, `language_code`, `stateprov`, `rating`) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
      this._adapter.InsertCommand.CommandType = CommandType.Text;
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("giata_id", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "giata_id", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("hotel_name", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "hotel_name", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("city_id", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "city_id", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("city_name", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "city_name", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("country_code", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "country_code", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("address1", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "address1", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("address2", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "address2", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("address_more", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "address_more", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("street", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "street", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("street_number", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "street_number", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("address_city_name", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "address_city_name", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("postal_code", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "postal_code", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("address_additional_info", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "address_additional_info", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("address_country_code", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "address_country_code", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("voice_phone", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "voice_phone", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("email", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "email", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("url", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "url", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("geo_accuracy", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "geo_accuracy", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("latitude", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "latitude", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("longitude", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "longitude", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("ghgml", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ghgml", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("location_desc", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "location_desc", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("facilities_desc", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "facilities_desc", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("rooms_desc", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "rooms_desc", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("sports_ent_desc", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "sports_ent_desc", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("meals_desc", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "meals_desc", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("payment_desc", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "payment_desc", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("giata_last_update", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "giata_last_update", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("updated_on", OleDbType.Date, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "updated_on", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("language_code", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "language_code", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("stateprov", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "stateprov", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("rating", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "rating", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand = new OleDbCommand();
      this._adapter.UpdateCommand.Connection = this.Connection;
      this._adapter.UpdateCommand.CommandText = "UPDATE `Giata_hotel` SET `giata_id` = ?, `hotel_name` = ?, `city_id` = ?, `city_name` = ?, `country_code` = ?, `address1` = ?, `address2` = ?, `address_more` = ?, `street` = ?, `street_number` = ?, `address_city_name` = ?, `postal_code` = ?, `address_additional_info` = ?, `address_country_code` = ?, `voice_phone` = ?, `email` = ?, `url` = ?, `geo_accuracy` = ?, `latitude` = ?, `longitude` = ?, `ghgml` = ?, `location_desc` = ?, `facilities_desc` = ?, `rooms_desc` = ?, `sports_ent_desc` = ?, `meals_desc` = ?, `payment_desc` = ?, `giata_last_update` = ?, `updated_on` = ?, `language_code` = ?, `stateprov` = ?, `rating` = ? WHERE ((`giata_id` = ?) AND ((? = 1 AND `hotel_name` IS NULL) OR (`hotel_name` = ?)) AND ((? = 1 AND `city_id` IS NULL) OR (`city_id` = ?)) AND ((? = 1 AND `city_name` IS NULL) OR (`city_name` = ?)) AND ((? = 1 AND `country_code` IS NULL) OR (`country_code` = ?)) AND ((? = 1 AND `address1` IS NULL) OR (`address1` = ?)) AND ((? = 1 AND `address2` IS NULL) OR (`address2` = ?)) AND ((? = 1 AND `address_more` IS NULL) OR (`address_more` = ?)) AND ((? = 1 AND `street` IS NULL) OR (`street` = ?)) AND ((? = 1 AND `street_number` IS NULL) OR (`street_number` = ?)) AND ((? = 1 AND `address_city_name` IS NULL) OR (`address_city_name` = ?)) AND ((? = 1 AND `postal_code` IS NULL) OR (`postal_code` = ?)) AND ((? = 1 AND `address_additional_info` IS NULL) OR (`address_additional_info` = ?)) AND ((? = 1 AND `address_country_code` IS NULL) OR (`address_country_code` = ?)) AND ((? = 1 AND `voice_phone` IS NULL) OR (`voice_phone` = ?)) AND ((? = 1 AND `email` IS NULL) OR (`email` = ?)) AND ((? = 1 AND `url` IS NULL) OR (`url` = ?)) AND ((? = 1 AND `geo_accuracy` IS NULL) OR (`geo_accuracy` = ?)) AND ((? = 1 AND `latitude` IS NULL) OR (`latitude` = ?)) AND ((? = 1 AND `longitude` IS NULL) OR (`longitude` = ?)) AND ((? = 1 AND `ghgml` IS NULL) OR (`ghgml` = ?)) AND ((? = 1 AND `location_desc` IS NULL) OR (`location_desc` = ?)) AND ((? = 1 AND `facilities_desc` IS NULL) OR (`facilities_desc` = ?)) AND ((? = 1 AND `rooms_desc` IS NULL) OR (`rooms_desc` = ?)) AND ((? = 1 AND `sports_ent_desc` IS NULL) OR (`sports_ent_desc` = ?)) AND ((? = 1 AND `meals_desc` IS NULL) OR (`meals_desc` = ?)) AND ((? = 1 AND `payment_desc` IS NULL) OR (`payment_desc` = ?)) AND ((? = 1 AND `giata_last_update` IS NULL) OR (`giata_last_update` = ?)) AND ((? = 1 AND `updated_on` IS NULL) OR (`updated_on` = ?)) AND ((? = 1 AND `language_code` IS NULL) OR (`language_code` = ?)) AND ((? = 1 AND `stateprov` IS NULL) OR (`stateprov` = ?)) AND ((? = 1 AND `rating` IS NULL) OR (`rating` = ?)))";
      this._adapter.UpdateCommand.CommandType = CommandType.Text;
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("giata_id", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "giata_id", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("hotel_name", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "hotel_name", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("city_id", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "city_id", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("city_name", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "city_name", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("country_code", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "country_code", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("address1", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "address1", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("address2", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "address2", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("address_more", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "address_more", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("street", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "street", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("street_number", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "street_number", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("address_city_name", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "address_city_name", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("postal_code", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "postal_code", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("address_additional_info", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "address_additional_info", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("address_country_code", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "address_country_code", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("voice_phone", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "voice_phone", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("email", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "email", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("url", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "url", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("geo_accuracy", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "geo_accuracy", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("latitude", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "latitude", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("longitude", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "longitude", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("ghgml", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ghgml", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("location_desc", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "location_desc", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("facilities_desc", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "facilities_desc", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("rooms_desc", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "rooms_desc", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("sports_ent_desc", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "sports_ent_desc", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("meals_desc", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "meals_desc", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("payment_desc", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "payment_desc", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("giata_last_update", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "giata_last_update", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("updated_on", OleDbType.Date, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "updated_on", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("language_code", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "language_code", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("stateprov", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "stateprov", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("rating", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "rating", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_giata_id", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "giata_id", DataRowVersion.Original, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_hotel_name", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "hotel_name", DataRowVersion.Original, true, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_hotel_name", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "hotel_name", DataRowVersion.Original, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_city_id", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "city_id", DataRowVersion.Original, true, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_city_id", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "city_id", DataRowVersion.Original, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_city_name", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "city_name", DataRowVersion.Original, true, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_city_name", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "city_name", DataRowVersion.Original, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_country_code", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "country_code", DataRowVersion.Original, true, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_country_code", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "country_code", DataRowVersion.Original, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_address1", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "address1", DataRowVersion.Original, true, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_address1", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "address1", DataRowVersion.Original, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_address2", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "address2", DataRowVersion.Original, true, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_address2", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "address2", DataRowVersion.Original, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_address_more", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "address_more", DataRowVersion.Original, true, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_address_more", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "address_more", DataRowVersion.Original, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_street", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "street", DataRowVersion.Original, true, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_street", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "street", DataRowVersion.Original, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_street_number", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "street_number", DataRowVersion.Original, true, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_street_number", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "street_number", DataRowVersion.Original, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_address_city_name", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "address_city_name", DataRowVersion.Original, true, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_address_city_name", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "address_city_name", DataRowVersion.Original, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_postal_code", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "postal_code", DataRowVersion.Original, true, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_postal_code", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "postal_code", DataRowVersion.Original, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_address_additional_info", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "address_additional_info", DataRowVersion.Original, true, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_address_additional_info", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "address_additional_info", DataRowVersion.Original, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_address_country_code", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "address_country_code", DataRowVersion.Original, true, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_address_country_code", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "address_country_code", DataRowVersion.Original, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_voice_phone", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "voice_phone", DataRowVersion.Original, true, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_voice_phone", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "voice_phone", DataRowVersion.Original, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_email", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "email", DataRowVersion.Original, true, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_email", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "email", DataRowVersion.Original, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_url", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "url", DataRowVersion.Original, true, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_url", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "url", DataRowVersion.Original, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_geo_accuracy", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "geo_accuracy", DataRowVersion.Original, true, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_geo_accuracy", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "geo_accuracy", DataRowVersion.Original, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_latitude", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "latitude", DataRowVersion.Original, true, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_latitude", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "latitude", DataRowVersion.Original, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_longitude", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "longitude", DataRowVersion.Original, true, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_longitude", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "longitude", DataRowVersion.Original, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_ghgml", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ghgml", DataRowVersion.Original, true, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_ghgml", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ghgml", DataRowVersion.Original, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_location_desc", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "location_desc", DataRowVersion.Original, true, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_location_desc", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "location_desc", DataRowVersion.Original, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_facilities_desc", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "facilities_desc", DataRowVersion.Original, true, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_facilities_desc", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "facilities_desc", DataRowVersion.Original, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_rooms_desc", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "rooms_desc", DataRowVersion.Original, true, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_rooms_desc", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "rooms_desc", DataRowVersion.Original, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_sports_ent_desc", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "sports_ent_desc", DataRowVersion.Original, true, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_sports_ent_desc", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "sports_ent_desc", DataRowVersion.Original, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_meals_desc", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "meals_desc", DataRowVersion.Original, true, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_meals_desc", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "meals_desc", DataRowVersion.Original, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_payment_desc", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "payment_desc", DataRowVersion.Original, true, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_payment_desc", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "payment_desc", DataRowVersion.Original, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_giata_last_update", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "giata_last_update", DataRowVersion.Original, true, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_giata_last_update", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "giata_last_update", DataRowVersion.Original, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_updated_on", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "updated_on", DataRowVersion.Original, true, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_updated_on", OleDbType.Date, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "updated_on", DataRowVersion.Original, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_language_code", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "language_code", DataRowVersion.Original, true, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_language_code", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "language_code", DataRowVersion.Original, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_stateprov", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "stateprov", DataRowVersion.Original, true, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_stateprov", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "stateprov", DataRowVersion.Original, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_rating", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "rating", DataRowVersion.Original, true, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_rating", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "rating", DataRowVersion.Original, false, (object) null));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitConnection()
    {
      this._connection = new OleDbConnection();
      this._connection.ConnectionString = Settings.Default.db1ConnectionString;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitCommandCollection()
    {
      this._commandCollection = new OleDbCommand[1];
      this._commandCollection[0] = new OleDbCommand();
      this._commandCollection[0].Connection = this.Connection;
      this._commandCollection[0].CommandText = "SELECT giata_id, hotel_name, city_id, city_name, country_code, address1, address2, address_more, street, street_number, address_city_name, postal_code, address_additional_info, address_country_code, voice_phone, email, url, geo_accuracy, latitude, longitude, ghgml, location_desc, facilities_desc, rooms_desc, sports_ent_desc, meals_desc, payment_desc, giata_last_update, updated_on, language_code, stateprov, rating FROM Giata_hotel";
      this._commandCollection[0].CommandType = CommandType.Text;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Fill, true)]
    public virtual int Fill(db1DataSet.Giata_hotelDataTable dataTable)
    {
      this.Adapter.SelectCommand = this.CommandCollection[0];
      if (this.ClearBeforeFill)
        dataTable.Clear();
      return this.Adapter.Fill((DataTable) dataTable);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Select, true)]
    public virtual db1DataSet.Giata_hotelDataTable GetData()
    {
      this.Adapter.SelectCommand = this.CommandCollection[0];
      db1DataSet.Giata_hotelDataTable data = new db1DataSet.Giata_hotelDataTable();
      this.Adapter.Fill((DataTable) data);
      return data;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(db1DataSet.Giata_hotelDataTable dataTable) => this.Adapter.Update((DataTable) dataTable);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(db1DataSet dataSet) => this.Adapter.Update((DataSet) dataSet, "Giata_hotel");

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(DataRow dataRow) => this.Adapter.Update(new DataRow[1]
    {
      dataRow
    });

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(DataRow[] dataRows) => this.Adapter.Update(dataRows);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Delete, true)]
    public virtual int Delete(
      int? Original_giata_id,
      string Original_hotel_name,
      int? Original_city_id,
      string Original_city_name,
      string Original_country_code,
      string Original_address1,
      string Original_address2,
      string Original_address_more,
      string Original_street,
      string Original_street_number,
      string Original_address_city_name,
      string Original_postal_code,
      string Original_address_additional_info,
      string Original_address_country_code,
      string Original_voice_phone,
      string Original_email,
      string Original_url,
      string Original_geo_accuracy,
      string Original_latitude,
      string Original_longitude,
      string Original_ghgml,
      string Original_location_desc,
      string Original_facilities_desc,
      string Original_rooms_desc,
      string Original_sports_ent_desc,
      string Original_meals_desc,
      string Original_payment_desc,
      string Original_giata_last_update,
      DateTime? Original_updated_on,
      string Original_language_code,
      string Original_stateprov,
      string Original_rating)
    {
      if (Original_giata_id.HasValue)
        this.Adapter.DeleteCommand.Parameters[0].Value = (object) Original_giata_id.Value;
      else
        this.Adapter.DeleteCommand.Parameters[0].Value = (object) DBNull.Value;
      if (Original_hotel_name == null)
      {
        this.Adapter.DeleteCommand.Parameters[1].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[2].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[1].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[2].Value = (object) Original_hotel_name;
      }
      if (Original_city_id.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[3].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[4].Value = (object) Original_city_id.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[3].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[4].Value = (object) DBNull.Value;
      }
      if (Original_city_name == null)
      {
        this.Adapter.DeleteCommand.Parameters[5].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[6].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[5].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[6].Value = (object) Original_city_name;
      }
      if (Original_country_code == null)
      {
        this.Adapter.DeleteCommand.Parameters[7].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[8].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[7].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[8].Value = (object) Original_country_code;
      }
      if (Original_address1 == null)
      {
        this.Adapter.DeleteCommand.Parameters[9].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[10].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[9].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[10].Value = (object) Original_address1;
      }
      if (Original_address2 == null)
      {
        this.Adapter.DeleteCommand.Parameters[11].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[12].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[11].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[12].Value = (object) Original_address2;
      }
      if (Original_address_more == null)
      {
        this.Adapter.DeleteCommand.Parameters[13].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[14].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[13].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[14].Value = (object) Original_address_more;
      }
      if (Original_street == null)
      {
        this.Adapter.DeleteCommand.Parameters[15].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[16].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[15].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[16].Value = (object) Original_street;
      }
      if (Original_street_number == null)
      {
        this.Adapter.DeleteCommand.Parameters[17].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[18].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[17].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[18].Value = (object) Original_street_number;
      }
      if (Original_address_city_name == null)
      {
        this.Adapter.DeleteCommand.Parameters[19].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[20].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[19].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[20].Value = (object) Original_address_city_name;
      }
      if (Original_postal_code == null)
      {
        this.Adapter.DeleteCommand.Parameters[21].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[22].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[21].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[22].Value = (object) Original_postal_code;
      }
      if (Original_address_additional_info == null)
      {
        this.Adapter.DeleteCommand.Parameters[23].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[24].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[23].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[24].Value = (object) Original_address_additional_info;
      }
      if (Original_address_country_code == null)
      {
        this.Adapter.DeleteCommand.Parameters[25].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[26].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[25].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[26].Value = (object) Original_address_country_code;
      }
      if (Original_voice_phone == null)
      {
        this.Adapter.DeleteCommand.Parameters[27].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[28].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[27].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[28].Value = (object) Original_voice_phone;
      }
      if (Original_email == null)
      {
        this.Adapter.DeleteCommand.Parameters[29].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[30].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[29].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[30].Value = (object) Original_email;
      }
      if (Original_url == null)
      {
        this.Adapter.DeleteCommand.Parameters[31].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[32].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[31].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[32].Value = (object) Original_url;
      }
      if (Original_geo_accuracy == null)
      {
        this.Adapter.DeleteCommand.Parameters[33].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[34].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[33].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[34].Value = (object) Original_geo_accuracy;
      }
      if (Original_latitude == null)
      {
        this.Adapter.DeleteCommand.Parameters[35].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[36].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[35].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[36].Value = (object) Original_latitude;
      }
      if (Original_longitude == null)
      {
        this.Adapter.DeleteCommand.Parameters[37].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[38].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[37].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[38].Value = (object) Original_longitude;
      }
      if (Original_ghgml == null)
      {
        this.Adapter.DeleteCommand.Parameters[39].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[40].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[39].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[40].Value = (object) Original_ghgml;
      }
      if (Original_location_desc == null)
      {
        this.Adapter.DeleteCommand.Parameters[41].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[42].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[41].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[42].Value = (object) Original_location_desc;
      }
      if (Original_facilities_desc == null)
      {
        this.Adapter.DeleteCommand.Parameters[43].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[44].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[43].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[44].Value = (object) Original_facilities_desc;
      }
      if (Original_rooms_desc == null)
      {
        this.Adapter.DeleteCommand.Parameters[45].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[46].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[45].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[46].Value = (object) Original_rooms_desc;
      }
      if (Original_sports_ent_desc == null)
      {
        this.Adapter.DeleteCommand.Parameters[47].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[48].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[47].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[48].Value = (object) Original_sports_ent_desc;
      }
      if (Original_meals_desc == null)
      {
        this.Adapter.DeleteCommand.Parameters[49].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[50].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[49].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[50].Value = (object) Original_meals_desc;
      }
      if (Original_payment_desc == null)
      {
        this.Adapter.DeleteCommand.Parameters[51].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[52].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[51].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[52].Value = (object) Original_payment_desc;
      }
      if (Original_giata_last_update == null)
      {
        this.Adapter.DeleteCommand.Parameters[53].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[54].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[53].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[54].Value = (object) Original_giata_last_update;
      }
      if (Original_updated_on.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[55].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[56].Value = (object) Original_updated_on.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[55].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[56].Value = (object) DBNull.Value;
      }
      if (Original_language_code == null)
      {
        this.Adapter.DeleteCommand.Parameters[57].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[58].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[57].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[58].Value = (object) Original_language_code;
      }
      if (Original_stateprov == null)
      {
        this.Adapter.DeleteCommand.Parameters[59].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[60].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[59].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[60].Value = (object) Original_stateprov;
      }
      if (Original_rating == null)
      {
        this.Adapter.DeleteCommand.Parameters[61].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[62].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[61].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[62].Value = (object) Original_rating;
      }
      ConnectionState state = this.Adapter.DeleteCommand.Connection.State;
      if ((this.Adapter.DeleteCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
        this.Adapter.DeleteCommand.Connection.Open();
      try
      {
        return this.Adapter.DeleteCommand.ExecuteNonQuery();
      }
      finally
      {
        if (state == ConnectionState.Closed)
          this.Adapter.DeleteCommand.Connection.Close();
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Insert, true)]
    public virtual int Insert(
      int? giata_id,
      string hotel_name,
      int? city_id,
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
      DateTime? updated_on,
      string language_code,
      string stateprov,
      string rating)
    {
      if (giata_id.HasValue)
        this.Adapter.InsertCommand.Parameters[0].Value = (object) giata_id.Value;
      else
        this.Adapter.InsertCommand.Parameters[0].Value = (object) DBNull.Value;
      if (hotel_name == null)
        this.Adapter.InsertCommand.Parameters[1].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[1].Value = (object) hotel_name;
      if (city_id.HasValue)
        this.Adapter.InsertCommand.Parameters[2].Value = (object) city_id.Value;
      else
        this.Adapter.InsertCommand.Parameters[2].Value = (object) DBNull.Value;
      if (city_name == null)
        this.Adapter.InsertCommand.Parameters[3].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[3].Value = (object) city_name;
      if (country_code == null)
        this.Adapter.InsertCommand.Parameters[4].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[4].Value = (object) country_code;
      if (address1 == null)
        this.Adapter.InsertCommand.Parameters[5].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[5].Value = (object) address1;
      if (address2 == null)
        this.Adapter.InsertCommand.Parameters[6].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[6].Value = (object) address2;
      if (address_more == null)
        this.Adapter.InsertCommand.Parameters[7].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[7].Value = (object) address_more;
      if (street == null)
        this.Adapter.InsertCommand.Parameters[8].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[8].Value = (object) street;
      if (street_number == null)
        this.Adapter.InsertCommand.Parameters[9].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[9].Value = (object) street_number;
      if (address_city_name == null)
        this.Adapter.InsertCommand.Parameters[10].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[10].Value = (object) address_city_name;
      if (postal_code == null)
        this.Adapter.InsertCommand.Parameters[11].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[11].Value = (object) postal_code;
      if (address_additional_info == null)
        this.Adapter.InsertCommand.Parameters[12].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[12].Value = (object) address_additional_info;
      if (address_country_code == null)
        this.Adapter.InsertCommand.Parameters[13].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[13].Value = (object) address_country_code;
      if (voice_phone == null)
        this.Adapter.InsertCommand.Parameters[14].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[14].Value = (object) voice_phone;
      if (email == null)
        this.Adapter.InsertCommand.Parameters[15].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[15].Value = (object) email;
      if (url == null)
        this.Adapter.InsertCommand.Parameters[16].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[16].Value = (object) url;
      if (geo_accuracy == null)
        this.Adapter.InsertCommand.Parameters[17].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[17].Value = (object) geo_accuracy;
      if (latitude == null)
        this.Adapter.InsertCommand.Parameters[18].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[18].Value = (object) latitude;
      if (longitude == null)
        this.Adapter.InsertCommand.Parameters[19].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[19].Value = (object) longitude;
      if (ghgml == null)
        this.Adapter.InsertCommand.Parameters[20].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[20].Value = (object) ghgml;
      if (location_desc == null)
        this.Adapter.InsertCommand.Parameters[21].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[21].Value = (object) location_desc;
      if (facilities_desc == null)
        this.Adapter.InsertCommand.Parameters[22].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[22].Value = (object) facilities_desc;
      if (rooms_desc == null)
        this.Adapter.InsertCommand.Parameters[23].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[23].Value = (object) rooms_desc;
      if (sports_ent_desc == null)
        this.Adapter.InsertCommand.Parameters[24].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[24].Value = (object) sports_ent_desc;
      if (meals_desc == null)
        this.Adapter.InsertCommand.Parameters[25].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[25].Value = (object) meals_desc;
      if (payment_desc == null)
        this.Adapter.InsertCommand.Parameters[26].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[26].Value = (object) payment_desc;
      if (giata_last_update == null)
        this.Adapter.InsertCommand.Parameters[27].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[27].Value = (object) giata_last_update;
      if (updated_on.HasValue)
        this.Adapter.InsertCommand.Parameters[28].Value = (object) updated_on.Value;
      else
        this.Adapter.InsertCommand.Parameters[28].Value = (object) DBNull.Value;
      if (language_code == null)
        this.Adapter.InsertCommand.Parameters[29].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[29].Value = (object) language_code;
      if (stateprov == null)
        this.Adapter.InsertCommand.Parameters[30].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[30].Value = (object) stateprov;
      if (rating == null)
        this.Adapter.InsertCommand.Parameters[31].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[31].Value = (object) rating;
      ConnectionState state = this.Adapter.InsertCommand.Connection.State;
      if ((this.Adapter.InsertCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
        this.Adapter.InsertCommand.Connection.Open();
      try
      {
        return this.Adapter.InsertCommand.ExecuteNonQuery();
      }
      finally
      {
        if (state == ConnectionState.Closed)
          this.Adapter.InsertCommand.Connection.Close();
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Update, true)]
    public virtual int Update(
      int? giata_id,
      string hotel_name,
      int? city_id,
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
      DateTime? updated_on,
      string language_code,
      string stateprov,
      string rating,
      int? Original_giata_id,
      string Original_hotel_name,
      int? Original_city_id,
      string Original_city_name,
      string Original_country_code,
      string Original_address1,
      string Original_address2,
      string Original_address_more,
      string Original_street,
      string Original_street_number,
      string Original_address_city_name,
      string Original_postal_code,
      string Original_address_additional_info,
      string Original_address_country_code,
      string Original_voice_phone,
      string Original_email,
      string Original_url,
      string Original_geo_accuracy,
      string Original_latitude,
      string Original_longitude,
      string Original_ghgml,
      string Original_location_desc,
      string Original_facilities_desc,
      string Original_rooms_desc,
      string Original_sports_ent_desc,
      string Original_meals_desc,
      string Original_payment_desc,
      string Original_giata_last_update,
      DateTime? Original_updated_on,
      string Original_language_code,
      string Original_stateprov,
      string Original_rating)
    {
      if (giata_id.HasValue)
        this.Adapter.UpdateCommand.Parameters[0].Value = (object) giata_id.Value;
      else
        this.Adapter.UpdateCommand.Parameters[0].Value = (object) DBNull.Value;
      if (hotel_name == null)
        this.Adapter.UpdateCommand.Parameters[1].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[1].Value = (object) hotel_name;
      if (city_id.HasValue)
        this.Adapter.UpdateCommand.Parameters[2].Value = (object) city_id.Value;
      else
        this.Adapter.UpdateCommand.Parameters[2].Value = (object) DBNull.Value;
      if (city_name == null)
        this.Adapter.UpdateCommand.Parameters[3].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[3].Value = (object) city_name;
      if (country_code == null)
        this.Adapter.UpdateCommand.Parameters[4].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[4].Value = (object) country_code;
      if (address1 == null)
        this.Adapter.UpdateCommand.Parameters[5].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[5].Value = (object) address1;
      if (address2 == null)
        this.Adapter.UpdateCommand.Parameters[6].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[6].Value = (object) address2;
      if (address_more == null)
        this.Adapter.UpdateCommand.Parameters[7].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[7].Value = (object) address_more;
      if (street == null)
        this.Adapter.UpdateCommand.Parameters[8].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[8].Value = (object) street;
      if (street_number == null)
        this.Adapter.UpdateCommand.Parameters[9].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[9].Value = (object) street_number;
      if (address_city_name == null)
        this.Adapter.UpdateCommand.Parameters[10].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[10].Value = (object) address_city_name;
      if (postal_code == null)
        this.Adapter.UpdateCommand.Parameters[11].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[11].Value = (object) postal_code;
      if (address_additional_info == null)
        this.Adapter.UpdateCommand.Parameters[12].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[12].Value = (object) address_additional_info;
      if (address_country_code == null)
        this.Adapter.UpdateCommand.Parameters[13].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[13].Value = (object) address_country_code;
      if (voice_phone == null)
        this.Adapter.UpdateCommand.Parameters[14].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[14].Value = (object) voice_phone;
      if (email == null)
        this.Adapter.UpdateCommand.Parameters[15].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[15].Value = (object) email;
      if (url == null)
        this.Adapter.UpdateCommand.Parameters[16].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[16].Value = (object) url;
      if (geo_accuracy == null)
        this.Adapter.UpdateCommand.Parameters[17].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[17].Value = (object) geo_accuracy;
      if (latitude == null)
        this.Adapter.UpdateCommand.Parameters[18].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[18].Value = (object) latitude;
      if (longitude == null)
        this.Adapter.UpdateCommand.Parameters[19].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[19].Value = (object) longitude;
      if (ghgml == null)
        this.Adapter.UpdateCommand.Parameters[20].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[20].Value = (object) ghgml;
      if (location_desc == null)
        this.Adapter.UpdateCommand.Parameters[21].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[21].Value = (object) location_desc;
      if (facilities_desc == null)
        this.Adapter.UpdateCommand.Parameters[22].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[22].Value = (object) facilities_desc;
      if (rooms_desc == null)
        this.Adapter.UpdateCommand.Parameters[23].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[23].Value = (object) rooms_desc;
      if (sports_ent_desc == null)
        this.Adapter.UpdateCommand.Parameters[24].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[24].Value = (object) sports_ent_desc;
      if (meals_desc == null)
        this.Adapter.UpdateCommand.Parameters[25].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[25].Value = (object) meals_desc;
      if (payment_desc == null)
        this.Adapter.UpdateCommand.Parameters[26].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[26].Value = (object) payment_desc;
      if (giata_last_update == null)
        this.Adapter.UpdateCommand.Parameters[27].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[27].Value = (object) giata_last_update;
      if (updated_on.HasValue)
        this.Adapter.UpdateCommand.Parameters[28].Value = (object) updated_on.Value;
      else
        this.Adapter.UpdateCommand.Parameters[28].Value = (object) DBNull.Value;
      if (language_code == null)
        this.Adapter.UpdateCommand.Parameters[29].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[29].Value = (object) language_code;
      if (stateprov == null)
        this.Adapter.UpdateCommand.Parameters[30].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[30].Value = (object) stateprov;
      if (rating == null)
        this.Adapter.UpdateCommand.Parameters[31].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[31].Value = (object) rating;
      if (Original_giata_id.HasValue)
        this.Adapter.UpdateCommand.Parameters[32].Value = (object) Original_giata_id.Value;
      else
        this.Adapter.UpdateCommand.Parameters[32].Value = (object) DBNull.Value;
      if (Original_hotel_name == null)
      {
        this.Adapter.UpdateCommand.Parameters[33].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[34].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[33].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[34].Value = (object) Original_hotel_name;
      }
      if (Original_city_id.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[35].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[36].Value = (object) Original_city_id.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[35].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[36].Value = (object) DBNull.Value;
      }
      if (Original_city_name == null)
      {
        this.Adapter.UpdateCommand.Parameters[37].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[38].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[37].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[38].Value = (object) Original_city_name;
      }
      if (Original_country_code == null)
      {
        this.Adapter.UpdateCommand.Parameters[39].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[40].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[39].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[40].Value = (object) Original_country_code;
      }
      if (Original_address1 == null)
      {
        this.Adapter.UpdateCommand.Parameters[41].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[42].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[41].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[42].Value = (object) Original_address1;
      }
      if (Original_address2 == null)
      {
        this.Adapter.UpdateCommand.Parameters[43].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[44].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[43].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[44].Value = (object) Original_address2;
      }
      if (Original_address_more == null)
      {
        this.Adapter.UpdateCommand.Parameters[45].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[46].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[45].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[46].Value = (object) Original_address_more;
      }
      if (Original_street == null)
      {
        this.Adapter.UpdateCommand.Parameters[47].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[48].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[47].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[48].Value = (object) Original_street;
      }
      if (Original_street_number == null)
      {
        this.Adapter.UpdateCommand.Parameters[49].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[50].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[49].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[50].Value = (object) Original_street_number;
      }
      if (Original_address_city_name == null)
      {
        this.Adapter.UpdateCommand.Parameters[51].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[52].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[51].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[52].Value = (object) Original_address_city_name;
      }
      if (Original_postal_code == null)
      {
        this.Adapter.UpdateCommand.Parameters[53].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[54].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[53].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[54].Value = (object) Original_postal_code;
      }
      if (Original_address_additional_info == null)
      {
        this.Adapter.UpdateCommand.Parameters[55].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[56].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[55].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[56].Value = (object) Original_address_additional_info;
      }
      if (Original_address_country_code == null)
      {
        this.Adapter.UpdateCommand.Parameters[57].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[58].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[57].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[58].Value = (object) Original_address_country_code;
      }
      if (Original_voice_phone == null)
      {
        this.Adapter.UpdateCommand.Parameters[59].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[60].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[59].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[60].Value = (object) Original_voice_phone;
      }
      if (Original_email == null)
      {
        this.Adapter.UpdateCommand.Parameters[61].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[62].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[61].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[62].Value = (object) Original_email;
      }
      if (Original_url == null)
      {
        this.Adapter.UpdateCommand.Parameters[63].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[64].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[63].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[64].Value = (object) Original_url;
      }
      if (Original_geo_accuracy == null)
      {
        this.Adapter.UpdateCommand.Parameters[65].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[66].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[65].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[66].Value = (object) Original_geo_accuracy;
      }
      if (Original_latitude == null)
      {
        this.Adapter.UpdateCommand.Parameters[67].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[68].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[67].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[68].Value = (object) Original_latitude;
      }
      if (Original_longitude == null)
      {
        this.Adapter.UpdateCommand.Parameters[69].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[70].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[69].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[70].Value = (object) Original_longitude;
      }
      if (Original_ghgml == null)
      {
        this.Adapter.UpdateCommand.Parameters[71].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[72].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[71].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[72].Value = (object) Original_ghgml;
      }
      if (Original_location_desc == null)
      {
        this.Adapter.UpdateCommand.Parameters[73].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[74].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[73].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[74].Value = (object) Original_location_desc;
      }
      if (Original_facilities_desc == null)
      {
        this.Adapter.UpdateCommand.Parameters[75].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[76].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[75].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[76].Value = (object) Original_facilities_desc;
      }
      if (Original_rooms_desc == null)
      {
        this.Adapter.UpdateCommand.Parameters[77].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[78].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[77].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[78].Value = (object) Original_rooms_desc;
      }
      if (Original_sports_ent_desc == null)
      {
        this.Adapter.UpdateCommand.Parameters[79].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[80].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[79].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[80].Value = (object) Original_sports_ent_desc;
      }
      if (Original_meals_desc == null)
      {
        this.Adapter.UpdateCommand.Parameters[81].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[82].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[81].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[82].Value = (object) Original_meals_desc;
      }
      if (Original_payment_desc == null)
      {
        this.Adapter.UpdateCommand.Parameters[83].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[84].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[83].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[84].Value = (object) Original_payment_desc;
      }
      if (Original_giata_last_update == null)
      {
        this.Adapter.UpdateCommand.Parameters[85].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[86].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[85].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[86].Value = (object) Original_giata_last_update;
      }
      if (Original_updated_on.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[87].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[88].Value = (object) Original_updated_on.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[87].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[88].Value = (object) DBNull.Value;
      }
      if (Original_language_code == null)
      {
        this.Adapter.UpdateCommand.Parameters[89].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[90].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[89].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[90].Value = (object) Original_language_code;
      }
      if (Original_stateprov == null)
      {
        this.Adapter.UpdateCommand.Parameters[91].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[92].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[91].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[92].Value = (object) Original_stateprov;
      }
      if (Original_rating == null)
      {
        this.Adapter.UpdateCommand.Parameters[93].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[94].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[93].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[94].Value = (object) Original_rating;
      }
      ConnectionState state = this.Adapter.UpdateCommand.Connection.State;
      if ((this.Adapter.UpdateCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
        this.Adapter.UpdateCommand.Connection.Open();
      try
      {
        return this.Adapter.UpdateCommand.ExecuteNonQuery();
      }
      finally
      {
        if (state == ConnectionState.Closed)
          this.Adapter.UpdateCommand.Connection.Close();
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Update, true)]
    public virtual int Update(
      string hotel_name,
      int? city_id,
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
      DateTime? updated_on,
      string language_code,
      string stateprov,
      string rating,
      int? Original_giata_id,
      string Original_hotel_name,
      int? Original_city_id,
      string Original_city_name,
      string Original_country_code,
      string Original_address1,
      string Original_address2,
      string Original_address_more,
      string Original_street,
      string Original_street_number,
      string Original_address_city_name,
      string Original_postal_code,
      string Original_address_additional_info,
      string Original_address_country_code,
      string Original_voice_phone,
      string Original_email,
      string Original_url,
      string Original_geo_accuracy,
      string Original_latitude,
      string Original_longitude,
      string Original_ghgml,
      string Original_location_desc,
      string Original_facilities_desc,
      string Original_rooms_desc,
      string Original_sports_ent_desc,
      string Original_meals_desc,
      string Original_payment_desc,
      string Original_giata_last_update,
      DateTime? Original_updated_on,
      string Original_language_code,
      string Original_stateprov,
      string Original_rating)
    {
      return this.Update(Original_giata_id, hotel_name, city_id, city_name, country_code, address1, address2, address_more, street, street_number, address_city_name, postal_code, address_additional_info, address_country_code, voice_phone, email, url, geo_accuracy, latitude, longitude, ghgml, location_desc, facilities_desc, rooms_desc, sports_ent_desc, meals_desc, payment_desc, giata_last_update, updated_on, language_code, stateprov, rating, Original_giata_id, Original_hotel_name, Original_city_id, Original_city_name, Original_country_code, Original_address1, Original_address2, Original_address_more, Original_street, Original_street_number, Original_address_city_name, Original_postal_code, Original_address_additional_info, Original_address_country_code, Original_voice_phone, Original_email, Original_url, Original_geo_accuracy, Original_latitude, Original_longitude, Original_ghgml, Original_location_desc, Original_facilities_desc, Original_rooms_desc, Original_sports_ent_desc, Original_meals_desc, Original_payment_desc, Original_giata_last_update, Original_updated_on, Original_language_code, Original_stateprov, Original_rating);
    }
  }
}
