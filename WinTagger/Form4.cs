using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace WinTagger
{
  public class Form4 : Form
  {
    private BindingSource bs = new BindingSource();
    private IContainer components = (IContainer) null;
    private DataGridView dataGridView1;
    private TextBox textBox1;

    public Form4() => this.InitializeComponent();

    private void Form4_Load(object sender, EventArgs e)
    {
      OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0; Data Source=./data/db1.mdb");
      try
      {
        connection.Open();
        OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(new OleDbCommand("SELECT * from Giata_hotel", connection));
        DataSet dataSet = new DataSet();
        oleDbDataAdapter.Fill(dataSet);
        this.dataGridView1.DataSource = (object) dataSet;
        this.bs.DataSource = (object) dataSet;
        this.bs.DataMember = dataSet.Tables[0].TableName;
        this.dataGridView1.DataSource = (object) this.bs;
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

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.dataGridView1 = new DataGridView();
      this.textBox1 = new TextBox();
      ((ISupportInitialize) this.dataGridView1).BeginInit();
      this.SuspendLayout();
      this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new Point(138, 13);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new Size(629, 163);
      this.dataGridView1.TabIndex = 0;
      this.textBox1.Location = new Point(329, 214);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new Size(100, 20);
      this.textBox1.TabIndex = 1;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(855, 318);
      this.Controls.Add((Control) this.textBox1);
      this.Controls.Add((Control) this.dataGridView1);
      this.Name = nameof (Form4);
      this.Text = nameof (Form4);
      this.Load += new EventHandler(this.Form4_Load);
      ((ISupportInitialize) this.dataGridView1).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
