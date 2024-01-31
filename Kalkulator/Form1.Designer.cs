using System.Windows.Forms;

namespace App1
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
            button0 = new Button();
            buttonFinish = new Button();
            buttonSum = new Button();
            buttonChangeType = new Button();
            buttonDot = new Button();
            button6 = new Button();
            buttonMinus = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button9 = new Button();
            buttonOn = new Button();
            buttonClear = new Button();
            button7 = new Button();
            button4 = new Button();
            buttonDivide = new Button();
            button11 = new Button();
            button5 = new Button();
            button8 = new Button();
            numberInput = new TextBox();
            panel1 = new Panel();
            buttonMultiple = new Button();
            buttonPrecent = new Button();
            buttonEl = new Button();
            buttonMemory = new Button();
            buttonMemorySum = new Button();
            buttonMemoryMinus = new Button();
            label1 = new Label();
            label2 = new Label();
            labelError = new Label();
            SuspendLayout();
            // 
            // button0
            // 
            button0.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button0.BackColor = Color.Gray;
            button0.ForeColor = Color.White;
            button0.Location = new Point(12, 319);
            button0.Name = "button0";
            button0.Size = new Size(55, 30);
            button0.TabIndex = 15;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = false;
            button0.Click += button0_Click;
            // 
            // buttonFinish
            // 
            buttonFinish.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonFinish.BackColor = Color.Black;
            buttonFinish.ForeColor = Color.White;
            buttonFinish.Location = new Point(317, 319);
            buttonFinish.Name = "buttonFinish";
            buttonFinish.Size = new Size(55, 30);
            buttonFinish.TabIndex = 16;
            buttonFinish.Text = "=";
            buttonFinish.UseVisualStyleBackColor = false;
            buttonFinish.Click += buttonFinish_Click;
            // 
            // buttonSum
            // 
            buttonSum.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonSum.BackColor = Color.Black;
            buttonSum.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonSum.ForeColor = Color.White;
            buttonSum.Location = new Point(239, 279);
            buttonSum.Name = "buttonSum";
            buttonSum.Padding = new Padding(3);
            buttonSum.Size = new Size(55, 70);
            buttonSum.TabIndex = 17;
            buttonSum.Text = "+";
            buttonSum.UseVisualStyleBackColor = false;
            buttonSum.Click += buttonSum_Click;
            // 
            // buttonChangeType
            // 
            buttonChangeType.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonChangeType.BackColor = Color.Gray;
            buttonChangeType.ForeColor = Color.White;
            buttonChangeType.Location = new Point(163, 319);
            buttonChangeType.Name = "buttonChangeType";
            buttonChangeType.Size = new Size(55, 30);
            buttonChangeType.TabIndex = 18;
            buttonChangeType.Text = "+/-";
            buttonChangeType.UseVisualStyleBackColor = false;
            buttonChangeType.Click += buttonChangeType_Click;
            // 
            // buttonDot
            // 
            buttonDot.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonDot.BackColor = Color.Gray;
            buttonDot.ForeColor = Color.White;
            buttonDot.Location = new Point(88, 319);
            buttonDot.Name = "buttonDot";
            buttonDot.Size = new Size(55, 30);
            buttonDot.TabIndex = 19;
            buttonDot.Text = ",";
            buttonDot.UseVisualStyleBackColor = false;
            buttonDot.Click += buttonDot_Click;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button6.BackColor = Color.Gray;
            button6.ForeColor = Color.White;
            button6.Location = new Point(163, 239);
            button6.Name = "button6";
            button6.Size = new Size(55, 30);
            button6.TabIndex = 20;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // buttonMinus
            // 
            buttonMinus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonMinus.BackColor = Color.Black;
            buttonMinus.ForeColor = Color.White;
            buttonMinus.Location = new Point(317, 279);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(55, 30);
            buttonMinus.TabIndex = 21;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = false;
            buttonMinus.Click += buttonMinus_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button3.BackColor = Color.Gray;
            button3.ForeColor = Color.White;
            button3.Location = new Point(163, 279);
            button3.Name = "button3";
            button3.Size = new Size(55, 30);
            button3.TabIndex = 22;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.BackColor = Color.Gray;
            button2.ForeColor = Color.White;
            button2.Location = new Point(88, 279);
            button2.Name = "button2";
            button2.Size = new Size(55, 30);
            button2.TabIndex = 23;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.BackColor = Color.Gray;
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 279);
            button1.Name = "button1";
            button1.Size = new Size(55, 30);
            button1.TabIndex = 24;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button9
            // 
            button9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button9.BackColor = Color.Gray;
            button9.ForeColor = Color.White;
            button9.Location = new Point(163, 199);
            button9.Name = "button9";
            button9.Size = new Size(55, 30);
            button9.TabIndex = 25;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // buttonOn
            // 
            buttonOn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonOn.BackColor = Color.Black;
            buttonOn.ForeColor = Color.Orange;
            buttonOn.Location = new Point(12, 159);
            buttonOn.Name = "buttonOn";
            buttonOn.Size = new Size(55, 30);
            buttonOn.TabIndex = 26;
            buttonOn.Text = "ON/C";
            buttonOn.UseVisualStyleBackColor = false;
            buttonOn.Click += buttonOn_Click;
            // 
            // buttonClear
            // 
            buttonClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonClear.BackColor = Color.Black;
            buttonClear.ForeColor = Color.Orange;
            buttonClear.Location = new Point(88, 159);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(55, 30);
            buttonClear.TabIndex = 27;
            buttonClear.Text = "CI/C";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button7.BackColor = Color.Gray;
            button7.ForeColor = Color.White;
            button7.Location = new Point(12, 199);
            button7.Name = "button7";
            button7.Size = new Size(55, 30);
            button7.TabIndex = 28;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button4.BackColor = Color.Gray;
            button4.ForeColor = Color.White;
            button4.Location = new Point(12, 239);
            button4.Name = "button4";
            button4.Size = new Size(55, 30);
            button4.TabIndex = 29;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // buttonDivide
            // 
            buttonDivide.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonDivide.BackColor = Color.Black;
            buttonDivide.ForeColor = Color.White;
            buttonDivide.Location = new Point(317, 239);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(55, 30);
            buttonDivide.TabIndex = 30;
            buttonDivide.Text = "/";
            buttonDivide.UseVisualStyleBackColor = false;
            buttonDivide.Click += buttonDivide_Click;
            // 
            // button11
            // 
            button11.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button11.BackColor = SystemColors.AppWorkspace;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Segoe UI", 9.75F);
            button11.ForeColor = SystemColors.ControlText;
            button11.Location = new Point(239, 239);
            button11.Name = "button11";
            button11.Size = new Size(55, 30);
            button11.TabIndex = 31;
            button11.Text = "*";
            button11.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button5.BackColor = Color.Gray;
            button5.ForeColor = Color.White;
            button5.Location = new Point(88, 239);
            button5.Name = "button5";
            button5.Size = new Size(55, 30);
            button5.TabIndex = 32;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button8.BackColor = Color.Gray;
            button8.ForeColor = Color.White;
            button8.Location = new Point(88, 199);
            button8.Name = "button8";
            button8.Size = new Size(55, 30);
            button8.TabIndex = 37;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // numberInput
            // 
            numberInput.BackColor = Color.DarkSeaGreen;
            numberInput.CharacterCasing = CharacterCasing.Upper;
            numberInput.Enabled = false;
            numberInput.Font = new Font("Courier New", 15F, FontStyle.Bold, GraphicsUnit.Point, 238);
            numberInput.ImeMode = ImeMode.Off;
            numberInput.Location = new Point(12, 44);
            numberInput.MaxLength = 0;
            numberInput.Name = "numberInput";
            numberInput.ReadOnly = true;
            numberInput.Size = new Size(360, 30);
            numberInput.TabIndex = 38;
            numberInput.TextAlign = HorizontalAlignment.Right;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Location = new Point(257, 103);
            panel1.Name = "panel1";
            panel1.Size = new Size(115, 34);
            panel1.TabIndex = 39;
            // 
            // buttonMultiple
            // 
            buttonMultiple.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonMultiple.BackColor = Color.Black;
            buttonMultiple.ForeColor = Color.White;
            buttonMultiple.Location = new Point(239, 239);
            buttonMultiple.Name = "buttonMultiple";
            buttonMultiple.Size = new Size(55, 30);
            buttonMultiple.TabIndex = 40;
            buttonMultiple.Text = "*";
            buttonMultiple.UseVisualStyleBackColor = false;
            buttonMultiple.Click += buttonMultiple_Click;
            // 
            // buttonPrecent
            // 
            buttonPrecent.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonPrecent.BackColor = Color.Black;
            buttonPrecent.ForeColor = Color.White;
            buttonPrecent.Location = new Point(239, 199);
            buttonPrecent.Name = "buttonPrecent";
            buttonPrecent.Size = new Size(55, 30);
            buttonPrecent.TabIndex = 41;
            buttonPrecent.Text = "%";
            buttonPrecent.UseVisualStyleBackColor = false;
            buttonPrecent.Click += buttonPrecent_Click;
            // 
            // buttonEl
            // 
            buttonEl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonEl.BackColor = Color.Black;
            buttonEl.ForeColor = Color.White;
            buttonEl.Location = new Point(317, 199);
            buttonEl.Name = "buttonEl";
            buttonEl.Size = new Size(55, 30);
            buttonEl.TabIndex = 42;
            buttonEl.Text = "√";
            buttonEl.UseVisualStyleBackColor = false;
            buttonEl.Click += buttonEl_Click;
            // 
            // buttonMemory
            // 
            buttonMemory.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonMemory.BackColor = Color.Black;
            buttonMemory.ForeColor = Color.White;
            buttonMemory.Location = new Point(163, 159);
            buttonMemory.Name = "buttonMemory";
            buttonMemory.Size = new Size(55, 30);
            buttonMemory.TabIndex = 43;
            buttonMemory.Text = "Mr/Mc";
            buttonMemory.UseVisualStyleBackColor = false;
            buttonMemory.Click += buttonMemory_Click;
            // 
            // buttonMemorySum
            // 
            buttonMemorySum.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonMemorySum.BackColor = Color.Black;
            buttonMemorySum.ForeColor = Color.White;
            buttonMemorySum.Location = new Point(239, 159);
            buttonMemorySum.Name = "buttonMemorySum";
            buttonMemorySum.Size = new Size(55, 30);
            buttonMemorySum.TabIndex = 44;
            buttonMemorySum.Text = "M +";
            buttonMemorySum.UseVisualStyleBackColor = false;
            buttonMemorySum.Click += buttonMemorySum_Click;
            // 
            // buttonMemoryMinus
            // 
            buttonMemoryMinus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonMemoryMinus.BackColor = Color.Black;
            buttonMemoryMinus.ForeColor = Color.White;
            buttonMemoryMinus.Location = new Point(317, 159);
            buttonMemoryMinus.Name = "buttonMemoryMinus";
            buttonMemoryMinus.Size = new Size(55, 30);
            buttonMemoryMinus.TabIndex = 45;
            buttonMemoryMinus.Text = "M -";
            buttonMemoryMinus.UseVisualStyleBackColor = false;
            buttonMemoryMinus.Click += buttonMemoryMinus_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Gabriola", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.White;
            label1.Location = new Point(28, 92);
            label1.Name = "label1";
            label1.Size = new Size(115, 63);
            label1.TabIndex = 47;
            label1.Text = "Canon";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.White;
            label2.Location = new Point(200, 116);
            label2.Name = "label2";
            label2.Size = new Size(51, 21);
            label2.TabIndex = 48;
            label2.Text = "LS-88";
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.BackColor = Color.DarkSeaGreen;
            labelError.FlatStyle = FlatStyle.Flat;
            labelError.Font = new Font("Courier New", 15F, FontStyle.Bold);
            labelError.Location = new Point(19, 48);
            labelError.Name = "labelError";
            labelError.Size = new Size(22, 23);
            labelError.TabIndex = 49;
            labelError.Text = "E";
            labelError.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(384, 361);
            Controls.Add(labelError);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonMemoryMinus);
            Controls.Add(buttonMemorySum);
            Controls.Add(buttonMemory);
            Controls.Add(buttonEl);
            Controls.Add(buttonPrecent);
            Controls.Add(buttonMultiple);
            Controls.Add(panel1);
            Controls.Add(numberInput);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(buttonClear);
            Controls.Add(buttonOn);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(buttonDivide);
            Controls.Add(buttonMinus);
            Controls.Add(button0);
            Controls.Add(buttonDot);
            Controls.Add(buttonChangeType);
            Controls.Add(buttonSum);
            Controls.Add(buttonFinish);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(400, 400);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimumSize = new Size(400, 400);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button0;
        private Button buttonFinish;
        private Button buttonSum;
        private Button buttonChangeType;
        private Button buttonDot;
        private Button button5;
        private Button buttonMinus;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button4;
        private Button buttonOn;
        private Button buttonClear;
        private Button button7;
        private Button button9;
        private Button buttonDivide;
        private Button button11;
        private Button button6;
        private Button button8;
        private TextBox numberInput;
        private Panel panel1;
        private Button buttonMultiple;
        private Button buttonPrecent;
        private Button buttonEl;
        private Button buttonMemory;
        private Button buttonMemorySum;
        private Button buttonMemoryMinus;
        private Label label1;
        private Label label2;
        private Label labelError;
    }
}
