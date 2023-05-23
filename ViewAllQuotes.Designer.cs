namespace MegaDesk_2
{
    partial class ViewAllQuotes
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
            this.closeViewAllQuotesBtn = new System.Windows.Forms.Button();
            this.dataGridViewAll = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).BeginInit();
            this.SuspendLayout();
            // 
            // closeViewAllQuotesBtn
            // 
            this.closeViewAllQuotesBtn.AutoSize = true;
            this.closeViewAllQuotesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeViewAllQuotesBtn.Location = new System.Drawing.Point(731, 12);
            this.closeViewAllQuotesBtn.Name = "closeViewAllQuotesBtn";
            this.closeViewAllQuotesBtn.Size = new System.Drawing.Size(75, 34);
            this.closeViewAllQuotesBtn.TabIndex = 0;
            this.closeViewAllQuotesBtn.Text = "Close";
            this.closeViewAllQuotesBtn.UseVisualStyleBackColor = true;
            this.closeViewAllQuotesBtn.Click += new System.EventHandler(this.closeViewAllQuotesBtn_Click);
            // 
            // dataGridViewAll
            // 
            this.dataGridViewAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAll.Location = new System.Drawing.Point(0, 79);
            this.dataGridViewAll.Name = "dataGridViewAll";
            this.dataGridViewAll.Size = new System.Drawing.Size(916, 392);
            this.dataGridViewAll.TabIndex = 1;
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 471);
            this.Controls.Add(this.dataGridViewAll);
            this.Controls.Add(this.closeViewAllQuotesBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewAllQuotes";
            this.Text = "View All Quotes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeViewAllQuotesBtn;
        private System.Windows.Forms.DataGridView dataGridViewAll;
    }
}