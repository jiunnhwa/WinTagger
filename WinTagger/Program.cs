using System;
using System.Configuration;
using System.Windows.Forms;

namespace WinTagger
{
  internal static class Program
  {
    public static string AppVer = "0.93B";
    public static string ErrStr = "";
    public static string ConnString = "Provider=Microsoft.Jet.OleDb.4.0; Data Source =./data/db1.mdb";
    public static string ConnStringMYSQL = ConfigurationManager.AppSettings[nameof (ConnStringMYSQL)];

    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run((Form) new Form7());
    }
  }
}
