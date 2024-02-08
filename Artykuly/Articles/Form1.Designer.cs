using Microsoft.Data.Sqlite;
using System.Windows.Forms;

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            labelNoDb = new Label();
            buttonDeleteSelected = new Button();
            buttonEditSelected = new Button();
            buttonAdd = new Button();
            splitContainer1 = new SplitContainer();
            articlesGirdView = new DataGridView();
            textBoxContent = new TextBox();
            labelContent = new Label();
            buttoncolumn = new DataGridViewButtonColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)articlesGirdView).BeginInit();
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
            buttonDeleteSelected.TabIndex = 3;
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
            buttonEditSelected.TabIndex = 2;
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
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Add new article";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 55);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.AutoScroll = true;
            splitContainer1.Panel1.BackColor = SystemColors.ControlDark;
            splitContainer1.Panel1.Controls.Add(articlesGirdView);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(textBoxContent);
            splitContainer1.Panel2.Controls.Add(labelContent);
            splitContainer1.Size = new Size(884, 806);
            splitContainer1.SplitterDistance = 250;
            splitContainer1.TabIndex = 2;
            // 
            // articlesGirdView
            // 
            articlesGirdView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            articlesGirdView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            articlesGirdView.BorderStyle = BorderStyle.None;
            articlesGirdView.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            articlesGirdView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            articlesGirdView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            articlesGirdView.Dock = DockStyle.Top;
            articlesGirdView.GridColor = SystemColors.ControlDarkDark;
            articlesGirdView.Location = new Point(0, 0);
            articlesGirdView.Margin = new Padding(20);
            articlesGirdView.Name = "articlesGirdView";
            articlesGirdView.RowHeadersWidth = 40;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            articlesGirdView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            articlesGirdView.ScrollBars = ScrollBars.None;
            articlesGirdView.Size = new Size(250, 312);
            articlesGirdView.TabIndex = 0;
            articlesGirdView.CellClick += ArticlesGridView_CellClick;
            // 
            // textBoxContent
            // 
            textBoxContent.BackColor = SystemColors.ControlDarkDark;
            textBoxContent.BorderStyle = BorderStyle.None;
            textBoxContent.Location = new Point(66, 50);
            textBoxContent.Margin = new Padding(50);
            textBoxContent.Multiline = true;
            textBoxContent.Name = "textBoxContent";
            textBoxContent.Size = new Size(656, 603);
            textBoxContent.TabIndex = 2;
            // 
            // labelContent
            // 
            labelContent.AutoSize = true;
            labelContent.BackColor = SystemColors.ControlDarkDark;
            labelContent.Dock = DockStyle.Left;
            labelContent.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelContent.Location = new Point(0, 0);
            labelContent.Name = "labelContent";
            labelContent.Size = new Size(0, 21);
            labelContent.TabIndex = 1;
            // 
            // buttoncolumn
            // 
            buttoncolumn.Name = "buttoncolumn";
            buttoncolumn.Text = "Select";
            buttoncolumn.Width = 50;
            // 
            // Form1
            // 
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(884, 861);
            Controls.Add(splitContainer1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)articlesGirdView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void ArticlesGirdView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panel1;
        private Button buttonAdd;
        private Button buttonDeleteSelected;
        private Button buttonEditSelected;
        private SplitContainer splitContainer1;
        private Label labelNoDb;
        private DataGridView articlesGirdView;
        private DataGridViewButtonColumn buttoncolumn;
        private Label labelContent;
        private TextBox textBoxContent;
    }
}
