﻿using System;

namespace MandateStrategy
{
    partial class FormClass
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
            this.Strategy = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PortfolioItems
            // 
            this.PortfolioItems.FormattingEnabled = true;
            this.PortfolioItems.Location = new System.Drawing.Point(12, 12);
            this.PortfolioItems.Name = "PortfolioItems";
            this.PortfolioItems.Size = new System.Drawing.Size(193, 21);
            this.PortfolioItems.TabIndex = 2;
            // 
            // Strategy
            // 
            this.Strategy.Location = new System.Drawing.Point(211, 12);
            this.Strategy.Name = "Strategy";
            this.Strategy.Size = new System.Drawing.Size(68, 21);
            this.Strategy.TabIndex = 3;
            this.Strategy.Text = "Strategy";
            this.Strategy.UseVisualStyleBackColor = true;
            this.Strategy.Click += new System.EventHandler(this.Strategy_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutput.Location = new System.Drawing.Point(12, 49);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(267, 144);
            this.lblOutput.TabIndex = 6;
            // 
            // FormClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 205);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.Strategy);
            this.Controls.Add(this.PortfolioItems);
            this.Name = "FormClass";
            this.Text = "Class";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }


        #endregion
        private System.Windows.Forms.ComboBox PortfolioItems;
        private System.Windows.Forms.Button Strategy;
        private System.Windows.Forms.Label lblOutput;
    }
}

