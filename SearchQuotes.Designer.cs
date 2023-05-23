namespace MegaDesk_2
{
    partial class SearchQuotes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchQuoteCloseBtn = new System.Windows.Forms.Button();
            this.SearchOrdersByMaterial = new System.Windows.Forms.ComboBox();
            this.DisplaySearchOrders = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DisplaySearchOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // searchQuoteCloseBtn
            // 
            this.searchQuoteCloseBtn.AutoSize = true;
            this.searchQuoteCloseBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.searchQuoteCloseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchQuoteCloseBtn.Location = new System.Drawing.Point(820, 12);
            this.searchQuoteCloseBtn.Name = "searchQuoteCloseBtn";
            this.searchQuoteCloseBtn.Size = new System.Drawing.Size(75, 35);
            this.searchQuoteCloseBtn.TabIndex = 0;
            this.searchQuoteCloseBtn.Text = "Close";
            this.searchQuoteCloseBtn.UseVisualStyleBackColor = true;
            this.searchQuoteCloseBtn.Click += new System.EventHandler(this.SearchQuoteCloseBtn_Click);
            // 
            // SearchOrdersByMaterial
            // 
            this.SearchOrdersByMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchOrdersByMaterial.FormattingEnabled = true;
            this.SearchOrdersByMaterial.Location = new System.Drawing.Point(347, 31);
            this.SearchOrdersByMaterial.Name = "SearchOrdersByMaterial";
            this.SearchOrdersByMaterial.Size = new System.Drawing.Size(166, 32);
            this.SearchOrdersByMaterial.TabIndex = 1;
            this.SearchOrdersByMaterial.SelectedIndexChanged += new System.EventHandler(this.SearchOrdersByMaterial_SelectedIndexChanged);
            this.SearchOrdersByMaterial.SelectionChangeCommitted += new System.EventHandler(this.SearchOrdersByMaterial_SelectedIndexChanged);
            this.SearchOrdersByMaterial.SelectedValueChanged += new System.EventHandler(this.SearchOrdersByMaterial_SelectedIndexChanged);
            // 
            // DisplaySearchOrders
            // 
            this.DisplaySearchOrders.AllowUserToOrderColumns = true;
            this.DisplaySearchOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DisplaySearchOrders.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DisplaySearchOrders.Location = new System.Drawing.Point(0, 121);
            this.DisplaySearchOrders.Name = "DisplaySearchOrders";
            this.DisplaySearchOrders.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DisplaySearchOrders.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DisplaySearchOrders.RowHeadersWidth = 100;
            this.DisplaySearchOrders.Size = new System.Drawing.Size(907, 350);
            this.DisplaySearchOrders.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search By Material: ";
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.searchQuoteCloseBtn;
            this.ClientSize = new System.Drawing.Size(907, 471);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DisplaySearchOrders);
            this.Controls.Add(this.SearchOrdersByMaterial);
            this.Controls.Add(this.searchQuoteCloseBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchQuotes";
            this.Text = "Search Quotes";
            ((System.ComponentModel.ISupportInitialize)(this.DisplaySearchOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchQuoteCloseBtn;
        private System.Windows.Forms.ComboBox SearchOrdersByMaterial;
        private System.Windows.Forms.DataGridView DisplaySearchOrders;
        private System.Windows.Forms.Label label1;
    }
}