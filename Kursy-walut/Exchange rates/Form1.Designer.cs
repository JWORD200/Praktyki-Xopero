namespace Exchange_rates
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
            panelMain = new Panel();
            selectCurrency = new CheckedListBox();
            panel1 = new Panel();
            panelInfo2 = new Panel();
            currencyEffectiveDate = new Label();
            currencyNumber = new Label();
            currencyMid = new Label();
            panelInfo = new Panel();
            currencyNamelabel = new Label();
            currentCurrency = new Label();
            currencyCode = new Label();
            currentLink = new TextBox();
            labelJSON = new Label();
            panelMain.SuspendLayout();
            panel1.SuspendLayout();
            panelInfo2.SuspendLayout();
            panelInfo.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.DarkSlateGray;
            panelMain.Controls.Add(selectCurrency);
            panelMain.Controls.Add(panel1);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(689, 448);
            panelMain.TabIndex = 0;
            // 
            // selectCurrency
            // 
            selectCurrency.BackColor = Color.DarkCyan;
            selectCurrency.BorderStyle = BorderStyle.None;
            selectCurrency.CheckOnClick = true;
            selectCurrency.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            selectCurrency.FormattingEnabled = true;
            selectCurrency.Location = new Point(16, 21);
            selectCurrency.Name = "selectCurrency";
            selectCurrency.Size = new Size(219, 408);
            selectCurrency.TabIndex = 1;
            selectCurrency.ItemCheck += selectCurrency_ItemCheck;
            selectCurrency.SelectedIndexChanged += selectCurrency_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateGray;
            panel1.Controls.Add(panelInfo2);
            panel1.Controls.Add(panelInfo);
            panel1.Controls.Add(currentLink);
            panel1.Controls.Add(labelJSON);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(252, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(437, 448);
            panel1.TabIndex = 0;
            // 
            // panelInfo2
            // 
            panelInfo2.BorderStyle = BorderStyle.FixedSingle;
            panelInfo2.Controls.Add(currencyEffectiveDate);
            panelInfo2.Controls.Add(currencyNumber);
            panelInfo2.Controls.Add(currencyMid);
            panelInfo2.Location = new Point(16, 165);
            panelInfo2.Name = "panelInfo2";
            panelInfo2.Size = new Size(254, 127);
            panelInfo2.TabIndex = 4;
            panelInfo2.Visible = false;
            // 
            // currencyEffectiveDate
            // 
            currencyEffectiveDate.AutoSize = true;
            currencyEffectiveDate.Font = new Font("Segoe UI", 9.75F);
            currencyEffectiveDate.Location = new Point(10, 86);
            currencyEffectiveDate.Margin = new Padding(10);
            currencyEffectiveDate.Name = "currencyEffectiveDate";
            currencyEffectiveDate.Size = new Size(132, 17);
            currencyEffectiveDate.TabIndex = 3;
            currencyEffectiveDate.Text = "currencyEffectiveDate";
            currencyEffectiveDate.Visible = false;
            // 
            // currencyNumber
            // 
            currencyNumber.AutoSize = true;
            currencyNumber.Font = new Font("Segoe UI", 9.75F);
            currencyNumber.Location = new Point(10, 12);
            currencyNumber.Margin = new Padding(10);
            currencyNumber.Name = "currencyNumber";
            currencyNumber.Size = new Size(105, 17);
            currencyNumber.TabIndex = 1;
            currencyNumber.Text = "currencyNumber";
            currencyNumber.Visible = false;
            // 
            // currencyMid
            // 
            currencyMid.AutoSize = true;
            currencyMid.Font = new Font("Segoe UI", 9.75F);
            currencyMid.Location = new Point(10, 49);
            currencyMid.Margin = new Padding(10);
            currencyMid.Name = "currencyMid";
            currencyMid.Size = new Size(80, 17);
            currencyMid.TabIndex = 4;
            currencyMid.Text = "currencyMid";
            currencyMid.Visible = false;
            // 
            // panelInfo
            // 
            panelInfo.BorderStyle = BorderStyle.FixedSingle;
            panelInfo.Controls.Add(currencyNamelabel);
            panelInfo.Controls.Add(currentCurrency);
            panelInfo.Controls.Add(currencyCode);
            panelInfo.Location = new Point(16, 12);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(254, 127);
            panelInfo.TabIndex = 3;
            panelInfo.Visible = false;
            // 
            // currencyNamelabel
            // 
            currencyNamelabel.AutoSize = true;
            currencyNamelabel.Enabled = false;
            currencyNamelabel.Font = new Font("Segoe UI", 9.75F);
            currencyNamelabel.Location = new Point(127, 22);
            currencyNamelabel.Margin = new Padding(10);
            currencyNamelabel.Name = "currencyNamelabel";
            currencyNamelabel.Size = new Size(92, 17);
            currencyNamelabel.TabIndex = 2;
            currencyNamelabel.Text = "currencyName";
            currencyNamelabel.Visible = false;
            // 
            // currentCurrency
            // 
            currentCurrency.AutoSize = true;
            currentCurrency.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            currentCurrency.Location = new Point(10, 22);
            currentCurrency.Margin = new Padding(10);
            currentCurrency.Name = "currentCurrency";
            currentCurrency.Size = new Size(104, 17);
            currentCurrency.TabIndex = 0;
            currentCurrency.Text = "Current currency";
            currentCurrency.Visible = false;
            // 
            // currencyCode
            // 
            currencyCode.AutoSize = true;
            currencyCode.Font = new Font("Segoe UI", 9.75F);
            currencyCode.Location = new Point(10, 87);
            currencyCode.Name = "currencyCode";
            currencyCode.Size = new Size(88, 17);
            currencyCode.TabIndex = 5;
            currencyCode.Text = "currencyCode";
            currencyCode.Visible = false;
            // 
            // currentLink
            // 
            currentLink.BackColor = Color.SlateGray;
            currentLink.BorderStyle = BorderStyle.None;
            currentLink.ForeColor = SystemColors.MenuText;
            currentLink.Location = new Point(14, 413);
            currentLink.MaxLength = 57;
            currentLink.Name = "currentLink";
            currentLink.Size = new Size(411, 16);
            currentLink.TabIndex = 2;
            // 
            // labelJSON
            // 
            labelJSON.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelJSON.ForeColor = Color.Blue;
            labelJSON.Location = new Point(269, 21);
            labelJSON.Margin = new Padding(50);
            labelJSON.Name = "labelJSON";
            labelJSON.Size = new Size(168, 233);
            labelJSON.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 448);
            Controls.Add(panelMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(705, 487);
            MinimumSize = new Size(705, 487);
            Name = "Form1";
            Text = "Select Currency";
            Load += Form1_Load;
            panelMain.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelInfo2.ResumeLayout(false);
            panelInfo2.PerformLayout();
            panelInfo.ResumeLayout(false);
            panelInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private Panel panel1;
        private CheckedListBox selectCurrency;
        private Label labelJSON;
        private TextBox currentLink;
        private Panel panelInfo2;
        private Panel panelInfo;
        private Label currentCurrency;
        private Label currencyEffectiveDate;
        private Label currencyMid;
        private Label currencyCode;
        private Label currencyName;
        private Label currencyNumber;
        private Label currencyNamelabel;
    }
}
