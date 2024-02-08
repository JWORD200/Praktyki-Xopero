namespace Articles
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonSubmit = new Button();
            panelSubmit = new Panel();
            inputNewArticleName = new TextBox();
            inputNewCategory = new TextBox();
            inputNewContent = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panelSubmit.SuspendLayout();
            SuspendLayout();
            // 
            // buttonSubmit
            // 
            buttonSubmit.Anchor = AnchorStyles.None;
            buttonSubmit.BackColor = Color.Silver;
            buttonSubmit.FlatAppearance.BorderColor = Color.Black;
            buttonSubmit.FlatAppearance.BorderSize = 2;
            buttonSubmit.FlatStyle = FlatStyle.Flat;
            buttonSubmit.Location = new Point(136, 10);
            buttonSubmit.Margin = new Padding(10);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(101, 30);
            buttonSubmit.TabIndex = 4;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = false;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // panelSubmit
            // 
            panelSubmit.BackColor = SystemColors.ControlDark;
            panelSubmit.Controls.Add(buttonSubmit);
            panelSubmit.Dock = DockStyle.Bottom;
            panelSubmit.Location = new Point(0, 311);
            panelSubmit.Name = "panelSubmit";
            panelSubmit.Size = new Size(384, 50);
            panelSubmit.TabIndex = 5;
            // 
            // inputNewArticleName
            // 
            inputNewArticleName.Location = new Point(162, 41);
            inputNewArticleName.Name = "inputNewArticleName";
            inputNewArticleName.Size = new Size(100, 23);
            inputNewArticleName.TabIndex = 1;
            // 
            // inputNewCategory
            // 
            inputNewCategory.Location = new Point(162, 74);
            inputNewCategory.Name = "inputNewCategory";
            inputNewCategory.Size = new Size(100, 23);
            inputNewCategory.TabIndex = 2;
            // 
            // inputNewContent
            // 
            inputNewContent.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            inputNewContent.Location = new Point(52, 150);
            inputNewContent.Multiline = true;
            inputNewContent.Name = "inputNewContent";
            inputNewContent.Size = new Size(250, 140);
            inputNewContent.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(52, 42);
            label1.Name = "label1";
            label1.Size = new Size(85, 19);
            label1.TabIndex = 3;
            label1.Text = "Article name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(52, 74);
            label2.Name = "label2";
            label2.Size = new Size(104, 19);
            label2.TabIndex = 4;
            label2.Text = "Article category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(114, 128);
            label3.Name = "label3";
            label3.Size = new Size(123, 19);
            label3.TabIndex = 5;
            label3.Text = "Edit article content";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(384, 361);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(inputNewContent);
            Controls.Add(inputNewCategory);
            Controls.Add(inputNewArticleName);
            Controls.Add(panelSubmit);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MaximumSize = new Size(400, 400);
            MinimumSize = new Size(400, 400);
            Name = "Form3";
            ShowIcon = false;
            Text = "Form3";
            panelSubmit.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button buttonSubmit;
        private Panel panelSubmit;
        private TextBox inputNewArticleName;
        private TextBox inputNewCategory;
        private TextBox inputNewContent;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}