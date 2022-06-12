using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WinTagger
{
  public class Form1 : Form
  {
    private IContainer components = (IContainer) null;
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
    private ToolStripButton toolStripButton1;
    private ToolStripComboBox toolStripComboBox1;
    private ToolStripTextBox toolStripTextBox1;
    private ToolStripSplitButton toolStripButton2;
    private ToolStripMenuItem m1ToolStripMenuItem;
    private ToolStripMenuItem m2ToolStripMenuItem;
    private ToolStripMenuItem m2AToolStripMenuItem;
    private SplitContainer splitContainer1;
    private SplitContainer splitContainer2;
    private SplitContainer splitContainer3;
    private TextBox textBox4;
    private TextBox textBox3;
    private TextBox textBox2;
    private TextBox textBox1;
    private DataGridView dataGridView1;
    private TextBox textBox5;
    private TextBox textBox6;
    private TextBox textBox7;
    private TextBox textBox8;
    private DataGridView dataGridView2;
    private TabControl tabControl1;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private Label label1;
    private Label label2;
    private WebBrowser webBrowser1;

    public Form1() => this.InitializeComponent();

    private void Form1_Load(object sender, EventArgs e) => this.webBrowser1.Navigate("http://www.google.com");

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form1));
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
      this.toolStripButton1 = new ToolStripButton();
      this.toolStripComboBox1 = new ToolStripComboBox();
      this.toolStripTextBox1 = new ToolStripTextBox();
      this.toolStripButton2 = new ToolStripSplitButton();
      this.m1ToolStripMenuItem = new ToolStripMenuItem();
      this.m2ToolStripMenuItem = new ToolStripMenuItem();
      this.m2AToolStripMenuItem = new ToolStripMenuItem();
      this.splitContainer1 = new SplitContainer();
      this.splitContainer2 = new SplitContainer();
      this.splitContainer3 = new SplitContainer();
      this.dataGridView1 = new DataGridView();
      this.textBox1 = new TextBox();
      this.textBox2 = new TextBox();
      this.textBox3 = new TextBox();
      this.textBox4 = new TextBox();
      this.textBox5 = new TextBox();
      this.textBox6 = new TextBox();
      this.textBox7 = new TextBox();
      this.textBox8 = new TextBox();
      this.dataGridView2 = new DataGridView();
      this.label1 = new Label();
      this.label2 = new Label();
      this.tabControl1 = new TabControl();
      this.tabPage1 = new TabPage();
      this.tabPage2 = new TabPage();
      this.webBrowser1 = new WebBrowser();
      this.bindingNavigator1.BeginInit();
      this.bindingNavigator1.SuspendLayout();
      this.splitContainer1.BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.splitContainer2.BeginInit();
      this.splitContainer2.Panel1.SuspendLayout();
      this.splitContainer2.Panel2.SuspendLayout();
      this.splitContainer2.SuspendLayout();
      this.splitContainer3.BeginInit();
      this.splitContainer3.Panel1.SuspendLayout();
      this.splitContainer3.SuspendLayout();
      ((ISupportInitialize) this.dataGridView1).BeginInit();
      ((ISupportInitialize) this.dataGridView2).BeginInit();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.SuspendLayout();
      this.bindingNavigator1.AddNewItem = (ToolStripItem) this.bindingNavigatorAddNewItem;
      this.bindingNavigator1.CountItem = (ToolStripItem) this.bindingNavigatorCountItem;
      this.bindingNavigator1.DeleteItem = (ToolStripItem) this.bindingNavigatorDeleteItem;
      this.bindingNavigator1.Items.AddRange(new ToolStripItem[15]
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
        (ToolStripItem) this.bindingNavigatorDeleteItem,
        (ToolStripItem) this.toolStripButton1,
        (ToolStripItem) this.toolStripComboBox1,
        (ToolStripItem) this.toolStripTextBox1,
        (ToolStripItem) this.toolStripButton2
      });
      this.bindingNavigator1.Location = new Point(0, 0);
      this.bindingNavigator1.MoveFirstItem = (ToolStripItem) this.bindingNavigatorMoveFirstItem;
      this.bindingNavigator1.MoveLastItem = (ToolStripItem) this.bindingNavigatorMoveLastItem;
      this.bindingNavigator1.MoveNextItem = (ToolStripItem) this.bindingNavigatorMoveNextItem;
      this.bindingNavigator1.MovePreviousItem = (ToolStripItem) this.bindingNavigatorMovePreviousItem;
      this.bindingNavigator1.Name = "bindingNavigator1";
      this.bindingNavigator1.PositionItem = (ToolStripItem) this.bindingNavigatorPositionItem;
      this.bindingNavigator1.Size = new Size(1081, 25);
      this.bindingNavigator1.TabIndex = 0;
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
      this.toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.toolStripButton1.Image = (Image) componentResourceManager.GetObject("toolStripButton1.Image");
      this.toolStripButton1.ImageTransparentColor = Color.Magenta;
      this.toolStripButton1.Name = "toolStripButton1";
      this.toolStripButton1.Size = new Size(23, 22);
      this.toolStripButton1.Text = "toolStripButton1";
      this.toolStripComboBox1.Name = "toolStripComboBox1";
      this.toolStripComboBox1.Size = new Size(121, 25);
      this.toolStripTextBox1.Name = "toolStripTextBox1";
      this.toolStripTextBox1.Size = new Size(100, 25);
      this.toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.toolStripButton2.DropDownItems.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.m1ToolStripMenuItem,
        (ToolStripItem) this.m2ToolStripMenuItem
      });
      this.toolStripButton2.Image = (Image) componentResourceManager.GetObject("toolStripButton2.Image");
      this.toolStripButton2.ImageTransparentColor = Color.Magenta;
      this.toolStripButton2.Name = "toolStripButton2";
      this.toolStripButton2.Size = new Size(32, 22);
      this.toolStripButton2.Text = "toolStripButton2";
      this.m1ToolStripMenuItem.Name = "m1ToolStripMenuItem";
      this.m1ToolStripMenuItem.Size = new Size(152, 22);
      this.m1ToolStripMenuItem.Text = "M1";
      this.m2ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.m2AToolStripMenuItem
      });
      this.m2ToolStripMenuItem.Name = "m2ToolStripMenuItem";
      this.m2ToolStripMenuItem.Size = new Size(152, 22);
      this.m2ToolStripMenuItem.Text = "M2";
      this.m2AToolStripMenuItem.Name = "m2AToolStripMenuItem";
      this.m2AToolStripMenuItem.Size = new Size(152, 22);
      this.m2AToolStripMenuItem.Text = "M2A";
      this.splitContainer1.Dock = DockStyle.Fill;
      this.splitContainer1.Location = new Point(0, 25);
      this.splitContainer1.Name = "splitContainer1";
      this.splitContainer1.Panel1.Controls.Add((Control) this.splitContainer2);
      this.splitContainer1.Panel2.BackColor = SystemColors.ActiveCaption;
      this.splitContainer1.Panel2.Controls.Add((Control) this.splitContainer3);
      this.splitContainer1.Size = new Size(1081, 335);
      this.splitContainer1.SplitterDistance = 578;
      this.splitContainer1.TabIndex = 1;
      this.splitContainer2.Dock = DockStyle.Fill;
      this.splitContainer2.Location = new Point(0, 0);
      this.splitContainer2.Name = "splitContainer2";
      this.splitContainer2.Orientation = Orientation.Horizontal;
      this.splitContainer2.Panel1.Controls.Add((Control) this.textBox4);
      this.splitContainer2.Panel1.Controls.Add((Control) this.textBox3);
      this.splitContainer2.Panel1.Controls.Add((Control) this.textBox2);
      this.splitContainer2.Panel1.Controls.Add((Control) this.textBox1);
      this.splitContainer2.Panel1.Controls.Add((Control) this.dataGridView1);
      this.splitContainer2.Panel2.BackColor = SystemColors.ActiveCaption;
      this.splitContainer2.Panel2.Controls.Add((Control) this.tabControl1);
      this.splitContainer2.Size = new Size(578, 335);
      this.splitContainer2.SplitterDistance = 192;
      this.splitContainer2.TabIndex = 0;
      this.splitContainer3.BackColor = SystemColors.ControlLight;
      this.splitContainer3.Dock = DockStyle.Fill;
      this.splitContainer3.Location = new Point(0, 0);
      this.splitContainer3.Name = "splitContainer3";
      this.splitContainer3.Orientation = Orientation.Horizontal;
      this.splitContainer3.Panel1.Controls.Add((Control) this.dataGridView2);
      this.splitContainer3.Panel1.Controls.Add((Control) this.textBox5);
      this.splitContainer3.Panel1.Controls.Add((Control) this.textBox6);
      this.splitContainer3.Panel1.Controls.Add((Control) this.textBox7);
      this.splitContainer3.Panel1.Controls.Add((Control) this.textBox8);
      this.splitContainer3.Panel2.BackColor = SystemColors.ActiveCaption;
      this.splitContainer3.Size = new Size(499, 335);
      this.splitContainer3.SplitterDistance = 194;
      this.splitContainer3.TabIndex = 0;
      this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new Point(3, 3);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new Size(289, 186);
      this.dataGridView1.TabIndex = 0;
      this.textBox1.Location = new Point(347, 30);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new Size(101, 20);
      this.textBox1.TabIndex = 1;
      this.textBox2.Location = new Point(347, 56);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new Size(101, 20);
      this.textBox2.TabIndex = 2;
      this.textBox3.Location = new Point(347, 82);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new Size(101, 20);
      this.textBox3.TabIndex = 3;
      this.textBox4.Location = new Point(347, 108);
      this.textBox4.Name = "textBox4";
      this.textBox4.Size = new Size(101, 20);
      this.textBox4.TabIndex = 4;
      this.textBox5.Location = new Point(22, 108);
      this.textBox5.Name = "textBox5";
      this.textBox5.Size = new Size(101, 20);
      this.textBox5.TabIndex = 8;
      this.textBox6.Location = new Point(22, 82);
      this.textBox6.Name = "textBox6";
      this.textBox6.Size = new Size(101, 20);
      this.textBox6.TabIndex = 7;
      this.textBox7.Location = new Point(22, 56);
      this.textBox7.Name = "textBox7";
      this.textBox7.Size = new Size(101, 20);
      this.textBox7.TabIndex = 6;
      this.textBox8.Location = new Point(22, 30);
      this.textBox8.Name = "textBox8";
      this.textBox8.Size = new Size(101, 20);
      this.textBox8.TabIndex = 5;
      this.dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView2.Location = new Point(198, 5);
      this.dataGridView2.Name = "dataGridView2";
      this.dataGridView2.Size = new Size(289, 186);
      this.dataGridView2.TabIndex = 9;
      this.label1.AutoSize = true;
      this.label1.Location = new Point(639, 6);
      this.label1.Name = "label1";
      this.label1.Size = new Size(29, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "New";
      this.label2.AutoSize = true;
      this.label2.Location = new Point(676, 6);
      this.label2.Name = "label2";
      this.label2.Size = new Size(33, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Done";
      this.tabControl1.Controls.Add((Control) this.tabPage1);
      this.tabControl1.Controls.Add((Control) this.tabPage2);
      this.tabControl1.Location = new Point(13, 9);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new Size(562, (int) sbyte.MaxValue);
      this.tabControl1.TabIndex = 0;
      this.tabPage1.Controls.Add((Control) this.webBrowser1);
      this.tabPage1.Location = new Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new Padding(3);
      this.tabPage1.Size = new Size(554, 101);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "tabPage1";
      this.tabPage1.UseVisualStyleBackColor = true;
      this.tabPage2.Location = new Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new Padding(3);
      this.tabPage2.Size = new Size(411, 75);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "tabPage2";
      this.tabPage2.UseVisualStyleBackColor = true;
      this.webBrowser1.Dock = DockStyle.Fill;
      this.webBrowser1.Location = new Point(3, 3);
      this.webBrowser1.MinimumSize = new Size(20, 20);
      this.webBrowser1.Name = "webBrowser1";
      this.webBrowser1.Size = new Size(548, 95);
      this.webBrowser1.TabIndex = 0;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1081, 360);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.splitContainer1);
      this.Controls.Add((Control) this.bindingNavigator1);
      this.Name = nameof (Form1);
      this.Text = nameof (Form1);
      this.Load += new EventHandler(this.Form1_Load);
      this.bindingNavigator1.EndInit();
      this.bindingNavigator1.ResumeLayout(false);
      this.bindingNavigator1.PerformLayout();
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      this.splitContainer1.EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.splitContainer2.Panel1.ResumeLayout(false);
      this.splitContainer2.Panel1.PerformLayout();
      this.splitContainer2.Panel2.ResumeLayout(false);
      this.splitContainer2.EndInit();
      this.splitContainer2.ResumeLayout(false);
      this.splitContainer3.Panel1.ResumeLayout(false);
      this.splitContainer3.Panel1.PerformLayout();
      this.splitContainer3.EndInit();
      this.splitContainer3.ResumeLayout(false);
      ((ISupportInitialize) this.dataGridView1).EndInit();
      ((ISupportInitialize) this.dataGridView2).EndInit();
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
