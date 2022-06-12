using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WinTagger.HELPER
{
  internal class MySQL
  {
    public DataTable Reader2DataTable(string strSQL1, string strConn)
    {
      using (MySqlConnection mySqlConnection = new MySqlConnection(strConn))
      {
        mySqlConnection.Open();
        using (MySqlCommand command = mySqlConnection.CreateCommand())
        {
          command.CommandText = strSQL1;
          command.CommandType = CommandType.Text;
          command.Prepare();
          MySqlDataReader reader = command.ExecuteReader();
          using (reader)
          {
            DataTable dataTable = new DataTable();
            dataTable.Load((IDataReader) reader);
            return dataTable;
          }
        }
      }
    }

    public DataSet GetDataSet(string selectCommand, string ConnString)
    {
      MySqlConnection connection = new MySqlConnection(ConnString);
      DataSet dataSet = new DataSet();
      try
      {
        connection.Open();
        new MySqlDataAdapter(new MySqlCommand(selectCommand, connection)).Fill(dataSet);
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

    public void ExecNonQuery(string strSQL, string strConnection)
    {
      MySqlConnection connection = new MySqlConnection(strConnection);
      MySqlCommand mySqlCommand = new MySqlCommand(strSQL, connection);
      connection.Open();
      try
      {
        mySqlCommand.ExecuteNonQuery();
      }
      catch (Exception ex)
      {
        Program.ErrStr = ex.Message.ToString();
      }
      finally
      {
        connection.Close();
      }
    }
  }
}
