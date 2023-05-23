namespace MegaDesk_2
{
    partial class DisplayQuote
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
            this.closeDisplayQuoteButton = new System.Windows.Forms.Button();
            this.QuoteInfo = new System.Windows.Forms.Label();
            this.TotalQuotePrice = new System.Windows.Forms.TextBox();
            this.Dimensions = new System.Windows.Forms.GroupBox();
            this.Depth = new System.Windows.Forms.TextBox();
            this.Width = new System.Windows.Forms.TextBox();
            this.labelDeskDepth = new System.Windows.Forms.Label();
            this.labelDeskWidth = new System.Windows.Forms.Label();
            this.labelRushOptions = new System.Windows.Forms.Label();
            this.labelSurfaceType = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CustomerName = new System.Windows.Forms.TextBox();
            this.custFullNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Material = new System.Windows.Forms.TextBox();
            this.TypeOfDelivery = new System.Windows.Forms.TextBox();
            this.NumberOfDrawers = new System.Windows.Forms.TextBox();
            this.QuoteDate = new System.Windows.Forms.Label();
            this.SaveQuote = new System.Windows.Forms.Button();
            this.Dimensions.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeDisplayQuoteButton
            // 
            this.closeDisplayQuoteButton.AutoSize = true;
            this.closeDisplayQuoteButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeDisplayQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeDisplayQuoteButton.Location = new System.Drawing.Point(473, 421);
            this.closeDisplayQuoteButton.Name = "closeDisplayQuoteButton";
            this.closeDisplayQuoteButton.Size = new System.Drawing.Size(75, 34);
            this.closeDisplayQuoteButton.TabIndex = 0;
            this.closeDisplayQuoteButton.Text = "Close";
            this.closeDisplayQuoteButton.UseVisualStyleBackColor = true;
            this.closeDisplayQuoteButton.Click += new System.EventHandler(this.CloseDisplayQuoteButton_Click);
            // 
            // QuoteInfo
            // 
            this.QuoteInfo.AutoSize = true;
            this.QuoteInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuoteInfo.Location = new System.Drawing.Point(68, 22);
            this.QuoteInfo.Name = "QuoteInfo";
            this.QuoteInfo.Size = new System.Drawing.Size(127, 24);
            this.QuoteInfo.TabIndex = 2;
            this.QuoteInfo.Text = "Quote Details:";
            // 
            // TotalQuotePrice
            // 
            this.TotalQuotePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalQuotePrice.Location = new System.Drawing.Point(252, 372);
            this.TotalQuotePrice.Name = "TotalQuotePrice";
            this.TotalQuotePrice.Size = new System.Drawing.Size(168, 26);
            this.TotalQuotePrice.TabIndex = 3;
            // 
            // Dimensions
            // 
            this.Dimensions.Controls.Add(this.Depth);
            this.Dimensions.Controls.Add(this.Width);
            this.Dimensions.Controls.Add(this.labelDeskDepth);
            this.Dimensions.Controls.Add(this.labelDeskWidth);
            this.Dimensions.Location = new System.Drawing.Point(51, 120);
            this.Dimensions.Name = "Dimensions";
            this.Dimensions.Size = new System.Drawing.Size(397, 111);
            this.Dimensions.TabIndex = 14;
            this.Dimensions.TabStop = false;
            this.Dimensions.Text = "Dimensions";
            // 
            // Depth
            // 
            this.Depth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Depth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Depth.Location = new System.Drawing.Point(199, 71);
            this.Depth.Name = "Depth";
            this.Depth.Size = new System.Drawing.Size(168, 19);
            this.Depth.TabIndex = 25;
            // 
            // Width
            // 
            this.Width.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Width.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Width.Location = new System.Drawing.Point(201, 21);
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(168, 19);
            this.Width.TabIndex = 24;
            // 
            // labelDeskDepth
            // 
            this.labelDeskDepth.AutoSize = true;
            this.labelDeskDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeskDepth.Location = new System.Drawing.Point(101, 70);
            this.labelDeskDepth.Name = "labelDeskDepth";
            this.labelDeskDepth.Size = new System.Drawing.Size(94, 20);
            this.labelDeskDepth.TabIndex = 5;
            this.labelDeskDepth.Text = "Desk Depth";
            // 
            // labelDeskWidth
            // 
            this.labelDeskWidth.AutoSize = true;
            this.labelDeskWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeskWidth.Location = new System.Drawing.Point(101, 21);
            this.labelDeskWidth.Name = "labelDeskWidth";
            this.labelDeskWidth.Size = new System.Drawing.Size(91, 20);
            this.labelDeskWidth.TabIndex = 3;
            this.labelDeskWidth.Text = "Desk Width";
            // 
            // labelRushOptions
            // 
            this.labelRushOptions.AutoSize = true;
            this.labelRushOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRushOptions.Location = new System.Drawing.Point(128, 320);
            this.labelRushOptions.Name = "labelRushOptions";
            this.labelRushOptions.Size = new System.Drawing.Size(117, 20);
            this.labelRushOptions.TabIndex = 21;
            this.labelRushOptions.Text = "Delivery Choice";
            // 
            // labelSurfaceType
            // 
            this.labelSurfaceType.AutoSize = true;
            this.labelSurfaceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSurfaceType.Location = new System.Drawing.Point(121, 280);
            this.labelSurfaceType.Name = "labelSurfaceType";
            this.labelSurfaceType.Size = new System.Drawing.Size(125, 20);
            this.labelSurfaceType.TabIndex = 20;
            this.labelSurfaceType.Text = "Surface material";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Number of drawers ";
            // 
            // CustomerName
            // 
            this.CustomerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerName.Location = new System.Drawing.Point(248, 92);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(170, 19);
            this.CustomerName.TabIndex = 12;
            // 
            // custFullNameLabel
            // 
            this.custFullNameLabel.AutoSize = true;
            this.custFullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custFullNameLabel.Location = new System.Drawing.Point(92, 91);
            this.custFullNameLabel.Name = "custFullNameLabel";
            this.custFullNameLabel.Size = new System.Drawing.Size(153, 20);
            this.custFullNameLabel.TabIndex = 13;
            this.custFullNameLabel.Text = "Customer Full Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Quote Total       $";
            // 
            // Material
            // 
            this.Material.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Material.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Material.Location = new System.Drawing.Point(252, 281);
            this.Material.Name = "Material";
            this.Material.Size = new System.Drawing.Size(168, 19);
            this.Material.TabIndex = 23;
            // 
            // TypeOfDelivery
            // 
            this.TypeOfDelivery.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TypeOfDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeOfDelivery.Location = new System.Drawing.Point(252, 321);
            this.TypeOfDelivery.Name = "TypeOfDelivery";
            this.TypeOfDelivery.Size = new System.Drawing.Size(168, 19);
            this.TypeOfDelivery.TabIndex = 24;
            // 
            // NumberOfDrawers
            // 
            this.NumberOfDrawers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumberOfDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfDrawers.Location = new System.Drawing.Point(252, 240);
            this.NumberOfDrawers.Name = "NumberOfDrawers";
            this.NumberOfDrawers.Size = new System.Drawing.Size(168, 19);
            this.NumberOfDrawers.TabIndex = 25;
            // 
            // QuoteDate
            // 
            this.QuoteDate.AutoSize = true;
            this.QuoteDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuoteDate.Location = new System.Drawing.Point(359, 55);
            this.QuoteDate.Name = "QuoteDate";
            this.QuoteDate.Size = new System.Drawing.Size(0, 17);
            this.QuoteDate.TabIndex = 26;
            // 
            // SaveQuote
            // 
            this.SaveQuote.AutoSize = true;
            this.SaveQuote.BackColor = System.Drawing.Color.SeaGreen;
            this.SaveQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveQuote.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SaveQuote.Location = new System.Drawing.Point(252, 421);
            this.SaveQuote.Name = "SaveQuote";
            this.SaveQuote.Size = new System.Drawing.Size(119, 34);
            this.SaveQuote.TabIndex = 27;
            this.SaveQuote.Text = "Save Quote";
            this.SaveQuote.UseVisualStyleBackColor = false;
            this.SaveQuote.Click += new System.EventHandler(this.SaveQuote_Click);
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.CancelButton = this.closeDisplayQuoteButton;
            this.ClientSize = new System.Drawing.Size(560, 471);
            this.Controls.Add(this.SaveQuote);
            this.Controls.Add(this.QuoteDate);
            this.Controls.Add(this.NumberOfDrawers);
            this.Controls.Add(this.TypeOfDelivery);
            this.Controls.Add(this.Material);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Dimensions);
            this.Controls.Add(this.labelRushOptions);
            this.Controls.Add(this.labelSurfaceType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.custFullNameLabel);
            this.Controls.Add(this.TotalQuotePrice);
            this.Controls.Add(this.QuoteInfo);
            this.Controls.Add(this.closeDisplayQuoteButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DisplayQuote";
            this.Text = "Display Quote";
            this.Load += new System.EventHandler(this.DisplayQuote_Load);
            this.Dimensions.ResumeLayout(false);
            this.Dimensions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button closeDisplayQuoteButton;
        private System.Windows.Forms.Label QuoteInfo;
        private System.Windows.Forms.TextBox TotalQuotePrice;
        private System.Windows.Forms.GroupBox Dimensions;
        private System.Windows.Forms.Label labelDeskDepth;
        private System.Windows.Forms.Label labelDeskWidth;
        private System.Windows.Forms.Label labelRushOptions;
        private System.Windows.Forms.Label labelSurfaceType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CustomerName;
        private System.Windows.Forms.Label custFullNameLabel;
        private System.Windows.Forms.TextBox Depth;
        private System.Windows.Forms.TextBox Width;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Material;
        private System.Windows.Forms.TextBox TypeOfDelivery;
        private System.Windows.Forms.TextBox NumberOfDrawers;
        private System.Windows.Forms.Label QuoteDate;
        private System.Windows.Forms.Button SaveQuote;

        #endregion
        /*
         * This form view displays the current quote information after a successful quote add
         * */
    }
}