using Microsoft.Data.Sqlite;

namespace Articles
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            labelNoDb = new Label();
            buttonDeleteSelected = new Button();
            buttonEditSelected = new Button();
            buttonAdd = new Button();
            table = new TableLayoutPanel();
            splitContainer1 = new SplitContainer();
            vScrollBar2 = new VScrollBar();
            vScrollBar1 = new VScrollBar();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = SystemColors.ControlDark;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(labelNoDb);
            panel1.Controls.Add(buttonDeleteSelected);
            panel1.Controls.Add(buttonEditSelected);
            panel1.Controls.Add(buttonAdd);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(20);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(884, 55);
            panel1.TabIndex = 0;
            // 
            // labelNoDb
            // 
            labelNoDb.AutoSize = true;
            labelNoDb.Dock = DockStyle.Right;
            labelNoDb.Font = new Font("Segoe UI", 12F);
            labelNoDb.ForeColor = Color.Red;
            labelNoDb.Location = new Point(636, 5);
            labelNoDb.Name = "labelNoDb";
            labelNoDb.Size = new Size(241, 21);
            labelNoDb.TabIndex = 5;
            labelNoDb.Text = "DATABASE CONNECTION ERROR";
            labelNoDb.TextAlign = ContentAlignment.MiddleRight;
            labelNoDb.Visible = false;
            // 
            // buttonDeleteSelected
            // 
            buttonDeleteSelected.BackColor = Color.Silver;
            buttonDeleteSelected.FlatAppearance.BorderColor = Color.Black;
            buttonDeleteSelected.FlatAppearance.BorderSize = 2;
            buttonDeleteSelected.FlatStyle = FlatStyle.Flat;
            buttonDeleteSelected.Font = new Font("Segoe UI", 10F);
            buttonDeleteSelected.Location = new Point(272, 8);
            buttonDeleteSelected.Margin = new Padding(10);
            buttonDeleteSelected.Name = "buttonDeleteSelected";
            buttonDeleteSelected.Size = new Size(134, 30);
            buttonDeleteSelected.TabIndex = 4;
            buttonDeleteSelected.Text = "Delete selected article";
            buttonDeleteSelected.UseVisualStyleBackColor = false;
            buttonDeleteSelected.Click += buttonDeleteSelected_Click;
            // 
            // buttonEditSelected
            // 
            buttonEditSelected.BackColor = Color.Silver;
            buttonEditSelected.FlatAppearance.BorderColor = Color.Black;
            buttonEditSelected.FlatAppearance.BorderSize = 2;
            buttonEditSelected.FlatStyle = FlatStyle.Flat;
            buttonEditSelected.Font = new Font("Segoe UI", 10F);
            buttonEditSelected.Location = new Point(132, 8);
            buttonEditSelected.Margin = new Padding(10);
            buttonEditSelected.Name = "buttonEditSelected";
            buttonEditSelected.Size = new Size(120, 30);
            buttonEditSelected.TabIndex = 3;
            buttonEditSelected.Text = "Edit selected article";
            buttonEditSelected.UseVisualStyleBackColor = false;
            buttonEditSelected.Click += buttonEditSelected_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.Silver;
            buttonAdd.FlatAppearance.BorderColor = Color.Black;
            buttonAdd.FlatAppearance.BorderSize = 2;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Segoe UI", 10F);
            buttonAdd.Location = new Point(11, 8);
            buttonAdd.Margin = new Padding(10);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(101, 30);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Add new article";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // table
            // 
            table.AutoSize = true;
            table.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            table.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            table.ColumnCount = 2;
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            table.Dock = DockStyle.Left;
            table.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            table.Location = new Point(0, 55);
            table.Margin = new Padding(20);
            table.Name = "table";
            table.RowCount = 5;
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            table.Size = new Size(3, 806);
            table.TabIndex = 1;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 55);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = SystemColors.ControlDark;
            splitContainer1.Panel1.Controls.Add(vScrollBar2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(vScrollBar1);
            splitContainer1.Size = new Size(881, 806);
            splitContainer1.SplitterDistance = 526;
            splitContainer1.TabIndex = 2;
            // 
            // vScrollBar2
            // 
            vScrollBar2.Dock = DockStyle.Right;
            vScrollBar2.Location = new Point(509, 0);
            vScrollBar2.Name = "vScrollBar2";
            vScrollBar2.Size = new Size(17, 806);
            vScrollBar2.TabIndex = 0;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Dock = DockStyle.Right;
            vScrollBar1.Location = new Point(334, 0);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(17, 806);
            vScrollBar1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(40, 40);
            dataGridView1.Margin = new Padding(20);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(428, 159);
            dataGridView1.TabIndex = 1;
            // 
            // Form1
            // 
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(884, 861);
            Controls.Add(splitContainer1);
            Controls.Add(table);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button buttonAdd;
        private Button buttonDeleteSelected;
        private Button buttonEditSelected;
        private TableLayoutPanel table;
        private Splitter splitter;
        private SplitContainer splitContainer1;
        private VScrollBar vScrollBar1;
        private VScrollBar vScrollBar2;
        private Label labelNoDb;
        private DataGridView dataGridView1;
    }
}
