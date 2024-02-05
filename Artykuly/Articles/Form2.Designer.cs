using System.Diagnostics;

namespace Articles
{
    partial class Form2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components1 = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components1 != null))
            {
                components1.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void openNewForm()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelSubmit = new Panel();
            buttonSubmit = new Button();
            labelNoDb = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3  = new System.Windows.Forms.Label();
            inputNewArticleName = new TextBox();
            inputNewCategory = new TextBox();
            inputNewContent = new TextBox();
            panelSubmit.SuspendLayout();
            SuspendLayout();
            //
            // panelSubmit
            //
            panelSubmit.AutoSize = true;
            panelSubmit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelSubmit.BackColor = SystemColors.ControlDark;
            panelSubmit.BorderStyle = BorderStyle.FixedSingle;
            panelSubmit.Controls.Add(buttonSubmit);
            panelSubmit.Controls.Add(labelNoDb);
            panelSubmit.Controls.Add(label1);
            panelSubmit.Controls.Add(label2);
            panelSubmit.Controls.Add(label3);
            panelSubmit.Controls.Add(inputNewArticleName);
            panelSubmit.Controls.Add(inputNewCategory);
            panelSubmit.Controls.Add(inputNewContent);
            panelSubmit.Dock = DockStyle.Bottom;
            panelSubmit.Location = new Point(0, 400);
            panelSubmit.Margin = new Padding(20);
            panelSubmit.Name = "panelSubmit";
            panelSubmit.Padding = new Padding(5);
            panelSubmit.Size = new Size(884, 55);
            panelSubmit.TabIndex = 0;
            panelSubmit.Visible = true;
            panelSubmit.Location = new Point(0, 400);
            //
            // buttonSubmit
            //
            buttonSubmit.BackColor = Color.Silver;
            buttonSubmit.FlatAppearance.BorderColor = Color.Black;
            buttonSubmit.FlatAppearance.BorderSize = 2;
            buttonSubmit.FlatStyle = FlatStyle.Flat;
            buttonSubmit.Margin = new Padding(10);
            buttonSubmit.Name = "buttonAdd";
            buttonSubmit.Size = new Size(101, 30);
            buttonSubmit.Location = new Point(138, 5);
            buttonSubmit.Dock = DockStyle.Bottom;
            buttonSubmit.TabIndex = 0;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = false;
            buttonSubmit.Visible = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // labelNoDb
            // 
            labelNoDb.Anchor = AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left;
            labelNoDb.AutoSize = true;
            labelNoDb.ForeColor = Color.Red;
            labelNoDb.Dock = DockStyle.Bottom;
            labelNoDb.Name = "labelNoDb";
            labelNoDb.Size = new Size(140, 50) ;
            labelNoDb.TabIndex = 5;
            labelNoDb.Text = "DATABASE CONNECTION ERROR";
            labelNoDb.Visible = false;
            labelNoDb.Font = new Font("Segoe UI", 12F);
            labelNoDb.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // inputNewArticleName
            // 
            inputNewArticleName.Location = new Point(200, 20);
            inputNewArticleName.Name = "inputNewArticleName";
            inputNewArticleName.Size = new Size(100, 23);
            inputNewArticleName.TabIndex = 2;
            // 
            // inputNewCategory
            // 
            inputNewCategory.Location = new Point(200, 70);
            inputNewCategory.Name = "inputNewCategory";
            inputNewCategory.Size = new Size(100, 23);
            inputNewCategory.TabIndex = 1;
            // 
            // inputNewContent
            // 
            inputNewContent.Location = new Point(52, 150);
            inputNewContent.Multiline = true;
            inputNewContent.Name = "inputNewContent";
            inputNewContent.Size = new Size(250, 140);
            inputNewContent.TabIndex = 0;
            inputNewContent.Anchor = AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120,20);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 3;
            label1.Text = "Article name";
            label1.Font = new Font("Segoe UI", 10F);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 70);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 4;
            label2.Text = "Article category";
            label2.Font = new Font("Segoe UI", 10F);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 125);
            label3.Name = "label3";
            label3.Size = new Size(135, 15);
            label3.TabIndex = 5;
            label3.Text = "Your new article content";
            label3.Font = new Font("Segoe UI", 10F);
            // 
            // Form2
            // 
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(400, 400);
            Controls.Add(panelSubmit);
            Controls.Add(labelNoDb);
            Controls.Add(inputNewArticleName);
            Controls.Add(inputNewCategory);
            Controls.Add(inputNewContent);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximumSize = new Size(400, 400);
            MinimumSize = new Size(400, 400);
            Name = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelSubmit;
        private Button buttonSubmit;
        private Label labelNoDb, label1, label2, label3;
        private TextBox inputNewCategory, inputNewArticleName, inputNewContent;
    }
}
