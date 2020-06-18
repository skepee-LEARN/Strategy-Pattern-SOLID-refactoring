namespace MandateBasic
{
    partial class FormBasic
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
            this.PortfolioItems = new System.Windows.Forms.ComboBox();
            this.Basic = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PortfolioItems
            // 
            this.PortfolioItems.FormattingEnabled = true;
            this.PortfolioItems.Location = new System.Drawing.Point(11, 12);
            this.PortfolioItems.Name = "PortfolioItems";
            this.PortfolioItems.Size = new System.Drawing.Size(191, 21);
            this.PortfolioItems.TabIndex = 3;         
            // 
            // Basic
            // 
            this.Basic.Location = new System.Drawing.Point(208, 12);
            this.Basic.Name = "Basic";
            this.Basic.Size = new System.Drawing.Size(68, 21);
            this.Basic.TabIndex = 4;
            this.Basic.Text = "Basic";
            this.Basic.UseVisualStyleBackColor = true;
            this.Basic.Click += new System.EventHandler(this.Basic_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutput.Location = new System.Drawing.Point(9, 47);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(267, 144);
            this.lblOutput.TabIndex = 5;
            // 
            // FormBasic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 205);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.Basic);
            this.Controls.Add(this.PortfolioItems);
            this.Name = "FormBasic";
            this.Text = "Basic";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox PortfolioItems;
        private System.Windows.Forms.Button Basic;
        private System.Windows.Forms.Label lblOutput;
    }
}

