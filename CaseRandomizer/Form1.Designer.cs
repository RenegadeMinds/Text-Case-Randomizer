namespace CaseRandomizer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnRandomizeCase = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.scContainer = new System.Windows.Forms.SplitContainer();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblCounts = new System.Windows.Forms.Label();
            this.chkHomoglyphs = new System.Windows.Forms.CheckBox();
            this.chkRandomizeCase = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.scContainer)).BeginInit();
            this.scContainer.Panel1.SuspendLayout();
            this.scContainer.Panel2.SuspendLayout();
            this.scContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRandomizeCase
            // 
            this.btnRandomizeCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandomizeCase.Location = new System.Drawing.Point(12, 12);
            this.btnRandomizeCase.Name = "btnRandomizeCase";
            this.btnRandomizeCase.Size = new System.Drawing.Size(368, 49);
            this.btnRandomizeCase.TabIndex = 0;
            this.btnRandomizeCase.Text = "Randomize Case and/or Do Homoglyphs";
            this.btnRandomizeCase.UseVisualStyleBackColor = true;
            this.btnRandomizeCase.Click += new System.EventHandler(this.btnRandomizeCase_Click);
            // 
            // txtInput
            // 
            this.txtInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(0, 0);
            this.txtInput.MaxLength = 327670000;
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInput.Size = new System.Drawing.Size(368, 343);
            this.txtInput.TabIndex = 1;
            // 
            // txtOutput
            // 
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(0, 0);
            this.txtOutput.MaxLength = 327670000;
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(367, 343);
            this.txtOutput.TabIndex = 2;
            // 
            // scContainer
            // 
            this.scContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scContainer.Location = new System.Drawing.Point(12, 95);
            this.scContainer.Name = "scContainer";
            // 
            // scContainer.Panel1
            // 
            this.scContainer.Panel1.Controls.Add(this.txtInput);
            // 
            // scContainer.Panel2
            // 
            this.scContainer.Panel2.Controls.Add(this.txtOutput);
            this.scContainer.Size = new System.Drawing.Size(739, 343);
            this.scContainer.SplitterDistance = 368;
            this.scContainer.TabIndex = 3;
            // 
            // lblInstructions
            // 
            this.lblInstructions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(386, 12);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(365, 49);
            this.lblInstructions.TabIndex = 4;
            this.lblInstructions.Text = "Enter text into the left text box. Click the button. The result will be in the ri" +
    "ght text box.";
            // 
            // lblCounts
            // 
            this.lblCounts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounts.Location = new System.Drawing.Point(387, 61);
            this.lblCounts.Name = "lblCounts";
            this.lblCounts.Size = new System.Drawing.Size(365, 28);
            this.lblCounts.TabIndex = 5;
            // 
            // chkHomoglyphs
            // 
            this.chkHomoglyphs.AutoSize = true;
            this.chkHomoglyphs.Checked = true;
            this.chkHomoglyphs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHomoglyphs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHomoglyphs.Location = new System.Drawing.Point(194, 65);
            this.chkHomoglyphs.Name = "chkHomoglyphs";
            this.chkHomoglyphs.Size = new System.Drawing.Size(146, 24);
            this.chkHomoglyphs.TabIndex = 6;
            this.chkHomoglyphs.Text = "Use homoglyphs";
            this.chkHomoglyphs.UseVisualStyleBackColor = true;
            // 
            // chkRandomizeCase
            // 
            this.chkRandomizeCase.AutoSize = true;
            this.chkRandomizeCase.Checked = true;
            this.chkRandomizeCase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRandomizeCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRandomizeCase.Location = new System.Drawing.Point(12, 65);
            this.chkRandomizeCase.Name = "chkRandomizeCase";
            this.chkRandomizeCase.Size = new System.Drawing.Size(147, 24);
            this.chkRandomizeCase.TabIndex = 7;
            this.chkRandomizeCase.Text = "Randomize case";
            this.chkRandomizeCase.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 450);
            this.Controls.Add(this.chkRandomizeCase);
            this.Controls.Add(this.chkHomoglyphs);
            this.Controls.Add(this.lblCounts);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.scContainer);
            this.Controls.Add(this.btnRandomizeCase);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(779, 489);
            this.Name = "Form1";
            this.Text = "Case Randomizer and Homoglyph Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.scContainer.Panel1.ResumeLayout(false);
            this.scContainer.Panel1.PerformLayout();
            this.scContainer.Panel2.ResumeLayout(false);
            this.scContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scContainer)).EndInit();
            this.scContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRandomizeCase;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.SplitContainer scContainer;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblCounts;
        private System.Windows.Forms.CheckBox chkHomoglyphs;
        private System.Windows.Forms.CheckBox chkRandomizeCase;
    }
}

