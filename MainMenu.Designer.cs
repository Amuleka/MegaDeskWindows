using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using System;

namespace MegaDesk_2
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.addQuoteBtn = new System.Windows.Forms.Button();
            this.viewQuoteBtn = new System.Windows.Forms.Button();
            this.searchQuotesBtn = new System.Windows.Forms.Button();
            this.exitApplicationBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // addQuoteBtn
            // 
            this.addQuoteBtn.AutoSize = true;
            this.addQuoteBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addQuoteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addQuoteBtn.Location = new System.Drawing.Point(12, 12);
            this.addQuoteBtn.Name = "addQuoteBtn";
            this.addQuoteBtn.Size = new System.Drawing.Size(200, 100);
            this.addQuoteBtn.TabIndex = 0;
            this.addQuoteBtn.Text = "Add a quote";
            this.addQuoteBtn.UseVisualStyleBackColor = false;
            this.addQuoteBtn.Click += new System.EventHandler(this.addQuoteBtn_Click);
            // 
            // viewQuoteBtn
            // 
            this.viewQuoteBtn.AutoSize = true;
            this.viewQuoteBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.viewQuoteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewQuoteBtn.Location = new System.Drawing.Point(12, 129);
            this.viewQuoteBtn.Name = "viewQuoteBtn";
            this.viewQuoteBtn.Size = new System.Drawing.Size(200, 100);
            this.viewQuoteBtn.TabIndex = 1;
            this.viewQuoteBtn.Text = "View all quotes";
            this.viewQuoteBtn.UseVisualStyleBackColor = false;
            this.viewQuoteBtn.Click += new System.EventHandler(this.viewQuoteBtn_Click);
            // 
            // searchQuotesBtn
            // 
            this.searchQuotesBtn.AutoSize = true;
            this.searchQuotesBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchQuotesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchQuotesBtn.Location = new System.Drawing.Point(12, 244);
            this.searchQuotesBtn.Name = "searchQuotesBtn";
            this.searchQuotesBtn.Size = new System.Drawing.Size(200, 100);
            this.searchQuotesBtn.TabIndex = 2;
            this.searchQuotesBtn.Text = "Search quotes";
            this.searchQuotesBtn.UseVisualStyleBackColor = false;
            this.searchQuotesBtn.Click += new System.EventHandler(this.searchQuotesBtn_Click);
            // 
            // exitApplicationBtn
            // 
            this.exitApplicationBtn.AutoSize = true;
            this.exitApplicationBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.exitApplicationBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitApplicationBtn.Location = new System.Drawing.Point(12, 359);
            this.exitApplicationBtn.Name = "exitApplicationBtn";
            this.exitApplicationBtn.Size = new System.Drawing.Size(200, 100);
            this.exitApplicationBtn.TabIndex = 3;
            this.exitApplicationBtn.Text = "Exit application";
            this.exitApplicationBtn.UseVisualStyleBackColor = false;
            this.exitApplicationBtn.Click += new System.EventHandler(this.exitApplicationBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(296, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 327);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 471);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exitApplicationBtn);
            this.Controls.Add(this.searchQuotesBtn);
            this.Controls.Add(this.viewQuoteBtn);
            this.Controls.Add(this.addQuoteBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Button addQuoteBtn;
        private Button viewQuoteBtn;
        private Button searchQuotesBtn;
        private Button exitApplicationBtn;


        #endregion

        private PictureBox pictureBox1;
    }
}

