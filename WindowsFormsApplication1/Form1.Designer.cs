﻿namespace RailForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbArriv = new System.Windows.Forms.ComboBox();
            this.cmbDepp = new System.Windows.Forms.ComboBox();
            this.lstRes = new System.Windows.Forms.ListBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(544, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "מוצא";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(544, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "יעד";
            // 
            // cmbArriv
            // 
            this.cmbArriv.FormattingEnabled = true;
            this.cmbArriv.Location = new System.Drawing.Point(416, 8);
            this.cmbArriv.Name = "cmbArriv";
            this.cmbArriv.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbArriv.Size = new System.Drawing.Size(121, 21);
            this.cmbArriv.TabIndex = 2;
            // 
            // cmbDepp
            // 
            this.cmbDepp.FormattingEnabled = true;
            this.cmbDepp.Location = new System.Drawing.Point(416, 32);
            this.cmbDepp.Name = "cmbDepp";
            this.cmbDepp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbDepp.Size = new System.Drawing.Size(121, 21);
            this.cmbDepp.TabIndex = 3;
            // 
            // lstRes
            // 
            this.lstRes.FormattingEnabled = true;
            this.lstRes.Location = new System.Drawing.Point(40, 8);
            this.lstRes.Name = "lstRes";
            this.lstRes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lstRes.Size = new System.Drawing.Size(328, 238);
            this.lstRes.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(464, 64);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "הצג מסלול";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 261);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lstRes);
            this.Controls.Add(this.cmbDepp);
            this.Controls.Add(this.cmbArriv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbArriv;
        private System.Windows.Forms.ComboBox cmbDepp;
        private System.Windows.Forms.ListBox lstRes;
        private System.Windows.Forms.Button btnSearch;
    }
}

