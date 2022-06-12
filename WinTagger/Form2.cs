using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WinTagger
{
  public class Form2 : Form
  {
    private IContainer components = (IContainer) null;
    private SplitContainer splitContainer1;
    private DataGridView dataGridView1;
    private DataGridView dataGridView2;
    private TextBox textBox4;
    private TextBox textBox3;
    private TextBox textBox2;
    private TextBox textBox1;
    private TextBox textBox5;
    private TextBox textBox6;
    private TextBox textBox7;
    private TextBox textBox8;

    public Form2() => this.InitializeComponent();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.splitContainer1 = new SplitContainer();
      this.dataGridView1 = new DataGridView();
      this.dataGridView2 = new DataGridView();
      this.textBox4 = new TextBox();
      this.textBox3 = new TextBox();
      this.textBox2 = new TextBox();
      this.textBox1 = new TextBox();
      this.textBox5 = new TextBox();
      this.textBox6 = new TextBox();
      this.textBox7 = new TextBox();
      this.textBox8 = new TextBox();
      this.splitContainer1.BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      ((ISupportInitialize) this.dataGridView1).BeginInit();
      ((ISupportInitialize) this.dataGridView2).BeginInit();
      this.SuspendLayout();
      this.splitContainer1.Dock = DockStyle.Fill;
      this.splitContainer1.Location = new Point(0, 0);
      this.splitContainer1.Name = "splitContainer1";
      this.splitContainer1.Panel1.Controls.Add((Control) this.textBox4);
      this.splitContainer1.Panel1.Controls.Add((Control) this.textBox3);
      this.splitContainer1.Panel1.Controls.Add((Control) this.textBox2);
      this.splitContainer1.Panel1.Controls.Add((Control) this.textBox1);
      this.splitContainer1.Panel1.Controls.Add((Control) this.dataGridView1);
      this.splitContainer1.Panel2.Controls.Add((Control) this.textBox5);
      this.splitContainer1.Panel2.Controls.Add((Control) this.textBox6);
      this.splitContainer1.Panel2.Controls.Add((Control) this.textBox7);
      this.splitContainer1.Panel2.Controls.Add((Control) this.textBox8);
      this.splitContainer1.Panel2.Controls.Add((Control) this.dataGridView2);
      this.splitContainer1.Size = new Size(1077, 495);
      this.splitContainer1.SplitterDistance = 533;
      this.splitContainer1.TabIndex = 0;
      this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new Point(24, 27);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new Size(497, 156);
      this.dataGridView1.TabIndex = 0;
      this.dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView2.Location = new Point(9, 27);
      this.dataGridView2.Name = "dataGridView2";
      this.dataGridView2.Size = new Size(497, 156);
      this.dataGridView2.TabIndex = 1;
      this.textBox4.Location = new Point(216, 276);
      this.textBox4.Name = "textBox4";
      this.textBox4.Size = new Size(101, 20);
      this.textBox4.TabIndex = 8;
      this.textBox3.Location = new Point(216, 250);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new Size(101, 20);
      this.textBox3.TabIndex = 7;
      this.textBox2.Location = new Point(216, 224);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new Size(101, 20);
      this.textBox2.TabIndex = 6;
      this.textBox1.Location = new Point(216, 198);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new Size(101, 20);
      this.textBox1.TabIndex = 5;
      this.textBox5.Location = new Point(220, 276);
      this.textBox5.Name = "textBox5";
      this.textBox5.Size = new Size(101, 20);
      this.textBox5.TabIndex = 8;
      this.textBox6.Location = new Point(220, 250);
      this.textBox6.Name = "textBox6";
      this.textBox6.Size = new Size(101, 20);
      this.textBox6.TabIndex = 7;
      this.textBox7.Location = new Point(220, 224);
      this.textBox7.Name = "textBox7";
      this.textBox7.Size = new Size(101, 20);
      this.textBox7.TabIndex = 6;
      this.textBox8.Location = new Point(220, 198);
      this.textBox8.Name = "textBox8";
      this.textBox8.Size = new Size(101, 20);
      this.textBox8.TabIndex = 5;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1077, 495);
      this.Controls.Add((Control) this.splitContainer1);
      this.Name = nameof (Form2);
      this.Text = nameof (Form2);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel1.PerformLayout();
      this.splitContainer1.Panel2.ResumeLayout(false);
      this.splitContainer1.Panel2.PerformLayout();
      this.splitContainer1.EndInit();
      this.splitContainer1.ResumeLayout(false);
      ((ISupportInitialize) this.dataGridView1).EndInit();
      ((ISupportInitialize) this.dataGridView2).EndInit();
      this.ResumeLayout(false);
    }
  }
}
